using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UserPreferences
    {
        private List<int> HoursVector;
        private float HourValue;
        private bool HasCar;
        private bool HasBike;
        private int MoneyLimit;
        private float BikeToCarRatio;

        public void Set() { }
        public List<int> GetHoursVector() { return null; }
        public float GetHourValue() { return 0; }
        public float GetBikeToCarRatio() { return 0; }
        public bool GetUserHasCar() { return false; }
        public bool GetHasCar() { return false; }
        public int GetMoneyLimit() { return 0; }
    }
}
