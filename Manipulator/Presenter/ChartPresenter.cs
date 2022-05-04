using System;
using System.Collections.Generic;
using ChartDirector;

namespace Manipulator.Presenter
{
    public class ChartPresenter
    {
        public const int ChartWidth = 730;
        public const int ChartHeight = 440;
        
        private WinChartViewer _chartViewer;

        private string[] _labels;

        public void InitChart(WinChartViewer chartViewer)
        {
            _chartViewer = chartViewer;
            double[] data = {0, 1};
            DrawChart(data);
        }
        
        public void DrawChart(double[] data)
        {
            XYChart c = new XYChart(ChartWidth, ChartHeight);

            // Set the plotarea at (30, 20) and of size 200 x 200 pixels
            c.setPlotArea(40, 20, 690, 350);

            // Add a bar chart layer using the given data
            LineLayer lineLayer = c.addLineLayer(data);

            c.xAxis().setLabels(_labels);
            c.xAxis().setLabelStep(100);
            // Set the labels on the x axis.
            // c.xAxis().setLabels(labels);

            // Output the chart
            _chartViewer.Chart = c;
             // data[data.Length] = 45;

            // var layer = c.addLineLayer2();
            // layer.addDataSet();
            
            // chartViewer.Update();
            //include tool tip for the chart
            _chartViewer.ImageMap = c.getHTMLImageMap("clickable", "", "title='{xLabel}: {value} GBytes'");
        }

        public void SolveLabels(double valueStep)
        {
            var label = 0.0;
            var labels = new List<string>();
            for (var i = 0; i < ChartWidth; i++)
            {
                label += valueStep;
                labels.Add(Convert.ToString(Math.Round(label, 2)));
            }

            _labels = labels.ToArray();
        }
    }
}