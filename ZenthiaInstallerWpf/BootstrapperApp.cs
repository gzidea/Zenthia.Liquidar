using System;
using System.Windows;
using System.Windows.Threading;
using Microsoft.Tools.WindowsInstallerXml.Bootstrapper;
using ZenthiaInstallerWpf.ViewModels;

namespace ZenthiaInstallerWpf
{
    // El host de WiX (ManagedBootstrapperApplicationHost) busca por reflection
    // la única clase del ensamblado que hereda de BootstrapperApplication.
    public class BootstrapperApp : BootstrapperApplication
    {
        private Dispatcher _dispatcher;
        private MainWindow _view;
        private MainViewModel _viewModel;

        public BootstrapperApp()
        {
            System.IO.File.WriteAllText(
                System.IO.Path.Combine(System.IO.Path.GetTempPath(), "ZenthiaBA_ctor.txt"),
                "Constructor de BootstrapperApp alcanzado a las " + DateTime.Now);

            // Esto abre el diálogo de "Just-In-Time Debugger" de Windows y te deja
            // elegir Visual Studio para adjuntarte ANTES de que siga ejecutando.
            // Comentalo una vez que termines de diagnosticar.
            System.Diagnostics.Debugger.Launch();
        }

        protected override void Run()
        {
            this.Engine.Log(LogLevel.Standard, "ZenthiaInstallerWpf: entrando a Run().");

            try
            {
                RunInternal();
            }
            catch (Exception ex)
            {
                // Sin este catch, una excepción acá puede no dejar rastro en el log de Burn.
                this.Engine.Log(LogLevel.Error,
                    "ZenthiaInstallerWpf: EXCEPCIÓN no controlada en Run(): " + ex);
                this.Engine.Quit(unchecked((int)0x80004005)); // E_FAIL
            }
        }

        private void RunInternal()
        {
            // El Engine corre en su propio hilo; para tener un Dispatcher de WPF
            // hace falta crear la ventana en un hilo STA propio con su bucle de mensajes.
            _dispatcher = Dispatcher.CurrentDispatcher;

            this.Engine.Log(LogLevel.Standard, "ZenthiaInstallerWpf: creando ViewModel y MainWindow.");
            _viewModel = new MainViewModel(this.Engine);
            _view = new MainWindow { DataContext = _viewModel };

            // Suscripción a los eventos del motor de Burn
            this.DetectPackageComplete += OnDetectPackageComplete;
            this.PlanComplete += OnPlanComplete;
            this.ApplyComplete += OnApplyComplete;
            this.ExecutePackageBegin += OnExecutePackageBegin;
            this.Progress += OnProgress;
            this.ExecuteProgress += OnExecuteProgress;
            this.Error += OnError;

            _view.Closed += (s, e) => _dispatcher.InvokeShutdown();

            this.Engine.Log(LogLevel.Standard, "ZenthiaInstallerWpf: llamando a Engine.Detect().");
            this.Engine.Detect();

            this.Engine.Log(LogLevel.Standard, "ZenthiaInstallerWpf: mostrando la ventana.");
            _view.Show();
            System.Windows.Threading.Dispatcher.Run();

            this.Engine.Log(LogLevel.Standard, "ZenthiaInstallerWpf: interfaz cerrada, finalizando.");
            this.Engine.Quit(_viewModel.ExitCode);
        }

        private void OnDetectPackageComplete(object sender, DetectPackageCompleteEventArgs e)
        {
            // Acá podrías inspeccionar e.PackageId / e.State si tenés varios paquetes
        }

        private void OnPlanComplete(object sender, PlanCompleteEventArgs e)
        {
            if (e.Status >= 0)
            {
                _dispatcher.Invoke(() => this.Engine.Apply(_view.WindowHandlePtr()));
            }
        }

        private void OnExecutePackageBegin(object sender, ExecutePackageBeginEventArgs e)
        {
            _dispatcher.BeginInvoke(new Action(() =>
                _viewModel.CurrentPackage = e.PackageId));
        }

        private void OnProgress(object sender, ProgressEventArgs e)
        {
            _dispatcher.BeginInvoke(new Action(() =>
                _viewModel.OverallProgress = e.ProgressPercentage));
        }

        private void OnExecuteProgress(object sender, ExecuteProgressEventArgs e)
        {
            _dispatcher.BeginInvoke(new Action(() =>
                _viewModel.CurrentPackageProgress = e.ProgressPercentage));
        }

        private void OnError(object sender, ErrorEventArgs e)
        {
            this.Engine.Log(LogLevel.Error,
                $"[{e.ErrorType}] {e.PackageId}: {e.ErrorMessage} (code {e.ErrorCode})");

            _dispatcher.Invoke(() => _viewModel.ShowError(e.ErrorMessage));

            // Devolvé el resultado que corresponda según cómo quieras manejar el error
            e.Result = Result.Abort;
        }

        private void OnApplyComplete(object sender, ApplyCompleteEventArgs e)
        {
            _dispatcher.BeginInvoke(new Action(() =>
            {
                _viewModel.OnInstallComplete(e.Status);
            }));
        }
    }
}