using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using ZenthiaInstallerWpf.ViewModels;

namespace ZenthiaInstallerWpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContextChanged += (s, e) =>
            {
                if (e.OldValue is MainViewModel oldVm) oldVm.RequestClose -= OnRequestClose;
                if (e.NewValue is MainViewModel newVm) newVm.RequestClose += OnRequestClose;
            };
        }

        private void OnRequestClose(object sender, EventArgs e) => Close();

        // Engine.Apply necesita el handle (HWND) de la ventana para poder
        // pegar la UI del reinicio/UAC si hiciera falta.
        public IntPtr WindowHandlePtr()
        {
            return new WindowInteropHelper(this).EnsureHandle();
        }

        private void TerminosYCondiciones_Click(object sender, MouseButtonEventArgs e)
        {
            // Reemplazá esta URL por la de tus términos y condiciones reales
            Process.Start(new ProcessStartInfo("https://www.zenthia.com/terminos") { UseShellExecute = true });
        }

        private void Cerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
