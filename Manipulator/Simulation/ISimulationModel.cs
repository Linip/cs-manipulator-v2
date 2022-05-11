using Manipulator.Simulation.Model;

namespace Manipulator.Simulation
{
    public interface ISimulationModel
    {
        SystemState NextState(double controlSignal, double timeStep);
    }
}