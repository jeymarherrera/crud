-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 09, 2022 at 02:29 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sistema_registros`
--

-- --------------------------------------------------------

--
-- Table structure for table `contacto`
--

CREATE TABLE `contacto` (
  `identificacion` varchar(45) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  `fecha_nac` date NOT NULL,
  `genero` varchar(45) NOT NULL,
  `telefono` varchar(45) NOT NULL,
  `direccion` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `contacto`
--

INSERT INTO `contacto` (`identificacion`, `nombre`, `apellido`, `fecha_nac`, `genero`, `telefono`, `direccion`) VALUES
('12', 'dfg', 'gdf', '2000-12-12', 'Femenino', '1212', 'asdasd'),
('324', 'fdg', 'gfdg', '2000-12-12', 'Femenino', '3423', 'dsfd');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `contacto`
--
ALTER TABLE `contacto`
  ADD PRIMARY KEY (`identificacion`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
