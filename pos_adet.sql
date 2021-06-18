-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 18, 2021 at 03:42 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pos_adet`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `item_add` (IN `code` INT, IN `name` VARCHAR(255), IN `price` FLOAT, IN `qty` INT, IN `photo` VARCHAR(255))  BEGIN
    INSERT INTO `item_catalog` (`code`, `name`, `price`, `qty`,`photo`) VALUES (code, name, price, qty, photo);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `item_view_all` ()  BEGIN
	SELECT * FROM item_catalog;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `item_catalog`
--

CREATE TABLE `item_catalog` (
  `code` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `price` float NOT NULL,
  `qty` int(11) NOT NULL,
  `photo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `item_catalog`
--

INSERT INTO `item_catalog` (`code`, `name`, `price`, `qty`, `photo`) VALUES
(1, 'Iphone 12 Pro Max', 120000, 1, 'https://www.dropbox.com/s/0ovuj757epla906/Iphone%2012%20Pro%20Max.png?dl=0'),
(696969, 'stupid ass face', 69000, 1, 'https://www.dropbox.com/s/ohd4psyfz9bn2e6/stupid%20ass%20face.png?dl=0'),
(423432432, 'Stupid Cunt', 69000, 1, 'https://www.dropbox.com/s/87v7ak9cyzfrw9p/Stupid%20Cunt.png?dl=0');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `item_catalog`
--
ALTER TABLE `item_catalog`
  ADD PRIMARY KEY (`code`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `item_catalog`
--
ALTER TABLE `item_catalog`
  MODIFY `code` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2147483648;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
