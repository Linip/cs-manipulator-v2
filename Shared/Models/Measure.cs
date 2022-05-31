using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manipulator.Shared.Models
{
    [Table("Measures")]
    public class Measure
    {
        public int Id { get; set; }

        [Required]
        public double Value { get; set; }
        
        [Required]
        public double Time { get; set; }
        
        public int SensorId { get; set; }
        public Sensor Sensor { get; set; }
    }
}