using System;

using System.Data.SQLite;
namespace Countdown
{
    internal class Database
    {
        private static string connectionString = "Data Source=Database.db;Version=3;";

        private static SQLiteConnection connect()
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
                return null;
            }

        }
        public static string getDateTime()
        {
            using (SQLiteConnection con = connect()) 
            {
                if (con == null) return "ERROR!!!";

                string query = "SELECT * FROM time WHERE id = 1";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string time = reader["time"].ToString();
                            string date = reader["date"].ToString();
                            return date+" "+time;
                        }
                        else
                        {
                            MessageBox.Show("Kayıt bulunamadı.");
                        }
                    }
                }
            }
            return "ERROR";
        }
        public static void updateDateTime(DateTime date,string time)
        {
            using (SQLiteConnection con = connect())
            {
                if (con == null)
                {
                    MessageBox.Show("Connection Failed!");
                    return;
                }
                string query = "UPDATE time SET date = @date, time = @time WHERE id = 1";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    string newDate = date.Day+"."+date.Month+"."+date.Year;
                    MessageBox.Show(time);
                    cmd.Parameters.AddWithValue("@date", newDate);
                    cmd.Parameters.AddWithValue("@time", time);

                    int rowsAffected = cmd.ExecuteNonQuery(); 

                    if (rowsAffected > 0)
                    {
                        foreach (Form form2 in Application.OpenForms)
                        {
                            if (form2 is Form2)
                            {
                                form2.Close();
                                break;
                            }
                        }
                        Form1 form1 = (Form1)Application.OpenForms["Form1"];
                        form1.refresh();
                        
                    }
                    else
                    {
                        MessageBox.Show("Error!!");
                    }
                }
            }
        }
    }
}
