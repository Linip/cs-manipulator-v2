using System.ComponentModel.DataAnnotations.Schema;

namespace Manipulator.Shared.Models
{
    [Table("Records")]
    public class DispatcherViewRecord
    {
        [Column("ManipulatorId")]
        public int ManipulatorId { get; set; }
        
        [Column("ManipulatorName")]
        public string ManipulatorName { get; set; }
        
        [Column("SensorId")]
        public int SensorId { get; set; }
        
        [Column("SensorType")]
        public int SensorType { get; set; }
        
        [Column("MeasureId")]
        public int MeasureId { get; set; }
        
        [Column("Value")]
        public double Value { get; set; }
        
        [Column("Time")]
        public double Time { get; set; }
    }
}