using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using BESEDa.Vizualization;
namespace BESEDa.Administrative
{
    [Serializable]
    public class Settings
    {
        Hashtable ht;
        int numberOfLevel;
        List<Row> listOfRows;
        public Settings()
        {
            ht = new Hashtable();
        }

        public int NumberOfLevel
        {
            get { return numberOfLevel; }
            set { numberOfLevel = value; }
        }
        public List<Row> ListOfRows
        {
            get { return listOfRows; }
            set { listOfRows = value; }
        }
        public int Count
        {
            get { return ht.Count; }
        }
        public void addToCollection()
        {
            if ((listOfRows != null) && (numberOfLevel != 0))
            {
                if(ht.ContainsKey(numberOfLevel))
                {
                    ht.Remove(numberOfLevel);
                }
                    ht.Add(numberOfLevel, listOfRows);
            }
        }
        public int existRows()
        {
            if (ht.Count == 0)
                return 0;
            else
            {   int number = 0;
                bool isExist=true;
                foreach (DictionaryEntry de in ht)
                {
                    
                        List<Row> list = (List<Row>)de.Value;
                        if (list.Count == listOfRows.Count)
                        {
                            foreach (Row r in list)
                            {
                                if (!listOfRows.Contains(r))
                                    isExist = false;
                            }
                            if (isExist)
                                number = (int)de.Key;
                            else
                                isExist = true;
                        }
                }
                return number;
            }
        }
        public void changeOrDeleteRow(int key)
        {
            if (ht.ContainsKey(numberOfLevel)) // Если настройка для данного упражнения уже была, то производим обмен настроек
            {
                if (key == numberOfLevel)
                {
                    ht.Remove(numberOfLevel);
                    ht.Add(numberOfLevel, listOfRows);
                }
                else
                {
                    List<Row> old = null;
                    foreach (DictionaryEntry de in ht)
                    {
                        if ((int)de.Key == numberOfLevel)
                        {
                            old = (List<Row>)de.Value;
                        }
                    }
                    ht.Remove(key);
                    ht.Remove(numberOfLevel);
                    ht.Add(key, old);
                    ht.Add(numberOfLevel, listOfRows);
                }
            }
            else //Иначе этому ряду сохраняем выбранные настройки а то удаляем
            {
                ht.Remove(key);
                ht.Add(numberOfLevel, listOfRows);
            }

        }
        public string notConfigured()
        {
            string symbols = "";
            for (int i = 1; i < 10; i++)
            {
                if (!ht.ContainsKey(i))
                    symbols += i + ",";
            }
            return symbols.TrimEnd(',');
        }
        public string getSymbols(int level, int[] zones)
        {
            string symbols = "";
            List<Row> rows=null;
            if (ht!=null)
            {
                foreach (DictionaryEntry de in ht)
                {
                    if ((int)de.Key == level)
                        rows = (List<Row>)de.Value;
                }
            }
            if (rows != null)
            {
                int size = zones.Length;
                foreach (Row r in rows)
                {
                    for (int i = 0; i<size; i++)
                    {
                        symbols += r.getSymbols(zones[i])+",";
                    }
                   
                }
                symbols = symbols.TrimEnd(',');
            }
            return symbols;
        }
    }
}
