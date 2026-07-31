using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using Microsoft.Tools.WindowsInstallerXml.Bootstrapper;

namespace ZenthiaInstallerWpf.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly Engine _engine;

        public MainViewModel(Engine engine)
        {
            _engine = engine;
            InstallCommand = new RelayCommand(_ => StartInstall(), _ => !IsInstalling);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void Raise(string prop) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public string ProductTitle => "Zenthia - Instalación de LiquidAR";
        public string ProductSubtitle => "sera instalado en su equipo";

        public int ExitCode { get; private set; }

        private bool _isInstalling;
        public bool IsInstalling
        {
            get => _isInstalling;
            set { _isInstalling = value; Raise(nameof(IsInstalling)); }
        }

        private string _currentPackage;
        public string CurrentPackage
        {
            get => _currentPackage;
            set { _currentPackage = value; Raise(nameof(CurrentPackage)); }
        }

        private int _overallProgress;
        public int OverallProgress
        {
            get => _overallProgress;
            set { _overallProgress = value; Raise(nameof(OverallProgress)); }
        }

        private int _currentPackageProgress;
        public int CurrentPackageProgress
        {
            get => _currentPackageProgress;
            set { _currentPackageProgress = value; Raise(nameof(CurrentPackageProgress)); }
        }

        public ICommand InstallCommand { get; }

        // No existe un objeto Application en este host (se usa Dispatcher.Run()),
        // así que el cierre se señaliza con este evento y la ventana se cierra sola.
        public event EventHandler RequestClose;

        private void StartInstall()
        {
            IsInstalling = true;
            // Dispara el plan de instalación; el resultado de Plan()
            // se recibe en PlanComplete y desde ahí se llama a Engine.Apply()
            _engine.Plan(LaunchAction.Install);
        }

        public void ShowError(string message)
        {
            IsInstalling = false;
            MessageBox.Show(message, "Error durante la instalación",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void OnInstallComplete(int status)
        {
            IsInstalling = false;
            ExitCode = status;

            if (status >= 0)
            {
                MessageBox.Show("La instalación finalizó correctamente.",
                    "Zenthia - LiquidAR", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            RequestClose?.Invoke(this, EventArgs.Empty);
        }
    }
}
