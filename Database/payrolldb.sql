-- MySQL dump 10.13  Distrib 9.1.0, for Win64 (x86_64)
--
-- Host: localhost    Database: payrolldb
-- ------------------------------------------------------
-- Server version	9.1.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `complaint_reviews`
--

DROP TABLE IF EXISTS `complaint_reviews`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `complaint_reviews` (
  `review_id` int NOT NULL AUTO_INCREMENT,
  `complaint_id` int NOT NULL,
  `reviewed_by_role` varchar(50) NOT NULL,
  `remarks` text NOT NULL,
  `reviewed_at` datetime DEFAULT CURRENT_TIMESTAMP,
  `visible_to_employee` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`review_id`),
  KEY `complaint_id` (`complaint_id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `complaint_reviews`
--

LOCK TABLES `complaint_reviews` WRITE;
/*!40000 ALTER TABLE `complaint_reviews` DISABLE KEYS */;
INSERT INTO `complaint_reviews` VALUES (1,3,'HR','1','2025-12-15 19:38:14',0),(2,4,'HR','bobo','2025-12-15 20:56:27',0),(3,4,'HR','bobo','2025-12-15 20:56:34',0),(4,4,'HR','bobo','2025-12-15 20:58:53',0),(5,4,'HR','bobo','2025-12-15 21:23:12',0),(6,4,'HR','haha','2025-12-15 21:51:37',0),(7,5,'HR','bobo','2025-12-15 22:55:53',0);
/*!40000 ALTER TABLE `complaint_reviews` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `complaints`
--

DROP TABLE IF EXISTS `complaints`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `complaints` (
  `complaint_id` int NOT NULL AUTO_INCREMENT,
  `employee_id` int NOT NULL,
  `subject` varchar(255) NOT NULL,
  `description` text NOT NULL,
  `type` varchar(50) DEFAULT NULL,
  `status` varchar(50) DEFAULT 'Pending',
  `filed_at` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`complaint_id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `complaints`
--

LOCK TABLES `complaints` WRITE;
/*!40000 ALTER TABLE `complaints` DISABLE KEYS */;
INSERT INTO `complaints` VALUES (1,1,'buang','ahh',NULL,'In Progress','2025-12-15 17:59:34'),(2,1,'sf','ffff',NULL,'Pending','2025-12-15 18:18:25'),(3,1,'h','fFFF',NULL,'In Progress','2025-12-15 18:28:29'),(4,1,'hatodg','hahaha new','Payroll','Forwarded to Admin','2025-12-15 19:42:47'),(5,1,'Ha','dadaff','Work','Resolved','2025-12-15 22:46:13'),(6,3,'sd','addd','Work','Pending','2025-12-16 00:06:22');
/*!40000 ALTER TABLE `complaints` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee_log`
--

DROP TABLE IF EXISTS `employee_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee_log` (
  `attendance_id` int NOT NULL AUTO_INCREMENT,
  `employee_id` int NOT NULL,
  `time_in` datetime NOT NULL,
  `time_out` datetime NOT NULL,
  `total_hours` decimal(5,2) DEFAULT NULL,
  `overtime_hours` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`attendance_id`),
  KEY `employee_id` (`employee_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_log`
--

LOCK TABLES `employee_log` WRITE;
/*!40000 ALTER TABLE `employee_log` DISABLE KEYS */;
/*!40000 ALTER TABLE `employee_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `employee_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) DEFAULT NULL,
  `last_name` varchar(50) DEFAULT NULL,
  `age` int DEFAULT NULL,
  `address` text,
  `gender` varchar(10) DEFAULT NULL,
  `city` varchar(50) DEFAULT NULL,
  `date_of_birth` datetime NOT NULL,
  `civil_status` varchar(20) DEFAULT NULL,
  `mobile` varchar(15) DEFAULT NULL,
  `zip_code` varchar(10) DEFAULT NULL,
  `mother_name` varchar(100) DEFAULT NULL,
  `mother_occupation` varchar(100) DEFAULT NULL,
  `father_name` varchar(100) DEFAULT NULL,
  `father_occupation` varchar(100) DEFAULT NULL,
  `salary` decimal(10,2) DEFAULT NULL,
  `position` varchar(50) DEFAULT NULL,
  `department` varchar(100) NOT NULL,
  `date_hired` datetime NOT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(255) NOT NULL,
  `image_path` varchar(255) DEFAULT NULL,
  `account_type` varchar(20) DEFAULT NULL,
  `employee_type` varchar(255) DEFAULT NULL,
  `role` varchar(255) DEFAULT NULL,
  `image_data` longblob,
  PRIMARY KEY (`employee_id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (1,'jl','jl',18,'dhdh','m','dhdhdhd','2005-08-13 00:00:00','m','111111111111','1234','ma','afsfsf','wa','gggsg',15000.00,'Assistant','IT','2025-12-11 00:00:00','jl','$2a$11$af71.xnlyPYUQDC.QMkaHuI6SU/dM1963LM1miZJ9RnHOjQs9Z7bG','C:\\Users\\alyxz\\OneDrive\\Desktop\\PAYROLL SYSTEM - Copy\\JamesLoyd\\JamesLoyd\\bin\\Debug\\net8.0-windows\\\\employee_images\\emp_639010858828174900.jpg',NULL,'Fulltime','Employee',NULL),(2,'mama','aa',0,'s','gsg','gsgg','2005-03-04 00:00:00','hdg','111111111111','334343','fsfffsfsf','fs','fs','sfsf',15000.00,'hotdog','it','2025-12-11 19:45:06','aa','','','Staff','contract','Employee',NULL),(3,'ha','ff',445,'fgd','gg','dgd','2025-03-06 00:00:00','singdad','123','gg','ddad','gfgg','fafafdsf','g',15000.00,'Assistant','It','2025-12-16 00:04:25','ha','$2a$11$2x3zu2zrrNuvuZCsySQ/HeZBd1UFQoj/fsxXUwGUXBbQK87.9Wa6i','C:\\Users\\alyxz\\OneDrive\\Desktop\\PAYROLL SYSTEM - Copy\\JamesLoyd\\JamesLoyd\\bin\\Debug\\net8.0-windows\\\\employee_images\\emp_639014403218976848.jpg','Staff','full time','Employee',NULL),(4,'James','Tapdasan',20,'Naga','M','Naga','2025-12-16 00:00:00','Single','09876543211','1345','Mama','None','Papa','None',34000.00,'Accountant','Finance','2025-12-16 00:00:00','james','$2a$11$K5zWM3qgUCn/jvfwAlpxy.XX/hZCg1aJWmMqmyfadW7lIi7mtglui','Images/EmployeePics\\4.jpg',NULL,'Full-Time','Employee',NULL);
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payroll`
--

DROP TABLE IF EXISTS `payroll`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payroll` (
  `payroll_id` int NOT NULL AUTO_INCREMENT,
  `employee_id` int NOT NULL,
  `period_start` date DEFAULT NULL,
  `period_end` date DEFAULT NULL,
  `basic_pay` decimal(10,2) DEFAULT NULL,
  `overtime_pay` decimal(10,2) DEFAULT NULL,
  `absences` int DEFAULT NULL,
  `sss` decimal(10,2) DEFAULT NULL,
  `philhealth` decimal(10,2) DEFAULT NULL,
  `pagibig` decimal(10,2) DEFAULT NULL,
  `gross_pay` decimal(10,2) DEFAULT NULL,
  `net_pay` decimal(10,2) DEFAULT NULL,
  `date_generated` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`payroll_id`),
  UNIQUE KEY `unique_employee_period` (`employee_id`,`period_start`,`period_end`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payroll`
--

LOCK TABLES `payroll` WRITE;
/*!40000 ALTER TABLE `payroll` DISABLE KEYS */;
INSERT INTO `payroll` VALUES (1,1,'2025-12-01','2025-12-31',15000.00,0.00,21,500.00,350.00,200.00,15000.00,-368.18,'2025-12-17 10:07:03');
/*!40000 ALTER TABLE `payroll` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prepared_payroll`
--

DROP TABLE IF EXISTS `prepared_payroll`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prepared_payroll` (
  `prepared_id` int NOT NULL AUTO_INCREMENT,
  `employee_id` int NOT NULL,
  `period_start` date NOT NULL,
  `period_end` date NOT NULL,
  `basic_pay` decimal(10,2) NOT NULL,
  `overtime_pay` decimal(10,2) NOT NULL,
  `absences` int NOT NULL,
  `sss` decimal(10,2) DEFAULT NULL,
  `philhealth` decimal(10,2) DEFAULT NULL,
  `pagibig` decimal(10,2) DEFAULT NULL,
  `gross_pay` decimal(10,2) NOT NULL,
  `net_pay` decimal(10,2) NOT NULL,
  `status` enum('Pending','Approved') DEFAULT 'Pending',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`prepared_id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prepared_payroll`
--

LOCK TABLES `prepared_payroll` WRITE;
/*!40000 ALTER TABLE `prepared_payroll` DISABLE KEYS */;
INSERT INTO `prepared_payroll` VALUES (1,1,'2025-12-01','2025-12-31',15000.00,0.00,21,500.00,350.00,200.00,15000.00,-368.18,'Approved','2025-12-17 02:06:38'),(2,1,'2025-12-01','2025-12-31',15000.00,0.00,21,500.00,350.00,200.00,15000.00,-368.18,'Pending','2025-12-17 02:07:23'),(3,1,'2025-12-01','2025-12-31',15000.00,0.00,21,500.00,350.00,200.00,15000.00,-368.18,'Pending','2025-12-17 02:08:13'),(4,1,'2025-12-01','2025-12-31',16000.00,0.00,21,500.00,350.00,200.00,15000.00,-368.18,'Pending','2025-12-17 02:08:15');
/*!40000 ALTER TABLE `prepared_payroll` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `time_logs`
--

DROP TABLE IF EXISTS `time_logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `time_logs` (
  `id` int NOT NULL AUTO_INCREMENT,
  `employee_id` int NOT NULL,
  `date` date NOT NULL,
  `shift_type` enum('Morning','Afternoon') DEFAULT NULL,
  `time_in` datetime DEFAULT NULL,
  `time_out` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `employee_id` (`employee_id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `time_logs`
--

LOCK TABLES `time_logs` WRITE;
/*!40000 ALTER TABLE `time_logs` DISABLE KEYS */;
INSERT INTO `time_logs` VALUES (1,1,'2025-12-15','Afternoon','2025-12-15 23:49:10','2025-12-15 23:49:12'),(2,4,'2025-12-16','Morning','2025-12-16 07:46:04','2025-12-16 11:50:27'),(3,4,'2025-12-16','Afternoon','2025-12-16 13:00:49','2025-12-16 22:11:00');
/*!40000 ALTER TABLE `time_logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `role` enum('Admin','Employee','HR','Staff') NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (2,'employee1','employee123','Employee'),(5,'admin','$2a$11$8u03KnNVNpX3vYE.F01gY./VmzxX5PDPC0Lt24V7yuLUK.Z8CV2l6','Admin'),(8,'staff','$2b$12$IdCbrncvUqmr0L98w1sRw.WyNUUI9CdsrOXouFz9239uzzCnJbYfy','Staff');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-08-06 19:21:50
