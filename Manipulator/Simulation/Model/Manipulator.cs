using Manipulator.Model;

namespace Manipulator.Simulation.Model
{
    public class Manipulator : ISimulationModel
    {
        public readonly MotorSpecification Motor;
        public readonly ControlElementSpecification Element;
        
        private SystemState _previousState;
        private Regulator.IRegulator _regulator;
        

        public Manipulator(MotorSpecification motor, ControlElementSpecification element)
        {
            Motor = motor;
            Element = element;

            _previousState = new SystemState
            {
                Angle = 0,
                AngularVelocity = 0,
                CurrentStrength = 0,
                ControlSignal = 0,
            };
        }
        
        public SystemState NextState(double controlSignal, double timeStep)
        {
            var state = new SystemState();

            state.ControlSignal = controlSignal;

            // var tunedSignal = _regulator.Tune(state.ControlSignal);
            
            state.CurrentStrength =
                _previousState.CurrentStrength
                - timeStep / Motor.WindingInductance * Motor.WindingResistance * _previousState.CurrentStrength
                - timeStep / Motor.WindingInductance / Motor.SpeedRatio * _previousState.AngularVelocity
                + timeStep / Motor.WindingInductance * state.ControlSignal;

            state.AngularVelocity =
                _previousState.AngularVelocity
                - timeStep / Element.InertiaMoment * Element.FrictionCoefficient * _previousState.AngularVelocity
                - timeStep / Element.InertiaMoment * Element.SpringConstant * _previousState.Angle
                + timeStep / Element.InertiaMoment * Motor.InstantaneousFactor * state.CurrentStrength;

            state.Angle = _previousState.Angle + timeStep * _previousState.AngularVelocity;

            _previousState = state;
            
            return state;
        }
    }
}