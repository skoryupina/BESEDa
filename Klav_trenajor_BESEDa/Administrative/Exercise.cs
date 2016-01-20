using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace BESEDa.Administrative
{
    public class Exercise
    {

        private int _number; //их 10 штук, поле не статическое
        private int _numberOfLevel;
        string _usingSymbols;
        private int _allowedMistakes; // Кол-во допустимых ошибок 
        private string _text;
        private WorkWithDB _db;
        public Exercise(int number, int numberOfLevel, string text, string usingSymbols)
        {
            _number = number;
            _numberOfLevel = numberOfLevel;
            _text = text;
            _allowedMistakes = Convert.ToInt32(text.Length * 0.1); // 10% от длины упражнения
            _usingSymbols = usingSymbols;
            _db = new WorkWithDB();
        }
        public Exercise(string zones, int numberOfLevel, string text, string usingSymbols)
        {
            _number = accordZoneWithExercise(zones);
            _numberOfLevel = numberOfLevel;
            _text = text;
            _allowedMistakes = Convert.ToInt32(text.Length * 0.1); // 10% от длины упражнения
            _usingSymbols = usingSymbols;
            _db = new WorkWithDB();
        }

        public Exercise(int number, int numberOfLevel)
        {
            _number = number;
            _numberOfLevel = numberOfLevel;
            _db = new WorkWithDB();
        }
      
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public int NumberOfLevel
        {
            get { return _numberOfLevel; }
            set { _numberOfLevel = value; }
        }
        public string UsingSymbols
        {
            get { return _usingSymbols; }
            set { _usingSymbols = value; }
        }
        public int AllowedMistakes
        {
            get { return _allowedMistakes; }
            set { _allowedMistakes = value; }
        }
        public string Text
        {
            get { return _text; }
            set { _text = value; } // наверное стоит убрать seter
        }
        /// <summary>
        /// Определяет номер упражнения по выбранным зонам
        /// </summary>
        /// <param name="zones">строка с номерами зон, разделенные запятыми</param>
        /// <returns></returns>
        public static int accordZoneWithExercise(string zones)
        {
            string[] zoneArray = zones.Split(',');
            if (zoneArray != null)
            {
                int size = zoneArray.Length;
                switch (size)
                {
                    case 1:
                        {
                            switch (zoneArray[0])
                            {
                                case "1": return 1;
                                case "2": return 2;
                                case "3": return 3;
                                case "4": return 4;
                                default: return -1;
                            }
                        }
                    case 2:
                        {
                            switch (zoneArray[0])
                            {
                                case "1":
                                    {
                                        switch (zoneArray[1])
                                        {
                                            case "2": return 5;
                                            case "3": return 8;
                                            case "4": return 10;
                                            default: return -1;
                                        }
                                    }

                                case "2":
                                    {
                                        switch (zoneArray[1])
                                        {
                                            case "3": return 6;
                                            case "4": return 9;
                                            default: return -1;
                                        }
                                    }

                                case "3":
                                    {
                                        switch (zoneArray[1])
                                        {
                                            case "4": return 7;
                                            default: return -1;
                                        }
                                    }
                                default: return -1;
                            }
                        }
                    case 3:
                        {
                            switch (zoneArray[0])
                            {
                                case "1":
                                    {
                                        switch (zoneArray[1])
                                        {
                                            case "2":
                                                {
                                                    switch (zoneArray[2])
                                                    {
                                                        case "3": return 11;
                                                        case "4": return 13;
                                                        default: return -1;
                                                    }
                                                }
                                            case "3":
                                                {
                                                    return 14;
                                                }
                                            default: return -1;
                                        }
                                    }
                                case "2":
                                    return 12;
                                default: return -1;
                            }
                        }
                    case 4: return 15;
                    default: return -1;
                }
            }
            else
                return -1;
        }
       /// <summary>
       /// Возвращает номера зон в виде строки по номеру упражнения
       /// </summary>
       /// <param name="numberOfExercise"></param>
       /// <returns></returns>
        public static string zonesFromExercise(int numberOfExercise)
        {
            switch (numberOfExercise)
            {
                case 1: return "1";
                case 2: return "2";
                case 3: return "3";
                case 4: return "4";
                case 5: return "1,2";
                case 6: return "2,3";
                case 7: return "3,4";
                case 8: return "1,3";
                case 9: return "2,4";
                case 10: return "1,4";
                case 11: return "1,2,3";
                case 12: return "2,3,4";
                case 13: return "1,2,4";
                case 14: return "1,3,4";
                case 15: return "1,2,3,4";
                default: return "";

            }

        }
        /// <summary>
        /// Добавляет упражнение в БД (нужны все поля)
        /// </summary>
        /// <returns>Кол-во добавленных строк в таблицу БД или -1 при ошибке</returns>
        public int insertExercise()
        {
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                int num = 0;
                
                try
                {
                    SQLiteCommand command = new SQLiteCommand(string.Format("INSERT into 'Exercise'"
                        + "(number,numberOfLevel, usedSymbols, text, AmountOfMistakes) VALUES ({0},{1},'{2}','{3}',{4});",
                        _number, _numberOfLevel, _usingSymbols, _text, _allowedMistakes), scon);
                    num = command.ExecuteNonQuery();
                    _db.closeConnection();
                    return num;

                }
                catch
                {
                    return -1;
                }
                finally
                {
                    if (scon != null)
                        _db.closeConnection();
                }
            }
            else 
            {
                return code;
            }
        }

        public int updateExercise()
        {
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                int num = 0;

                try
                {
                    SQLiteCommand command = new SQLiteCommand(string.Format("UPDATE 'Exercise'"
                        + " SET usedSymbols='{0}', text='{1}', AmountOfMistakes={2} WHERE number={3} AND numberOfLevel={4};",
                         _usingSymbols, _text, _allowedMistakes,_number, _numberOfLevel), scon);
                    num = command.ExecuteNonQuery();
                    _db.closeConnection();
                    return num;

                }
                catch
                {
                    return -1;
                }
                finally
                {
                    if (scon != null)
                        _db.closeConnection();
                }
            }
            else
            {
                return code;
            }
        }
        /// <summary>
        /// Извлекает упражнение из БД. Экземпляр класса должен содержать номер упражнения и номер уровня
        /// </summary>
        /// <returns>Кол-во извлеченных строк из таблицы БД или -1 при ошибке</returns>
        public int selectExercise()
        {
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                int num = 0;
                try
                {
                    SQLiteCommand command = new SQLiteCommand(string.Format("SELECT usedSymbols, text, " +
                        "AmountOfMistakes from 'Exercise' where number = {0} AND numberOfLevel = {1};",
                        _number, _numberOfLevel), scon);
                    SQLiteDataReader data = command.ExecuteReader();
                    if (data.HasRows)
                    {
                        if (!data.IsDBNull(0))
                        {
                            data.Read();
                            _usingSymbols = data.GetString(0);
                            _text = data.GetString(1);
                            _allowedMistakes = data.GetInt32(2);
                        }
                    }
                    num = data.StepCount;
                    data.Close();
                    return num;
                }
                catch
                {
                    return -1;
                }
                finally
                {
                    if (scon != null)
                        _db.closeConnection();
                }
            }
            else
            {
                return code;
            }
        }
        public int replaceExercises(int numberForReplace)
        {
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                int num = 0;
                try
                {
                    SQLiteCommand command = new SQLiteCommand(string.Format("UPDATE Exercise SET numberOFlevel=11 "+
                        "WHERE numberOfLevel={0};",_numberOfLevel), scon);
                    num = command.ExecuteNonQuery();
                   
                        command = new SQLiteCommand(string.Format("UPDATE Exercise SET numberOFlevel=12 " +
                        "WHERE numberOfLevel={0};", numberForReplace), scon);
                        num = command.ExecuteNonQuery();
                        command = new SQLiteCommand(string.Format("UPDATE Exercise SET numberOflevel={0} WHERE numberOfLevel=11;",
                           numberForReplace), scon);
                        num = command.ExecuteNonQuery();
                        command = new SQLiteCommand(string.Format("UPDATE Exercise SET numberOflevel={0} WHERE numberOfLevel=12;",
                              _numberOfLevel), scon);
                        num = command.ExecuteNonQuery();

                    return num;
                    
                }
                catch
                {
                    return -1;
                }
                finally
                {
                    if (scon != null)
                        _db.closeConnection();
                }
            }
            else
            {
                return code;
            }
        }

    }
}
