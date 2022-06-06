using System.Collections.Generic;

namespace Manipulator
{
    public class DataSeries
    {
        private readonly List<double> _data;

        public DataSeries(int sampleSize) 
        {
            _data = new List<double>();
        }

        public void Add(double value)
        {
            _data.Add(value);
        }

        public double[] ToArray()
        {
            return _data.ToArray();
        }
    }
}