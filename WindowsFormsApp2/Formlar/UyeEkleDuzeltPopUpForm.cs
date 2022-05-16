using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UyeEkleDuzeltPopUpForm : Form
    {
        private string islemTuru = "ekle";
        private int duzeltecekUyeId = 0;
        //Yeni Uye ekleme için : Yapıncı metodun Overload 1
        public UyeEkleDuzeltPopUpForm()
        {

            InitializeComponent();
            uyeDilleri.CheckOnClick = true;
            uyeFavBilgiAlan.CheckOnClick = true;
            Item temp;

            DataTable dt_diller = Sorgular.oku("SELECT * FROM diller");
            for (int i = 0; i< dt_diller.Rows.Count; i++ )
            {
                temp = new Item{
                    Text = dt_diller.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_diller.Rows[i]["id"].ToString())
                };
                uyeDilleri.Items.Add(temp);
            }

            DataTable dt_fav_bilgi_alan = Sorgular.oku("SELECT * FROM bilgi_alanlari");
            for (int i = 0; i < dt_fav_bilgi_alan.Rows.Count; i++)
            {
                temp = new Item{
                    Text = dt_fav_bilgi_alan.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_fav_bilgi_alan.Rows[i]["id"].ToString())
                };
                uyeFavBilgiAlan.Items.Add(temp);
            }

            DataTable dt_ulkeler = Sorgular.oku("SELECT * FROM ulkeler");
            for (int i = 0; i < dt_ulkeler.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_ulkeler.Rows[i]["isim"].ToString(),
                    Id = Convert.ToInt32(dt_ulkeler.Rows[i]["id"].ToString())
                };

                ulke.Items.Add(temp);
            }

            DataTable dt_meslek = Sorgular.oku("SELECT * FROM meslekler");
            for (int i = 0; i < dt_meslek.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_meslek.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_meslek.Rows[i]["id"].ToString())
                };
                meslek.Items.Add(temp);
            }


        }

        //Var olan Uye değitirmek : Yapıcı metodun Overload 2
        public UyeEkleDuzeltPopUpForm( int duzeltecekUyeId )
        {

            InitializeComponent();
            this.islemTuru = "guncele";
            this.duzeltecekUyeId = duzeltecekUyeId;
            this.EkleBut.Text = "Güncele";

            //Ad, soyad, email inputlara uye değerleri veriyoruz-----------------
            DataTable uyeDT = Sorgular.oku(
                @"
                    SELECT 
                        uye.id, uye.ad , uye.soyadi, uye.email AS eposta, uye.tel AS telefon, 
                        meslek.baslik meslek, meslek.id meslekId, ulke.isim ulke, ulke.id ulkeId, uye.sehir, uye.sifre
                    FROM 
                        uyeler uye, meslekler meslek, ulkeler ulke 
                    WHERE 
                        uye.ulke_id=ulke.id AND uye.meslek_id=meslek.id
                    AND uye.id=" + duzeltecekUyeId +
                ";"
            );

            DataRow uye = uyeDT.Rows[0];
            this.adInput.Text = uye["ad"].ToString();
            this.soyadiInput.Text = uye["soyadi"].ToString();
            this.epostaInput.Text = uye["eposta"].ToString();
            this.telInput.Text = uye["telefon"].ToString();
            this.sehirInput.Text = uye["sehir"].ToString();
            this.sifreInput.Text = uye["sifre"].ToString();


            //Ulke ve meslek
            uyeDilleri.CheckOnClick = true;
            uyeFavBilgiAlan.CheckOnClick = true;
            Item temp;

            DataTable dt_ulkeler = Sorgular.oku("SELECT * FROM ulkeler");
            for (int i = 0; i < dt_ulkeler.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_ulkeler.Rows[i]["isim"].ToString(),
                    Id = Convert.ToInt32(dt_ulkeler.Rows[i]["id"].ToString())
                };
                ulke.Items.Add(temp);
            }

            DataTable dt_meslek = Sorgular.oku("SELECT * FROM meslekler");
            for (int i = 0; i < dt_meslek.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_meslek.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_meslek.Rows[i]["id"].ToString())
                };
                meslek.Items.Add(temp);
            }

            //Ulke ve meslek Kombo boxlara uye ulkesi ve mesleği seçiyoruz.
            
            ulke.SelectedIndex = Convert.ToInt32(uye["ulkeId"].ToString()) - 1;
            meslek.SelectedIndex = Convert.ToInt32(uye["meslekId"].ToString()) - 1;

            //CheckedLiSTbOXlAR
            DataTable t_temp;
            DataTable dt_diller = Sorgular.oku("SELECT * FROM diller");
            for (int i = 0; i < dt_diller.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_diller.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_diller.Rows[i]["id"].ToString())
                };

                //Önce bütün Itemsleri ekliyoruz
                uyeDilleri.Items.Add(temp);

                t_temp = Sorgular.oku(
                    @"SELECT * FROM uyelerin_dilleri 
                    WHERE dil_id = " + Convert.ToInt32(dt_diller.Rows[i]["id"].ToString()) + " AND " + 
                    "uye_id = " + duzeltecekUyeId + ";"
                );
                if (t_temp.Rows.Count > 0)
                {
                    uyeDilleri.SetItemCheckState(i, CheckState.Checked);
                }
            }

            DataTable dt_fav_bilgi_alan = Sorgular.oku("SELECT * FROM bilgi_alanlari");
            for (int i = 0; i < dt_fav_bilgi_alan.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_fav_bilgi_alan.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_fav_bilgi_alan.Rows[i]["id"].ToString())
                };

                //Once butun itemleri ekliyoruz
                uyeFavBilgiAlan.Items.Add(temp);

                t_temp = Sorgular.oku(
                    @"SELECT * FROM uyelerin_favori_bilgi_alanlari 
                    WHERE bilgi_alani_id = " + Convert.ToInt32(dt_fav_bilgi_alan.Rows[i]["id"].ToString()) + " AND " +
                    "uye_id = " + duzeltecekUyeId + ";"
                );
                if (t_temp.Rows.Count > 0)
                {
                    uyeFavBilgiAlan.SetItemCheckState(i, CheckState.Checked);
                }

            }

        }
        //Form yuklendiğinda Çalışan metodu
        bool yeniUyeValidasyon()
        {
            List<ItemToValide> itemsToValidate = new List<ItemToValide>();
            itemsToValidate.Add(new ItemToValide(adInput.Text.Trim(), "required", "Ad", adErrLab));
            itemsToValidate.Add(new ItemToValide(soyadiInput.Text.Trim(), "required", "Soyad", soyadErrLab));
            itemsToValidate.Add(new ItemToValide(epostaInput.Text.Trim(), "email", "Eposta", emailErrLab));
            itemsToValidate.Add(new ItemToValide(telInput.Text.Trim(), "phone", "Tel", telErrLab));
            itemsToValidate.Add(new ItemToValide(sehirInput.Text.Trim(), "required", "Sehir", sehirErrLab));
            itemsToValidate.Add(new ItemToValide(sifreInput.Text.Trim(), "password", "Şifre", sifreErrLab));

            string group1 = Validation.check(itemsToValidate);

            string ulkeValid = Validation.checkComboBox(ulke, "ülke", ulkeErrLab);
            string meslekValid = Validation.checkComboBox(meslek, "Meslek", meslekErrLab);


            string uyeDilleriValid = Validation.checkCheckedList(uyeDilleri, "Üye Dilleri", uyeDilleriErrLab);
            string uyeFavBilgiAlanValid = Validation.checkCheckedList(uyeFavBilgiAlan, "üye Favori Bilgi Alanlari", uyerFavBilgiAlanlariErrLab);

            if (
                group1 == "valid" &&
                ulkeValid == "valid" &&
                meslekValid == "valid" &&
                uyeDilleriValid == "valid" &&
                uyeFavBilgiAlanValid == "valid"
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void EkleBut_Click(object sender, EventArgs e)
        {
            Item item;
            string ad = adInput.Text.Trim();
            string soyadi = soyadiInput.Text.Trim();
            string eposta = epostaInput.Text.Trim();
            string tel = telInput.Text.Trim();
            string sifre = sifreInput.Text.Trim();
            string sehir = sehirInput.Text.Trim();
            bool formIsValid = false;

            //Validation -------- (Form Kontrolü) ----------
            formIsValid = yeniUyeValidasyon();
            //--------------

            if (formIsValid)
            {

                Item selectedUlke = ulke.SelectedItem as Item;
                string ulke_id = Convert.ToString(selectedUlke.Id);

                Item selectedMeslek = meslek.SelectedItem as Item;
                string meslek_id = Convert.ToString(selectedMeslek.Id);

                try
                {
                    if (this.islemTuru == "ekle")
                    {
                        //Yeni Uye, uyeler tablosune eklenmesi
                        string uyeSqlInsertClause = " INSERT INTO uyeler (ad, soyadi, email, tel, meslek_id, ulke_id, sehir, sifre) ";
                        string uyeSqlValuesClause = " VALUES ('" + ad + "', '" + soyadi + "' , '" + eposta + "' , '" + tel + "' ," + meslek_id + " ," + ulke_id + ", '" + sehir + "' , '" + sifre + "' )";
                        string addUyeQuery = uyeSqlInsertClause + uyeSqlValuesClause;
                        Sorgular.ekle_guncele_sil(addUyeQuery);
                        //
                    }
                    else // gunceleme işlem için :
                    {
                        //Yeni Uye, uyeler tablosune eklenmesi
                        string uyeSqlEkleClause =
                            " UPDATE uyeler SET ad='" + ad + "', soyadi='" + soyadi + "', email='" + eposta +
                                "', tel='" + tel + "', meslek_id=" + meslek_id + ", ulke_id=" + ulke_id +
                                ", sehir='" + sehir + "', sifre='" + sifre + "'" +
                            "WHERE id=" + duzeltecekUyeId;
                        Sorgular.ekle_guncele_sil(uyeSqlEkleClause);
                        //
                    }


                    //Yeni Eklenmis uyenin idsi alalım. email field unique olduğu için onu kullanalım
                    DataTable eklenmisUye_id_DT = Sorgular.oku("SELECT id, ad FROM uyeler WHERE email='" + eposta + "'");
                    int eklenmisUye_id = Convert.ToInt32(eklenmisUye_id_DT.Rows[0]["id"].ToString());
                    //

                    if (this.islemTuru == "guncele")
                    {
                        //guncele durumunda ilk olarak uyenin dilleri ve FavBilgiAlanları siliyioruz
                        Sorgular.ekle_guncele_sil("DELETE from uyelerin_dilleri WHERE uye_id=" + this.duzeltecekUyeId);
                        Sorgular.ekle_guncele_sil("DELETE from uyelerin_favori_bilgi_alanlari WHERE uye_id=" + this.duzeltecekUyeId);
                    }

                    //uyenin dilleri ekleme
                    string uye_dil_sql_sorgu = "INSERT INTO uyelerin_dilleri (dil_id, uye_id) VALUES ";
                    for (int i = 0; i < uyeDilleri.CheckedItems.Count; i++)
                    {
                        item = uyeDilleri.CheckedItems[i] as Item;
                        uye_dil_sql_sorgu += (i == 0) ?
                            " (" + item.Id + ", " + eklenmisUye_id + ") " :
                            " , (" + item.Id + ", " + eklenmisUye_id + ") ";
                    }
                    Sorgular.ekle_guncele_sil(uye_dil_sql_sorgu);
                    //

                    //uyenin fav bilgi alanlari ekleme
                    string uye_fav_bilgi_sorgu = "INSERT INTO uyelerin_favori_bilgi_alanlari (uye_id, bilgi_alani_id) VALUES ";
                    for (int i = 0; i < uyeFavBilgiAlan.CheckedItems.Count; i++)
                    {
                        item = uyeFavBilgiAlan.CheckedItems[i] as Item;
                        uye_fav_bilgi_sorgu += (i == 0) ?
                            " (" + eklenmisUye_id + ", " + item.Id + ") " :
                            " , (" + eklenmisUye_id + ", " + item.Id + ") ";
                    }
                    Sorgular.ekle_guncele_sil(uye_fav_bilgi_sorgu);
                    //

                    //Başarili işlem mesaji
                    if (this.islemTuru == "ekle")
                    {
                        MessageBox.Show(
                            eklenmisUye_id_DT.Rows[0]["ad"] + " (Uye-" + eklenmisUye_id_DT.Rows[0]["id"] + ")" +
                            " Uyesi Sisteme Basarili bir şekilde eklenmiş!!"
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            eklenmisUye_id_DT.Rows[0]["ad"] + " (Uye-" + eklenmisUye_id_DT.Rows[0]["id"] + ")" +
                            " Uyenin Bilgileri Basarili bir şekilde güncelenmiş!!"
                        );
                    }

                    //Uyeleri Formu yeniliyoruz.
                    Program.anaForm.yeniFormYukle(new UyelerForm());
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: uyeEkle : " + ex);
                }

            }
        }

        private void uyeEklemeIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
    
    //Bu sınıf Comboboxlarda ve CheckedList items-leri hem bir "id" hem de gösterilecek 
    //bir metin tutturmak için oluşturuldu 
    public class Item
    {
        public string Text;
        public int Id;

        public override string ToString()
        {
            return this.Text;
        }
    }
}