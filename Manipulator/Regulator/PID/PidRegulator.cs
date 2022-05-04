using System.Collections.Generic;

namespace Manipulator.Regulator.PID
{
    public class PidRegulator : IRegulator
    {
        private readonly PidSpecification _s;

        private readonly List<double> _errors;

        private double _result;

        public PidRegulator(PidSpecification specification)
        {
            _s = specification;

            _errors = new List<double>(4) {0, 0, 0};
        }

        public double Tune(double error, double simulationStep)
        {
            _errors.RemoveAt(2);
            _errors.Insert(0, error);

            var discreteIntegral =  _s.Proportional * _s.Integrating * simulationStep;
            var discreteDifferentiating =  _s.Proportional * _s.Differentiating / simulationStep;
            
            _result = _result
                + discreteIntegral * _errors[0]
                + _s.Proportional * (_errors[0] - _errors[1])
                + discreteDifferentiating * (_errors[0] - 2 * _errors[1] + _errors[2]);

            return _result;
        }
    }
}