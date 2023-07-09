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
-- Table structure for table `tb_exercicios`
--

DROP TABLE IF EXISTS `tb_exercicios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_exercicios` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Exercicios1` varchar(100) DEFAULT NULL,
  `Exercicios2` varchar(100) DEFAULT NULL,
  `Exercicios3` varchar(100) DEFAULT NULL,
  `Exercicios4` varchar(100) DEFAULT NULL,
  `Exercicios5` varchar(100) DEFAULT NULL,
  `Exercicios6` varchar(100) DEFAULT NULL,
  `Exercicios7` varchar(100) DEFAULT NULL,
  `Exercicios8` varchar(100) DEFAULT NULL,
  `Series1` varchar(50) DEFAULT NULL,
  `Series2` varchar(50) DEFAULT NULL,
  `Series3` varchar(50) DEFAULT NULL,
  `Series4` varchar(50) DEFAULT NULL,
  `Series5` varchar(50) DEFAULT NULL,
  `Series6` varchar(50) DEFAULT NULL,
  `Series7` varchar(50) DEFAULT NULL,
  `Series8` varchar(50) DEFAULT NULL,
  `Intervalos1` varchar(50) DEFAULT NULL,
  `Intervalos2` varchar(50) DEFAULT NULL,
  `Intervalos3` varchar(50) DEFAULT NULL,
  `Intervalos4` varchar(50) DEFAULT NULL,
  `Intervalos5` varchar(50) DEFAULT NULL,
  `Intervalos6` varchar(50) DEFAULT NULL,
  `Intervalos7` varchar(50) DEFAULT NULL,
  `Intervalos8` varchar(50) DEFAULT NULL,
  `Reperticoes1` varchar(50) DEFAULT NULL,
  `Reperticoes2` varchar(50) DEFAULT NULL,
  `Reperticoes3` varchar(50) DEFAULT NULL,
  `Reperticoes4` varchar(50) DEFAULT NULL,
  `Reperticoes5` varchar(50) DEFAULT NULL,
  `Reperticoes6` varchar(50) DEFAULT NULL,
  `Reperticoes7` varchar(50) DEFAULT NULL,
  `Reperticoes8` varchar(50) DEFAULT NULL,
  `IdPaciente` int DEFAULT NULL,
  `DataExercicio` datetime DEFAULT NULL,
  `Secao` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_exercicios`
--

LOCK TABLES `tb_exercicios` WRITE;
/*!40000 ALTER TABLE `tb_exercicios` DISABLE KEYS */;
INSERT INTO `tb_exercicios` VALUES (1,'https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','2 vezes','5 vezes','5 vezes','4 vezes','5 vezes','3 vezes','2 vezes','3 vezes','15 minutos','10 Minutos','5 Minutos','3 Minutos','5 Minutos','5 Minutos','3 Minutos','8 Minutos','5 vezes','2 vezes','3 vezes','3 vezes','5 vezes','2 vezes','5 vezes','8 vezes',8,'2023-05-06 21:47:02','Seção de treino de mãos'),(2,'teste1','teste2','teste3','teste4','teste5','teste6','teste7','teste8','1 vez','2 vezes','3 vezes','4 vezes','5 vezes','6 vezes','7 vezes','8 vezes','1 minuto','2 minutos','3 minutos','4 minutos','5 minutos','6 minutos','7 minutos','8 minutos','1 vez','2 vezes','3 vezes','4 vezes','5 vezes','6 vezes','7 vezes','8 vezes',0,'2023-05-07 23:29:04','teste'),(3,'teste1','teste2','teste3','teste4','teste5','teste6','teste7','teste8','1 vez','2 vezes','3 vezes','4 vezes','5 vezes','6 vezes','7 vezes','8 vezes','1 minuto','2 minutos','3 minutos','4 minutos','5 minutos','6 minutos','7 minutos','8 minutos','1 vez','2 vezes','3 vezes','4 vezes','5 vezes','6 vezes','7 vezes','8 vezes',0,'2023-05-07 23:29:21','teste'),(4,'teste1','teste2','teste3','teste4','teste5','teste6','teste7','teste8','1 vez','2 vezes','3 vezes','4 vezes','5 vezes','6 vezes','7 vezes','8 vezes','1 minuto','2 minutos','7 minutos','4 minutos','5 minutos','6 minutos','7 minutos','8 minutos','1 vez','2 vezes','3 vezes','4 vezes','5 vezes','6 vezes','7 vezes','8 vezes',0,'2023-05-07 23:34:57','teste'),(5,'teste1','teste2','teste3','teste4','teste5','teste6','teste7','teste8','1 vez','2 vezes','3 vezes','4 vezes','5 vezes','6 vezes','7 vezes','8 vezes','1 minuto','2 minutos','3 minutos','4 minutos','5 minutos','6 minutos','7 minutos','8 minutos','1 vez','2 vezes','3 vezes','4 vezes','5 vezes','6 vezes','7 vezes','8 vezes',8,'2023-05-07 23:38:37','teste'),(6,'ok','ok2','3','4','5','6','7','8','1 vez','2 vezes','3 vezes','4 vezes','5 vezes','6 vezes','7 vezes','8 vezes','1 minuto','2 minutos','3 minutos','4 minutos','5 minutos','6 minutos','7 minutos','8 minutos','1 vez','2 vezes','3 vezes','4 vezes','5 vezes','6 vezes','7 vezes','8 vezes',13,'2023-05-08 16:16:03','teste bolsonaro'),(7,'teste1','teste2','teste3','teste4','teste5','teste6','teste7','teste8','1 vez','2 vezes','3 vezes','4 vezes','5 vezes','6 vezes','7 vezes','8 vezes','1 minuto','2 minutos','3 minutos','4 minutos','5 minutos','6 minutos','7 minutos','8 minutos','1 vez','2 vezes','3 vezes','4 vezes','5 vezes','6 vezes','7 vezes','8 vezes',15,'2023-05-25 20:18:03','treino de pernas'),(8,'https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','','','','','','','','3 vezes','','','','','','','','3 minutos','','','','','','','','3 vezes','','','','','','','',16,'2023-05-29 21:00:40',''),(9,'https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','7 vezes','5 vezes','6 vezes','6 vezes','8 vezes','8 vezes','8 vezes','8 vezes','4 minutos','6 minutos','8 minutos','7 minutos','8 minutos','7 minutos','5 minutos','6 minutos','3 vezes','7 vezes','5 vezes','8 vezes','6 vezes','6 vezes','7 vezes','4 vezes',16,'2023-05-31 20:00:53','Seção de treino de mãos'),(10,'https://www.youtube.com/watch?v=8UaguGuEQWg&ab_channel=CarolBorba','teste2','','','','','','','4 vezes','9 vezes','','','','','','','3 minutos','6 minutos','','','','','','','2 vezes','9 vezes','','','','','','',16,'2023-05-31 20:31:33','Seção de treino de mãos');
/*!40000 ALTER TABLE `tb_exercicios` ENABLE KEYS */;
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
