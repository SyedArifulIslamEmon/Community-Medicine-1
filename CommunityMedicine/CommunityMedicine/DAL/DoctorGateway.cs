using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using CommunityMedicine.Model;

namespace CommunityMedicine.DAL
{
    public class DoctorGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["CommunityDBConnectionString"].ConnectionString;

        public int SaveDoctor(Doctor doctor)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO tbl_doctor VALUES(''"+doctor.Name+",'"+doctor.Degree+"','"+doctor.Specialization+"')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public Doctor IsExist(Doctor doctor)
        {
            SqlConnection connection=new SqlConnection();
            string query = "SELECT * FROM tbl_doctor WHERE '"+doctor.Name+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Doctor aDoctor = null;
            if (reader.HasRows)
            {
                aDoctor=new Doctor();
                reader.Read();
                aDoctor.DoctorId = (int)reader["id"];
                aDoctor.Name = reader["name"].ToString();
                aDoctor.Degree = reader["degree"].ToString();
                aDoctor.Specialization = reader["specialization"].ToString();
            }
            reader.Close();
            connection.Close();
            return aDoctor;
        }
    }
}