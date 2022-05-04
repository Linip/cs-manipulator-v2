using System;
using System.Globalization;
using System.Threading;
using Manipulator.Contexts.Simulator;
using Manipulator.Regulator.PID;
using Manipulator.Simulation.Model;
using Manipulator.View;

namespace Manipulator.Presenter
{
    public class MainPresenter
    {
        private readonly MainForm _view;
        public readonly ChartPresenter ChartPresenter;
        private DataSeries _dataSeries;

        private readonly NumberFormatInfo _numberFormatInfo = new NumberFormatInfo
        {
            NumberDecimalSeparator = ","
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
            
            
            var motorSpecification = new MotorSpecification
            {
                InstantaneousFactor =  ToDouble(_view.instantaneousFactorTextBox.Text),
                WindingInductance = ToDouble(_view.windingInductanceTextBox.Text),
                WindingResistance = ToDouble(_view.windingResistanceTextBox.Text),
                SpeedRatio = ToDouble(_view.speedRatioTextBox.Text)
            };
            
            var controlElementSpecification = new ControlElementSpecification
            {
                InertiaMoment = ToDouble(_view.inertiaMomentTextBox.Text),
                FrictionCoefficient = ToDouble(_view.frictionCoefficientTextBox.Text),
                SpringConstant = ToDouble(_view.springConstantTextBox.Text)
            };

            var regulatorSpecification = new PidSpecification
            {
                Proportional = ToDouble(_view.regulatorPoporcialTeaxtBox.Text),
                Integrating = ToDouble(_view.regulatorIntegralTextBox.Text),
                Differentiating = ToDouble(_view.regulatorDifferentialTextBox.Text),
            };
            
            var simulationTime = ToDouble(_view.simulationTimeTextBox.Text);
            var controlSignal = ToDouble(_view.controlSignalTextBox.Text);
            var simulationStep = ToDouble(_view.simulationStep.Text);

            var regulator = new PidRegulator(regulatorSpecification);
            
            var manipulator = new Simulation.Model.Manipulator(motorSpecification, controlElementSpecification, regulator);
            
            var simulator =  new Simulator(manipulator, simulationTime, controlSignal, simulationStep, _dataSeries);


            var thread = new Thread(simulator.Run);
            thread.Start();
            // thread.Join();
        }

        private double ToDouble(string value)
        {
            return Convert.ToDouble(value, _numberFormatInfo);
        }

        public void StopSimulation()
        {
            _view.updateChart.Stop();
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