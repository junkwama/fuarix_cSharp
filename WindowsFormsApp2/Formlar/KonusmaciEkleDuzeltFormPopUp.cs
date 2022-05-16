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
    public partial class KonusmaciEkleDuzeltFormPopUp : Form
    {
        private string islemTuru = "ekle";
        private int duzelteceKonusmaciId = 0;
        //Yeni Uye ekleme için : Yapıncı metodun Overload 1
        public KonusmaciEkleDuzeltFormPopUp()
        {

            InitializeComponent();
            konusmaciDilleri.CheckOnClick = true;
            konusmaciFavBilgiAlan.CheckOnClick = true;
            Item temp;

            DataTable dt_diller = Sorgular.oku("SELECT * FROM diller");
            for (int i = 0; i < dt_diller.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_diller.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_diller.Rows[i]["id"].ToString())
                };
                konusmaciDilleri.Items.Add(temp);
            }

            DataTable dt_fav_bilgi_alan = Sorgular.oku("SELECT * FROM bilgi_alanlari");
            for (int i = 0; i < dt_fav_bilgi_alan.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_fav_bilgi_alan.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_fav_bilgi_alan.Rows[i]["id"].ToString())
                };
                konusmaciFavBilgiAlan.Items.Add(temp);
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

            //meslek select comboBox
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

            //Ana Bilgi Analı select ComboBox
            DataTable dt_ana_bilgi_alanlari = Sorgular.oku("SELECT * FROM bilgi_alanlari");
            for (int i = 0; i < dt_ana_bilgi_alanlari.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_ana_bilgi_alanlari.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_ana_bilgi_alanlari.Rows[i]["id"].ToString())
                };
                anaBilgiAlaniCB.Items.Add(temp);
            }

        }

        //Var olan Uye değitirmek : Yapıcı metodun Overload 2
        public KonusmaciEkleDuzeltFormPopUp(int duzeltecekKonusmaciId)
        {

            InitializeComponent();
            this.islemTuru = "guncele";
            this.duzelteceKonusmaciId = duzeltecekKonusmaciId;
            this.EkleBut.Text = "Güncele";

            //Ad, soyad, email inputlara konusmaci değerleri veriyoruz-----------------
            DataTable konusmaciDT = Sorgular.oku(
                @"
                    SELECT
                        konusmaci.id, ad,soyad soyadi, email AS eposta, tel AS telefon , internet_sitesi as internetSitesi, kurum, kurum_gorevi AS kurumGorevi, ana_bilgi_alani_id,
                        hakkinda, sehir, sifre, profil, bilgiAlani.baslik AS anaBilgiAlani, meslek.baslik AS meslek, meslek.id meslekId , ulke.isim AS ulke, ulke.id ulkeId
                    FROM
                        konusmacilar konusmaci, ulkeler ulke, bilgi_alanlari bilgiAlani, meslekler meslek
                    WHERE
                        konusmaci.ana_bilgi_alani_id=bilgiAlani.id AND konusmaci.meslek_id=meslek.id 
                        AND konusmaci.ulke_id=ulke.id AND konusmaci.id=" + duzeltecekKonusmaciId +
                ";"
            );

            DataRow konusmaci = konusmaciDT.Rows[0];
            this.adInput.Text = konusmaci["ad"].ToString();
            this.soyadiInput.Text = konusmaci["soyadi"].ToString();
            this.epostaInput.Text = konusmaci["eposta"].ToString();
            this.telInput.Text = konusmaci["telefon"].ToString();
            this.sehirInput.Text = konusmaci["sehir"].ToString();
            this.sifreInput.Text = konusmaci["sifre"].ToString();
            this.site.Text = konusmaci["internetSitesi"].ToString();
            this.kurum.Text = konusmaci["kurum"].ToString();
            this.gorev.Text = konusmaci["kurumGorevi"].ToString();
            this.hakkinda.Text = konusmaci["hakkinda"].ToString();

            //Ulke ve meslek
            konusmaciDilleri.CheckOnClick = true;
            konusmaciFavBilgiAlan.CheckOnClick = true;
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

            DataTable dt_ana_bilgi_alani = Sorgular.oku("SELECT * FROM bilgi_alanlari");
            for (int i = 0; i < dt_ana_bilgi_alani.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_ana_bilgi_alani.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_ana_bilgi_alani.Rows[i]["id"].ToString())
                };
                anaBilgiAlaniCB.Items.Add(temp);
            }
            //Ulke ve meslek Kombo boxlara konusmaci ulkesi ve mesleği seçiyoruz.

            ulke.SelectedIndex = Convert.ToInt32(konusmaci["ulkeId"].ToString()) - 1;
            meslek.SelectedIndex = Convert.ToInt32(konusmaci["meslekId"].ToString()) - 1;
            anaBilgiAlaniCB.SelectedIndex = Convert.ToInt32(konusmaci["ana_bilgi_alani_id"].ToString()) - 1;

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
                konusmaciDilleri.Items.Add(temp);

                t_temp = Sorgular.oku(
                    @"SELECT * FROM konusmaci_dilleri 
                        WHERE dil_id = " + Convert.ToInt32(dt_diller.Rows[i]["id"].ToString()) + " AND " +
                    "konusmaci_id = " + duzeltecekKonusmaciId + ";"
                );
                if (t_temp.Rows.Count > 0)
                {
                    konusmaciDilleri.SetItemCheckState(i, CheckState.Checked);
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
                konusmaciFavBilgiAlan.Items.Add(temp);

                t_temp = Sorgular.oku(
                    @"SELECT * FROM konusmaciler_diger_bilgi_alanlar 
                        WHERE bilgi_alani_id = " + Convert.ToInt32(dt_fav_bilgi_alan.Rows[i]["id"].ToString()) + " AND " +
                    "konusmaci_id = " + duzeltecekKonusmaciId + ";"
                );
                if (t_temp.Rows.Count > 0)
                {
                    konusmaciFavBilgiAlan.SetItemCheckState(i, CheckState.Checked);
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

            itemsToValidate.Add(new ItemToValide(kurum.Text.Trim(), "required", "Kurum", kurumErrLab));
            itemsToValidate.Add(new ItemToValide(gorev.Text.Trim(), "required", "Görev", gorevErrLab));
            itemsToValidate.Add(new ItemToValide(site.Text.Trim(), "required", "İnternet Sitesi", siteErrLab));
            itemsToValidate.Add(new ItemToValide(hakkinda.Text.Trim(), "required", "Hakkında", hakkindaErrLab));


            string group1 = Validation.check(itemsToValidate);

            string ulkeValid = Validation.checkComboBox(ulke, "ülke", ulkeErrLab);
            string meslekValid = Validation.checkComboBox(meslek, "Meslek", meslekErrLab);
            string anaBilgiAlaniValid = Validation.checkComboBox(meslek, "Ana Bilgi Alanı", anaBilgiAlaniErrLab);


            string uyeDilleriValid = Validation.checkCheckedList(konusmaciDilleri, "Üye Dilleri", uyeDilleriErrLab);
            string uyeFavBilgiAlanValid = Validation.checkCheckedList(konusmaciFavBilgiAlan, "üye Favori Bilgi Alanlari", uyerFavBilgiAlanlariErrLab);

            if (
                group1 == "valid" &&
                ulkeValid == "valid" &&
                meslekValid == "valid" &&
                uyeDilleriValid == "valid" &&
                uyeFavBilgiAlanValid == "valid" &&
                anaBilgiAlaniValid == "valid"
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
            string kurumValue = kurum.Text.Trim();
            string gorevValue = gorev.Text.Trim();
            string hakkindaValue = hakkinda.Text.Trim();
            string siteValue = site.Text.Trim();
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

                Item selectedAnaBilgiAlani = anaBilgiAlaniCB.SelectedItem as Item;
                string anaBilgiAlani_id = Convert.ToString(selectedAnaBilgiAlani.Id);

                try
                {
                    if (this.islemTuru == "ekle")
                    {
                        //Yeni Uye, uyeler tablosune eklenmesi
                        try
                        {
                            string konusmaciSqlInsertClause = "INSERT INTO konusmacilar (ad, soyad, email, tel, internet_sitesi, kurum, kurum_gorevi, hakkinda, ana_bilgi_alani_id, meslek_id, ulke_id, sehir, sifre) ";
                            string konusmaciSqlValuesClause = "VALUES('" + ad + "','" + soyadi + "','" + eposta + "','" + tel + "','" + siteValue + "','" + kurumValue + "','" + gorevValue + "',\"" + hakkindaValue + "\"," + anaBilgiAlani_id + "," + meslek_id + "," + ulke_id + ",'" + sehir + "','" + sifre + "');";
                            Sorgular.ekle_guncele_sil(konusmaciSqlInsertClause + konusmaciSqlValuesClause);
                        }catch(Exception ex)
                        {
                            MessageBox.Show("Hata oluştu : " + ex.Message);
                        }
                        //
                    }
                    else // gunceleme işlem için :
                    {
                        //Yeni Uye, uyeler tablosune eklenmesi
                        try
                        {
                            string konusmaciSqlDuzeltClause =
                            "UPDATE konusmacilar SET ad='" + ad + "', soyad='" + soyadi + "', email='" + eposta +
                            "', tel='" + tel + "', internet_sitesi='" + siteValue + "', kurum='" + kurumValue + "', " +
                            "kurum_gorevi='" + gorevValue + "', hakkinda=\"" + hakkindaValue + "\", ana_bilgi_alani_id=" + anaBilgiAlani_id +
                            ", meslek_id=" + meslek_id + ", ulke_id=" + ulke_id + ", sehir='" + sehir + "', sifre='" + sifre + "' WHERE id=" + duzelteceKonusmaciId;
                            //MessageBox.Show(konusmaciSqlDuzeltClause);
                            Sorgular.ekle_guncele_sil(konusmaciSqlDuzeltClause);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata Oluştu : " + ex.Message);
                        }
                        //
                    }


                    //Yeni Eklenmis uyenin idsi alalım. email field unique olduğu için onu kullanalım
                    DataTable eklenmisKonusmaci_id_DT = Sorgular.oku("SELECT id, ad FROM konusmacilar WHERE email='" + eposta + "'");
                    int eklenmisKonusmaci_id = Convert.ToInt32(eklenmisKonusmaci_id_DT.Rows[0]["id"].ToString());
                    //

                    if (this.islemTuru == "guncele")
                    {
                        //guncele durumunda ilk olarak uyenin dilleri ve FavBilgiAlanları siliyioruz
                        try
                        {
                            Sorgular.ekle_guncele_sil("DELETE from konusmaci_dilleri WHERE konusmaci_id=" + this.duzelteceKonusmaciId);
                            Sorgular.ekle_guncele_sil("DELETE from konusmaciler_diger_bilgi_alanlar WHERE konusmaci_id=" + this.duzelteceKonusmaciId);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata Oluştu : " + ex.Message);
                        }
                    }

                    //uyenin dilleri ekleme
                    string konusmaci_dil_sql_sorgu = "INSERT INTO konusmaci_dilleri (dil_id, konusmaci_id) VALUES ";
                    for (int i = 0; i < konusmaciDilleri.CheckedItems.Count; i++)
                    {
                        item = konusmaciDilleri.CheckedItems[i] as Item;
                        konusmaci_dil_sql_sorgu += (i == 0) ?
                            " (" + item.Id + ", " + eklenmisKonusmaci_id + ") " :
                            " , (" + item.Id + ", " + eklenmisKonusmaci_id + ") ";
                    }
                    Sorgular.ekle_guncele_sil(konusmaci_dil_sql_sorgu);
                    //

                    //uyenin fav bilgi alanlari ekleme
                    string konusmaci_fav_bilgi_sorgu = "INSERT INTO konusmaciler_diger_bilgi_alanlar (konusmaci_id, bilgi_alani_id) VALUES ";
                    for (int i = 0; i < konusmaciFavBilgiAlan.CheckedItems.Count; i++)
                    {
                        item = konusmaciFavBilgiAlan.CheckedItems[i] as Item;
                        konusmaci_fav_bilgi_sorgu += (i == 0) ?
                            " (" + eklenmisKonusmaci_id + ", " + item.Id + ") " :
                            " , (" + eklenmisKonusmaci_id + ", " + item.Id + ") ";
                    }
                    Sorgular.ekle_guncele_sil(konusmaci_fav_bilgi_sorgu);
                    //

                    //Başarili işlem mesaji
                    if (this.islemTuru == "ekle")
                    {
                        MessageBox.Show(
                            eklenmisKonusmaci_id_DT.Rows[0]["ad"] + " (Knmc-" + eklenmisKonusmaci_id_DT.Rows[0]["id"] + ")" +
                            " Konuşmacı Sisteme Basarili bir şekilde eklenmiş!!"
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            eklenmisKonusmaci_id_DT.Rows[0]["ad"] + " (Knmc-" + eklenmisKonusmaci_id_DT.Rows[0]["id"] + ")" +
                            " Konuşmacının Bilgileri Basarili bir şekilde güncelenmiş!!"
                        );
                    }

                    //Uyeleri Formu yeniliyoruz.
                    Program.anaForm.yeniFormYukle(new KonusmacilarForm());
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

}
