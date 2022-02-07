-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 01, 2022 at 09:54 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.4.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `myhotel`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `customerId` int(11) NOT NULL,
  `customerName` varchar(250) NOT NULL,
  `mobile` bigint(20) NOT NULL,
  `nationality` varchar(250) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `dateofbirth` varchar(50) NOT NULL,
  `idProof` varchar(250) NOT NULL,
  `address` varchar(350) NOT NULL,
  `checkin` varchar(250) NOT NULL,
  `checkout` varchar(250) DEFAULT NULL,
  `checkedout` varchar(250) NOT NULL DEFAULT 'No',
  `roomid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`customerId`, `customerName`, `mobile`, `nationality`, `gender`, `dateofbirth`, `idProof`, `address`, `checkin`, `checkout`, `checkedout`, `roomid`) VALUES
(1, 'Htet', 29928942, 'Myanamr', 'Female', '1/11/2010', '249942', 'Yangon', '1/11/2022', '1/16/2022', 'YES', 2),
(2, 'Win ', 981727271, 'Myanamr', 'Male', '1/11/2010', '293883', 'Yangon', '1/15/2022', '1/16/2022', 'YES', 3),
(3, 'htet', 223333, 'ksks', 'Male', '1/11/2022', '2222', 'dffw', '1/11/2022', '1/16/2022', 'YES', 2),
(5, 'htet', 20200, 'indian', 'Male', '1/11/2022', '12233', 'kfsfk', '1/11/2022', '1/18/2022', 'YES', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`customerId`),
  ADD KEY `roomid` (`roomid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `customerId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `customer`
--
ALTER TABLE `customer`
  ADD CONSTRAINT `customer_ibfk_1` FOREIGN KEY (`roomid`) REFERENCES `rooms` (`roomid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
