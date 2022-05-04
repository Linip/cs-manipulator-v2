using System;
using Manipulator.Model;

namespace Manipulator.Presenter
{
    public class DataPresenter
    {
        public int ValuesAmount;

        public DataSeries DataSeries;
        
        private readonly int _pointAmount;
        private int _saveAfter;

        private int _dataAdded = 0;

        public DataPresenter(int pointAmount)
        {
            _pointAmount = pointAmount;
           
        }
        
        public void Add(SystemState state)
        {
            if (_dataAdded % _saveAfter == 0)
            {
                DataSeries.Add(state.Angle);
            }

            _dataAdded++;
        }

        public void InitDataSeries()
        {
            DataSeries = new DataSeries();
        }

        public int CalculateSaveAfter()
        {
            _saveAfter = Convert.ToInt32(ValuesAmount / _pointAmount);
            return _saveAfter;
        }
    }
}