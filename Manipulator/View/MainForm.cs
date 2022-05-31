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

            Load += MainForm_Load;
        }

        private void MainForm_Load(Object sender, EventArgs e)
        {
            _presenter.DemandObjectName();
            _presenter.ChartPresenter.InitChart(winChartViewer);
            
            SetDefaultConfiguration();
        }


        public MainPresenter Presenter
        {
            set => _presenter = value;
        }

        private void runSimulation_Click(object sender, EventArgs e)
        {
            _presenter.RunSimulation();
        }

        private void stopSimulationButton_Click(object sender, EventArgs e)
        {
           _presenter.StopSimulation();
        }

        private void updateChart_Tick(object sender, EventArgs e)
        {
            _presenter.RenderChart();
        }

        private void setDefaultConfig_Click(object sender, EventArgs e)
        {
            SetDefaultConfiguration();
        }

        private void SetDefaultConfiguration()
        {
            windingInductanceTextBox.Text = Convert.ToString(Math.Pow(10, -2));
            windingResistanceTextBox.Text = Convert.ToString(13.8);
            speedRatioTextBox.Text = Convert.ToString(20);

            inertiaMomentTextBox.Text = Convert.ToString(0.08);
            frictionCoefficientTextBox.Text =  Convert.ToString(0.0023);
            instantaneousFactorTextBox.Text = Convert.ToString(49 * Math.Pow(10, -3));
            springConstantTextBox.Text = Convert.ToString(0.1);
            
            simulationTimeTextBox.Text = "20";
            simulationStep.Text = "0,001";
            controlSignalTextBox.Text = "1";

            regulatorPoporcialTeaxtBox.Text = "150";
            regulatorIntegralTextBox.Text = "150";
            regulatorDifferentialTextBox.Text = "150";
        }
    }
}