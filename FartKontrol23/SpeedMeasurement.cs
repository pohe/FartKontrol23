using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartKontrol23
{
    public class SpeedMeasurement
    {
        //instansfelter
        private int _id;
        private int _speed;
        private DateTime _timeStamp;

        //static betyder at variablen hører til klassen og ikke objektet
        // variablen er fælles for alle objekter
        private static int _counter=0;

        //Properties

        public int Id
        {
            get { return _id; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public DateTime TimeStamp
        {
            get { return _timeStamp; }
        }

        //Konstruktør

        public SpeedMeasurement( int speed )
        {
            _counter++;
            _id = _counter;
            _speed = speed;
            _timeStamp = DateTime.Now;
        }

        //ToString
        public override string ToString()
        {
            return $"Id {_id }  Speed {_speed}km/t   Timestamp {_timeStamp}  ";
        }

    }
}
