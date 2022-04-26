namespace Manipulator.Simulation.Model
{
    public class MotorSpecification
    {
        /// <summary>
        /// моментальный коэффициент двигателя
        /// </summary>
        public double InstantaneousFactor;

        /// <summary>
        /// индуктивность обмотки якоря двигателя
        /// </summary>
        public double WindingInductance;

        /// <summary>
        /// активное сопротивление обмотки якоря двигателя
        /// </summary>
        public double WindingResistance;

        /// <summary>
        /// скоростной коэффициент двигателя
        /// </summary>
        public double SpeedRatio;
    }
}