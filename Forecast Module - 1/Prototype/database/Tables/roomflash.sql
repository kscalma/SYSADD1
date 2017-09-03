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
-- Table structure for table `roomflash`
--

CREATE TABLE `roomflash` (
  `id` int(11) NOT NULL,
  `roomOtherActual` float NOT NULL,
  `roomAvailableActual` float NOT NULL,
  `roomIndividualLF` float NOT NULL,
  `roomGroupLF` float NOT NULL,
  `roomOtherLF` float NOT NULL,
  `roomAvailableLF` float NOT NULL,
  `roomSoldLF` float NOT NULL,
  `roomIndividualBudget` float NOT NULL,
  `roomGroupBudget` float NOT NULL,
  `roomOtherBudget` float NOT NULL,
  `roomAvailableBudget` float NOT NULL,
  `roomSoldBudget` float NOT NULL,
  `roomIndividualLY` float NOT NULL,
  `roomGroupLY` float NOT NULL,
  `roomOtherLY` float NOT NULL,
  `roomAvailableLY` float NOT NULL,
  `roomSoldLY` float NOT NULL,
  `roomRevenueActual` float NOT NULL,
  `roomIndividualActual` float NOT NULL,
  `roomGroupActual` float NOT NULL,
  `roomSoldActual` float NOT NULL,
  `occupancyActual` float NOT NULL,
  `adrActual` float NOT NULL,
  `roomRevParActual` float NOT NULL,
  `roomRevenueLF` float NOT NULL,
  `occupancyLF` float NOT NULL,
  `adrLF` float NOT NULL,
  `roomRevParLF` float NOT NULL,
  `roomRevenueBudget` float NOT NULL,
  `occupancyBudget` float NOT NULL,
  `adrBudget` float NOT NULL,
  `roomRevParBudget` float NOT NULL,
  `roomRevenueLY` float NOT NULL,
  `occupancyLY` float NOT NULL,
  `adrLY` float NOT NULL,
  `roomRevParLY` float NOT NULL,
  `roomRevenueVVB` float NOT NULL,
  `roomIndividualVVB` float NOT NULL,
  `roomGroupVVB` float NOT NULL,
  `roomOtherVVB` float NOT NULL,
  `roomAvailableVVB` float NOT NULL,
  `roomSoldVVB` float NOT NULL,
  `occupancyVVB` float NOT NULL,
  `adrVVB` float NOT NULL,
  `roomRevParVVB` float NOT NULL,
  `roomRevenueVVLY` float NOT NULL,
  `roomIndividualVVLY` float NOT NULL,
  `roomGroupVVLY` float NOT NULL,
  `roomOtherVVLY` float NOT NULL,
  `roomAvailableVVLY` float NOT NULL,
  `roomSoldVVLY` float NOT NULL,
  `occupancyVVLY` float NOT NULL,
  `adrVVLY` float NOT NULL,
  `roomRevParVVLY` float NOT NULL,
  `monthYear_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `roomflash`
--
ALTER TABLE `roomflash`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_roomFlash_monthYear1_idx` (`monthYear_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `roomflash`
--
ALTER TABLE `roomflash`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `roomflash`
--
ALTER TABLE `roomflash`
  ADD CONSTRAINT `fk_roomFlash_monthYear1` FOREIGN KEY (`monthYear_id`) REFERENCES `monthyear` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
