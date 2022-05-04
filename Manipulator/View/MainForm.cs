using System;
using System.Linq;
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
            PopulateMotorGridView();
           
            _presenter.ChartPresenter.InitChart(winChartViewer);
        }


        public MainPresenter Presenter
        {
            set => _presenter = value;
        }

        private void runSimulation_Click(object sender, EventArgs e)
        {
            _presenter.RunSimulation();
        }

        private void PopulateMotorGridView()
        {
            var cell = new DataGridViewTextBoxCell
            {
                Value = 0,
                ReadOnly = false
            };

            var row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell
            {
                Value = "Mоментальный коэффициент двигателя"
            });
            row.Cells.Add(new DataGridViewTextBoxCell
            {
                Value = 29,
                ReadOnly = false
            });
            
            var row0 = new IConvertible[] {"Mоментальный коэффициент двигателя", 29};
            var row1 = new[] {"Индуктивность обмотки якоря двигателя", "6"};
            var row2 = new[] {"Активное сопротивление обмотки якоря двигателя", "1"};
            var row3 = new[] {"Скоростной коэффициент двигателя", "7"};
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
            windingInductanceTextBox.Text = Convert.ToString(Math.Pow(10, -2));
            windingResistanceTextBox.Text = Convert.ToString(13.8);
            speedRatioTextBox.Text = Convert.ToString(20);

            inertiaMomentTextBox.Text = Convert.ToString(0.08);
            frictionCoefficientTextBox.Text =  Convert.ToString(0.0023);
            instantaneousFactorTextBox.Text = Convert.ToString(49 * Math.Pow(10, -3));
            springConstantTextBox.Text = Convert.ToString(0.1);

            regulatorPoporcialTeaxtBox.Text = "1";
            regulatorDifferentialTextBox.Text = "0";
            regulatorIntegralTextBox.Text = "0";
            
            simulationTimeTextBox.Text = "20";
            simulationStep.Text = "0,001";
            controlSignalTextBox.Text = "1";

        }
    }
}