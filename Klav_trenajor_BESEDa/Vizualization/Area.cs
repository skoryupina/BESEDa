using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BESEDa.Vizualization
{
    [Serializable]
    public class Area
    {
        private int _numberOfArea;
        private string _listSymbols;
        public Area(int numberOfArea, string listSymbols)
        {
            _numberOfArea = numberOfArea;
            _listSymbols = listSymbols;
        }
        public int numberOfArea
        {
            get { return _numberOfArea; }
            set { _numberOfArea = value; }
        }
        public string listOfSymbols
        {
            get { return _listSymbols; }
            set { _listSymbols = value; }
        }
       
    }
}
