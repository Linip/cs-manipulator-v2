using Manipulator.Simulation;

namespace Manipulator.Contexts.Simulator
{
    public class Simulator
    {
        private readonly double _samplingTime;
        private readonly double _controlSignal;
        private readonly ISimulationModel _model;
        private readonly DataSeries _dataSeries;

        private readonly double _step;

        private double _sumTime = 0;
        
        public Simulator(ISimulationModel model, double samplingTime, double controlSignal, double timeStep, DataSeries dataSeries)
        {
            _model = model;
            _samplingTime = samplingTime;
            _controlSignal = controlSignal;
            _step = timeStep;
            _dataSeries = dataSeries;
        }
        
        public void Run()
        {
            while (_sumTime < _samplingTime)
            {
                var state = _model.NextState(_controlSignal, _step);
                lock (_dataSeries)
                {
                    _dataSeries.Add(state.Angle);
                }

                _sumTime += _step;
            }
        }
    }
}