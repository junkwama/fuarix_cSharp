using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public class Sorgular
    {
        public static MySqlConnection connection = new MySqlConnection(
            "SERVER=localhost;" +
            "DATABASE=fuar_veri_tabani;" +
            "UID=root;" +
            "PASSWORD=1234;"
        );

        internal static DataTable oku(string sorgu)
        {
            
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:
            MySqlCommand cmd = new MySqlCommand(sorgu, connection);

            /* Veriler ile proje arasında adaptör görevi sağlayan bir ara eleman olan adp nesnesi oluşturulur: */
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            
            // DataTable türündeki dtable nesnesi oluşturulur:
            DataTable dtable = new DataTable();
            
            // adp'nin çalıştırdığı sql sorgusunun getirdiği sonuçlar dtable'a aktarılır:
            adp.Fill(dtable);

            // Bağlantı kapatılır:
            connection.Close();

            // Okunmuş verileri bir DataTable nesne üzerinde döndürülüyor
            return dtable;

        }

        internal static bool ekle_guncele_sil(string sorgu)
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            // try ile yazacağımız kod denenir:
            try
            {
                // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:
                MySqlCommand cmd = new MySqlCommand(sorgu, connection);
                // Sorgu çalıştırılır:
                int asignLines = cmd.ExecuteNonQuery();
                // Bağlantı kapatılır:
                connection.Close();
                // Returns true if the opetion is a success
                return true;
            }
            // Bir yerde hata varsa catch ile yakalanır ve mesaj verilir:   
            catch (MySqlException ex)
            {
                //Returns false if the operation fails
                MessageBox.Show("Hata : " + ex);
                return false;
            }
        }

    }
}
