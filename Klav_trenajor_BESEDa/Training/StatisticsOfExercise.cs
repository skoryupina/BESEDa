using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;


namespace BESEDa.Training
{
    class StatisticsOfExercise
    {
        private int _exerciseNumber;
        private int _trainingId;
        private DateTime _dataAndTime;
        private int _amountOfMistakes;
        private int _speed;
        WorkWithDB _db;

        public StatisticsOfExercise(int exerciseNumber, int trainingId, DateTime dataAndTime)
        {
            // Создаем класс статистики при начале прохождения упражнения, т.к указывается время начала
            _exerciseNumber = exerciseNumber;
            _trainingId = trainingId;
            _dataAndTime = dataAndTime;
            _db = new WorkWithDB();
        }
        public StatisticsOfExercise(int exerciseNumber, int trainingId)
        {
            // Конструктор для извлечения данных по номеру упр-ния и id тренировки
            _exerciseNumber = exerciseNumber;
            _trainingId = trainingId;
            _db = new WorkWithDB();
        }
        public StatisticsOfExercise(int exerciseNumber, int trainingId, DateTime dataAndTime,
            int amountOfMistakes, int speed)
        {
            _exerciseNumber = exerciseNumber;
            _trainingId = trainingId;
            _dataAndTime = dataAndTime;
            _amountOfMistakes = amountOfMistakes;
            _speed = speed;
            _db = new WorkWithDB();
        }
        public int ExerciseNumber
        {
            get { return _exerciseNumber; }
            set { _exerciseNumber = value; }
        }
        public int TrainingId
        {
            get { return _trainingId; }
            set { _trainingId = value; }
        }
        public DateTime DataAndTime
        {
            get { return _dataAndTime; }
            set { _dataAndTime = value; }
        }
        public int AmountOfMistakes
        {
            get { return _amountOfMistakes; }
            set { _amountOfMistakes = value; }
        }
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        /// <summary>
        /// Добавляет данные статистики в БД. (Нужны все поля)
        /// </summary>
        /// <returns>Кол-во добавленных строк в таблицу БД или код ошибки</returns>
        public int insertStastics()
        {
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                try
                {

                    SQLiteCommand command = new SQLiteCommand(string.Format("INSERT into 'StatisticsOfExercises'"
                        + "(number,id_training,dataTimeTr, amountOfMistakes, speed) VALUES ({0},{1},'{2}',{3},{4});",
                        _exerciseNumber, _trainingId, _dataAndTime.ToString("yyyy-MM-dd HH:mm:ss"), _amountOfMistakes, Speed), scon);
                    int num = command.ExecuteNonQuery();
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
        /// Извлекает данные статистики по номеру упражнения и id_тренировки (необходимые поля)
        /// </summary>
        /// <returns>Кол-во извлеченных строк, либо код ошибки</returns>
        public int selectStatistic()
        {
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                try
                {
                    SQLiteCommand command = new SQLiteCommand(string.Format("SELECT dataTimetr, "+
                        "amountOfMistakes, speed from 'StatisticsOfExercises' where number = '{0}'"+
                        " AND id_training = '{1}';", _exerciseNumber, _trainingId), scon);
                    SQLiteDataReader data = command.ExecuteReader();
                    if (data.HasRows)
                    {
                        _dataAndTime = data.GetDateTime(0);
                        _amountOfMistakes = data.GetInt32(1);
                        _speed = data.GetInt32(2);
                    }
                    int num = data.StepCount;
                    data.Close();
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
                        scon.Close();
                }
            }
            else
            {
                return code;
            }
        }

    }
}
