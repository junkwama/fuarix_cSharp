using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    
    public class KpanelVerileri
    {
        public int etkinlikSayisi;
        public int uyeSayisi;
        public int tmmEtkinlikSayisi;
        public int konusmaciSayisi;
        public int yoneticiSayisi;
        public int biletlerSayisi;
        public int mevcutEtkSayi;


        public List<KeyValuePair<string, int>> enIyiKonusmacilar;
        public List<KeyValuePair<string, int>> etkinlikTuruVeBilet;
        public List<KeyValuePair<string, int>> etkinlikTuruVeEtkinlik;
        public List<KeyValuePair<string, int>> enIyiEtkinlikler;

        public DataTable oneCikenEkinlikler;


        //Yahıcı metodu
        public KpanelVerileri()
        {
            this.veriTabanindaAlma();
        }

        //privates
        public void veriTabanindaAlma()
        {
            //Sıfırlama (İnitialisation)
            this.enIyiKonusmacilar = new List<KeyValuePair<string, int>>();
            this.etkinlikTuruVeBilet = new List<KeyValuePair<string, int>>();
            this.etkinlikTuruVeEtkinlik = new List<KeyValuePair<string, int>>();
            this.enIyiEtkinlikler = new List<KeyValuePair<string, int>>();

            this.oneCikenEkinlikler = new DataTable();

            //---------------

            //İstatlar Grup 1 
            DataTable istata1_DT = Sorgular.oku(

                @"SELECT * FROM (
                    (SELECT COUNT(id) AS etkinlikSayisi FROM etkinlikler) AS etkinlikSayisi,
                    (SELECT COUNT(id) AS konusmaciSayisi FROM konusmacilar) AS konusmaciSayisi,
                    (SELECT COUNT(id) AS uyeSayisi FROM uyeler) AS uyeSayisi,
                    (SELECT COUNT(id) AS katilanSayisi FROM biletler) AS katilanSayisi,
                    (SELECT COUNT(id) AS yoneticiSayisi FROM yoneticiler) AS yoneticiSayisi,
                    (SELECT COUNT(id) AS gerceklesmisEtkinlikSayisi FROM etkinlikler WHERE tarih < CURRENT_DATE()) AS gerceklesmisEtkinlikSayisi,
                    (SELECT COUNT(id) AS mevcutEtkinlikSayisi FROM etkinlikler WHERE (tarih > CURRENT_DATE()) OR (tarih = CURRENT_DATE()) ) AS mevcutEtkinlikSayisi
                )"
            );
           
            DataRow istat1 = istata1_DT.Rows[0];
            this.etkinlikSayisi = Convert.ToInt32(istat1["etkinlikSayisi"].ToString());
            this.konusmaciSayisi = Convert.ToInt32(istat1["konusmaciSayisi"].ToString());
            this.uyeSayisi = Convert.ToInt32(istat1["uyeSayisi"].ToString());
            this.biletlerSayisi = Convert.ToInt32(istat1["katilanSayisi"].ToString());
            this.yoneticiSayisi = Convert.ToInt32(istat1["yoneticiSayisi"].ToString());
            this.tmmEtkinlikSayisi = Convert.ToInt32(istat1["gerceklesmisEtkinlikSayisi"].ToString());
            this.mevcutEtkSayi = Convert.ToInt32(istat1["mevcutEtkinlikSayisi"].ToString());
            //---------------------


            //Tarih yaklaşan Etkinlikler
            this.oneCikenEkinlikler = Sorgular.oku(
                @"SELECT 
	                concat('Etklk - ', etkinlikler.id) AS Kod, etkinlikler.baslik AS Konu, 
                    etkinlik_turleri.baslik AS 'Etkinlik Türü', tarih as Tarih, baslangic_saati AS Saat,
                    TIMEDIFF(bitis_saati, baslangic_saati) AS Sure
                FROM etkinlikler, etkinlik_turleri
                WHERE etkinlikler.etkinlik_turu_id = etkinlik_turleri.id AND tarih >= curdate()
                ORDER BY tarih
                LIMIT 10"
            );
            //----------------



            //Her Etkinlik için türü için kaç bilet satın alındığı sayıyor
            //Etkinlik Türüne göre toplam Bilet Sayısı
            DataTable istat2_DT = Sorgular.oku(

                @"(SELECT
                    etkinlik_turleri.baslik as etkinlikTuru, 0 as toplamBilet
                FROM etkinlik_turleri
                
                WHERE baslik NOT IN
                    (SELECT
                        etkinlik_turleri.baslik as etkinlikTuru
                    FROM biletler, etkinlikler, etkinlik_turleri
                    WHERE biletler.etkinlik_id = etkinlikler.id AND etkinlikler.etkinlik_turu_id = etkinlik_turleri.id
                    GROUP BY etkinlik_turleri.baslik
                    )
                )

                    UNION

                (SELECT
                    etkinlik_turleri.baslik as etkinlikTuru, COUNT(*) as toplamBilet
                FROM biletler, etkinlikler, etkinlik_turleri
                WHERE biletler.etkinlik_id = etkinlikler.id AND etkinlikler.etkinlik_turu_id = etkinlik_turleri.id
                GROUP BY etkinlik_turleri.baslik
                )"

            );

            for (int i = 0; i< istat2_DT.Rows.Count; i++)
            {
                this.etkinlikTuruVeBilet.Add(
                   new KeyValuePair<string, int>(
                       istat2_DT.Rows[i]["etkinlikTuru"].ToString(), 
                       Convert.ToInt32(istat2_DT.Rows[i]["toplamBilet"].ToString())
                   )
                ); 
            }


            //----------


            //Etiklikler kendi türlerine göre gruplayıp sayıyor
            //Etkinlik Türüne göre Etkinlik Sayısı
            DataTable istat3_DT = Sorgular.oku(
                @"(SELECT etkinlik_turleri.baslik as etkinlikTuru, 0 as toplamBilet FROM etkinlik_turleri
                WHERE baslik NOT IN
                    (SELECT etkinlik_turleri.baslik as etkinlikTuru FROM etkinlikler, etkinlik_turleri
                    WHERE etkinlikler.etkinlik_turu_id = etkinlik_turleri.id GROUP BY etkinlik_turleri.baslik )
                )

                    UNION

                (SELECT etkinlik_turleri.baslik as etkinlikTuru, COUNT(*) as toplamBilet FROM etkinlikler, etkinlik_turleri
                    WHERE etkinlikler.etkinlik_turu_id = etkinlik_turleri.id GROUP BY etkinlik_turleri.baslik )"
            );

            for (int i = 0; i < istat3_DT.Rows.Count; i++)
            {
                this.etkinlikTuruVeEtkinlik.Add(
                   new KeyValuePair<string, int>(
                       istat3_DT.Rows[i]["etkinlikTuru"].ToString(),
                       Convert.ToInt32(istat3_DT.Rows[i]["toplamBilet"].ToString())
                   )
                );
            }
            ///------------------------


            //enIyiEtkinlik (Her etkinlik için bilet Sayısı)
            DataTable etkinlikVeBilet_DT = Sorgular.oku(

                @"SELECT etkinlikler.baslik as etkinlikBasligi, COUNT(*) as toplamBilet
                FROM etkinlikler, biletler
                WHERE etkinlikler.id = biletler.etkinlik_id
                GROUP BY etkinlikler.baslik"

            );

            for (int i = 0; i < etkinlikVeBilet_DT.Rows.Count; i++)
            {
                this.enIyiEtkinlikler.Add(
                   new KeyValuePair<string, int>(
                       etkinlikVeBilet_DT.Rows[i]["etkinlikBasligi"].ToString(),
                       Convert.ToInt32(etkinlikVeBilet_DT.Rows[i]["toplamBilet"].ToString())
                   )
                );
            }


            //enIyiEtkinlik (Her etkinlik için bilet Sayısı)
            DataTable enIyiKonusmacilar_DT = Sorgular.oku(

                @"SELECT concat(konusmacilar.ad, ' ', konusmacilar.soyad ) as konusmaci, COUNT(*) as toplamEtkinlik
                FROM konusmacilar, etkinliklerin_konusmacilari etk_k
                WHERE konusmacilar.id = etk_k.konusmaci_id
                GROUP BY konusmaci"

            );

            for (int i = 0; i < enIyiKonusmacilar_DT.Rows.Count; i++)
            {
                this.enIyiKonusmacilar.Add(
                   new KeyValuePair<string, int>(
                       enIyiKonusmacilar_DT.Rows[i]["konusmaci"].ToString(),
                       Convert.ToInt32(enIyiKonusmacilar_DT.Rows[i]["toplamEtkinlik"].ToString())
                   )
                );
            }





        }















    }
}
