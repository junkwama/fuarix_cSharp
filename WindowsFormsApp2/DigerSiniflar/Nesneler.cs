using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Nesneler
    {
    }

    public class Yonetici
    {
        public string kod;
        public string ad;
        public string soyad;
        public string eposta;
        public string tel;
        public string sifre;
  
        public Yonetici(string id, string ad, string soyad, string eposta, string tel, string sifre)
        {
            this.kod = "YNTC-00" + id;
            this.ad = ad;
            this.soyad = soyad;
            this.eposta = eposta;
            this.tel = tel;
            this.sifre = sifre;
        }
    }
}
