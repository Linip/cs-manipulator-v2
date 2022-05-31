using System.Collections.Generic;

namespace Manipulator.Shared.Models
{
    public class Sensor
    {
        public int Id { get; set; }
        
        public string Guid { get; set; }
        
        public List<Measure> Measures { get; set; }
        
        public SensorType SensorType { get; set; }
        
        public int ControlObjectId { get; set; }
        public ControlObject ControlObject { get; set; }

        public Measure Measure(double value, double time)
        {
            var measure = new Measure() {Value = value, Time = time};
            if (Measures == null)
            {
                Measures = new List<Measure>();
            }
            
            Measures.Add(measure);

            return measure;
        }
    }
}