using System.Collections.Generic;
using Manipulator.Shared.Infrastructure;
using Manipulator.Shared.Models;

namespace Manipulator.Shared.Helpers
{
    public class InitHelper
    {
        public static void InitManipulator(ControlObject manipulator, SqliteContext entityManager)
        {
            manipulator.Sensors = new List<Sensor>
            {
                new Sensor() {SensorType = SensorType.Angular},
                new Sensor() {SensorType = SensorType.CurrentStrength},
                new Sensor() {SensorType = SensorType.ControlSignal},
            };
            entityManager.Manipulators.Add(manipulator);
            entityManager.SaveChanges();
        }
    }
}