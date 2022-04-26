using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manipulator.Properties;
using Manipulator.View;

namespace Manipulator
{
    internal static class Program
    {
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

        private static readonly Mutex Mutex = new Mutex(false, "Manupulator Control App");

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

        [SuppressMessage("ReSharper.DPA", "DPA0003: Excessive memory allocations in LOH", MessageId = "type: System.Int32[]")]
        [SuppressMessage("ReSharper.DPA", "DPA0001: Memory allocation issues")]
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