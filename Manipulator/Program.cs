using System;
using System.Threading;
using System.Windows.Forms;
using Manipulator.Presenter.Exceptions;
using Manipulator.Properties;
using Manipulator.View;

namespace Manipulator
{
    internal static class Program
    {
        private static readonly Mutex Mutex = new Mutex(false, "Manupulator Control App");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                PerformPayload();
            }
            catch (WelcomeNotEnterObjectNameException)
            {
                Environment.Exit(0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static void EnsureOnlyOneApplicationInstanceIsRunning()
        {
            if (Mutex.WaitOne(TimeSpan.FromSeconds(5), false))
            {
                return;
            }
            
            Mutex.ReleaseMutex();
            
            MessageBox.Show(
                Resources.Program_EnsureOnlyOneApplicationInstanceIsRunning_MessageBoxText);
                
            Environment.Exit(0);
        }

        private static void PerformPayload()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new MainForm();

            var presenter = new Presenter.MainPresenter(view);
            
            Application.Run(view);
        }
      
    }
}