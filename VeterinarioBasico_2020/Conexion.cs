using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VeterinarioBasico_2020
{
    class Conexion

    {
        
        public MySqlConnection conexion;
            public Conexion()
        {
            try
            {
                conexion = new MySqlConnection("Server=127.0.0.1; Database=veterinaria_fujur; Uid=root; Pwd=; Port=3306");
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public Boolean compruebaUsr( string User_Name, string Pass)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM user WHERE  User_Name = @User_Name", conexion);
               
                consulta.Parameters.AddWithValue("@User_Name", User_Name);

                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    string passWithHash = resultado.GetString("Pass");
                    if (BCrypt.Net.BCrypt.Verify(Pass, passWithHash))
                    {

                        return true;
                    }
                }
                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {

                return false;
            }
        }

        public String addUser(string Name, string Last_Name, string User_Name, string Address, string Phone_Number, string Dni, string Date_Birth, string Pass, string myHash)
        {
        
            try
            {

                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO `user` (` Name`, `Last_Name`, `Address`, `Phone_Number`, `Dni, Date_Birth`, `Pass`) VALUES ('" + Name + "','" + Last_Name + "', '"+ User_Name +"', '" + Address + "', '" + Phone_Number + "', '" + Dni + "', '" + Date_Birth + "','" + Pass + "')", conexion);
                consulta.Parameters.AddWithValue("@Name", Name);
                consulta.Parameters.AddWithValue("@Last_Name", Last_Name);
                consulta.Parameters.AddWithValue("@User_Name", User_Name);
                consulta.Parameters.AddWithValue("@Address", Address);
                consulta.Parameters.AddWithValue("@Phone_Number", Phone_Number);
                consulta.Parameters.AddWithValue("@Dni", Dni);
                consulta.Parameters.AddWithValue("@Date_Birth", Date_Birth);
                consulta.Parameters.AddWithValue("@Pass", Pass);

                consulta.ExecuteNonQuery();
                
                conexion.Close();
                return "ok";
            }
            catch (MySqlException e)
            {
                return "rrea esad ";
            }
        }



    }
}
