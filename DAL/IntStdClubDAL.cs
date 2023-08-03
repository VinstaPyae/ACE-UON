﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace UON.DAL
{
    public class IntStdClubDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["UONSource"].ConnectionString;

        public DataTable GetIntStdClubData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [dbo].[Int_Student_Club]";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return dataTable;
        }
    }

}