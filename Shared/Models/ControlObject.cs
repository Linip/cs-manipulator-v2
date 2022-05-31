using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Manipulator.Shared.Models
{
    public class ControlObject
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public List<Sensor> Sensors { get; set; }

        public Sensor GetSensor(SensorType type)
        {
            return Sensors.Find(x => x.SensorType.Equals(type));
        }
    }
}