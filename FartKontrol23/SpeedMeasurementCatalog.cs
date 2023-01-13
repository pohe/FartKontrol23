using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartKontrol23
{
    public class SpeedMeasurementCatalog
    {
        //instansfelter
        //private string _address;
        private string _zone;
        private int _speedLimit;

        private List<SpeedMeasurement> _list;

        //properties

        public string Address
        {
            get;
            set;
        }

        public string Zone
        {
            get { return _zone; }
            set { _zone = value; }
        }

        public int SpeedLimit 
        {
            get { return _speedLimit; }
            set { _speedLimit = value; }
        }

        //Konstruktør

        public SpeedMeasurementCatalog( string address, string zone, int speedLimit )
        {
            _zone = zone;
            _speedLimit = speedLimit;
            Address = address;
            _list = new List<SpeedMeasurement>();
        }

        //metoder

        public void AddSpeedMeasurement(int speed) //metodenavn + parameterliste kaldes signaturen
        {
            SpeedMeasurement speedMeasurement = new SpeedMeasurement(speed);
            _list.Add(speedMeasurement);
        }


        public double AvarageSpeed()
        {
            double averageSpeed = 0;
            double speedCaculation = 0;
            foreach (SpeedMeasurement item in _list)
            {
                speedCaculation = speedCaculation + item.Speed;
            }
            if (_list.Count == 0)
                return 0;
            else
            {
                averageSpeed = speedCaculation / _list.Count;
                return averageSpeed;
            }
            
        }
        


        //Tostring
        public override string ToString()
        {
            //SKal udskrive alle speedmeasurements i _list
            string allSpeedMeasurements = "";
            foreach (SpeedMeasurement item in _list)
            {
                allSpeedMeasurements = allSpeedMeasurements +" \t" +  item.ToString() + "\n";
            }
            return $"Address {Address } Zone {_zone} SpeedLimit {_speedLimit} \nFartregistreringer \n{allSpeedMeasurements}   ";
        }


    }
}
