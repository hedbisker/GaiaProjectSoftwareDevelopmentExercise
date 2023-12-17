using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Data.SqlClient;

namespace GaiaProjectSoftwareDevelopmentExercise.Services
{
    internal class DataBaseManager
    {
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hed\source\repos\GaiaProjectSoftwareDevelopmentExercise\GaiaProjectSoftwareDevelopmentExercise\DatabaseTest.mdf;Integrated Security=True";


        public void addValues(string Operation, string FirstValue,string SecondValue,string Result)
        {

            string queryString = "INSERT INTO DataResult (Operation, FirstValue, SecondValue, Result)" +
                $" VALUES ('{Operation}', '{FirstValue}', '{SecondValue}','{Result}');";
       
            SqlConnection connection = new SqlConnection(connStr);
            try
            {
                SqlCommand myCommand = new SqlCommand(queryString, connection);
                connection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Cancel();

            }
            finally
            {
                connection.Close();
            }
        }

    }
}