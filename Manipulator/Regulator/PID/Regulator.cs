using System.Collections.Generic;

namespace Manipulator.Regulator.PID
{
    public class Regulator : IRegulator
    {
        public readonly double Proportional;
        public readonly double Integrating;
        public readonly double Differentiating;
        public readonly double SimulationTime;

        private readonly List<double> _errors;

        private double _result;

        public Regulator(double proportional, double integrating, double differentiating, double simulationTime)
        {
            Proportional = proportional;
            Integrating = integrating;
            Differentiating = differentiating;
            SimulationTime = simulationTime;

            _errors = new List<double>(4) {0, 0, 0};
        }

        public double Tune(double error)
        {
            _errors.RemoveAt(2);
            _errors.Insert(0, error);

            _result = _result
                      + Proportional * Integrating * SimulationTime + _errors[0]
                      + Proportional * (_errors[0] - _errors[1])
                      + Proportional * Differentiating / SimulationTime * (_errors[0] - 2 * _errors[1] + _errors[2]);

            return _result;
        }
    }
}