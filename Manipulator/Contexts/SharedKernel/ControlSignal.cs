namespace Manipulator.Contexts.SharedKernel
{
    public class ControlSignal
    {
        private double _signal;

        public ControlSignal(double signal)
        {
            _signal = signal;
        }

        public void SetSignal(double signal)
        {
            _signal = signal;
        }

        public double GetSignal()
        {
            return _signal;
        }
    }
}