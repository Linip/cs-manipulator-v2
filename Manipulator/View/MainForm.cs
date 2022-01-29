using System;
using System.Windows.Forms;
using Manipulator.Presenter;

namespace Manipulator.View
{
    public partial class MainForm : Form, IMainView
    {
        private MainPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();
        }


        public MainPresenter Presenter
        {
            set => _presenter = value;
        }

        private void runSimulation_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}