using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC
{
    public class EDC
    {
        private int _meterNum;
        private int _oldReading;
        private int _newReading;
        private int _consumeWat;
        private int _rate;
        private int _total;

        public int MeterNum { get { return _meterNum; } set { _meterNum = value; } }
        public int OldReading { get { return _oldReading; } set { _oldReading = value; } }
        public int NewReading { get { return _newReading; } set { _newReading = value; } }
        public int ConsumeWat { get { return _consumeWat; } set { _consumeWat = value; } }
        public int Rate { get { return _rate; } set { _rate = value; } }
        public int Total { get { return _total; } set { _total = value; } }

        public string CalcConsume()
        {
            _consumeWat = _newReading - _oldReading;

            return _consumeWat.ToString();
        }

        public string CalcTotal()
        {
            string result;

            _total = _consumeWat * _rate;
            result = String.Format("{0:n0}", _total) + "R";

            return result;
        }

        public void Clear()
        {
            _meterNum = 0;
            _oldReading = 0;
            _newReading = 0;
            _consumeWat = 0;
            _rate = 0;
            _total = 0;
        }
    }
}
