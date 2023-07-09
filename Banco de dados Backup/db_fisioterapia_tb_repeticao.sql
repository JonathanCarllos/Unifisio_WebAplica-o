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
-- Table structure for table `tb_repeticao`
--

DROP TABLE IF EXISTS `tb_repeticao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_repeticao` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Definicao` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_repeticao`
--

LOCK TABLES `tb_repeticao` WRITE;
/*!40000 ALTER TABLE `tb_repeticao` DISABLE KEYS */;
INSERT INTO `tb_repeticao` VALUES (1,'1 vez'),(2,'2 vezes'),(3,'3 vezes'),(4,'4 vezes'),(5,'5 vezes'),(6,'6 vezes'),(7,'7 vezes'),(8,'8 vezes'),(9,'9 vezes'),(10,'10 vezes'),(11,'11vezes'),(12,'12 vezes'),(13,'13 vezes'),(14,'14 vezes'),(15,'15 vezes'),(16,'16 vezes'),(17,'17 vezes'),(18,'18 vezes'),(19,'19 vezes'),(20,'20 vezes'),(21,'21 vezes'),(22,'22 vezes'),(23,'23 vezes'),(24,'24 vezes'),(25,'25 vezes'),(26,'26 vezes'),(27,'27 vezes'),(28,'28 vezes'),(29,'29 vezes'),(30,'30 vezes');
/*!40000 ALTER TABLE `tb_repeticao` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-04 22:31:40
