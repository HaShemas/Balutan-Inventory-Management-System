-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 08, 2023 at 12:12 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `balutan2`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `All_Products` ()  BEGIN
SELECT product_tbl.*,user_tbl.username FROM `product_tbl` INNER JOIN user_tbl ON product_tbl.user_id = user_tbl.user_id;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Stand-in structure for view `display_data`
-- (See below for the actual view)
--
CREATE TABLE `display_data` (
`product_id` int(11)
,`pname` text
,`des` text
,`sku` text
,`price` double
,`cost` double
,`category` text
,`type` text
,`status` text
);

-- --------------------------------------------------------

--
-- Table structure for table `product_tbl`
--

CREATE TABLE `product_tbl` (
  `product_id` int(11) NOT NULL,
  `pname` text NOT NULL,
  `des` text NOT NULL,
  `sku` text NOT NULL,
  `price` double NOT NULL,
  `cost` double NOT NULL,
  `category` text NOT NULL,
  `type` text NOT NULL,
  `status` text NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product_tbl`
--

INSERT INTO `product_tbl` (`product_id`, `pname`, `des`, `sku`, `price`, `cost`, `category`, `type`, `status`, `user_id`) VALUES
(1, 'fries', 'qwe', '123', 12, 11, 'Protein', 'Inventory', 'Disabled', 1),
(2, 'pizza', 'gdsfsdf', '33', 23, 12, 'Protein', 'Inventory', 'Inactive', 1),
(3, 'sda', 'gfhfghfgh', '777', 44, 33, 'Protein', 'Service', 'Active', 2),
(4, 'skemb', 'ambot', '9999', 222, 23, 'Protein', 'Inventory', 'Active', 1),
(5, 'ambot', 'qweqwe', '6565', 222, 12, 'Protein', 'Inventory', 'Active', 1);

-- --------------------------------------------------------

--
-- Table structure for table `usertype_tbl`
--

CREATE TABLE `usertype_tbl` (
  `usertype_id` int(11) NOT NULL,
  `type` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `usertype_tbl`
--

INSERT INTO `usertype_tbl` (`usertype_id`, `type`) VALUES
(1, 'Admin'),
(2, 'Warehouse User');

-- --------------------------------------------------------

--
-- Table structure for table `user_tbl`
--

CREATE TABLE `user_tbl` (
  `user_id` int(11) NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL,
  `fname` text NOT NULL,
  `lname` text NOT NULL,
  `usertype_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_tbl`
--

INSERT INTO `user_tbl` (`user_id`, `username`, `password`, `fname`, `lname`, `usertype_id`) VALUES
(1, 'admin', 'admin', 'Jeb', 'Jumilla', 1),
(2, 'skam', 'skam', 'skam', 'skam', 0),
(3, 'aw', 'aw', 'sa', 'sa', 0);

-- --------------------------------------------------------

--
-- Structure for view `display_data`
--
DROP TABLE IF EXISTS `display_data`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `display_data`  AS SELECT `product_tbl`.`product_id` AS `product_id`, `product_tbl`.`pname` AS `pname`, `product_tbl`.`des` AS `des`, `product_tbl`.`sku` AS `sku`, `product_tbl`.`price` AS `price`, `product_tbl`.`cost` AS `cost`, `product_tbl`.`category` AS `category`, `product_tbl`.`type` AS `type`, `product_tbl`.`status` AS `status` FROM (`product_tbl` join `user_tbl` on(`product_tbl`.`user_id` = `user_tbl`.`user_id`)) WHERE `product_tbl`.`status` = 'Active' OR `product_tbl`.`status` = 'Inactive' ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `product_tbl`
--
ALTER TABLE `product_tbl`
  ADD PRIMARY KEY (`product_id`),
  ADD UNIQUE KEY `sku` (`sku`) USING HASH;

--
-- Indexes for table `usertype_tbl`
--
ALTER TABLE `usertype_tbl`
  ADD PRIMARY KEY (`usertype_id`);

--
-- Indexes for table `user_tbl`
--
ALTER TABLE `user_tbl`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`) USING HASH;

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `product_tbl`
--
ALTER TABLE `product_tbl`
  MODIFY `product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `usertype_tbl`
--
ALTER TABLE `usertype_tbl`
  MODIFY `usertype_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `user_tbl`
--
ALTER TABLE `user_tbl`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
