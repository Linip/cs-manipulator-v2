using System;
using System.Threading;
using System.Windows.Forms;
using Manipulator.Properties;
using Manipulator.View;

namespace Manipulator
{
    internal static class ModelProgram
    {
        private static readonly Mutex Mutex = new Mutex(false, "Manupulator Control App");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EnsureOnlyOneApplicationInstanceIsRunning();
            
            try
            {
                PerformPayload();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Mutex.ReleaseMutex();
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