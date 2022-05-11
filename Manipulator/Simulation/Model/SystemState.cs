// ReSharper disable CommentTypo
namespace Manipulator.Simulation.Model
{
    public class SystemState
    {
        /// <summary>
        ///  x1 - угол поворота
        /// </summary>
        public double Angle;

        /// <summary>
        /// x2 - скорость поворота
        /// </summary>
        public double AngularVelocity;

        /// <summary>
        /// i - сила тока
        /// </summary>
        public double CurrentStrength;

        /// <summary>
        /// u - управляющий сигнал
        /// </summary>
        public double ControlSignal;

        /// <summary>
        /// Время измерения стейта
        /// </summary>
        public double Time;
    }
}