namespace Manipulator.Simulation.Model
{
    public class ControlElementSpecification
    {
        /// <summary>
        /// момент инерции звена
        /// </summary>
        public double InertiaMoment;

        /// <summary>
        /// коэффициент вязкого трения в подшипниках
        /// </summary>
        public double FrictionCoefficient;

        /// <summary>
        /// коэффициент жёсткости пружины
        /// </summary>
        public double SpringConstant;
    }
}