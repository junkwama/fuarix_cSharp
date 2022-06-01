# fuarix_cSharp
<img src="https://github.com/Judy-Nkwama/fuarix_cSharp/blob/main/Screenshot%20(158).png" /></br>
<h2>FUARIX FUAR / KONFERANS SALONU OTOMASYONU</h2>

Otomasyonumuz; sempozyum, konferans, seminer, kongre ve forum gibi, katılımcıların katılması dahilinde gerçekleşen etkinliklere göz atma, haklarında bilgi sahibi olma ve programa üye olunma dahilinde istenilen etkinliğe bilet alınmasını sağlamaktadır.</br>

<h2>Sisteme Giriş</h2></br>

Programa ilk bakışta bir Sisteme Giriş formuyla karşılaşıyoruz. Veritabanına kayıtlı olan üyeler ve yöneticilerin e-posta ve şifre bilgilerini girmesi dahilinde bu form ile fuar sistemine giriş sağlanmaktadır. E-posta ve Şifre için verilen input kısımlarına girilen bilgiler, veritabanımızın 'uyeler' veya 'yoneticiler' tablolarındaki email ve sifre alanlarındaki bilgiler ile eşleşiyorsa sisteme giriş sağlanmaktadır. Aksi takdirde 'Hesap bulunamadı' hatası ile sisteme giriş sağlanamamaktadır. Bahsettiğimiz verilere, formun .cs dosyasına eklediğimiz Sorgular sınıfından çağrılan oku metoduna gönderdiğimiz sql cümleleri ile erişmekteyiz.</br>

<h2>Kontrol Paneli</h2></br>

Sisteme giriş yaptığımızda karşımıza çıkan form Kontrol Panelimiz. Burada yönetici email ve şifresi ile giriş yaptığımdan, sisteme kayıtlı üye sayısını, alınan bilet sayısını, etkinliklerde yer alacak olan konuşmacı sayısını ve yönetici sayısını görebilmekteyiz. Aşağısında gördüğümüz Öne çıkan etkinlikler, yakın zamanda gerçekleşecek etkinlikleri göstermektedir. Bahsettiğimiz verilere, formun .cs dosyasına eklediğimiz Sorgular sınıfından çağrılan oku metoduna gönderdiğimiz sql cümleleri ile erişmekteyiz.</br>
Bir aşağıda en başta belirttiğim etkinlik türlerinden kaç tanesinin aktif olduğunu gösteren bir grafik yer alıyor. Birazdan göstereceğimiz etkinlikler kısmında, eklenecek yeni bir etkinliğe göre veritabanındaki etkinlik türü ve sayısının eşleşmesi halinde yeni etkinlik de grafiğe sayı olarak eklenecektir. 
Yandaki daire grafikte ise etkinliklere göre satın alınan bilet sayısı gösterilmektedir. Biletler sayfasında göstereceğimiz üzere, yeni bir bilet alındığında da veritabanındaki bilet sayısı değişeceğinden, güncel bilet sayılarına göre grafik yeniden düzenlenecektir.</br>
En altta gördüğümüz etkinlik sayısı ve mevcut etklinlikten bahsettik. Geçmiş etkinlikler de burada gösterilmektedir. Mevcut etkinlik sayısı ve geçmiş etkinlikler, güncel tarihe göre belirlenmekte olup, etkinliğin tarihi geçtiği anda geçmiş etkinlikler kategorisine geçmektedir.</br>

<h2>Etkinlikler</h2></br>

Etkinlikler sayfasına göz attığımızda, önceden eklediğimiz örnek etkinlikleri görmekteyiz. Her bir etkinliğe tıklandığında detayları gözükmektedir. Bir tanesine bakalım. (Etkinliğe tıkla) Etkinliklerin numarası, isimleri, açıklaması, özeti, ayrıntıları ve aşağısında da etkinlik için rezerve edilmiş olan koltuklar yer almaktadır. Bunların hepsi veritabanındaki 'etkinlikler' tablosunda kayıtlıdır ve eğer yeni bir etkinlik eklemek istersek, eklediğimiz anda veritabanına da kaydedilecektir. Bahsettiğimiz verilere, formun .cs dosyasına eklediğimiz Sorgular sınıfından çağrılan oku metoduna gönderdiğimiz sql cümleleri ile erişmekteyiz.
Etkinliğe bilet almak için Rezervasyon Yap butonuna tıklıyoruz. Karşımıza çıkan Bilet Satın Alma formunda koltuk düzeni, etkinliğin numarası ve seçilen koltuğun numarası yer alıyor. Kullanıcı, sisteme kayıt olduğunda veritabanına kaydedilen ID'sini Üye ID kısmına girip bileti satın al butonuna tıkladığında kullanıcı, etkinlik için bileti satın almış olup veritabanındaki 'biletler' tablosundaki etkinlik_id ve uye_id alanlarına ilgili bilgiler gitmektedir.  Bahsettiğimiz verilere, formun .cs dosyasına eklediğimiz Sorgular sınıfından çağrılan oku metoduna gönderdiğimiz sql cümleleri ile erişmekteyiz.</br>

<h2>Üyeler</h2></br>

Veritabanına önceden eklemiş olduğumuz 9 üye olduğu için, Sisteme Giriş kısmındaki email ve şifre kısmına veritabanına belirli email ve şifreleri ile kayıtlı olan bu 9 üye giriş yapabilmektedir. Her üyenin ayrı bir id, ad, soyad, email, şifre, telefon numarası, meslek, ülke, şehir bilgileri "güncelle" kısmında bulunmakta olup veriler veritabanındaki 'uyeler' tablosundan çekilmektedir. Yönetici tarafından sisteme yeni bir üye eklenmek istendiğinde "ekle" butonuna tıklanarak ilgili bilgileri girildiğinde ve ekle butonuna tıklandığında, 'uyeler' tablosuna yeni üye eklenecektir. Aynı şekilde, sisteme kayıtlı olan üyelerden biri silinmek istenirse "sil" butonuna tıklandığında üye bilgileri hem otomasyondan, hem de veritabanından silinecektir.
Bahsettiğimiz verilere, formun .cs dosyasına eklediğimiz Sorgular sınıfından çağrılan oku metoduna gönderdiğimiz sql cümleleri ile erişmekteyiz.
Konuşmacılar</br>
Veritabanına daha önceden kaydetmiş olduğumuz bazı konuşmacılar eklediğimiz sql cümleleri ile programa sağlanmaktadır. Her konuşmacının özellikleri, veritabanımızdaki 'konusmacilar' tablosundan çekilmekte olup programa yeni bir konuşmacı eklediğimizde, veritabanındaki bu tabloya ilgili alanlar ile kaydedilir. Her konuşmacının kendi id'si, ad, soyad, email, telefon ve diğer ayrıntılı bilgileri yer almaktadır. Bahsettiğimiz verilere, formun .cs dosyasına eklediğimiz Sorgular sınıfından çağrılan oku metoduna gönderdiğimiz sql cümleleri ile erişmekteyiz.

# Installation 


1- Import fuar_veri_tabani.sql database from repo to your MySQL. You can name that db as "fuar_veri_tabani" ;</br>
2- In the solution folder Go to DigerSiniflar -> SQL.cs ;</br>
3- Right at the top set the password of the connection methode to the one you use in your local MySQL;</br>
4- Add your own information to the "yoneticiler" table of "fuar_veri_tabani" db and try to connect to fuarix from login page.</br></br>

<img src="https://github.com/Judy-Nkwama/fuarix_cSharp/blob/main/Screenshot%20(130).png" />
