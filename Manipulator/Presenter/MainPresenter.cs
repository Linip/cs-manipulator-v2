using System;
using System.Globalization;
using System.Threading;
using Manipulator.Contexts.Simulator;
using Manipulator.Simulation.Model;
using Manipulator.View;

namespace Manipulator.Presenter
{
    public class MainPresenter
    {
        const double TimeStep = 0.01;
        
        private readonly MainForm _view;
        public readonly ChartPresenter ChartPresenter;
        private DataSeries _dataSeries;

        private bool _stopSimulation = false;

        private readonly NumberFormatInfo _numberFormatInfo = new NumberFormatInfo
        {
            NumberDecimalSeparator = "."
        };

        public MainPresenter(MainForm view)
        {
            _view = view;
            view.Presenter = this;
            ChartPresenter = new ChartPresenter();
        }

        public void RunSimulation()
        {
            
            _dataSeries = new DataSeries(5);

            _view.updateChart.Start();
            
            
            
            
            // var motorSpecification = new MotorSpecification
            // {
            //     InstantaneousFactor =  ToDouble(_view.instantaneousFactorTextBox.Text),
            //     WindingInductance = ToDouble(_view.windingInductanceTextBox.Text),
            //     WindingResistance = ToDouble(_view.windingResistanceTextBox.Text),
            //     SpeedRatio = ToDouble(_view.speedRatioTextBox.Text)
            // };
            //
            // var controlElementSpecification = new ControlElementSpecification
            // {
            //     InertiaMoment = ToDouble(_view.inertiaMomentTextBox.Text),
            //     FrictionCoefficient = ToDouble(_view.frictionCoefficientTextBox.Text),
            //     SpringConstant = ToDouble(_view.springConstantTextBox.Text)
            // };
            //
            // var samplingTime = ToDouble(_view.samplingTimeTextBox.Text);
            // var controlSignal = ToDouble(_view.controlSignalTextBox.Text);
            //
            // var manipulator = new Simulation.Model.Manipulator(motorSpecification, controlElementSpecification);
            //
            // _dataSeries = new DataSeries((int) (samplingTime / TimeStep));
            // var simulator =  new Simulator(manipulator, samplingTime, controlSignal, TimeStep, _dataSeries);

            // var chartThread = new Thread(ChartThread);
            // chartThread.Start();
            // chartThread.Join();
            
            // ChartThread();

            // var thread = new Thread(simulator.Run);
            // thread.Start();
            // thread.Join();
        }

        private double ToDouble(string value)
        {
            return Convert.ToDouble(value, _numberFormatInfo);
        }

        private void ChartThread()
        {
            while (!_stopSimulation)
            {
                lock (_dataSeries)
                {
                    ChartPresenter.DrawChart( _dataSeries.ToArray());
                }
                // Thread.Sleep(20);
            }
        }

        public void StopSimulation()
        {
            _view.updateChart.Stop();
            _stopSimulation = true;
        }

        public void RenderChart()
        {
            lock (_dataSeries)
            {
                ChartPresenter.DrawChart(_dataSeries.ToArray());
            }
        }
    }
}