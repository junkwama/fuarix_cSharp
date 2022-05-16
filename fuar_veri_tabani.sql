-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: fuar_veri_tabani
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bilet_koltuklari`
--

DROP TABLE IF EXISTS `bilet_koltuklari`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bilet_koltuklari` (
  `id` int NOT NULL AUTO_INCREMENT,
  `bilet_id` int NOT NULL,
  `koltuk_id` int NOT NULL,
  PRIMARY KEY (`bilet_id`,`koltuk_id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  KEY `koltuk_ile_baglanma_idx` (`koltuk_id`),
  CONSTRAINT `bilet_ile_baglanma` FOREIGN KEY (`bilet_id`) REFERENCES `biletler` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `koltuk_ile_baglanma` FOREIGN KEY (`koltuk_id`) REFERENCES `koltuklar` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bilet_koltuklari`
--

LOCK TABLES `bilet_koltuklari` WRITE;
/*!40000 ALTER TABLE `bilet_koltuklari` DISABLE KEYS */;
/*!40000 ALTER TABLE `bilet_koltuklari` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `biletler`
--

DROP TABLE IF EXISTS `biletler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `biletler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `etkinlik_id` int NOT NULL,
  `uye_id` int NOT NULL,
  `koltuk_numarasi` varchar(45) NOT NULL,
  PRIMARY KEY (`etkinlik_id`,`koltuk_numarasi`),
  UNIQUE KEY `bilet_id` (`id`),
  UNIQUE KEY `koltuk_id_UNIQUE` (`koltuk_numarasi`),
  KEY `uye_id` (`uye_id`),
  KEY `etiklik_and_bilet_idx` (`etkinlik_id`),
  CONSTRAINT `bilet ile koltuk baglanmasi ` FOREIGN KEY (`koltuk_numarasi`) REFERENCES `koltuklar` (`koltuk_numarasi`),
  CONSTRAINT `etiklik_and_bilet` FOREIGN KEY (`etkinlik_id`) REFERENCES `etkinlikler` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `uye_id` FOREIGN KEY (`uye_id`) REFERENCES `uyeler` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `biletler`
--

LOCK TABLES `biletler` WRITE;
/*!40000 ALTER TABLE `biletler` DISABLE KEYS */;
INSERT INTO `biletler` VALUES (11,1,8,'ALPHA-4'),(15,1,9,'ALPHA-5'),(32,2,4,'ALPHA-11');
/*!40000 ALTER TABLE `biletler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bilgi_alanlari`
--

DROP TABLE IF EXISTS `bilgi_alanlari`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bilgi_alanlari` (
  `id` int NOT NULL AUTO_INCREMENT,
  `baslik` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `baslik_UNIQUE` (`baslik`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bilgi_alanlari`
--

LOCK TABLES `bilgi_alanlari` WRITE;
/*!40000 ALTER TABLE `bilgi_alanlari` DISABLE KEYS */;
INSERT INTO `bilgi_alanlari` VALUES (1,'Bitkiler'),(2,'Biyoloji'),(3,'Biyomedikal'),(43,'Bulut Teknologiler'),(5,'Çevre'),(6,'Denizcilik'),(7,'Diş Hekimliği'),(8,'Ebelik'),(24,'Edebiyatı'),(4,'Ekonomi'),(9,'Elektrik'),(10,'Elektronik ve Haberleşme'),(11,'Endüstri'),(12,'Enerji'),(13,'Felsefe'),(14,'Fen'),(15,'Fizik'),(16,'Gastronomi ve Mutfak Sanatları'),(17,'Gazetecilik'),(18,'Görsel İletişim Tasarımı'),(19,'Halkla İlişkiler'),(20,'Hukuk'),(21,'İç Mimarlık'),(22,'İktisat'),(23,'İlahiyat'),(26,'İnşaat'),(27,'İşletme'),(28,'Jeofizik'),(29,'Kimya'),(42,'Makine Ogrenmesi'),(30,'Matematik'),(31,'Mekatronik'),(25,'Öğretmenliği'),(32,'Otomotiv'),(33,'Radyo, Televizyon ve Sinema'),(34,'Rehberlik ve Psikolojik'),(35,'Siyaset'),(36,'Sosyal Hizmet'),(37,'Tarih'),(38,'Tıp'),(39,'Turizm'),(41,'undefined'),(40,'Yazılım');
/*!40000 ALTER TABLE `bilgi_alanlari` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diller`
--

DROP TABLE IF EXISTS `diller`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diller` (
  `id` int NOT NULL AUTO_INCREMENT,
  `baslik` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diller`
--

LOCK TABLES `diller` WRITE;
/*!40000 ALTER TABLE `diller` DISABLE KEYS */;
INSERT INTO `diller` VALUES (1,'Turkçe'),(2,'İngilizce'),(3,'Arapça'),(4,'Almanca'),(5,'Fince'),(6,'Rusça'),(7,'Farsça'),(8,'Japonca'),(9,'İspanyolca'),(10,'Portekizce'),(11,'Çince'),(12,'Hintçe'),(13,'Korece'),(14,'İtalyanca'),(15,'Kürtçe'),(16,'Azerice'),(17,'Endonezce'),(18,'Özbekçe'),(19,'Yunanca'),(20,'Swahili'),(21,'Lingala');
/*!40000 ALTER TABLE `diller` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `etkinlik_canli_baglantilari`
--

DROP TABLE IF EXISTS `etkinlik_canli_baglantilari`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `etkinlik_canli_baglantilari` (
  `id` int NOT NULL AUTO_INCREMENT,
  `baglanti` varchar(255) NOT NULL,
  `etkinlik_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `baglanti_ile_etkinlik_baglanmasi_idx` (`etkinlik_id`),
  CONSTRAINT `baglanti_ile_etkinlik_baglanmasi` FOREIGN KEY (`etkinlik_id`) REFERENCES `etkinlikler` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `etkinlik_canli_baglantilari`
--

LOCK TABLES `etkinlik_canli_baglantilari` WRITE;
/*!40000 ALTER TABLE `etkinlik_canli_baglantilari` DISABLE KEYS */;
INSERT INTO `etkinlik_canli_baglantilari` VALUES (3,'aaaa',1),(4,'www.kdedvvv.com',2),(9,'https://www.ted.com/talks/melissa_j_moore_the_breakthrough_science_of_mrna_medicine',6),(10,'ee.cn',4);
/*!40000 ALTER TABLE `etkinlik_canli_baglantilari` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `etkinlik_turleri`
--

DROP TABLE IF EXISTS `etkinlik_turleri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `etkinlik_turleri` (
  `id` int NOT NULL AUTO_INCREMENT,
  `baslik` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `etkinlik_turleri`
--

LOCK TABLES `etkinlik_turleri` WRITE;
/*!40000 ALTER TABLE `etkinlik_turleri` DISABLE KEYS */;
INSERT INTO `etkinlik_turleri` VALUES (1,'Kongre'),(2,'Konferans'),(3,'Forum'),(4,'Seminer'),(5,'Sympozyum');
/*!40000 ALTER TABLE `etkinlik_turleri` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `etkinlikler`
--

DROP TABLE IF EXISTS `etkinlikler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `etkinlikler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `baslik` varchar(255) NOT NULL,
  `tarih` date NOT NULL,
  `konuya_giris_metni` text,
  `baslangic_saati` time NOT NULL,
  `bitis_saati` time NOT NULL,
  `salon_id` int NOT NULL,
  `etkinlik_dili_id` int NOT NULL,
  `etkinlik_turu_id` int NOT NULL,
  `arka_plan_linki` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fuar_veri_tabani-salon_id` (`salon_id`),
  KEY `ekinlik_ile_dilini_baglanmasi_idx` (`etkinlik_dili_id`),
  KEY `ekinlik_ve_turune_baglamak_idx` (`etkinlik_turu_id`),
  CONSTRAINT `ekinlik_ile_dilini_baglanmasi` FOREIGN KEY (`etkinlik_dili_id`) REFERENCES `diller` (`id`),
  CONSTRAINT `ekinlik_ve_turune_baglamak` FOREIGN KEY (`etkinlik_turu_id`) REFERENCES `etkinlik_turleri` (`id`),
  CONSTRAINT `fuar_veri_tabani-salon_id` FOREIGN KEY (`salon_id`) REFERENCES `salonlar` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `etkinlikler`
--

LOCK TABLES `etkinlikler` WRITE;
/*!40000 ALTER TABLE `etkinlikler` DISABLE KEYS */;
INSERT INTO `etkinlikler` VALUES (1,'Atoma inanmayin. Sorgulayın!','2022-04-15','Erkcan Özcan, daha çok küçük yaşlarda başlayan bilime olan aşkını, ilkokuldan CERN\'e uzanan \'Fizikçi\' olma macerasını bizlerle esprili bir dille paylaşıyor. \'Benim dediğime ya da gösterdiğime inanmayın\' diyen Özcan, bilimin sorgulayarak ilerleyeceğini bizlere bir kez daha örneklerle gösteriyor.','18:30:00','20:00:00',1,1,1,'https://haberler.boun.edu.tr/sites/haberler.boun.edu.tr/files/kapak-ve-haber-resimleri/57862c1b196821.jpg'),(2,'Bilim İnsanının Katmanları','2022-04-28','Eskiden bilim adamları nasıldı, peki şimdi nasıl? Mete Atatüre, günümüzün değişen bilim insanı kavramını katmanlarıyla açıklıyor.','18:30:00','22:00:00',1,2,5,'https://www.esciupfnews.com/wp-content/uploads/2021/01/Evolution-COVID19-Lao.jpg'),(3,'NFT\'ler, metaverse ve dijital sanatın geleceği','2022-05-30','NFT\'lerle ilgili takıntı hakkında kısa ama aydınlatıcı bir derse mi ihtiyacınız var? Elizabeth Strickler kısaltmayı bozuyor ve değiştirilemez belirteçlerin temellerini açıklayarak, bu dijital varlıkların, meta veri tabanında ve dışında yaratımlarından para kazanmak isteyen sanatçılar ve içerik oluşturucular için ortamı nasıl değiştirdiğini paylaşıyor.','18:00:00','20:00:00',2,1,2,'https://mariepoli.com/wp-content/uploads/2021/04/490455cc-bcf6-41cf-9ca7-1c7faca9768b.jpg'),(4,'Savaş mültecisi olmak nasıl bir şey','2022-06-16','Yazar ve mülteci savunucusu Zarlasht Halaimzai, sürekli şiddet tehdidi altında yaşamanın kalıcı bir etkisi olduğunu söylüyor - tehlikeden kaçtıktan sonra bile. Dünya çapında çatışmalar nedeniyle zorla yerinden edilen milyonlarca insandan biri olan Halaimzai, şimdi başkalarının savaşın yıkımını aşmasına yardımcı oluyor. Bu dokunaklı, hayati konuşmada, harcanabilir olmanın kalıcı travmasını dile getiriyor ve bir topluluğa ait olmanın uzun süredir kayıp olan güvenlik duygularını geri getirmeye nasıl yardımcı olabileceğini paylaşıyor.','20:00:00','22:30:00',3,1,4,'https://img.theepochtimes.com/assets/uploads/2016/06/20/GettyImages-456342514.jpg'),(5,'Why people and AI make good business partners','2022-04-12','What happens when the data-driven capabilities of AI are combined with human creativity and ingenuity? Shining a light on the opportunities this futuristic collaboration could bring to the workplace, AI expert Shervin Khodabandeh shares how to redesign companies so that people and machines can learn from each other','14:00:00','18:00:00',1,2,5,'https://www.ted.com/speakers/shervin_khodabandeh'),(6,'The breakthrough science of mRNA medicine','2022-05-19','The  secret behind medicine that uses messenger RNA (or mRNA) is that it \"teaches\" our bodies how to fight diseases on our own, leading to groundbreaking treatments for COVID-19 and, potentially one day, cancer, the flu and other ailments that have haunted humanity for millennia. RNA researcher Melissa J. Moore -- Moderna\'s chief scientific officer and one of the many people responsible for the rapid creation and deployment of their COVID-19 vaccine -- takes us down to the molecula','16:30:35','20:00:00',2,2,5,'https://avatars.mds.yandex.net/i?id=a523f2d18dbfed152ad68cbbd43f6f3b-5707109-images-thumbs&n=13');
/*!40000 ALTER TABLE `etkinlikler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `etkinliklerin_konusmacilari`
--

DROP TABLE IF EXISTS `etkinliklerin_konusmacilari`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `etkinliklerin_konusmacilari` (
  `id` int NOT NULL AUTO_INCREMENT,
  `konusmaci_id` int NOT NULL,
  `etkinlik_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `etkinlik_konusmaci_baglantisi_idx` (`etkinlik_id`),
  KEY `konusmaci_etkinlik_id_idx` (`konusmaci_id`),
  CONSTRAINT `etkinlik_konusmaci_baglantisi` FOREIGN KEY (`etkinlik_id`) REFERENCES `etkinlikler` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `konusmaci_etkinlik_id` FOREIGN KEY (`konusmaci_id`) REFERENCES `konusmacilar` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `etkinliklerin_konusmacilari`
--

LOCK TABLES `etkinliklerin_konusmacilari` WRITE;
/*!40000 ALTER TABLE `etkinliklerin_konusmacilari` DISABLE KEYS */;
INSERT INTO `etkinliklerin_konusmacilari` VALUES (4,3,3),(6,5,5),(7,1,5),(12,1,1),(13,1,2),(14,2,2),(20,7,6),(21,4,4);
/*!40000 ALTER TABLE `etkinliklerin_konusmacilari` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `etkinliklerin_yonelik_olduklari_bilgi_alanlari`
--

DROP TABLE IF EXISTS `etkinliklerin_yonelik_olduklari_bilgi_alanlari`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `etkinliklerin_yonelik_olduklari_bilgi_alanlari` (
  `id` int NOT NULL AUTO_INCREMENT,
  `bilgi_alani_id` int NOT NULL,
  `etkinlik_id` int NOT NULL,
  PRIMARY KEY (`etkinlik_id`,`bilgi_alani_id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  KEY `etkinlik_ile_biligi_alani_baglanmasi_idx` (`bilgi_alani_id`),
  KEY `etkinlik_ile_biligi_alani_baglanmasi` (`etkinlik_id`),
  CONSTRAINT `biligi_alani_ile_etkinlik_naglanmasi` FOREIGN KEY (`bilgi_alani_id`) REFERENCES `bilgi_alanlari` (`id`) ON UPDATE CASCADE,
  CONSTRAINT `etkinlik_ile_biligi_alani_baglanmasi` FOREIGN KEY (`etkinlik_id`) REFERENCES `etkinlikler` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `etkinliklerin_yonelik_olduklari_bilgi_alanlari`
--

LOCK TABLES `etkinliklerin_yonelik_olduklari_bilgi_alanlari` WRITE;
/*!40000 ALTER TABLE `etkinliklerin_yonelik_olduklari_bilgi_alanlari` DISABLE KEYS */;
INSERT INTO `etkinliklerin_yonelik_olduklari_bilgi_alanlari` VALUES (26,1,1),(27,2,1),(28,7,1),(29,8,1),(30,10,1),(31,17,1),(32,19,1),(33,14,2),(34,18,2),(52,2,6),(53,3,6),(54,14,6),(55,28,6),(56,29,6),(57,2,4);
/*!40000 ALTER TABLE `etkinliklerin_yonelik_olduklari_bilgi_alanlari` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `koltuklar`
--

DROP TABLE IF EXISTS `koltuklar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `koltuklar` (
  `id` int NOT NULL AUTO_INCREMENT,
  `salon_id` int NOT NULL,
  `koltuk_numarasi` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `koltuk_numarasi_UNIQUE` (`koltuk_numarasi`),
  KEY `salon_id` (`salon_id`),
  CONSTRAINT `salon_id` FOREIGN KEY (`salon_id`) REFERENCES `salonlar` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=201 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `koltuklar`
--

LOCK TABLES `koltuklar` WRITE;
/*!40000 ALTER TABLE `koltuklar` DISABLE KEYS */;
INSERT INTO `koltuklar` VALUES (1,1,'ALPHA-1'),(2,1,'ALPHA-2'),(3,1,'ALPHA-3'),(4,1,'ALPHA-4'),(5,1,'ALPHA-5'),(6,1,'ALPHA-6'),(7,1,'ALPHA-7'),(8,1,'ALPHA-8'),(9,1,'ALPHA-9'),(10,1,'ALPHA-10'),(11,1,'ALPHA-11'),(12,1,'ALPHA-12'),(13,1,'ALPHA-13'),(14,1,'ALPHA-14'),(15,1,'ALPHA-15'),(16,1,'ALPHA-16'),(17,1,'ALPHA-17'),(18,1,'ALPHA-18'),(19,1,'ALPHA-19'),(20,1,'ALPHA-20'),(21,1,'ALPHA-21'),(22,1,'ALPHA-22'),(23,1,'ALPHA-23'),(24,1,'ALPHA-24'),(25,1,'ALPHA-25'),(26,1,'ALPHA-26'),(27,1,'ALPHA-27'),(28,1,'ALPHA-28'),(29,1,'ALPHA-29'),(30,1,'ALPHA-30'),(31,1,'ALPHA-31'),(32,1,'ALPHA-32'),(33,1,'ALPHA-33'),(34,1,'ALPHA-34'),(35,1,'ALPHA-35'),(36,1,'ALPHA-36'),(37,1,'ALPHA-37'),(38,1,'ALPHA-38'),(39,1,'ALPHA-39'),(40,1,'ALPHA-40'),(41,1,'ALPHA-41'),(42,1,'ALPHA-42'),(43,1,'ALPHA-43'),(44,1,'ALPHA-44'),(45,1,'ALPHA-45'),(46,1,'ALPHA-46'),(47,1,'ALPHA-47'),(48,1,'ALPHA-48'),(49,1,'ALPHA-49'),(50,1,'ALPHA-50'),(51,2,'BETA-1'),(52,2,'BETA-2'),(53,2,'BETA-3'),(54,2,'BETA-4'),(55,2,'BETA-5'),(56,2,'BETA-6'),(57,2,'BETA-7'),(58,2,'BETA-8'),(59,2,'BETA-9'),(60,2,'BETA-10'),(61,2,'BETA-11'),(62,2,'BETA-12'),(63,2,'BETA-13'),(64,2,'BETA-14'),(65,2,'BETA-15'),(66,2,'BETA-16'),(67,2,'BETA-17'),(68,2,'BETA-18'),(69,2,'BETA-19'),(70,2,'BETA-20'),(71,2,'BETA-21'),(72,2,'BETA-22'),(73,2,'BETA-23'),(74,2,'BETA-24'),(75,2,'BETA-25'),(76,2,'BETA-26'),(77,2,'BETA-27'),(78,2,'BETA-28'),(79,2,'BETA-29'),(80,2,'BETA-30'),(81,2,'BETA-31'),(82,2,'BETA-32'),(83,2,'BETA-33'),(84,2,'BETA-34'),(85,2,'BETA-35'),(86,2,'BETA-36'),(87,2,'BETA-37'),(88,2,'BETA-38'),(89,2,'BETA-39'),(90,2,'BETA-40'),(91,2,'BETA-41'),(92,2,'BETA-42'),(93,2,'BETA-43'),(94,2,'BETA-44'),(95,2,'BETA-45'),(96,2,'BETA-46'),(97,2,'BETA-47'),(98,2,'BETA-48'),(99,2,'BETA-49'),(100,2,'BETA-50'),(151,3,'GAMMA-1'),(152,3,'GAMMA-2'),(153,3,'GAMMA-3'),(154,3,'GAMMA-4'),(155,3,'GAMMA-5'),(156,3,'GAMMA-6'),(157,3,'GAMMA-7'),(158,3,'GAMMA-8'),(159,3,'GAMMA-9'),(160,3,'GAMMA-10'),(161,3,'GAMMA-11'),(162,3,'GAMMA-12'),(163,3,'GAMMA-13'),(164,3,'GAMMA-14'),(165,3,'GAMMA-15'),(166,3,'GAMMA-16'),(167,3,'GAMMA-17'),(168,3,'GAMMA-18'),(169,3,'GAMMA-19'),(170,3,'GAMMA-20'),(171,3,'GAMMA-21'),(172,3,'GAMMA-22'),(173,3,'GAMMA-23'),(174,3,'GAMMA-24'),(175,3,'GAMMA-25'),(176,3,'GAMMA-26'),(177,3,'GAMMA-27'),(178,3,'GAMMA-28'),(179,3,'GAMMA-29'),(180,3,'GAMMA-30'),(181,3,'GAMMA-31'),(182,3,'GAMMA-32'),(183,3,'GAMMA-33'),(184,3,'GAMMA-34'),(185,3,'GAMMA-35'),(186,3,'GAMMA-36'),(187,3,'GAMMA-37'),(188,3,'GAMMA-38'),(189,3,'GAMMA-39'),(190,3,'GAMMA-40'),(191,3,'GAMMA-41'),(192,3,'GAMMA-42'),(193,3,'GAMMA-43'),(194,3,'GAMMA-44'),(195,3,'GAMMA-45'),(196,3,'GAMMA-46'),(197,3,'GAMMA-47'),(198,3,'GAMMA-48'),(199,3,'GAMMA-49'),(200,3,'GAMMA-50');
/*!40000 ALTER TABLE `koltuklar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `konusmaci_dilleri`
--

DROP TABLE IF EXISTS `konusmaci_dilleri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `konusmaci_dilleri` (
  `id` int NOT NULL AUTO_INCREMENT,
  `dil_id` int NOT NULL,
  `konusmaci_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `diller_ile_konusmaci_baglanmasi_idx` (`dil_id`),
  KEY `konusmaci_ile_diller_baglanmasi_idx` (`konusmaci_id`),
  CONSTRAINT `diller_ile_konusmaci_baglanmasi` FOREIGN KEY (`dil_id`) REFERENCES `diller` (`id`) ON UPDATE CASCADE,
  CONSTRAINT `konusmaci_ile_diller_baglanmasi` FOREIGN KEY (`konusmaci_id`) REFERENCES `konusmacilar` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `konusmaci_dilleri`
--

LOCK TABLES `konusmaci_dilleri` WRITE;
/*!40000 ALTER TABLE `konusmaci_dilleri` DISABLE KEYS */;
INSERT INTO `konusmaci_dilleri` VALUES (8,2,3),(9,2,4),(10,4,4),(11,8,4),(12,2,5),(13,4,5),(14,1,2),(15,2,2),(16,3,2),(17,6,2),(18,7,2),(27,2,1),(28,3,1),(32,2,7),(33,9,7);
/*!40000 ALTER TABLE `konusmaci_dilleri` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `konusmacilar`
--

DROP TABLE IF EXISTS `konusmacilar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `konusmacilar` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ad` varchar(50) NOT NULL,
  `soyad` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `tel` varchar(15) NOT NULL,
  `internet_sitesi` varchar(255) DEFAULT NULL,
  `kurum` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL COMMENT 'Konusmacinin calistigi kurum',
  `kurum_gorevi` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL COMMENT 'Ne olarak calisiyor kurumda',
  `hakkinda` varchar(1000) DEFAULT NULL,
  `profil` varchar(255) DEFAULT NULL,
  `sehir` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `ana_bilgi_alani_id` int NOT NULL,
  `meslek_id` int NOT NULL,
  `ulke_id` int NOT NULL,
  `sifre` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email` (`email`),
  UNIQUE KEY `tel` (`tel`),
  KEY `ana_bilgi_alani_id_idx` (`ana_bilgi_alani_id`),
  KEY `konusmaciler_ile_meslekler_baglanmasi_idx` (`meslek_id`),
  KEY `konusmaci_ile_ulke_baglanmasi_idx` (`ulke_id`),
  CONSTRAINT `ana_bilgi_alani_ile_bilgi_alanlari_baglanmasi` FOREIGN KEY (`ana_bilgi_alani_id`) REFERENCES `bilgi_alanlari` (`id`),
  CONSTRAINT `konusmaci_ile_ulke_baglanmasi` FOREIGN KEY (`ulke_id`) REFERENCES `ulkeler` (`id`),
  CONSTRAINT `konusmaciler_ile_meslekler_baglanmasi` FOREIGN KEY (`meslek_id`) REFERENCES `meslekler` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `konusmacilar`
--

LOCK TABLES `konusmacilar` WRITE;
/*!40000 ALTER TABLE `konusmacilar` DISABLE KEYS */;
INSERT INTO `konusmacilar` VALUES (1,'Erkcan','Özcan','erkcan@gmail.com','+90873648764','https://www.linkedin.com/in/erkcan/?originalSubdomain=tr','Professor of Physics at Boğaziçi University','Academisyen','Lisans eğitimini 1995-1999 arasında Orta Doğu Teknik Üniversitesi’nde elektrik-elektronik mühendisliği ve fizik dallarında tamamlayan Prof. Dr. Erkcan Özcan, deneysel parçacık fiziği üzerine olan doktora derecesini Stanford Üniversitesi’nden aldı. 2006-2010 döneminde University College London adına önce Londra’da, daha sonra İsviçre’deki CERN araştırma merkezinde çalıştı. 2011 başında Boğaziçi Üniversitesi Fizik Bölümü kadrosuna katılan Özcan, halen Boğaziçi CERN ATLAS takımının liderliğini ve KAHVELab (Kandilli Algıç, Hızlandırıcı ve Enstrümantasyon Laboratuvarı) yürütücülüğünü sürdürmektedir.',NULL,'Bozci',9,36,190,'24435'),(2,'Mete','Atatüre','mete@gmail.com','+90783674689','https://www.phy.cam.ac.uk/directory/ataturem','Cambridge University','Academisyen','Bilkent Üniversitesi Fizik bölümünden 1996 yılında mezun oldu. Aynı yıl Boston Üniversitesi Kuantum Görüntüleme Laboratuvarinda çok parametreli dolanıklık ve kuantum girişim alanında doktora çalışmalarına başladı. 2002 yılında doktorasını alan Atatüre, ETH Zurih’te Profesör Atac Imamoglu’nun grubunda araştırma görevlisi olarak yer aldı. 2007 yılında Cambridge Üniversitesi Fizik bölümü ’nde öğretim üyesi olarak katılıp kendi araştırma grubunu kurdu, 2015 yılında profesör oldu. Halen aynı bölümde kuantum malzeme ve sistemler konusunda ekibiyle beraber araştırmalarına devam etmekte olan Atatüre, Institute of Physics ve Bilim Akademisi Derneği üyesidir. ','https://upload.wikimedia.org/wikipedia/commons/8/81/Mete_Atatüre.jpg','Ankara',15,21,190,'54653'),(3,'Elizabeth','Stickers','elizabeth@gmail.com','+10214445415','https://www.ted.com/speakers/elizabeth_strickler','South University','Academisyen','Yaratıcılığa, yenilikçiliğe ve girişimciliğe tutkuyla inanan Elizabeth Strickler, yeteneklerini öğrencileri ve müşterilerini iş kurma, sürükleyici hikayeler anlatma ve daha güçlü bir kültürel ekonomi inşa etme konusunda desteklemek için kullanır.',NULL,'New York',15,21,4,'45685'),(4,'Zarlasht ','Halaimzai','Halaimzai@yandex.com','+24381470545','https://www.ted.com/speakers/zarlasht_halaimzai','Refugee Healing Network','CEO','Zarlasht Halaimzai, mülteci iyileştirme ağı Amna\'nın kurucusudur. Amna, mültecilerin savaşın ve zorla yerinden edilmenin travmasını atlatmasına yardımcı oluyor.',NULL,'Belize',15,39,45,'00000'),(5,'Shervin','Khodabandeh','Khodabandeh@rta.com','+58445454542','https://www.ted.com/speakers/shervin_khodabandeh','BCG\'s Shervin Khodabandeh','GD','BCG\'s Shervin Khodabandeh helps businesses get real impact from AI by working with them to build game-changing capabilities.','https://ted-conferences-speaker-photos-production.s3.amazonaws.com/LnGs8MbedmqCdoeBK4PGAzPv','Berlin',4,40,3,'00000'),(7,'Melissa','Moore','melissa@fuarix.tr','+805484845','https://www.ted.com/speakers/melissa_j_moore','University Of Vancouver','Academisyen','As chief scientific officer at Moderna, Melissa J. Moore is making medicines from messenger RNA, including the COVID vaccines that are saving millions of lives.',NULL,'Vancouver',29,14,88,'11111');
/*!40000 ALTER TABLE `konusmacilar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `konusmaciler_diger_bilgi_alanlar`
--

DROP TABLE IF EXISTS `konusmaciler_diger_bilgi_alanlar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `konusmaciler_diger_bilgi_alanlar` (
  `id` int NOT NULL AUTO_INCREMENT,
  `konusmaci_id` int NOT NULL,
  `bilgi_alani_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `bilgi_alani_idx` (`bilgi_alani_id`),
  KEY `uyeler_ile_bilgi_alanlari_baglanmasi_idx` (`konusmaci_id`),
  CONSTRAINT `konusmaci_ile_bilgi_alanlar_baglamak` FOREIGN KEY (`bilgi_alani_id`) REFERENCES `bilgi_alanlari` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `konusmaciler_ile_diger_bilgi_alanlari_baglanmasi` FOREIGN KEY (`konusmaci_id`) REFERENCES `konusmacilar` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `konusmaciler_diger_bilgi_alanlar`
--

LOCK TABLES `konusmaciler_diger_bilgi_alanlar` WRITE;
/*!40000 ALTER TABLE `konusmaciler_diger_bilgi_alanlar` DISABLE KEYS */;
INSERT INTO `konusmaciler_diger_bilgi_alanlar` VALUES (5,2,2),(6,2,3),(7,2,4),(16,1,2),(17,1,3),(20,7,2),(21,7,29),(22,7,25);
/*!40000 ALTER TABLE `konusmaciler_diger_bilgi_alanlar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `meslekler`
--

DROP TABLE IF EXISTS `meslekler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `meslekler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `baslik` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `meslekler`
--

LOCK TABLES `meslekler` WRITE;
/*!40000 ALTER TABLE `meslekler` DISABLE KEYS */;
INSERT INTO `meslekler` VALUES (1,'Biyomedikal Mühendisliği'),(2,'Yazılım Mühendisliği'),(3,'Mali Planlayıcı'),(4,'Diş Sağlığı Uzmanı'),(5,'Aktüer'),(6,'Odyolog'),(7,'Mesleki Terapist'),(8,'Optometrist ( Gözlük veya kontakt lens işleri)'),(9,'Fizyoterapist'),(10,'Bilgisayar Sistem Analisti'),(11,'Kayropraktik Uzmanı'),(12,'Konuşma Bozuklukları Uzmanı'),(13,'Fizyolog (İnsan vücudu ile ilgili problemlerin çözüme kavuşturulması)'),(14,'Üniversite Profesörü'),(15,'Veteriner'),(16,'Diyetisyen'),(17,'Eczacı'),(18,'Matematikçi'),(19,'Sosyolog'),(20,'İstatistikçi'),(21,'Fizikçi'),(22,'Gözlükçü'),(23,'Ayak Hastalıkları Uzmanı'),(24,'Web Geliştirici'),(25,'Tarihçi'),(26,'Çevre Mühendisi'),(27,'Şartlı Tahliye Memuru'),(28,'Petrol Mühendisliği'),(29,'Meteoroloji Uzmanı'),(30,'Jeolog'),(31,'İnsan Kaynakları Müdürü'),(32,'İnşaat Mühendisi'),(33,'Ortodonti Uzmanı'),(34,'Solunum Terapisti'),(35,'Tıbbi Kayıtlar Teknisyeni'),(36,'Astronom'),(37,'Psikiyatrist'),(38,'Bilgisayar Programcısı'),(39,'Sosyal ve Topluluk Müdürü/ Yöneticisi'),(40,'Pazar Araştırma Analisti'),(41,'Avukat Yardımcısı'),(42,'Dişçi'),(43,'Cilt Bakım Uzmanı'),(44,'Endüstriyel Makine Tamircileri'),(45,'Hekim (Genel Uygulama)'),(46,'Lojistik'),(47,'Muhasebeci'),(48,'Yönetim Danışmanı'),(49,'Sosyal Hizmet Uzmanı'),(50,'Hekim Yardımcısı'),(51,'Cerrah'),(52,'Meslek Danışmanı'),(53,'Duvar Ustası'),(54,'Bilirkişi'),(55,'Hemşire'),(56,'Arkeolog'),(57,'Müze Müdürü'),(58,'Psikolog'),(59,'Cam Ustası'),(60,'Teknik Yazar'),(61,'Bilgisayar Mühendisi');
/*!40000 ALTER TABLE `meslekler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salonlar`
--

DROP TABLE IF EXISTS `salonlar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `salonlar` (
  `id` int NOT NULL AUTO_INCREMENT,
  `salon_adi` varchar(50) DEFAULT NULL,
  `koltuk_sayisi` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salonlar`
--

LOCK TABLES `salonlar` WRITE;
/*!40000 ALTER TABLE `salonlar` DISABLE KEYS */;
INSERT INTO `salonlar` VALUES (1,'ALPHA',50),(2,'BETA',50),(3,'GAMMA',50);
/*!40000 ALTER TABLE `salonlar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ulkeler`
--

DROP TABLE IF EXISTS `ulkeler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ulkeler` (
  `id` int NOT NULL,
  `isim` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ulkeler`
--

LOCK TABLES `ulkeler` WRITE;
/*!40000 ALTER TABLE `ulkeler` DISABLE KEYS */;
INSERT INTO `ulkeler` VALUES (1,'Abhazya'),(2,'Afganistan'),(3,'Almanya'),(4,'ABD'),(5,'Andorra'),(6,'Angola'),(7,'Antigua ve Barbuda'),(8,'Arjantin'),(9,'Arnavutluk'),(10,'Avustralya'),(11,'Avusturya'),(12,'Azerbaycan'),(13,'Bahamalar'),(14,'Bahreyn'),(15,'Bangladeş'),(16,'Barbados'),(17,'Batı Sahra'),(18,'Belarus'),(19,'Belçika'),(20,'Belize'),(21,'Benin'),(22,'Bhutan'),(23,'Birleşik Arap Emirlikleri'),(24,'Bolivya'),(25,'Bosna Hersek'),(26,'Botsvana'),(27,'Brezilya'),(28,'Brunei'),(29,'Bulgaristan'),(30,'Burkina Faso'),(31,'Burundi'),(32,'Cezayir'),(33,'Cibuti Cumhuriyeti'),(34,'Çad'),(35,'Çek Cumhuriyeti'),(36,'Çin Halk Cumhuriyeti'),(37,'Dağlık Karabağ Cumhuriyeti'),(38,'Danimarka'),(39,'Doğu Timor'),(40,'Dominik Cumhuriyeti'),(41,'Dominika'),(42,'Ekvador'),(43,'Ekvator Ginesi'),(44,'El Salvador'),(45,'Endonezya'),(46,'Eritre'),(47,'Ermenistan'),(48,'Estonya'),(49,'Etiyopya'),(50,'Fas'),(51,'Fiji'),(52,'Fildişi Sahilleri'),(53,'Filipinler'),(54,'Filistin'),(55,'Finlandiya'),(56,'Fransa'),(57,'Gabon'),(58,'Gambiya'),(59,'Gana'),(60,'Gine Bissau'),(61,'Gine'),(62,'Grenada'),(63,'Guyana'),(64,'Guatemala'),(65,'Güney Afrika '),(66,'Güney Kore'),(67,'Güney Osetya'),(68,'Gürcistan'),(69,'Haiti'),(70,'Hırvatistan'),(71,'Hindistan'),(72,'Hollanda'),(73,'Honduras'),(74,'Irak'),(75,'İngiltere'),(76,'İran'),(77,'İrlanda'),(78,'İspanya'),(79,'İsrail'),(80,'İsveç'),(81,'İsviçre'),(82,'İtalya'),(83,'İzlanda'),(84,'Jamaika'),(85,'Japonya'),(86,'Kamboçya'),(87,'Kamerun'),(88,'Kanada'),(89,'Karadağ'),(90,'Katar'),(91,'Kazakistan'),(92,'Kenya'),(93,'Kırgızistan'),(94,'Kıbrıs Cumhuriyeti'),(95,'Kiribati'),(96,'Kolombiya'),(97,'Komorlar'),(98,'Kongo'),(99,'Kongo Demokratik'),(100,'Kosova'),(101,'Kosta Rika'),(102,'Kuveyt'),(103,'Kuzey Kıbrıs Türk Cumhuriyeti'),(104,'Kuzey Kore'),(105,'Küba'),(106,'Lakota Cumhuriyeti'),(107,'Laos'),(108,'Lesotho'),(109,'Letonya'),(110,'Liberya'),(111,'Libya'),(112,'Liechtenstein'),(113,'Litvanya'),(114,'Lübnan'),(115,'Lüksemburg'),(116,'Macaristan'),(117,'Madagaskar'),(118,'Makedonya Cumhuriyeti'),(119,'Malavi'),(120,'Maldivler'),(121,'Malezya'),(122,'Mali'),(123,'Malta'),(124,'Marshall Adaları'),(125,'Meksika'),(126,'Mısır'),(127,'Mikronezya'),(128,'Moğolistan'),(129,'Moldova'),(130,'Monako'),(131,'Moritanya'),(132,'Moritus'),(133,'Mozambik'),(134,'Myanmar'),(135,'Namibya'),(136,'Nauru'),(137,'Nepal'),(138,'Nikaragua'),(139,'Nijer'),(140,'Nijerya'),(141,'Norveç'),(142,'Orta Afrika Cumhuriyeti'),(143,'Özbekistan'),(144,'Pakistan'),(145,'Palau'),(146,'Panama'),(147,'Papua Yeni Gine'),(148,'Paraguay'),(149,'Peru'),(150,'Polonya'),(151,'Portekiz'),(152,'Romanya'),(153,'Ruanda'),(154,'Rusya Federasyonu'),(155,'Saint Kitts ve Nevis'),(156,'Saint Lucia'),(157,'Saint Vincent ve Grenadinler'),(158,'Samoa'),(159,'San Marino'),(160,'Sao Tome ve Principe'),(161,'Sealand'),(162,'Senegal'),(163,'Seyşeller'),(164,'Sırbistan'),(165,'Sierra Leone'),(166,'Singapur'),(167,'Slovakya'),(168,'Slovenya'),(169,'Solomon Adaları'),(170,'Somali'),(171,'Somaliland'),(172,'Sri Lanka'),(173,'Sudan'),(174,'Surinam'),(175,'Suudi Arabistan'),(176,'Suriye'),(177,'Svaziland'),(178,'Şili'),(179,'Tacikistan'),(180,'Tamil Eelam'),(181,'Tanzanya'),(182,'Tayland'),(183,'Tayvan'),(184,'Togo'),(185,'Tonga'),(186,'Transdinyester'),(187,'Trinidad ve Tobago'),(188,'Tunus'),(189,'Tuvalu'),(190,'Türkiye'),(191,'Türkmenistan'),(192,'Uganda'),(193,'Ukrayna'),(194,'Umman'),(195,'Uruguay'),(196,'Ürdün'),(197,'Vanuatu'),(198,'Vatikan'),(199,'Venezuela'),(200,'Vietnam'),(201,'Yemen'),(202,'Yeni Zelanda'),(203,'Yeşil Burun'),(204,'Yunanistan'),(205,'Zambiya'),(206,'Zimbabve');
/*!40000 ALTER TABLE `ulkeler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uyeler`
--

DROP TABLE IF EXISTS `uyeler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `uyeler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ad` varchar(50) NOT NULL,
  `soyadi` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `tel` varchar(15) NOT NULL,
  `meslek_id` int NOT NULL,
  `ulke_id` int NOT NULL,
  `sehir` varchar(50) DEFAULT NULL,
  `sifre` varchar(5) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email` (`email`),
  UNIQUE KEY `tel` (`tel`),
  KEY `ulke_ile_uye_baglanmasi_idx` (`ulke_id`),
  KEY `uyeler_ile_meslekleri_baglanmasi_idx` (`meslek_id`),
  CONSTRAINT `ulke_ile_uye_baglanmasi` FOREIGN KEY (`ulke_id`) REFERENCES `ulkeler` (`id`) ON UPDATE CASCADE,
  CONSTRAINT `uyeler_ile_meslekleri_baglanmasi` FOREIGN KEY (`meslek_id`) REFERENCES `meslekler` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uyeler`
--

LOCK TABLES `uyeler` WRITE;
/*!40000 ALTER TABLE `uyeler` DISABLE KEYS */;
INSERT INTO `uyeler` VALUES (4,'Amouro','Gason','mourg32@protonmail.com','+33769776779',20,15,'BUDAPEST','00000'),(8,'Mehmet','Akıf','m.afif42@gmail.com','+90538624574',21,190,'İzmit','54321'),(9,'Elif','Erdem','elif@yandx.com','+905558485',19,190,'Aksaray','11111'),(10,'Mister','Toe','toe454@gmail.com','+18548545845',28,75,'London','00000'),(13,'Arsu','doaam','doaam454@gmail.com','+808548545845',30,83,'Roma','00000'),(19,'khıl','khanzay','kkhanzay@gmail.com','+905551672743',26,190,'kocaeli','mm555'),(20,'Melek','Ece','mele.ecf@gmail.com','+90535445641',17,190,'İzmit','11111'),(21,'Eren','Aslan','erenalslan@gmail.com','+90548484545',26,190,'İstanbul','11111'),(22,'David','Carlos','dav.carlos@gmail.com','+9053458455',43,75,'London','11144'),(23,'Büşra','Kanıolğlu','busra@protonmail.com','+904547544542',47,190,'Gebsen','21212'),(24,'Pierre','Lebeaux','pierre@gokt.fr','+3354548754',23,56,'Paris','aaaaa'),(25,'Alfredo','Dominos','alfredo@gmail.com','+8445454512',28,24,'Gualalapa','üüüüü'),(26,'Fatma','Damla','fadam@kocaeli.edu.tr','+9045454121',47,190,'Aksaray','aaaaa'),(27,'Jean','Françoil','fean@phk.com','+3048454454',21,41,'Piere','eeeee');
/*!40000 ALTER TABLE `uyeler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uyelerin_dilleri`
--

DROP TABLE IF EXISTS `uyelerin_dilleri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `uyelerin_dilleri` (
  `id` int NOT NULL AUTO_INCREMENT,
  `dil_id` int NOT NULL,
  `uye_id` int NOT NULL,
  PRIMARY KEY (`dil_id`,`uye_id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  KEY `uyeler_ile_diller_baglanmasi_idx` (`uye_id`),
  KEY `diller_ile_ uyeler_balanmasi_idx` (`dil_id`),
  CONSTRAINT `diller_ile_ uyeler_balanmasi` FOREIGN KEY (`dil_id`) REFERENCES `diller` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `uyeler_ile_diller_baglanmasi` FOREIGN KEY (`uye_id`) REFERENCES `uyeler` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=95 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uyelerin_dilleri`
--

LOCK TABLES `uyelerin_dilleri` WRITE;
/*!40000 ALTER TABLE `uyelerin_dilleri` DISABLE KEYS */;
INSERT INTO `uyelerin_dilleri` VALUES (12,2,4),(13,1,8),(14,1,9),(15,2,13),(16,5,13),(17,7,13),(18,9,13),(42,2,10),(59,1,19),(60,2,19),(66,1,20),(67,2,20),(68,17,20),(69,19,20),(70,21,20),(71,1,21),(72,3,21),(73,6,21),(74,13,21),(75,2,22),(76,16,22),(77,17,22),(78,18,22),(79,1,23),(80,2,23),(81,3,23),(82,1,24),(83,2,24),(84,8,24),(85,2,25),(86,9,25),(87,10,25),(88,11,25),(89,1,26),(90,2,26),(91,3,26),(92,3,27),(93,4,27),(94,6,27);
/*!40000 ALTER TABLE `uyelerin_dilleri` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uyelerin_favori_bilgi_alanlari`
--

DROP TABLE IF EXISTS `uyelerin_favori_bilgi_alanlari`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `uyelerin_favori_bilgi_alanlari` (
  `id` int NOT NULL AUTO_INCREMENT,
  `uye_id` int NOT NULL,
  `bilgi_alani_id` int NOT NULL,
  PRIMARY KEY (`bilgi_alani_id`,`uye_id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  KEY `uyeler_ile_favori_alanlari_baglanmasi_idx` (`uye_id`),
  KEY `favori_bilgi_alanlari_ile_uyeleri_baglanmasi_idx` (`bilgi_alani_id`),
  CONSTRAINT `favori_bilgi_alanlari_ile_uyeleri_baglanmasi` FOREIGN KEY (`bilgi_alani_id`) REFERENCES `bilgi_alanlari` (`id`) ON UPDATE CASCADE,
  CONSTRAINT `uyeler_ile_favori_alanlari_baglanmasi` FOREIGN KEY (`uye_id`) REFERENCES `uyeler` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=115 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uyelerin_favori_bilgi_alanlari`
--

LOCK TABLES `uyelerin_favori_bilgi_alanlari` WRITE;
/*!40000 ALTER TABLE `uyelerin_favori_bilgi_alanlari` DISABLE KEYS */;
INSERT INTO `uyelerin_favori_bilgi_alanlari` VALUES (1,8,1),(2,8,2),(3,8,3),(4,8,4),(5,8,6),(6,9,1),(7,9,2),(8,9,8),(9,13,2),(10,13,5),(11,13,7),(12,13,9),(33,4,5),(34,4,9),(57,10,5),(73,19,5),(77,20,2),(78,20,3),(79,20,19),(80,20,21),(81,20,29),(82,20,42),(83,20,31),(84,21,2),(85,21,43),(86,21,42),(87,21,31),(88,21,38),(89,21,41),(90,22,2),(91,22,43),(92,22,15),(93,22,17),(94,22,20),(95,23,2),(96,23,25),(97,23,36),(98,23,37),(99,23,40),(100,24,21),(101,24,22),(102,24,23),(103,24,26),(104,25,2),(105,25,43),(106,26,2),(107,26,21),(108,26,23),(109,26,26),(110,26,27),(111,26,28),(112,27,43),(113,27,5),(114,27,8);
/*!40000 ALTER TABLE `uyelerin_favori_bilgi_alanlari` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `yoneticiler`
--

DROP TABLE IF EXISTS `yoneticiler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `yoneticiler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ad` varchar(50) NOT NULL,
  `soyad` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `tel` varchar(15) NOT NULL,
  `sifre` varchar(5) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email` (`email`),
  UNIQUE KEY `tel` (`tel`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `yoneticiler`
--

LOCK TABLES `yoneticiler` WRITE;
/*!40000 ALTER TABLE `yoneticiler` DISABLE KEYS */;
INSERT INTO `yoneticiler` VALUES (1,'Judy','Nkwama','nkwamajudy@gmail.com','+243814702818','11111'),(2,'Fatma','Nur','fatmanur@kocaeli.edu.tr','+905556859954','12345'),(3,'Derya','Eryılmaz','derya@yandex.com','+905456585524','00000'),(4,'Mehmet','Hülya','ka_testi@kocaeli.edu.tr','+905386057751','12345');
/*!40000 ALTER TABLE `yoneticiler` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-16  8:17:33
