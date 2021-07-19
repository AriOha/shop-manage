-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 19, 2021 at 10:25 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `shop`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `id` int(5) NOT NULL,
  `firstName` varchar(15) NOT NULL,
  `lastName` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`id`, `firstName`, `lastName`) VALUES
(3000, 'Niki', 'Jam'),
(3001, 'Rotem', 'Cohen'),
(3002, 'Jeff', 'Bazos'),
(3003, 'Roni', 'Daniel'),
(3004, 'Ari', 'Elasda'),
(3024, 'Dan', 'Bil');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `id` int(5) NOT NULL,
  `customerId` int(5) NOT NULL,
  `dateTime` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`id`, `customerId`, `dateTime`) VALUES
(11, 3003, '2021-07-17 01:08:24'),
(13, 3000, '2021-07-17 11:31:46'),
(14, 3001, '2021-07-17 11:33:54'),
(15, 3001, '2021-07-17 11:35:46'),
(16, 3000, '2021-07-17 11:36:25'),
(17, 3001, '2021-07-17 11:50:59'),
(18, 3001, '2021-07-17 12:00:07'),
(19, 3004, '2021-07-17 12:32:47'),
(20, 3004, '2021-07-17 12:32:52'),
(22, 3024, '2021-07-18 18:36:57'),
(23, 3002, '2021-07-19 22:08:26');

-- --------------------------------------------------------

--
-- Table structure for table `order_products`
--

CREATE TABLE `order_products` (
  `id` int(5) NOT NULL,
  `orderId` int(5) NOT NULL,
  `productId` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `order_products`
--

INSERT INTO `order_products` (`id`, `orderId`, `productId`) VALUES
(8, 11, 2000),
(9, 11, 2001),
(10, 11, 2003),
(11, 11, 2002),
(12, 11, 2004),
(15, 13, 2000),
(16, 13, 2001),
(17, 13, 2002),
(18, 14, 2000),
(19, 14, 2001),
(20, 14, 2002),
(22, 15, 2016),
(23, 15, 2014),
(24, 15, 2013),
(25, 15, 2012),
(26, 15, 2011),
(27, 15, 2010),
(28, 15, 2009),
(29, 15, 2008),
(30, 15, 2007),
(31, 15, 2006),
(32, 15, 2005),
(33, 15, 2004),
(34, 15, 2003),
(35, 15, 2002),
(36, 15, 2001),
(37, 15, 2000),
(38, 16, 2000),
(39, 16, 2001),
(40, 16, 2002),
(41, 16, 2003),
(42, 17, 2004),
(43, 17, 2006),
(44, 17, 2007),
(45, 18, 2004),
(46, 19, 2000),
(47, 19, 2001),
(48, 19, 2002),
(49, 20, 2000),
(50, 20, 2016),
(51, 20, 2013),
(52, 20, 2012),
(58, 22, 2014),
(59, 23, 2004),
(60, 23, 2010),
(61, 23, 2013),
(62, 23, 2011),
(63, 23, 2008),
(64, 23, 2027),
(65, 23, 2006);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `id` int(5) NOT NULL,
  `name` varchar(40) NOT NULL,
  `supplierId` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`id`, `name`, `supplierId`) VALUES
(2000, 'iPhone 13 Pro', 1003),
(2001, 'Samsung S21 Ultra', 1002),
(2002, 'Logitech Keyboard', 1000),
(2003, 'Logitec MX3', 1000),
(2004, 'Asus ROG 2021', 1000),
(2005, 'Lenovo Yoga', 1000),
(2006, 'McBook 2020', 1003),
(2007, 'iPhone 12 Max', 1003),
(2008, 'Asus VivoBook 2019', 1001),
(2009, 'OnePlus 8', 1001),
(2010, 'Lenovo Yoga', 1001),
(2011, 'McBook 2018', 1001),
(2012, 'Dell Insperion 2020', 1002),
(2013, 'McBook Pro 2021', 1003),
(2014, 'iPad Pro 13', 1000),
(2016, 'Google Home', 1004),
(2027, 'McBook 2021', 1003);

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE `suppliers` (
  `id` int(5) NOT NULL,
  `name` varchar(50) NOT NULL,
  `address` varchar(60) NOT NULL,
  `phone` varchar(12) NOT NULL,
  `email` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`id`, `name`, `address`, `phone`, `email`) VALUES
(1000, 'KSP', 'Haifa', '555123654', 'supp@ksp.co.il'),
(1001, 'Ivory', 'Haifa', '048123654', 'supp@ivory.co.il'),
(1002, 'Bug', 'Tel-Aviv', '028123654', 'supp@bug.co.il'),
(1003, 'iDigital', 'Haifa', '048326598', 'store@idigital.com'),
(1004, 'Best Mobile', 'Kiryat Bialik', '0513265486', 'bestm@mobile.com'),
(1005, 'Ariel', 'City', '054664', 'a@aa.co.il');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`),
  ADD KEY `orders_to_customer` (`customerId`);

--
-- Indexes for table `order_products`
--
ALTER TABLE `order_products`
  ADD PRIMARY KEY (`id`),
  ADD KEY `order_products_to_orders` (`orderId`),
  ADD KEY `order_products_to_products` (`productId`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`),
  ADD KEY `product_to_supplier` (`supplierId`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3026;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `order_products`
--
ALTER TABLE `order_products`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2028;

--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1032;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_to_customer` FOREIGN KEY (`customerId`) REFERENCES `customers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `order_products`
--
ALTER TABLE `order_products`
  ADD CONSTRAINT `order_products_to_orders` FOREIGN KEY (`orderId`) REFERENCES `orders` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `order_products_to_products` FOREIGN KEY (`productId`) REFERENCES `products` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `product_to_supplier` FOREIGN KEY (`supplierId`) REFERENCES `suppliers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
