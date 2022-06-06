using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ChartDirector;
using Manipulator.Shared.Infrastructure;
using Manipulator.Shared.Models;

namespace AdminPanel
{
    public partial class MainForm : Form
    {
        private List<DispatcherViewRecord> _tableRecords;

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
                .Where((p => p.SensorId == 34))
                .Select((p => p.Value));
            
            XYChart c = new XYChart(560, 440);

            c.setPlotArea(40, 20, 530, 400);

            LineLayer lineLayer = c.addLineLayer(points.ToArray());
            
            winChartViewer1.Chart = c;
            
            
            
            winChartViewer1.ImageMap = c.getHTMLImageMap("clickable", "", "title='{xLabel}: {value} GBytes'");
        }
    }
}