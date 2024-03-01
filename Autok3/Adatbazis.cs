using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autok3
{
    internal class Adatbazis
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "autok";  
            builder.CharacterSet = "utf8";
            conn = new MySqlConnection(builder.ConnectionString); 
            sql = conn.CreateCommand();
            try
            {
                kapcsolatNyit();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            finally
            {
                kapcsolatZar();
            }
        }

        
        private void kapcsolatZar()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        private void kapcsolatNyit()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }

        internal List<Auto> getAllAuto() 
        {
            List<Auto> autok = new List<Auto>();
            sql.CommandText = "SELECT * FROM `auto` ORDER BY`marka`";
            try
            {
                kapcsolatNyit();
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {                       
                        string rendszam = dr.GetString("rendszam");
                        string marka = dr.GetString("marka");
                        string modell = dr.GetString("modell");
                        int gyartasiev = dr.GetInt32("gyartasiev");
                        DateTime forgalmiErvenyesseg = dr.GetDateTime("forgalmiErvenyesseg");  
                        int vetelar = dr.GetInt32("vetelar");
                        int kmallas = dr.GetInt32("kmallas");
                        int hengerurtartalom = dr.GetInt32("hengerurtartalom");
                        int tomeg = dr.GetInt32("tomeg");
                        int teljesitmeny = dr.GetInt32("teljesitmeny");
                        autok.Add(new Auto(rendszam, marka, modell, gyartasiev, forgalmiErvenyesseg, vetelar, kmallas, hengerurtartalom, tomeg, teljesitmeny));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
            return autok;
        }

        internal void updateAuto(Auto auto) 
        {
            try
            {
                kapcsolatNyit();

                sql.CommandText = "UPDATE `auto` SET `marka`=@marka,`modell`=@modell,`gyartasiev`=@gyartasiev,`forgalmiErvenyesseg`= @forgalmiErvenyesseg,`vetelar`=@vetelar,`kmallas`=@kmallas,`hengerurtartalom`=@hengerurtartalom,`tomeg`=@tomeg,`teljesitmeny`=@teljesitmeny WHERE `rendszam`=@rendszam";
                
                sql.Parameters.Clear();

                sql.Parameters.AddWithValue("@rendszam", auto.Rendszam);
                sql.Parameters.AddWithValue("@marka", auto.Marka);
                sql.Parameters.AddWithValue("@modell", auto.Modell);
                sql.Parameters.AddWithValue("@gyartasiev", auto.Gyartasiev);
                sql.Parameters.AddWithValue("@forgalmiErvenyesseg", auto.ForgalmiErvenyesseg);
                sql.Parameters.AddWithValue("@vetelar", auto.Vetelar);
                sql.Parameters.AddWithValue("@kmallas", auto.Kmallas);
                sql.Parameters.AddWithValue("@hengerurtartalom", auto.Hengerurtartalom);
                sql.Parameters.AddWithValue("@tomeg", auto.Tomeg);
                sql.Parameters.AddWithValue("@teljesitmeny", auto.Teljesitmeny);

                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }
      
        internal void insertAuto(Auto auto) 
        {
            try
            {
                kapcsolatNyit();

                sql.CommandText = "INSERT INTO `auto` (`rendszam`,`marka`,`modell`,`gyartasiev`,`forgalmiErvenyesseg`,`vetelar`,`kmallas`,`hengerurtartalom`,`tomeg`,`teljesitmeny`) VALUES (@rendszam, @marka, @modell, @gyartasiev, @forgalmiErvenyesseg, @vetelar, @kmallas, @hengerurtartalom, @tomeg, @teljesitmeny)";
                
                sql.Parameters.Clear();
                
                sql.Parameters.AddWithValue("@rendszam", auto.Rendszam);
                sql.Parameters.AddWithValue("@marka", auto.Marka);
                sql.Parameters.AddWithValue("@modell", auto.Modell);
                sql.Parameters.AddWithValue("@gyartasiev", auto.Gyartasiev);
                sql.Parameters.AddWithValue("@forgalmiErvenyesseg", auto.ForgalmiErvenyesseg); 
                sql.Parameters.AddWithValue("@vetelar", auto.Vetelar);
                sql.Parameters.AddWithValue("@kmallas", auto.Kmallas);
                sql.Parameters.AddWithValue("@hengerurtartalom", auto.Hengerurtartalom);
                sql.Parameters.AddWithValue("@tomeg", auto.Tomeg);
                sql.Parameters.AddWithValue("@teljesitmeny", auto.Teljesitmeny);

                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }

        internal void deleteAuto(Auto auto) 
        {
            try
            {
                kapcsolatNyit();

                sql.CommandText = "DELETE FROM `auto` WHERE `rendszam`= @rendszam";
            
                sql.Parameters.Clear();
            
                sql.Parameters.AddWithValue("@rendszam", auto.Rendszam);
            
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }
    }
}


 
