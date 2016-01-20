using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BESEDa.Vizualization;
using BESEDa.Administrative;
using System.Data.SQLite;

namespace BESEDa.Training
{
    class Level
    {
        private int _numberOfLevel;
        List<Row> _usingRowList;
        List<Exercise> _exercises;
        WorkWithDB _db;
        public Level(int numberOfLevel, List<Row> usingRowList)
        {
            _numberOfLevel = numberOfLevel;
            _usingRowList = usingRowList;
            _exercises = new List<Exercise>(10);
            _db = new WorkWithDB();
        }
        public List<Row> UsingRowList
        {
            get { return _usingRowList; }
        }
        public List<Exercise> Exercises
        {
            get { return _exercises; } 
        }
        /// <summary>
        /// Возвращает упражнение по номеру
        /// </summary>
        /// <param name="numberOfExercise">Номер упражнения</param>
        /// <returns>Экземпляр Упражнения</returns>
        public Exercise getExercise(int numberOfExercise)
        {
            return _exercises[numberOfExercise-1];
        }
        /// <summary>
        /// Добавляет упражнение в список в соответствии с номером
        /// </summary>
        /// <param name="exercise">Экземпляр класса Упражнение</param>
        public void addExercize(Exercise exercise)
        {
            _exercises.Insert(exercise.Number-1, exercise);
        }
        /// <summary>
        /// Добавляет номер уровня в Базу данных
        /// </summary>
        /// <returns>Код ошибки, либо кол-во добавленных строк</returns>
        public int insertLevel()
        {
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                try
                {
                    SQLiteCommand command = new SQLiteCommand(string.Format("INSERT into 'Level'"+
                        " (number) VALUES ({0});", _numberOfLevel));
                    int num = command.ExecuteNonQuery();
                    _db.closeConnection();
                    return num;
                }
                catch { return -1; }
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
