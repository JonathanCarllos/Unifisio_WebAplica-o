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
-- Table structure for table `tb_anamnese_itens`
--

DROP TABLE IF EXISTS `tb_anamnese_itens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_anamnese_itens` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_anamenese` int DEFAULT NULL,
  `pergunta` varchar(200) DEFAULT NULL,
  `tipo` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=79 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_anamnese_itens`
--

LOCK TABLES `tb_anamnese_itens` WRITE;
/*!40000 ALTER TABLE `tb_anamnese_itens` DISABLE KEYS */;
INSERT INTO `tb_anamnese_itens` VALUES (2,1,'BEBE','SN'),(3,1,'PRATICA ESPORTES','SN'),(4,2,'FUMA','SN'),(5,2,'BEBE','SN'),(6,2,'DUM','SN'),(7,2,'GRAVIDEZ','QTD'),(8,NULL,'Prática esportes?','SN'),(9,NULL,'Prática esportes?','SN'),(10,NULL,'ok?',''),(11,NULL,'ok?','QTD'),(12,NULL,'ok?',''),(13,NULL,'ok?','QTD'),(14,1,'macho ou femea?','SN'),(15,0,'macho ou femea?','QTD'),(16,1,'ok','QTD'),(17,2,'ok','QTD'),(18,2,'Teste 3','QTD'),(19,1,'teste 55','QTD'),(20,2,'nova pergunta 1','QTD'),(21,1,'nova pergunta 89','SN'),(22,1,'guilherme','QTD'),(23,2,'Bebe?','QTD'),(24,0,'Prática esportes?','SN'),(25,0,'TEste fsfsssg','SN'),(26,3,'Prática esportes?','QTD'),(27,4,'Ja teve problemas?','QTD'),(28,4,'Prática esportes?','SN'),(29,3,'Fumar?','SN'),(30,5,'dadsdasd','QTD'),(31,6,'tesre','SN'),(32,7,'ok','QTD'),(33,7,'Prática Esportes?','SN'),(34,7,'Fumar?','SN'),(35,9,'Prática esportes?','SN'),(36,9,'Fuma','SN'),(37,9,'Quantas vezes','QTD'),(38,10,'Prática esportes?','SN'),(39,10,'Toma algum medicamento?','SN'),(40,10,'quais?','QTD'),(41,11,'Joga video game?','SN'),(42,11,'Prática esportes?','SN'),(43,11,'ok','QTD'),(44,12,'Prática esportes?','SN'),(45,12,'cdsvdgdbd','QTD'),(46,9,'defervvrvvr','SN'),(47,12,'macho ou femea?','SN'),(48,13,'Prática esportes?','SN'),(49,14,'palmeiras vai ter mundial?','SN'),(50,14,'Prática esportes?','QTD'),(51,15,'Comer verduras?','SN'),(52,15,'Prática esportes?','SN'),(53,15,'Quantos dias de exercicios fisicos?','QTD'),(54,16,'Prática esportes?','SN'),(55,17,'Prática esportes?','SN'),(56,17,'Usa lentes de contatos?','SN'),(57,17,'Ingestão de água(copo/dia)','QTD'),(58,17,'macho ou femea?','SN'),(59,17,'','QTD'),(60,18,'Prática esportes?','SN'),(61,19,'Prática esportes?','SN'),(62,19,'ok','QTD'),(63,20,'Prática esportes?','SN'),(64,20,'Tem filhos?','SN'),(65,20,'Quantos?','QTD'),(66,16,'ok?','SN'),(67,16,'Tem filhos?','SN'),(68,21,'fumante?','SN'),(69,16,'Casado?','QTD'),(70,22,'Sintomas?','QTD'),(71,22,'Quanto tempo ?','QTD'),(72,22,'Foi medicado?','SN'),(73,23,'fumante?','SN'),(74,23,'Prática esportes?','SN'),(75,23,'Tem filhos?','QTD'),(76,16,'Prática esportes?','SN'),(77,24,'fumante?','SN'),(78,24,'Tem filhos? quantos ?','QTD');
/*!40000 ALTER TABLE `tb_anamnese_itens` ENABLE KEYS */;
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
