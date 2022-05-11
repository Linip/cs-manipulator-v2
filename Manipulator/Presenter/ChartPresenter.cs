using ChartDirector;

namespace Manipulator.Presenter
{
    
    public class ChartPresenter
    {
        private WinChartViewer _chartViewer;

        public void InitChart(WinChartViewer chartViewer)
        {
            _chartViewer = chartViewer;
            double[] data = {0, 1};
            DrawChart(data);
        }
        
        public void DrawChart(double[] data)
        {
            XYChart c = new XYChart(730, 440);

            // Set the plotarea at (30, 20) and of size 200 x 200 pixels
            c.setPlotArea(40, 20, 690, 400);

            // Add a bar chart layer using the given data
            LineLayer lineLayer = c.addLineLayer(data);

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
    }
}