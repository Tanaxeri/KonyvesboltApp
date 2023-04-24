using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvesboltApp
{
    internal class SqlData
    {

        private MySqlConnection sqlconnection;
        private MySqlCommand sqlcommand;
        private string errorMessage = null;

        public SqlData(string host, string user, string password, string database)
        {

            MySqlConnectionStringBuilder stringbuilder = new MySqlConnectionStringBuilder();
            stringbuilder.Server = host;
            stringbuilder.UserID = user;
            stringbuilder.Password = password;
            stringbuilder.Database = database;
            sqlconnection = new MySqlConnection(stringbuilder.ConnectionString);
            sqlcommand = sqlconnection.CreateCommand();

        }
        //Írunk 2 metódust hogy nyissa és zárja az adatbázishoz való csatlakozást és ha hiba van akkor jelezze.
        private bool databaseOpen()
        {

            try
            {

                if (sqlconnection.State != System.Data.ConnectionState.Open)
                {

                    sqlconnection.Open();

                }

            }
            catch (MySqlException ex)
            {

                errorMessage = ex.Message;
                return false;

            }

            return true;
        }
        private bool databaseClose()
        {

            try
            {

                if (sqlconnection.State != System.Data.ConnectionState.Closed)
                {

                    sqlconnection.Close();

                }

            }
            catch (MySqlException ex)
            {

                errorMessage = ex.Message;
                return false;

            }

            return true;
        }

        public void KonyvekGridUpdate()
        {           

            if (databaseOpen())
            {                

                try
                {

                    sqlcommand = new MySqlCommand("SELECT * FROM `konyv`;", sqlconnection);

                    using (MySqlDataReader rd = sqlcommand.ExecuteReader())
                    {

                        while (rd.Read())
                        {

                            Konyvdata ujkonyvdata = new Konyvdata(rd.GetInt32("konyvid"), rd.GetString("szerzo"), rd.GetString("cim"), rd.GetInt32("megjelenesi_ev"), rd.GetString("megjelenes_helye"), rd.GetString("kiado"), rd.GetString("kategoria"), rd.GetString("nyelv"), rd.GetString("sorozatcim"), rd.GetInt32("isbn"), rd.GetInt32("ar"));
                            Program.konyvekform.KonyvekGrid.DataSource = ujkonyvdata;                          

                        }

                    }

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show(ex.Message);

                }              

            }
            else
            {

                MessageBox.Show(errorMessage);

            }
            databaseClose();

        }

    }
}
