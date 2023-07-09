-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: db_fisioterapia
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `tb_intervalo`
--

DROP TABLE IF EXISTS `tb_intervalo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_intervalo` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Definicao` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_intervalo`
--

LOCK TABLES `tb_intervalo` WRITE;
/*!40000 ALTER TABLE `tb_intervalo` DISABLE KEYS */;
INSERT INTO `tb_intervalo` VALUES (1,'1 minuto'),(2,'2 minutos'),(3,'3 minutos'),(4,'4 minutos'),(5,'5 minutos'),(6,'6 minutos'),(7,'7 minutos'),(8,'8 minutos'),(9,'9 minutos'),(10,'10 minutos'),(11,'11 minutos'),(12,'12 minutos'),(13,'13 minutos'),(14,'14 minutos'),(15,'15 minutos'),(16,'16 minutos'),(17,'17 minutos'),(18,'18 minutos'),(19,'19 minutos'),(20,'20 minutos'),(21,'21 minutos'),(22,'22 minutos'),(23,'23 minutos'),(24,'24 minutos'),(25,'25 minutos'),(26,'26 minutos'),(27,'27 minutos'),(28,'28 minutos'),(29,'29 minutos'),(30,'30 minutos');
/*!40000 ALTER TABLE `tb_intervalo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-04 22:31:41
