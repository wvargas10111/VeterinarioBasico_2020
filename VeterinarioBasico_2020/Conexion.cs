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

        public Boolean compruebaUsr( String User_Name, String Pass)
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
                        conexion.Close();
                        return true;
                    }

                    conexion.Close();
                    return false;
                }
                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                conexion.Close();
                return false;
            }
        }

       

        public String addUser(String Name, String Last_Name, String User_Name, String Address, String Phone_Number, String Dni, String Date_Birth, String Pass)
        {
             try
            {
                
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO user ( Name, Last_Name, User_Name, Address, Phone_Number, Dni, Date_Birth, Pass) VALUES (@Name, @Last_Name,  @User_Name, @Address, @Phone_Number, @Dni, @Date_Birth, @Pass)", conexion);
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
                conexion.Close();
                return "rrea esad ";
                System.Diagnostics.Debug.WriteLine("hola22");
            }
        }



    }
}
