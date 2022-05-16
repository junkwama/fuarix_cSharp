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
    public partial class EtkinlikEkleDuzeltPopUp : Form
    {
        private string islemTuru = "ekle";
        private int duzeltecekEtkinlikId = 0;
        //Yeni Uye ekleme için : Yapıncı metodun Overload 1
        public EtkinlikEkleDuzeltPopUp()
        {

            InitializeComponent();
            etkinlikKonusmacilari.CheckOnClick = true;
            etkinlikYonBilgiAlan.CheckOnClick = true;
            Item temp;

            //bilgi_alanlari etkinlikKonusmacilari
            DataTable dt_etk_konusmaci = Sorgular.oku("SELECT id, CONCAT('Knsmc-',id) as Kod , CONCAT(ad, ' ', soyad) as ad FROM konusmacilar");
            for (int i = 0; i < dt_etk_konusmaci.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_etk_konusmaci.Rows[i]["ad"] + " " + dt_etk_konusmaci.Rows[i]["kod"],
                    Id = Convert.ToInt32(dt_etk_konusmaci.Rows[i]["id"].ToString())
                };
                etkinlikKonusmacilari.Items.Add(temp);
            }

            //bilgi_alanlari chekedlistBox
            DataTable dt_fav_bilgi_alan = Sorgular.oku("SELECT * FROM bilgi_alanlari");
            for (int i = 0; i < dt_fav_bilgi_alan.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_fav_bilgi_alan.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_fav_bilgi_alan.Rows[i]["id"].ToString())
                };
                etkinlikYonBilgiAlan.Items.Add(temp);
            }

            //etk türü combo box
            DataTable dt_etk_turleri = Sorgular.oku("SELECT * FROM etkinlik_turleri");
            for (int i = 0; i < dt_etk_turleri.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_etk_turleri.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_etk_turleri.Rows[i]["id"].ToString())
                };

                etkTuru.Items.Add(temp);
            }

            //diller select comboBox
            DataTable dt_diller = Sorgular.oku("SELECT * FROM diller");
            for (int i = 0; i < dt_diller.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_diller.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_diller.Rows[i]["id"].ToString())
                };
                etkDili.Items.Add(temp);
            }

            //Salonlar Analı select ComboBox
            DataTable dt_salon = Sorgular.oku("SELECT * FROM salonlar");
            for (int i = 0; i < dt_salon.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_salon.Rows[i]["salon_adi"].ToString(),
                    Id = Convert.ToInt32(dt_salon.Rows[i]["id"].ToString())
                };
                salonCB.Items.Add(temp);
            }

        }

        //Var olan Uye değitirmek : Yapıcı metodun Overload 2
        public EtkinlikEkleDuzeltPopUp(int duzeltecekEtkinlikId)
        {

            InitializeComponent();
            this.islemTuru = "guncele";
            this.duzeltecekEtkinlikId = duzeltecekEtkinlikId;
            this.EkleBut.Text = "Güncele";

            //Ad, soyad, email inputlara etkinlik değerleri veriyoruz-----------------
            DataTable etkinlikDT = Sorgular.oku(
                @"
                    SELECT 
                        etkinlik.id, etkinlik.baslik AS konu, etkinlik.tarih,
                        etkinlik.konuya_giris_metni AS giris, etkinlik.baslangic_saati, etkinlik.bitis_saati, etkinlik.arka_plan_linki, 
                        tur.id AS etk_turu_id, salon.salon_adi AS salon, salon.id AS salon_id,
                        dil.baslik AS etkinlik_dili, dil.id AS dil_id, tur.baslik AS etkinlik_turu
                    FROM 
                        etkinlikler etkinlik, diller dil, salonlar salon , etkinlik_turleri tur
                    WHERE 
                        etkinlik.salon_id=salon.id AND etkinlik.etkinlik_dili_id=dil.id AND etkinlik.etkinlik_turu_id=tur.id 
                    AND etkinlik.id=" + duzeltecekEtkinlikId + 
                "; "
            );

            DataTable arkaPlanDT = Sorgular.oku(
                "SELECT * FROM etkinlik_canli_baglantilari WHERE etkinlik_id=" + duzeltecekEtkinlikId 
            );

            if (arkaPlanDT.Rows.Count > 0) { 
                this.canliBaglati.Text = arkaPlanDT.Rows[0]["baglanti"].ToString(); 
            }

            DataRow etkinlik = etkinlikDT.Rows[0];
            this.baslik.Text = etkinlik["konu"].ToString();
            this.tarih.Value = Convert.ToDateTime(etkinlik["tarih"].ToString());
            this.etk_baslangicSaat.Value = Convert.ToDateTime(etkinlik["baslangic_saati"].ToString());
            this.bitisSaat.Value = Convert.ToDateTime(etkinlik["bitis_saati"].ToString());
            this.arkaPlan.Text = etkinlik["arka_plan_linki"].ToString();
            this.ozet.Text = etkinlik["giris"].ToString();

            //Ulke ve meslek
            etkinlikKonusmacilari.CheckOnClick = true;
            etkinlikYonBilgiAlan.CheckOnClick = true;
            Item temp;

            //etk türü combo box
            DataTable dt_etk_turleri = Sorgular.oku("SELECT * FROM etkinlik_turleri");
            for (int i = 0; i < dt_etk_turleri.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_etk_turleri.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_etk_turleri.Rows[i]["id"].ToString())
                };

                etkTuru.Items.Add(temp);
            }

            //diller select comboBox
            DataTable dt_diller = Sorgular.oku("SELECT * FROM diller");
            for (int i = 0; i < dt_diller.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_diller.Rows[i]["baslik"].ToString(),
                    Id = Convert.ToInt32(dt_diller.Rows[i]["id"].ToString())
                };
                etkDili.Items.Add(temp);
            }

            //Salonlar Analı select ComboBox
            DataTable dt_salon = Sorgular.oku("SELECT * FROM salonlar");
            for (int i = 0; i < dt_salon.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_salon.Rows[i]["salon_adi"].ToString(),
                    Id = Convert.ToInt32(dt_salon.Rows[i]["id"].ToString())
                };
                salonCB.Items.Add(temp);
            }
            //Ulke ve meslek Kombo boxlara etkinlik ulkesi ve mesleği seçiyoruz.

            etkTuru.SelectedIndex = Convert.ToInt32(etkinlik["etk_turu_id"].ToString()) - 1;
            etkDili.SelectedIndex = Convert.ToInt32(etkinlik["dil_id"].ToString()) - 1;
            salonCB.SelectedIndex = Convert.ToInt32(etkinlik["salon_id"].ToString()) - 1;

            //CheckedLiSTbOXlAR
            DataTable t_temp;
            DataTable dt_konusmacilar = Sorgular.oku("SELECT * FROM konusmacilar");
            for (int i = 0; i < dt_konusmacilar.Rows.Count; i++)
            {
                temp = new Item
                {
                    Text = dt_konusmacilar.Rows[i]["ad"] + " " + dt_konusmacilar.Rows[i]["soyad"],
                    Id = Convert.ToInt32(dt_konusmacilar.Rows[i]["id"].ToString())
                };

                //Önce bütün Itemsleri ekliyoruz
                etkinlikKonusmacilari.Items.Add(temp);

                t_temp = Sorgular.oku(
                    @"SELECT * FROM etkinliklerin_konusmacilari 
                        WHERE konusmaci_id = " + Convert.ToInt32(dt_konusmacilar.Rows[i]["id"].ToString()) + " AND " +
                    "etkinlik_id = " + duzeltecekEtkinlikId + ";"
                );
                if (t_temp.Rows.Count > 0)
                {
                    etkinlikKonusmacilari.SetItemCheckState(i, CheckState.Checked);
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
                etkinlikYonBilgiAlan.Items.Add(temp);

                t_temp = Sorgular.oku(
                    @"SELECT * FROM etkinliklerin_yonelik_olduklari_bilgi_alanlari 
                        WHERE bilgi_alani_id = " + Convert.ToInt32(dt_fav_bilgi_alan.Rows[i]["id"].ToString()) + " AND " +
                    "etkinlik_id = " + this.duzeltecekEtkinlikId + ";"
                );
                if (t_temp.Rows.Count > 0)
                {
                    etkinlikYonBilgiAlan.SetItemCheckState(i, CheckState.Checked);
                }

            }

        }
        //Form yuklendiğinda Çalışan metodu
        bool yeniUyeValidasyon()
        {
            List<ItemToValide> itemsToValidate = new List<ItemToValide>();
            itemsToValidate.Add(new ItemToValide(baslik.Text.Trim(), "required", "Konu Başlığı", baslikErrLab));
            itemsToValidate.Add(new ItemToValide(canliBaglati.Text.Trim(), "required", "Canli Link", canliBaglatiErrLab));
            itemsToValidate.Add(new ItemToValide(arkaPlan.Text.Trim(), "required", "Arka plan Bg", arkaPlanLinkErrLab));
            itemsToValidate.Add(new ItemToValide(ozet.Text.Trim(), "required", "Özet", ozetErrLab));
            string group1 = Validation.check(itemsToValidate);

            string etkTuruValid = Validation.checkComboBox(etkTuru, "Etkinlik Türü", etkTuruErrLab);
            string etkDiliValid = Validation.checkComboBox(etkDili, "Etkinlik Dili", etkDiliErrLab);
            string salonValid = Validation.checkComboBox(salonCB, "Salon", salonCBErrLab);

            string etkinlikKonusmacilariValid = Validation.checkCheckedList(etkinlikKonusmacilari, "Etkinlik Konusmacilari", etkinlikKonusmacilariErrLab);
            string etkinlikYonBilgiAlanValid = Validation.checkCheckedList(etkinlikYonBilgiAlan, "Etkinlik Yönelik Bilgi Alanlari", etkYonBilgiAlanlariErrLab);

            if (
                group1 == "valid" &&
                etkTuruValid == "valid" &&
                etkDiliValid == "valid" &&
                salonValid == "valid" &&
                etkinlikKonusmacilariValid == "valid" &&
                etkinlikYonBilgiAlanValid == "valid"
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void EkleBut_Click_1(object sender, EventArgs e)
        {
            Item item;
            string baslikValue = baslik.Text.Trim();
            string canliBaglatiValue = canliBaglati.Text.Trim();
            string arkaPlanValue = arkaPlan.Text.Trim();
            string ozetValue = ozet.Text.Trim();
            DateTime tarihValue = tarih.Value;
            

            DateTime banlangicSaatValue = etk_baslangicSaat.Value;
            DateTime bitisSaatValue = bitisSaat.Value;

            bool formIsValid = false;

            //Validation -------- (Form Kontrolü) ----------
            formIsValid = yeniUyeValidasyon();
            //--------------

            if (formIsValid)
            {

                Item selectedEtkTuru = etkTuru.SelectedItem as Item;
                string tur_id = Convert.ToString(selectedEtkTuru.Id);

                Item selectedEtkDili = etkDili.SelectedItem as Item;
                string dil_id = Convert.ToString(selectedEtkDili.Id);

                Item selectedSalonCB = salonCB.SelectedItem as Item;
                string salonCB_id = Convert.ToString(selectedSalonCB.Id);

                try
                {
                    if (this.islemTuru == "ekle")
                    {
                        //Yeni Uye, uyeler tablosune eklenmesi
                        try
                        {
                            string etkinlikSqlInsertClause = @"INSERT INTO  etkinlikler (
                                baslik, tarih, konuya_giris_metni, baslangic_saati, bitis_saati, arka_plan_linki, 
                                salon_id, etkinlik_dili_id, etkinlik_turu_id
			                ) ";

                            string etkinlikSqlValuesClause = "VALUES('" + baslikValue.Replace("'", "\\'") + "','" + tarihValue.Date.ToString("yyyy-MM-dd") + "','" + ozetValue.Replace("'", "\\'") + "','" + banlangicSaatValue.ToString("HH:mm:ss") + "','" + bitisSaatValue.ToString("HH:mm:ss") + "','" + arkaPlanValue + "'," + salonCB_id + "," + dil_id + "," + tur_id + ");";
                            //MessageBox.Show(etkinlikSqlInsertClause + etkinlikSqlValuesClause);
                            Sorgular.ekle_guncele_sil(etkinlikSqlInsertClause + etkinlikSqlValuesClause);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata oluştu : " + ex.Message);
                        }
                        //
                    }
                    else // gunceleme işlem için :
                    {
                        //Yeni etkinlik, etkinlikler tablosuna eklenmesi
                        try
                        {
                            
                            string etkinlikSqlDuzeltClause =
                            "UPDATE etkinlikler SET baslik='" + baslikValue.Replace("'", "\\'") + "', tarih='" + tarihValue.Date.ToString("yyyy-MM-dd") + "', konuya_giris_metni='" + ozetValue.Replace("'", "\\'") + "', baslangic_saati='" + banlangicSaatValue.ToString("HH:mm:ss") + "', bitis_saati='" + bitisSaatValue.ToString("HH:mm:ss") + "', arka_plan_linki='" + arkaPlanValue + "'," +
                            "salon_id =" + salonCB_id + ", etkinlik_dili_id=" + dil_id + ", etkinlik_turu_id=" + tur_id + " WHERE id=" + duzeltecekEtkinlikId;

                            //MessageBox.Show(etkinlikSqlDuzeltClause);
                            Sorgular.ekle_guncele_sil(etkinlikSqlDuzeltClause);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata Oluştu : " + ex.Message);
                        }
                        //
                    }


                    //Yeni Eklenmis uyenin idsi alalım. email field unique olduğu için onu kullanalım
                    DataTable eklenmisEtkinlik_id_DT = Sorgular.oku("SELECT id, baslik FROM etkinlikler WHERE baslik='" + baslikValue + "' ORDER BY id DESC");
                    int eklenmisEtkinlik_id = Convert.ToInt32(eklenmisEtkinlik_id_DT.Rows[0]["id"].ToString());
                    //

                    if (this.islemTuru == "guncele")
                    {
                        //guncele durumunda ilk olarak uyenin dilleri ve FavBilgiAlanları siliyioruz
                        try
                        {
                            Sorgular.ekle_guncele_sil("DELETE from etkinliklerin_konusmacilari WHERE etkinlik_id=" + this.duzeltecekEtkinlikId);
                            Sorgular.ekle_guncele_sil("DELETE from etkinlik_canli_baglantilari WHERE etkinlik_id=" + this.duzeltecekEtkinlikId);
                            Sorgular.ekle_guncele_sil("DELETE from etkinliklerin_yonelik_olduklari_bilgi_alanlari WHERE etkinlik_id=" + this.duzeltecekEtkinlikId);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata Oluştu : " + ex.Message);
                        }
                    }
                    
                    //etkinlik konusmacilari
                    string konusmaci_dil_sql_sorgu = "INSERT INTO etkinliklerin_konusmacilari (konusmaci_id, etkinlik_id) VALUES ";
                    for (int i = 0; i < etkinlikKonusmacilari.CheckedItems.Count; i++)
                    {
                        item = etkinlikKonusmacilari.CheckedItems[i] as Item;
                        konusmaci_dil_sql_sorgu += (i == 0) ?
                            " (" + item.Id + ", " + eklenmisEtkinlik_id + ") " :
                            " , (" + item.Id + ", " + eklenmisEtkinlik_id + ") ";
                    }
                    //MessageBox.Show(konusmaci_dil_sql_sorgu);
                    Sorgular.ekle_guncele_sil(konusmaci_dil_sql_sorgu);
                    //


                    //etkinlik fav bilgi alanlari ekleme
                    string etkinlik_fav_bilgi_sorgu = "INSERT INTO etkinliklerin_yonelik_olduklari_bilgi_alanlari (etkinlik_id, bilgi_alani_id) VALUES ";
                    for (int i = 0; i < etkinlikYonBilgiAlan.CheckedItems.Count; i++)
                    {
                        item = etkinlikYonBilgiAlan.CheckedItems[i] as Item;
                        etkinlik_fav_bilgi_sorgu += (i == 0) ?
                            " (" + eklenmisEtkinlik_id + ", " + item.Id + ") " :
                            " , (" + eklenmisEtkinlik_id + ", " + item.Id + ") ";
                    }
                    //MessageBox.Show(etkinlik_fav_bilgi_sorgu);
                    Sorgular.ekle_guncele_sil(etkinlik_fav_bilgi_sorgu);
                    //

                    //Canli bağlatilari
                    if (canliBaglatiValue.Length > 0)
                    {
                        Sorgular.ekle_guncele_sil("INSERT INTO etkinlik_canli_baglantilari ( etkinlik_id, baglanti ) VALUES( " + eklenmisEtkinlik_id + ", '" + canliBaglatiValue + "' )");
                        //MessageBox.Show("INSERT INTO etkinlik_canli_baglantilari ( etkinlik_id, baglanti ) VALUES( " + eklenmisEtkinlik_id + ", " + canliBaglatiValue + " )");
                    }

                    //Başarili işlem mesaji
                    if (this.islemTuru == "ekle")
                    {
                        MessageBox.Show(
                            eklenmisEtkinlik_id_DT.Rows[0]["baslik"] + " (Etklk-" + eklenmisEtkinlik_id_DT.Rows[0]["id"] + ")" +
                            " Etkinlik Sisteme Basarili bir şekilde eklenmiş!!"
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            eklenmisEtkinlik_id_DT.Rows[0]["baslik"] + " (Etklk-" + eklenmisEtkinlik_id_DT.Rows[0]["id"] + ")" +
                            " Etkinlik Bilgileri Basarili bir şekilde güncelenmiş!!"
                        );
                    }

                    //Uyeleri Formu yeniliyoruz.
                    Program.anaForm.yeniFormYukle(new EtkinliklerForm());
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: uyeEkle : " + ex);
                }

            }
        }

        private void İptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
