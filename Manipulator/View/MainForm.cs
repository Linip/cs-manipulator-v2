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

            //
            // motorSpecificationGridView.Rows.Add(row);
            // motorSpecificationGridView.Rows.Add(row1);
            // motorSpecificationGridView.Rows.Add(row2);
            // motorSpecificationGridView.Rows.Add(row3);
        }

        private void stopSimulationButton_Click(object sender, EventArgs e)
        {
           _presenter.StopSimulation();
        }

        private void updateChart_Tick(object sender, EventArgs e)
        {
            _presenter.RenderChart();
        }
    }
}