using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_exercise
{
    internal class Car
    {
        private int _maxSpeed;
        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                if (value > 0 && value < 120)
                {
                    _maxSpeed = value;
                }
                else
                {
                    throw new Exception("Interval of max speed have to be: 1 - 120");
                }
            }
             
        }

        
    }
}
