-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Sep 01, 2017 at 02:53 AM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 7.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `advanceyii4`
--

-- --------------------------------------------------------

--
-- Table structure for table `roomsegmentation`
--

CREATE TABLE `roomsegmentation` (
  `id` int(11) NOT NULL,
  `roomType` varchar(45) NOT NULL,
  `actualRNS` float NOT NULL,
  `budgetRNS` float NOT NULL,
  `lastYearRNS` float NOT NULL,
  `actualARR` float NOT NULL,
  `budgetARR` float NOT NULL,
  `lastYearARR` float NOT NULL,
  `growthRateRNS` float NOT NULL,
  `growthRateARR` float NOT NULL,
  `actualR` float NOT NULL,
  `budgetR` float NOT NULL,
  `lastYearR` float NOT NULL,
  `growthRateR` float NOT NULL,
  `monthYear_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `roomsegmentation`
--
ALTER TABLE `roomsegmentation`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_roomSegmentation_monthYear_idx` (`monthYear_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `roomsegmentation`
--
ALTER TABLE `roomsegmentation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `roomsegmentation`
--
ALTER TABLE `roomsegmentation`
  ADD CONSTRAINT `fk_roomSegmentation_monthYear` FOREIGN KEY (`monthYear_id`) REFERENCES `monthyear` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
