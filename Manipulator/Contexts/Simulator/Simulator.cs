using System.Threading;
using Manipulator.Presenter;
using Manipulator.Simulation;

namespace Manipulator.Contexts.Simulator
{
    public class Simulator
    {
        private readonly double _simulationTime;
        private readonly double _controlSignal;
        private readonly ISimulationModel _model;
        private readonly DataSeries _dataSeries;
        private readonly DataPresenter _dataPresenter;

        private readonly double _step;

        private double _sumTime = 0;
        
        public Simulator(ISimulationModel model, double simulationTime, double controlSignal, double timeStep, DataSeries dataSeries, DataPresenter dataPresenter)
        {
            _model = model;
            _simulationTime = simulationTime;
            _controlSignal = controlSignal;
            _step = timeStep;
            _dataSeries = dataSeries;
            _dataPresenter = dataPresenter;
        }
        
        public void Run()
        {
            while (_sumTime < _simulationTime)
            {
                var state = _model.NextState(_controlSignal, _step);
               
                
                lock (_dataPresenter)
                {
                    _dataPresenter.Add(state);
                }

                _sumTime += _step;
                
            }

            var t = 3;
        }
    }
}