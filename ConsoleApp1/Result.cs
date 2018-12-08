using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Result
    {
        private List<Place> Sequence;
        private float Prices;
        private float MinutesSpent;
        private bool Error;
        private WaysOfTravel HowTravel;

        public List<Place> GetSequence() { return null; }
        public float GetPrices() { return 0; }
        public float GetMinutesSpent() { return 0; }
        public bool IsError() { return false; }

        public void SetSequence(List<Place> places) { }
        public void SetPrices() { }
        public void SetMinutesSpent() { }

        public enum WaysOfTravel { Car, Bike, Bus };

        public Result(int _type)
        {
            this.Sequence = null;
            this.Prices = 0;
            this.MinutesSpent = 0;
            this.Error = false;
            this.HowTravel.Equals(2);
        }

        public Result()
        {
            this.Sequence = null;
            this.Prices = 0;
            this.MinutesSpent = 0;
            this.Error = false;
        }
    }
}
