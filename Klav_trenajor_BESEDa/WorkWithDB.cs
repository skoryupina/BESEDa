using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using BESEDa.Authorization;
using BESEDa.Administrative;

namespace BESEDa
{
   
    class WorkWithDB
    {
        private SQLiteConnection sqliteConnection;
        private static string dbName = "beseda";

        public SQLiteConnection SqLiteConnection
        {
            get { return sqliteConnection; }
        }

        public WorkWithDB()
        {
            sqliteConnection = new SQLiteConnection(string.Format("Data Source={0};", dbName));
        }

        /// <summary>
        /// Открывает соединение к БД "БЕСЕДа"
        /// Возвращает код - состояние подключения
        /// </summary>

        public int openConnection()
        {
            int result;
            try
            {
                sqliteConnection.Open();
                result = 1;
            }
            catch
            {
                result = -1;
            }
            return result;
        }


        public int closeConnection()
        {
            int result;
            try
            {
                sqliteConnection.Close();
                result = 1;
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public void createTableUser()
        {
            //создание таблицы пользователей

            SQLiteCommand createUsers = new SQLiteCommand
            ("CREATE TABLE IF NOT EXISTS User" +
            "(" +
            "login VARCHAR(20) PRIMARY KEY," +
            "password VARCHAR(10) NOT NULL," +
            "lastDataTraining DateTime," +
            "lastLevelNumber INT);", sqliteConnection);
            createUsers.ExecuteNonQuery();
        }

        public void createTableLevel()
        {
            // создание таблицы уровней

            SQLiteCommand createLevel = new SQLiteCommand
           ("CREATE TABLE IF NOT EXISTS Level" +
           "(" +
           "number INT PRIMARY KEY);", sqliteConnection);
            sqliteConnection.Open();
            createLevel.ExecuteNonQuery();
        }

        public void createTableExercise()
        {
            //связывание Уровня и Упражнения
            //создание таблицы упражнений

            SQLiteCommand createExercises = new SQLiteCommand
            ("CREATE TABLE IF NOT EXISTS Exercise" +
            "(" +
            "number INT," +
            "numberOfLevel INT REFERENCES Level(number) NOT NULL," +
            "usedSymbols VARCHAR(50) NOT NULL," +
            "text VARCHAR(50) NOT NULL," +
            "AmountOfMistakes INT NOT NULL, " +
            "CONSTRAINT pk_ex PRIMARY KEY (number,numberOfLevel));", sqliteConnection);
            createExercises.ExecuteNonQuery();
        }

        public void createTableTraining()
        {
            //связывание Уровня, Тренировки, Пользователя
            //создание таблицы тренировок
            SQLiteCommand createTraining = new SQLiteCommand
             ("CREATE TABLE IF NOT EXISTS Training" +
             "(" +
             "id_training INT PRIMARY KEY," +
             "dataTimeOfTraining DateTime NOT NULL," +
             "login VARCHAR(20) REFERENCES User(login) NOT NULL," +
             "numberOfLevel INT REFERENCES Level(number) NOT NULL);", sqliteConnection);
            createTraining.ExecuteNonQuery();
        }

        public void createTableStatistics()
        {
            //связывание Тренировки, Статистики по упражнению
            //создание таблицы статистики по упражнению
            SQLiteCommand createStat = new SQLiteCommand
             ("CREATE TABLE IF NOT EXISTS StatisticsOfExercises" +
             "(" +
             "number INT," +
             "dataTimeTr DateTime NOT NULL," +
             "amountOfMistakes INT NOT NULL," +
             "speed INT NOT NULL, " +
             "id_training INT REFERENCES Training(id_training)," +
             "CONSTRAINT pk_stat PRIMARY KEY (number,id_training));", sqliteConnection);
            createStat.ExecuteNonQuery();
        }

        /// <summary>
        /// Добавляет запись в таблицу пользователя (при регистрации)
        /// </summary>
        /// <param name="user">Объект пользователя</param>
        /// <returns></returns>

        public int insertUser(User user)
        {
             SQLiteCommand insertCom = new SQLiteCommand("INSERT " +
             "INTO User(login,password) " +
             "VALUES(" + "'" + user.Login + "'" + "," + "'"+ user.Password +"'" + ");", sqliteConnection);
            int num = insertCom.ExecuteNonQuery();
            return num;
        }

        /// <summary>
        /// Добавляет упражнение в БД. (нужны все поля)
        /// </summary>
        /// <param name="ex">Объект упражнения</param>
        /// <returns></returns>
        public int insertExercise(Exercise ex)
        {
            SQLiteCommand insertCom = new SQLiteCommand("INSERT " +
            "INTO Exercise " +
            "VALUES(" + ex.Number + ","  + ex.NumberOfLevel + ","+
            "'" + ex.UsingSymbols + "'," + "'" + ex.Text + "'," + 
            ex.AllowedMistakes+ ");", sqliteConnection);
            int num = insertCom.ExecuteNonQuery();
            return num;
        }


        public void createTables()
        {
            //sqliteConnection = new SQLiteConnection(string.Format("Data Source={0};", dbName));

            //создание таблицы пользователей

            //SQLiteCommand createUsers = new SQLiteCommand
            //("CREATE TABLE IF NOT EXISTS User" +
            //"(" +
            //"login VARCHAR(20) PRIMARY KEY," +
            //"password VARCHAR(10) NOT NULL," +
            //"lastDataTraining DateTime," +
            //"lastLevelNumber INT);", sqliteConnection);
            //sqliteConnection.Open();
            //createUsers.ExecuteNonQuery();


            // создание таблицы уровней

            // SQLiteCommand createLevel = new SQLiteCommand
            //("CREATE TABLE IF NOT EXISTS Level" +
            //"(" +
            //"number INT PRIMARY KEY);", sqliteConnection);
            // sqliteConnection.Open();
            // createLevel.ExecuteNonQuery();




            //связывание Уровня и Упражнения
            //создание таблицы упражнений

            // SQLiteCommand createExercises = new SQLiteCommand
            //("CREATE TABLE IF NOT EXISTS Exercise" +
            //"(" +
            //"number INT," +
            //"numberOfLevel INT REFERENCES Level(number) NOT NULL," +
            //"usedSymbols VARCHAR(50) NOT NULL," +
            //"text VARCHAR(50) NOT NULL," +
            //"AmountOfMistakes INT NOT NULL, "+
            //"CONSTRAINT pk_ex PRIMARY KEY (number,numberOfLevel));", sqliteConnection);
            //sqliteConnection.Open();
            //createExercises.ExecuteNonQuery();


            //связывание Уровня, Тренировки, Пользователя
            //создание таблицы тренировок
            //SQLiteCommand createTraining = new SQLiteCommand
            // ("CREATE TABLE IF NOT EXISTS Training" +
            // "(" +
            // "id_training INT PRIMARY KEY," +
            // "dataTimeOfTraining DateTime NOT NULL," +
            // "login VARCHAR(20) REFERENCES User(login) NOT NULL," +
            // "numberOfLevel INT REFERENCES Level(number) NOT NULL);", sqliteConnection);
            //sqliteConnection.Open();
            //createTraining.ExecuteNonQuery();


            //связывание Тренировки, Статистики по упражнению
            //создание таблицы статистики по упражнению
            //SQLiteCommand createStat = new SQLiteCommand
            // ("CREATE TABLE IF NOT EXISTS StatisticsOfExercises" +
            // "(" +
            // "number INT," +
            // "dataTimeTr DateTime NOT NULL," +
            // "amountOfMistakes INT NOT NULL," +
            // "speed INT NOT NULL, "+
            // "id_training INT REFERENCES Training(id_training),"+
            // "CONSTRAINT pk_stat PRIMARY KEY (number,id_training));", sqliteConnection);
            //sqliteConnection.Open();
            //createStat.ExecuteNonQuery();



            //SQLiteCommand insertCom = new SQLiteCommand("INSERT " +
            //   "INTO User(login,password) " +
            //   "VALUES(" + "'Sara'" + "," + "'Катя'" + ");", sqliteConnection);

            //int num = insertCom.ExecuteNonQuery();

            //createUsers.ExecuteNonQuery();
        }
    }
}
