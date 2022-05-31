using System.Collections.Generic;

namespace Manipulator.Shared.Models
{
    public class Sensor
    {
        public int Id { get; set; }
        
        public string Guid { get; set; }
        
        public List<Measure> Measures { get; set; }
        
        public int ControlObjectId { get; set; }
        public ControlObject ControlObject { get; set; }
    }
}