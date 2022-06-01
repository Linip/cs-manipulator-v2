using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminPanel.Presenters;
using ChartDirector;
using Manipulator.Shared.Infrastructure;
using Manipulator.Shared.Models;

namespace AdminPanel
{
    public partial class MainForm : Form
    {
        public MainPresenter Presenter { get; set; }

        private List<DispatcherViewRecord> _tableRecords;
        
        // private WinChartViewer _chartViewer;

        public MainForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = bindingSource1;

            Load += MainForm_Load;
        }

        private void MainForm_Load(Object sender, EventArgs e)
        {
            using (var db = new SqliteContext())
            {
                var recordsQuery =
                    from dispatcherViewRecord in db.DispatcherViewRecords
                    select dispatcherViewRecord;

                _tableRecords = recordsQuery.ToList();

                bindingSource1.DataSource = _tableRecords;
            }
            
            DrawChart(_tableRecords);
        }

        public void DrawChart(List<DispatcherViewRecord> data)
        {
            var points = data
                .Where((p => p.SensorType == Convert.ToInt32(SensorType.Angular)))
                .Where((p => p.SensorId == 7))
                .Select((p => p.Value));
            
            XYChart c = new XYChart(560, 440);

            // Set the plotarea at (30, 20) and of size 200 x 200 pixels
            c.setPlotArea(40, 20, 530, 400);

            // Add a bar chart layer using the given data
            LineLayer lineLayer = c.addLineLayer(points.ToArray());

            // Set the labels on the x axis.
            // c.xAxis().setLabels(labels);

            // Output the chart
            winChartViewer1.Chart = c;
            // data[data.Length] = 45;

            // var layer = c.addLineLayer2();
            // layer.addDataSet();
            
            // chartViewer.Update();
            //include tool tip for the chart
            winChartViewer1.ImageMap = c.getHTMLImageMap("clickable", "", "title='{xLabel}: {value} GBytes'");
        }
    }
}