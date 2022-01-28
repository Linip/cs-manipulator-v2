namespace Manipulator.Regulator
{
    public interface IRegulator
    {
        double Tune(double signal);
    }
}