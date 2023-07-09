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
-- Table structure for table `tb_paciente`
--

DROP TABLE IF EXISTS `tb_paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_paciente` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) DEFAULT NULL,
  `Cpf` varchar(20) DEFAULT NULL,
  `Celular` varchar(20) DEFAULT NULL,
  `Sexo` varchar(20) DEFAULT NULL,
  `Profissao` varchar(100) DEFAULT NULL,
  `EstadoCivil` varchar(25) DEFAULT NULL,
  `Logradouro` varchar(100) DEFAULT NULL,
  `NumeroCasa` varchar(10) DEFAULT NULL,
  `Bairro` varchar(100) DEFAULT NULL,
  `Cidade` varchar(100) DEFAULT NULL,
  `Cep` varchar(20) DEFAULT NULL,
  `Estado` varchar(27) DEFAULT NULL,
  `DataNascimento` varchar(15) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Telefone` varchar(20) DEFAULT NULL,
  `CelularResponsavel` varchar(20) DEFAULT NULL,
  `NomeResponsavel` varchar(100) DEFAULT NULL,
  `CpfResponsavel` varchar(100) DEFAULT NULL,
  `RazaoSocial` varchar(20) DEFAULT NULL,
  `Cnpj` varchar(20) DEFAULT NULL,
  `TelefoneConv` varchar(20) DEFAULT NULL,
  `LogradouroConv` varchar(100) DEFAULT NULL,
  `NumeroConv` varchar(10) DEFAULT NULL,
  `BairroConv` varchar(100) DEFAULT NULL,
  `CidadeConv` varchar(100) DEFAULT NULL,
  `CepConv` varchar(20) DEFAULT NULL,
  `UfConv` varchar(27) DEFAULT NULL,
  `TipoPlanos` varchar(25) DEFAULT NULL,
  `ObsMedica` varchar(244) DEFAULT NULL,
  `Pergunta` varchar(255) DEFAULT NULL,
  `Pergunta2` varchar(255) DEFAULT NULL,
  `Pergunta3` varchar(255) DEFAULT NULL,
  `DataExer` varchar(10) DEFAULT NULL,
  `Hora` varchar(10) DEFAULT NULL,
  `Senha` varchar(50) DEFAULT NULL,
  `DataRelatorio` varchar(10) DEFAULT NULL,
  `QtdRelatorio` varchar(10) DEFAULT NULL,
  `Relatorio` varchar(255) DEFAULT NULL,
  `Fisioterapeuta` varchar(100) DEFAULT NULL,
  `Pergunta4` varchar(100) DEFAULT NULL,
  `Pergunta5` varchar(100) DEFAULT NULL,
  `Avaliador` varchar(100) DEFAULT NULL,
  `Reperticoes` varchar(50) DEFAULT NULL,
  `Reperticoes2` varchar(50) DEFAULT NULL,
  `Reperticoes3` varchar(50) DEFAULT NULL,
  `Reperticoes4` varchar(50) DEFAULT NULL,
  `Reperticoes5` varchar(50) DEFAULT NULL,
  `Reperticoes6` varchar(50) DEFAULT NULL,
  `Reperticoes7` varchar(50) DEFAULT NULL,
  `Reperticoes8` varchar(50) DEFAULT NULL,
  `Series` varchar(50) DEFAULT NULL,
  `Series2` varchar(50) DEFAULT NULL,
  `Series3` varchar(50) DEFAULT NULL,
  `Series4` varchar(50) DEFAULT NULL,
  `Series5` varchar(50) DEFAULT NULL,
  `Series6` varchar(50) DEFAULT NULL,
  `Series7` varchar(50) DEFAULT NULL,
  `Series8` varchar(50) DEFAULT NULL,
  `Intervalos` varchar(50) DEFAULT NULL,
  `Intervalos2` varchar(50) DEFAULT NULL,
  `Intervalos3` varchar(50) DEFAULT NULL,
  `Intervalos4` varchar(50) DEFAULT NULL,
  `Intervalos5` varchar(50) DEFAULT NULL,
  `Intervalos6` varchar(50) DEFAULT NULL,
  `Intervalos7` varchar(50) DEFAULT NULL,
  `Intervalos8` varchar(50) DEFAULT NULL,
  `Pergunta6` varchar(100) DEFAULT NULL,
  `Pergunta7` varchar(100) DEFAULT NULL,
  `Pergunta8` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_paciente`
--

LOCK TABLES `tb_paciente` WRITE;
/*!40000 ALTER TABLE `tb_paciente` DISABLE KEYS */;
INSERT INTO `tb_paciente` VALUES (8,'Jonathan Carlos Moura da Silva','057.665.853-73','(11)98462-6234','MASCULINO','Análista de Sistemas','','Av. Demétrio Lêonidas Konidis','155','Terra Preta (Terra Preta)','Mairiporã','07661-160','São Paulo','27/05/1994','jonathan.carllos1994@gmail.com','(11) 4486-3531','(11) 98525-0210','Jonathan Carlos Moura da Silva','057.652.258-20','','','','','','','','','','','não a nenhuma obs','https://www.youtube.com/watch?v=PR18M5j_b88&ab_channel=CanaldasFraturas','https://www.youtube.com/watch?v=PR18M5j_b88&ab_channel=CanaldasFraturas','https://www.youtube.com/watch?v=PR18M5j_b88&ab_channel=CanaldasFraturas','06/04/2023','17:42','123456','13/04/2023','4 vezes','hoje tiver 4x','','https://www.youtube.com/watch?v=PR18M5j_b88&ab_channel=CanaldasFraturas','https://www.youtube.com/watch?v=PR18M5j_b88&ab_channel=CanaldasFraturas','','5 vezes','2 vezes','3 vezes','3 vezes','5 vezes','2 vezes','5 vezes','8 vezes','2 vezes','5 vezes','5 vezes','4 vezes','5 vezes','3 vezes','2 vezes','3 vezes','15 minutos','10 Minutos','5 Minutos','3 Minutos','5 Minutos','5 Minutos','3 Minutos','8 Minutos','https://www.youtube.com/watch?v=PR18M5j_b88&ab_channel=CanaldasFraturas','https://www.youtube.com/watch?v=PR18M5j_b88&ab_channel=CanaldasFraturas','https://www.youtube.com/watch?v=PR18M5j_b88&ab_channel=CanaldasFraturas'),(15,'João Pereira da Silva','762.535.383-49','(11)93562-1225','MASCULINO','Aposentado','Casado(a)',' Rua Adolfo André','185','Centro','Atibaia','12940-280','São Paulo','25/02/1972','joao.pereira@hotmail.com','(11) 4002-3325','(11) 98535-3325','Maria Silva Pereira','714.798.376-95','Santa Família','21.201.02/0001.21','(18) 3531-2520','R. Pedro Alvim','55','Vila Junqueira','Atibaia','12940-500','São Paulo','Individual','',NULL,NULL,NULL,NULL,NULL,'27051994',NULL,NULL,NULL,'Jennifer Maria',NULL,NULL,'Maria Silva',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(17,'Sandra Márcia Pereira','746.983.680-22','(11)98525-0072','FEMININO','Secretária','Casado(a)','R. Castro Fafe','295','Centro','Atibaia','12940-440','São Paulo','','sandramarcia@gmail.com','(11)3100-5502','(11)98525-2021','Marcos Silva','148.438.118-15','','','','','','','','','','','',NULL,NULL,NULL,NULL,NULL,'123123',NULL,NULL,NULL,'',NULL,NULL,'',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `tb_paciente` ENABLE KEYS */;
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
