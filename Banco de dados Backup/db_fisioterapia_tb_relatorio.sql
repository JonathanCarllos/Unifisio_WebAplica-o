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
-- Table structure for table `tb_relatorio`
--

DROP TABLE IF EXISTS `tb_relatorio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_relatorio` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Relatorio` varchar(255) DEFAULT NULL,
  `QtdRelatorio` varchar(100) DEFAULT NULL,
  `DataRelatorio` datetime DEFAULT NULL,
  `IdPaciente` int DEFAULT NULL,
  `Exercicio` varchar(5) DEFAULT NULL,
  `ExerciciosFeitos` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_relatorio`
--

LOCK TABLES `tb_relatorio` WRITE;
/*!40000 ALTER TABLE `tb_relatorio` DISABLE KEYS */;
INSERT INTO `tb_relatorio` VALUES (11,NULL,'10','2023-04-10 00:00:00',8,NULL,NULL),(12,NULL,'3 vezes','2023-04-17 21:57:54',8,NULL,NULL),(13,NULL,'3 vezes','2023-04-18 11:21:11',8,NULL,NULL),(14,NULL,'3 vezes','2023-04-18 19:25:00',8,NULL,NULL),(15,'llkllkkk','1 vez','2023-04-26 16:38:43',8,NULL,'Não'),(16,'hoje tiver 2 vazamentos de manhã e 2 a tarde','4 vezes','2023-04-26 16:40:47',8,NULL,'Sim'),(17,'5 vezes hoje','5 vezes','2023-04-27 13:28:44',8,NULL,'Sim'),(18,'1 vez','1 vez','2023-04-27 13:36:06',8,NULL,'Não'),(19,'hoje tiver duas vezes\r\n','2 vezes','2023-04-27 13:40:13',13,NULL,'Sim'),(20,'4 vezes','4 vezes','2023-04-27 13:43:52',13,NULL,'Sim'),(21,'6 vezes hoje','6 vezes','2023-04-27 13:44:31',13,NULL,'Não'),(22,'6 veezes hoje','6 vezes','2023-04-27 13:51:08',9,NULL,'Sim'),(23,'hoje eu tiver 8 vazamentos durante o dia','8 vezes','2023-04-27 19:43:42',14,NULL,'Sim'),(24,'hoje eu tiver 8 vezes','8 vezes','2023-04-27 23:31:44',8,NULL,'Não'),(25,'2 vezes','2 vezes','2023-04-28 17:11:27',8,NULL,'Sim'),(26,'2 vezes','2 vezes','2023-04-28 17:17:25',8,NULL,'Sim'),(27,'hoje tiver 2 vezes','2 vezes','2023-04-28 17:19:57',8,NULL,'Sim'),(28,'sangramento','4 vezes','2023-05-03 19:33:11',8,NULL,'Sim'),(29,'123','4 vezes','2023-05-03 19:37:23',8,NULL,'Não'),(30,'hoje eu fiz os treinos','4 vezes','2023-05-08 22:26:11',8,NULL,'Sim'),(31,'hoje tiver dois vazamentos durante o dia','2 vezes','2023-05-25 20:15:40',15,NULL,'Sim'),(32,'hoje eu tiver 3 vazamentos durante o dia ','3 vezes','2023-05-29 08:30:47',16,NULL,'Sim');
/*!40000 ALTER TABLE `tb_relatorio` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-04 22:31:39
