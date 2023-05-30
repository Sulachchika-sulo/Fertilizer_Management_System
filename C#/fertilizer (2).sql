-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 03, 2022 at 05:17 AM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fertilizer`
--

-- --------------------------------------------------------

--
-- Table structure for table `billing`
--

CREATE TABLE `billing` (
  `BillNo` int(10) NOT NULL,
  `PLR` int(6) NOT NULL,
  `Fertilizer` varchar(200) NOT NULL,
  `Season` varchar(6) NOT NULL,
  `Date` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `billing`
--

INSERT INTO `billing` (`BillNo`, `PLR`, `Fertilizer`, `Season`, `Date`) VALUES
(2, 1002, 'F_Name', 'Maha', '24/7/2022'),
(15, 5446, '', 'Maha', '31/7/2022'),
(16, 5446, '', 'Maha', '31/7/2022'),
(17, 5446, '', 'Maha', '31/7/2022'),
(18, 5446, '', 'Maha', '8/2/2022');

-- --------------------------------------------------------

--
-- Table structure for table `farmer`
--

CREATE TABLE `farmer` (
  `PLR` int(6) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `NIC` varchar(12) DEFAULT NULL,
  `Perches` int(5) DEFAULT NULL,
  `Address` varchar(50) NOT NULL,
  `Continent` varchar(20) DEFAULT NULL,
  `Tell_No` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `farmer`
--

INSERT INTO `farmer` (`PLR`, `Name`, `NIC`, `Perches`, `Address`, `Continent`, `Tell_No`) VALUES
(201, 'gfhfgh', 'fhgh', 5, 'fghgfhg', 'ghghgf', '564646464'),
(220, 'Sree', '6114444444', 2, 'Vantb, Chen', 'Palllathuveli', '9777777777'),
(1000, 'cxvcx', 'xcvcxv', 1, 'xcvcx', 'xcvcx', '54542'),
(1002, 'gayu', '215464', 1, 'dsfdgfdfrertgfgdfvd', 'sdcs', '12454125'),
(5446, 'dfgfdg', 'fghfhfgh', 45, 'fdgfdgfdgfdg', 'fgfdgfd', ''),
(54545, 'dfgfdgf', 'fgdgdg', 5454, 'fdgfdgfdgd', 'fdgfdg', '454545');

-- --------------------------------------------------------

--
-- Table structure for table `ferti`
--

CREATE TABLE `ferti` (
  `F_Id` varchar(10) NOT NULL,
  `F_Name` varchar(30) NOT NULL,
  `kg` int(5) NOT NULL,
  `liter` int(5) NOT NULL,
  `Date` varchar(10) NOT NULL,
  `Description` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ferti`
--

INSERT INTO `ferti` (`F_Id`, `F_Name`, `kg`, `liter`, `Date`, `Description`) VALUES
('1000', 'gfhfghf', 50, 0, '8/2/2022', ''),
('1002', 'gayu', 0, 5, '24/7/2022', 'fddfgdgfgfgf'),
('1005', 'lkll', 0, 25, '28/7/2022', ''),
('dfgfd', 'fdgfg', 0, 54, '31/7/2022', ''),
('fdgfdg', 'gfgfg', 545, 0, '31/7/2022', ''),
('fe/100', 'cccc', 5, 0, '21/7/2022', 'dfd'),
('fe/10020', 'fghgfhgf(liter) ', 0, 2, '29/7/2022', 'bcfgdhggfhgf'),
('fe/1005', 'vcv', 0, 0, '13/7/2022', 'cxvcxj'),
('fe/22/1001', 'Compost', 400, 0, '2022-07-08', ''),
('Fert3', 'Uria3', 3200, 0, '31/7/2022', 'bbbbb'),
('fgfg', 'fgfgfg', 5454, 4545, '31/7/2022', ''),
('fghfhf', 'hgfhfg', 50, 0, '8/2/2022', ''),
('fhgfh', 'gfhgfh', 0, 0, '31/7/2022', ''),
('fhgfhee', 'rtrt', 565, 556, '31/7/2022', ''),
('ggfh', 'ghgfh', 54, 0, '31/7/2022', ''),
('ghfhf', 'fhgh', 454, 0, '31/7/2022', ''),
('trtret', 'ertrter', 5454, 0, '31/7/2022', ''),
('U1', 'Uria', 0, 0, '31/7/2022', ''),
('U2', 'Uria2', 2500, 556, '31/7/2022', 'aaaaa');

-- --------------------------------------------------------

--
-- Table structure for table `sea`
--

CREATE TABLE `sea` (
  `sid` varchar(10) NOT NULL,
  `sname` varchar(30) NOT NULL,
  `season` varchar(10) NOT NULL,
  `qty` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sea`
--

INSERT INTO `sea` (`sid`, `sname`, `season`, `qty`) VALUES
('10010', 'dhfghg(kg) ', 'Maha', 1),
('1002', 'gayu', 'Maha', 6),
('1005', 'lkll', 'Maha', 7),
('dfgfd', 'fdgfg', 'Maha', 4);

-- --------------------------------------------------------

--
-- Table structure for table `taxt`
--

CREATE TABLE `taxt` (
  `No` int(11) NOT NULL,
  `PLR` int(6) NOT NULL,
  `Date` date NOT NULL,
  `tax` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `taxt`
--

INSERT INTO `taxt` (`No`, `PLR`, `Date`, `tax`) VALUES
(4, 5446, '2022-07-31', 410),
(5, 5446, '2022-08-02', 50),
(6, 5446, '2022-08-02', 600),
(7, 5446, '2022-08-02', 50),
(8, 5446, '2022-08-02', 200),
(9, 5446, '2022-08-02', 60);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `Uname` varchar(30) NOT NULL,
  `Password` varchar(5) NOT NULL,
  `Type` varchar(10) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `E_pw` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`Uname`, `Password`, `Type`, `Email`, `E_pw`) VALUES
('ffghfg', 'dfgfh', 'User', 'fghfgh', 'hhfg'),
('raja', '852', 'user', 'abc', '123'),
('raji', '456', 'Admin', 'dfgdgfd', '456'),
('sfdgg', 'sgffd', 'Admin', 'sdgfdg', 'sgfg'),
('sfdsf', 'sdfds', 'Admin', 'sdfdsf', 'sdff'),
('sulo', '852', 'Admin', 'dfdgfdgfgfg', '123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `billing`
--
ALTER TABLE `billing`
  ADD PRIMARY KEY (`BillNo`),
  ADD KEY `PLR` (`PLR`);

--
-- Indexes for table `farmer`
--
ALTER TABLE `farmer`
  ADD PRIMARY KEY (`PLR`);

--
-- Indexes for table `ferti`
--
ALTER TABLE `ferti`
  ADD PRIMARY KEY (`F_Id`);

--
-- Indexes for table `sea`
--
ALTER TABLE `sea`
  ADD PRIMARY KEY (`sid`);

--
-- Indexes for table `taxt`
--
ALTER TABLE `taxt`
  ADD PRIMARY KEY (`No`),
  ADD KEY `PLR` (`PLR`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`Uname`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `billing`
--
ALTER TABLE `billing`
  MODIFY `BillNo` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `farmer`
--
ALTER TABLE `farmer`
  MODIFY `PLR` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54546;
--
-- AUTO_INCREMENT for table `taxt`
--
ALTER TABLE `taxt`
  MODIFY `No` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `billing`
--
ALTER TABLE `billing`
  ADD CONSTRAINT `billing_ibfk_1` FOREIGN KEY (`PLR`) REFERENCES `farmer` (`PLR`);

--
-- Constraints for table `taxt`
--
ALTER TABLE `taxt`
  ADD CONSTRAINT `taxt_ibfk_1` FOREIGN KEY (`PLR`) REFERENCES `farmer` (`PLR`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
