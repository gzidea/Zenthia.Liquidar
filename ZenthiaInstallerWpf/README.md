# ZenthiaInstallerWpf — Managed Bootstrapper Application (WiX v3)

Proyecto WPF (.NET Framework 4.6) que reemplaza la UI por defecto del Bundle
de WiX v3 por una ventana propia, replicando el diseño de referencia
(imagen a la izquierda, título + subtítulo, link de términos, botones
Instalar/Cerrar).

## Antes de compilar

1. **Ajustá `WixSdkPath`** en `ZenthiaInstallerWpf.csproj` a la carpeta SDK
   de tu instalación de WiX v3 (por defecto:
   `C:\Program Files (x86)\WiX Toolset v3.11\SDK\`).
2. **Reemplazá `Assets/apple.jpg`** por la foto real (el archivo actual es
   solo un placeholder generado para que el proyecto compile).
3. Cambiá la URL de términos y condiciones en `MainWindow.xaml.cs`.

## Cómo referenciarlo desde tu Bundle (.wxs)

En el proyecto de WiX que define el `<Bundle>`, agregá una referencia de
proyecto a `ZenthiaInstallerWpf.csproj` y reemplazá el `<BootstrapperApplicationRef>`
por defecto (`WixStandardBootstrapperApplication.RtfLicense` o similar) por
el payload de tu BA propio:

```xml
<Bundle Name="Zenthia - Instalación de LiquidAR" Version="1.0.0.0"
        Manufacturer="Zenthia" UpgradeCode="PUT-YOUR-GUID-HERE">

  <BootstrapperApplication>
    <Payload SourceFile="$(var.ZenthiaInstallerWpf.TargetDir)ZenthiaInstallerWpf.dll" />
    <Payload SourceFile="$(var.ZenthiaInstallerWpf.TargetDir)ZenthiaInstallerWpf.BootstrapperCore.config" />
  </BootstrapperApplication>

  <Chain>
    <MsiPackage SourceFile="$(var.Zenthia.LiquidAR.Win_TargetPath)" />
  </Chain>
</Bundle>
```

Puntos clave:

- El primer `Payload` **tiene que ser tu DLL principal** (el ensamblado que
  contiene `BootstrapperApp.cs`).
- El segundo `Payload` es el `.config` renombrado — el target `AfterBuild`
  del csproj ya se encarga de generarlo con el nombre correcto
  (`ZenthiaInstallerWpf.BootstrapperCore.config`).
- Si tu proyecto de Bundle referencia el `.csproj` de WPF como
  "ProjectReference", WiX resuelve automáticamente
  `$(var.ZenthiaInstallerWpf.TargetDir)`.

## Estructura

```
ZenthiaInstallerWpf/
├── BootstrapperApp.cs        # Clase que hereda de BootstrapperApplication
├── BootstrapperCore.config   # Le dice al host qué ensamblado/clase cargar
├── MainWindow.xaml(.cs)      # La ventana WPF con el diseño
├── ViewModels/
│   ├── MainViewModel.cs      # Progreso, estado, comando Instalar
│   └── RelayCommand.cs
└── Assets/apple.jpg          # Placeholder — reemplazar por la imagen real
```

## Flujo de ejecución

1. `Engine.Detect()` se dispara automáticamente al arrancar.
2. El usuario aprieta **Instalar** → `MainViewModel.StartInstall()` llama a
   `Engine.Plan(LaunchAction.Install)`.
3. `PlanComplete` dispara `Engine.Apply()`, que ejecuta el paquete MSI real.
4. `Progress` / `ExecuteProgress` actualizan la barra de progreso (hoy oculta
   por defecto — se muestra automáticamente vía el binding `IsInstalling`
   apenas arranca la instalación).
5. `ApplyComplete` cierra la ventana y devuelve el código de salida al
   motor de Burn.
