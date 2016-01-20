using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BESEDa.Vizualization
{
    [Serializable]
    public class Row
    {
        private int _rowNumber;
        private Area _indexFinger;
        private Area _middleFinger;
        private Area _annularyFinger;
        private Area _littleFinger;
        public Row(int rowNumber)
        {
            _rowNumber=rowNumber;
            if(_rowNumber==1) // Верхний ряд
            {
                string usingSymbols="4,5,6,7";
                _indexFinger = new Area(1, usingSymbols); // Зона указательных пальцев
                usingSymbols="3,8";
                _middleFinger = new Area(2, usingSymbols); // Зона средних пальцев
                usingSymbols =  "2,9";
                _annularyFinger = new Area(3, usingSymbols); // Зона безымянных пальцев
                usingSymbols =  "ё,1,0";
                _littleFinger = new Area(4, usingSymbols); // Зона мизинцев
            }
            else if (_rowNumber == 2)
            {
                string usingSymbols = "к,е,н,г";
                _indexFinger = new Area(1, usingSymbols); // Зона указательных пальцев
                usingSymbols =  "у,ш";
                _middleFinger = new Area(2, usingSymbols); // Зона средних пальцев
                usingSymbols =  "ц,щ";
                _annularyFinger = new Area(3, usingSymbols); // Зона безымянных пальцев
                usingSymbols =  "й,з,х,ъ";
                _littleFinger = new Area(4, usingSymbols); // Зона мизинцев
            }
            else if (_rowNumber == 3)
            {
                string usingSymbols ="а,п,р,о";
                _indexFinger = new Area(1, usingSymbols); // Зона указательных пальцев
                usingSymbols =  "в,л";
                _middleFinger = new Area(2, usingSymbols); // Зона средних пальцев
                usingSymbols =  "ы,д";
                _annularyFinger = new Area(3, usingSymbols); // Зона безымянных пальцев
                usingSymbols =  "ф,ж,э";
                _littleFinger = new Area(4, usingSymbols); // Зона мизинцев
            }
            else
            {
                string usingSymbols = "м,и,т,ь";
                _indexFinger = new Area(1, usingSymbols); // Зона указательных пальцев
                usingSymbols = "с,б";
                _middleFinger = new Area(2, usingSymbols); // Зона средних пальцев
                usingSymbols =  "ч,ю";
                _annularyFinger = new Area(3, usingSymbols); // Зона безымянных пальцев
                usingSymbols =  "я,.";
                _littleFinger = new Area(4, usingSymbols); // Зона мизинцев
            }
        }
        public int rowNumber
        {
            get { return _rowNumber; }
            
        }
        public Area indexFinger
        {
            get { return _indexFinger; }
            set { _indexFinger = value;  } // нужны ли сеттеры?  
        }
        public Area middleFinger
        {
            get { return _middleFinger; }
            set { _middleFinger = value; }
        }
        public Area annularyFinger
        {
            get { return _annularyFinger; }
            set { _annularyFinger = value; }
        }
        public Area littleFinger
        {
            get { return _littleFinger; }
            set { _littleFinger = value; }
        }
        public override int GetHashCode()
        {
            return _rowNumber;
        }
        public override bool Equals(Object obj)
        {
            if ((obj == null)||!(obj is Row))
                return false;
            else 
            {
                return _rowNumber == ((Row)obj)._rowNumber;
            }
        }
        public string getSymbols(int number)
        {
            if (number == 1)
                return _indexFinger.listOfSymbols;
            else if (number == 2)
                return _middleFinger.listOfSymbols;
            else if (number == 3)
                return _annularyFinger.listOfSymbols;
            else
                return _littleFinger.listOfSymbols;
        }

    }
}
