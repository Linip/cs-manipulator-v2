using Manipulator.Model;

namespace Manipulator.Simulation.Model
{
    public class Manipulator : ISimulationModel
    {
        public readonly MotorSpecification Motor;
        public readonly ControlElementSpecification Element;
        
        private SystemState _previousState;
        private readonly double _samplingTime;
        private Regulator.IRegulator _regulator;
        

        public Manipulator(MotorSpecification motor, ControlElementSpecification element, double samplingTime)
        {
            Motor = motor;
            Element = element;

            _samplingTime = samplingTime;

            _previousState = new SystemState
            {
                Angle = 0,
                AngularVelocity = 0,
                CurrentStrength = 0,
                ControlSignal = 0,
            };
        }
        
        public SystemState NextState(double controlSignal)
        {
            var state = new SystemState();

            state.ControlSignal = controlSignal;

            var tunedSignal = _regulator.Tune(state.ControlSignal);
            
            
            
            throw new System.NotImplementedException();
        }
    }
}