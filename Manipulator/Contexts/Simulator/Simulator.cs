using Manipulator.Shared.Infrastructure;
using Manipulator.Shared.Models;
using Manipulator.Simulation;

namespace Manipulator.Contexts.Simulator
{
    public class Simulator
    {
        private readonly double _simulationTime;
        private readonly double _controlSignal;
        private readonly ISimulationModel _model;
        private readonly DataSeries _dataSeries;
        private readonly string _manipulatorName;

        private readonly double _step;

        private double _sumTime = 0;
        
        const double StepToSave = 0.1;
        
        public ManipulatorRepository ManipulatorRepository { get; set; }
        
        public Simulator(ISimulationModel model, double simulationTime, double controlSignal, double timeStep, DataSeries dataSeries, string manipulatorName)
        {
            _model = model;
            _simulationTime = simulationTime;
            _controlSignal = controlSignal;
            _step = timeStep;
            _dataSeries = dataSeries;
            _manipulatorName = manipulatorName;
        }
        
        public void Run()
        {
            var manupulator = ManipulatorRepository.FindOneByName(_manipulatorName);
            
            while (_sumTime < _simulationTime)
            {
                var state = _model.NextState(_controlSignal, _step);
                
                lock (_dataSeries)
                {
                    _dataSeries.Add(state.Angle);
                }

                var rr = _sumTime % StepToSave;
                
                if (_sumTime % StepToSave < 0.0000001)
                {
                    manupulator.GetSensor(SensorType.Angular).Measure(state.Angle, _sumTime);
                    manupulator.GetSensor(SensorType.CurrentStrength).Measure(state.CurrentStrength, _sumTime);
                    manupulator.GetSensor(SensorType.ControlSignal).Measure(state.ControlSignal, _sumTime);
                    ManipulatorRepository.EntityManager.SaveChanges();
                }

                _sumTime += _step;
            }
        }
    }
}