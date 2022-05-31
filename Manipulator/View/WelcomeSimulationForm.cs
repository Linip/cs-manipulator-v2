using System;
using System.Windows.Forms;
using Manipulator.Presenter;

namespace Manipulator.View
{
    public partial class WelcomeSimulationForm : Form
    {
        public WelcomeSimulationForm()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public string getControlObjectName()
        {
            return controlObjectName.Text;
        }
    }
}