using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;


namespace BESEDa.Training
{
    public class UTraining
    {
        private int _trainingId;        // id тренировки
        private DateTime _startDateOfTraining;  //Дата начала тренировки
        private string _login;   // логин пользователя
        private int _numberOfLevel;   //  номер уровня
        private int _fontSize;  // размер шрифта
        private bool _backliteKeyBoard; // подсветка
        private int _numberOfCurrentExercise; //  Номер текущего упражнения
        WorkWithDB _db;
        public UTraining (string login,int numberOfLevel, int fontSize, bool backliteKeyBoard, int numberOfCurrentExercise) // пока без параметров
        {
            
            _login=login;
            _numberOfLevel = numberOfLevel;
            _fontSize = fontSize;
            _backliteKeyBoard = backliteKeyBoard;
            _numberOfCurrentExercise = numberOfCurrentExercise;
            _db = new WorkWithDB();
        }
        
        public int NumberOfLevel
        {
            get
            {return _numberOfLevel;}
            set
            {
                _numberOfLevel = value;
            }
        }
        public int TrainingID
        {
            get { return _trainingId; }
        }
        public int NumberOfCurrentExercise
        {
            get {return _numberOfCurrentExercise;}
            set{_numberOfCurrentExercise = value;}
        }

        public bool BackliteKeyBoard
        {
            get { return _backliteKeyBoard; }
            set { _backliteKeyBoard = value; }
        }
        public int FontSize
        {
            get { return _fontSize; }
            set { _fontSize = value; }
        }
        public DateTime StartDateOfTraining
        {
            get { return _startDateOfTraining; }
            set { _startDateOfTraining = value; }
        }
        public int getLastId()
        {
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                try
                {

                    SQLiteCommand command = new SQLiteCommand("SELECT MAX(id_training) FROM 'Training';"
                       , scon);
                    SQLiteDataReader data = command.ExecuteReader();
                    int num = 0;
                    if (data.HasRows)
                    {
                        if (!data.IsDBNull(0))
                        {
                            data.Read();
                            _trainingId = data.GetInt32(0);
                            ++_trainingId;
                        }
                    }
                    data.Close();
                    return num;
                }
                catch
                { return -1; }
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
        public int insertTraining()
        {
           int code = _db.openConnection();
           if (code == 1)
           {
               SQLiteConnection scon = _db.SqLiteConnection;
               try
               {

                   SQLiteCommand command = new SQLiteCommand("INSERT INTO 'Training'"
                       + "(id_training, dataTimeOfTraining, numberOfLevel,login) VALUES ("+_trainingId+",'" +
                       _startDateOfTraining.ToString("yyyy-MM-dd HH:mm:ss") + "'," + _numberOfLevel + ",'" + _login + "');", scon);
                   int num = command.ExecuteNonQuery();
                   _db.closeConnection();
                   return num;
               }
               catch
               { return -1; }
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
        public int deleteTraining()
        {
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                try
                {
                    SQLiteCommand command = new SQLiteCommand(
                 string.Format("DELETE FROM Training WHERE id_training={0};", _trainingId), scon);
                    int num = command.ExecuteNonQuery();
                    _db.closeConnection();
                    return num;
                }
                catch
                { return -1; }
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
