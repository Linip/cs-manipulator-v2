using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Manipulator
{
    public class DataSeries
    {
        private readonly List<double> _data;

        public DataSeries()
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