-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:4306
-- Generation Time: Oct 31, 2022 at 10:36 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sijin`
--

-- --------------------------------------------------------

--
-- Table structure for table `calculate`
--

CREATE TABLE `calculate` (
  `cal_code` int(5) NOT NULL,
  `menu_code` int(5) NOT NULL,
  `menu_name` varchar(20) NOT NULL,
  `ord_amount` int(2) NOT NULL,
  `menu_price` int(5) NOT NULL,
  `cal_amount` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `emp_code` int(5) NOT NULL,
  `emp_fname` varchar(20) NOT NULL,
  `emp_lname` varchar(20) NOT NULL,
  `emp_sex` varchar(20) NOT NULL,
  `emp_nation` varchar(20) NOT NULL,
  `emp_extraction` varchar(20) NOT NULL,
  `emp_birthday` datetime DEFAULT NULL,
  `emp_type` varchar(20) NOT NULL,
  `emp_hire` date NOT NULL,
  `emp_position` varchar(20) NOT NULL,
  `emp_salary` int(5) NOT NULL,
  `emp_add` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`emp_code`, `emp_fname`, `emp_lname`, `emp_sex`, `emp_nation`, `emp_extraction`, `emp_birthday`, `emp_type`, `emp_hire`, `emp_position`, `emp_salary`, `emp_add`) VALUES
(1000001, 'Phakpoom', 'Phonpaiboon', 'ชาย', 'ไทย', 'ไทย', '2000-11-02 00:00:00', 'full time', '2022-10-15', 'ลูกจ้าง', 30000, 'ห้อง 501 อาคารเลขที่ 15/132-133 หมู่ที่ 5 ต.คลองหนึ่ง อ.คลองหลวง จ.ปทุมธานี 12120');

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE `menu` (
  `menu_code` int(5) NOT NULL,
  `menu_name` varchar(50) NOT NULL,
  `menu_type` varchar(20) NOT NULL,
  `menu_material` varchar(50) NOT NULL,
  `menu_price` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `menu`
--

INSERT INTO `menu` (`menu_code`, `menu_name`, `menu_type`, `menu_material`, `menu_price`) VALUES
(1001, 'ปลาแซลม่อนแช่น้ำปลา', 'เมนูแนะนำ', '', 250),
(1002, 'ปลาพงราดซอสสับปะรด', 'เมนูแนะนำ ', '', 350),
(1003, 'ลาบแซลมอนสด ', 'เมนูแนะนำ ', '', 250),
(1004, 'ออเดิร์ฟรวม', 'เมนูแนะนำ ', '', 300),
(1005, 'ผัดฉ่าปลาคังกระทะร้อน', 'เมนูแนะนำ ', '', 220),
(1006, 'เนื้อเก๋าผัดฉ่ากระทะร้อน', 'เมนูแนะนำ ', '', 220),
(1007, 'ทะเลผัดฉ่ากระทะร้อน', 'เมนูแนะนำ ', '', 220),
(1008, 'เนื้อปลาคังลวกจิ้ม ', 'เมนูแนะนำ ', '', 220),
(1009, 'เนื้อปลาเก๋าลวกจิ้ม ', 'เมนูแนะนำ ', '', 220),
(1010, 'รวมมิตรทะเลลวกจิ้ม', 'เมนูแนะนำ ', '', 250),
(1011, 'กระเพาะปลาผัดแห้งเนื้อปู', 'เมนูแนะนำ ', '', 250),
(1012, 'กระเพาะปลา+เยื้อไผ่น้ำแดงเนื้อปู', 'เมนูแนะนำ ', '', 250),
(1013, 'ห่อหมกทะเลมะพร้าวอ่อน', 'เมนูแนะนำ ', '', 200),
(2001, 'กุ้งก้ามย่างลุยสวน', 'เมนูกุ้ง', '', 400),
(2002, 'กุ้งทะเลย่างลุยสวน', 'เมนูกุ้ง', '', 450),
(2003, 'กุ้งเล็กย่างลุยสวน', 'เมนูกุ้ง', '', 250),
(2004, 'กุ้งก้ามนึ่งนมสด', 'เมนูกุ้ง', '', 400),
(2005, 'กุ้งทะเลนึ่งนมสด', 'เมนูกุ้ง', '', 450),
(2006, 'กุ้งเล็กนึ่งนมสด', 'เมนูกุ้ง', '', 250),
(2007, 'กุ้งก้ามคั่วพริกเกลือกระเทียม', 'เมนูกุ้ง', '', 400),
(3001, 'ปลากะพงทอดน้ำปลา', 'เมนูปลา', '', 350),
(3002, 'ปลาทับทิมทอดน้ำปลา', 'เมนูปลา', '', 250),
(3003, 'ปลาช่อนทอดน้ำปลา', 'เมนูปลา', '', 280),
(3004, 'ปลากะพงทอดกระเทียม', 'เมนูปลา', '', 350),
(3005, 'ปลาทับทิมทอดกระเทียม', 'เมนูปลา', '', 250),
(3006, 'ปลาช่อนทอดกระเทียม', 'เมนูปลา', '', 280),
(3007, 'ปลากะพงผัดพริกไทยดำ', 'เมนูปลา', '', 350),
(3008, 'ปลาทับทิมผัดพริกไทยดำ', 'เมนูปลา', '', 250),
(3009, 'ปลาช่อนผัดพริกไทยดำ', 'เมนูปลา', '', 280),
(4001, 'ปูนิ่มทอดกระเทียมพริกไทย', 'เมนูปู', '', 350),
(4002, 'ปูนิ่มผัดผงกะหรี่', 'เมนูปู', '', 350),
(4003, 'ปูนิ่มผัดพริกไทยดำ', 'เมนูปู', '', 350),
(4004, 'ยำปูไข่ดอง', 'เมนูปู', '', 600),
(4005, 'เนื้อปูหลน', 'เมนูปู', '', 250),
(4006, 'เนื้อปูผัดผงกระหรี่', 'เมนูปู', '', 350),
(4007, 'เนื้อปูผัดพริกไทยดำ', 'เมนูปู', '', 350),
(5001, 'หอยนางรมทรงเครื่อง', 'เมนูหอย', '', 180),
(5002, 'หอยเชลล์ผัดฉ่ากระทะร้อน', 'เมนูหอย', '', 180),
(5003, 'หอยเชลล์ย่างเนย', 'เมนูหอย', '', 180),
(5004, 'หอยแครองลวก', 'เมนูหอย', '', 150),
(5005, 'หอยแครงเผา', 'เมนูหอย', '', 150),
(5006, 'หอยแมลงภู่อบหม้อดิน', 'เมนูหอย', '', 120),
(5007, 'ออส่วนหอยนางรม', 'เมนูหอย', '', 150),
(6001, 'หมึกไข่ย่าง', 'เมนูปลาหมึก', '', 250),
(6002, 'หมึกหอมย่าง', 'เมนูปลาหมึก', '', 250),
(6003, 'หมึกไข่ผัดกระเทียมโทน', 'เมนูปลาหมึก', '', 250),
(6004, 'ปลาหมึกผัดไข่เค็ม', 'เมนูปลาหมึก', '', 150),
(6005, 'ปลาหมึกผัดผงกระหรี่', 'เมนูปลาหมึก', '', 180),
(6006, 'หมึกไข่ทอดกระเทียม', 'เมนูปลาหมึก', '', 220),
(6007, 'หมึกไข่นึ่งมะนาว', 'เมนูปลาหมึก', '', 220),
(7001, 'ต้มยำกุ้งทะเล (แชบ๊วย)', 'เมนูต้ม', '', 450),
(7002, 'ต้มยำกุ้งกราม', 'เมนูต้ม', '', 400),
(7003, 'ต้มยำรวมมิตรทะเล', 'เมนูต้ม', '', 220),
(7004, 'ต้มยำกุ้งเล็ก+มันกุ้ง มะพร้าวอ่อน', 'เมนูต้ม', '', 220),
(8001, 'ส้มตำไหลบัวปูม้า', 'เมนูตำ/ยำ', '', 150),
(8002, 'ส้มตำปูม้า', 'เมนูตำ/ยำ', '', 150),
(9001, 'ยอดมะระแม้วไฟแดง', 'เมนูผัด', '', 80),
(9002, 'ยอดมะระแม้วผัดน้ำมันหอย', 'เมนูผัด', '', 80),
(9003, 'กระเฉดไฟแดง', 'เมนูผัด', '', 80),
(9004, 'ผักบุ้งไฟแดง', 'เมนูผัด', '', 80),
(10001, 'ปีกไก่ทอดน้ำปลา', 'เมนูทอด', '', 120),
(10002, 'ไก่บ้านทอดเกลือ', 'เมนูทอด', '', 120),
(11001, 'ข้าวผัดมันกุ้ง (เล็ก)', 'เมนูอาหารจานด่วน', '', 80),
(11002, 'ข้าวผัดมันกุ้ง (กลาง)', 'เมนูอาหารจานด่วน', '', 150),
(11003, 'ข้าวผัดมันกุ้ง (ใหญ่)', 'เมนูอาหารจานด่วน', '', 200),
(12001, 'น้ำโพลาลิส', 'เมนูเครื่องดื่ม', '', 20),
(12002, 'น้ำแข็ง (เล็ก)', 'เมนูเครื่องดื่ม', '', 30),
(12003, 'น้ำแข็ง (โถ)', 'เมนูเครื่องดื่ม', '', 60),
(12004, 'เอสลิตร', 'เมนูเครื่องดื่ม', '', 50),
(12005, 'เอส', 'เมนูเครื่องดื่ม', '', 25);

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

CREATE TABLE `order` (
  `tableNumber` int(9) NOT NULL,
  `ord_d` date NOT NULL,
  `ord_time` time NOT NULL,
  `tableName` varchar(15) NOT NULL,
  `numCustomer` int(11) NOT NULL,
  `ord_status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `order`
--

INSERT INTO `order` (`tableNumber`, `ord_d`, `ord_time`, `tableName`, `numCustomer`, `ord_status`) VALUES
(301022001, '2022-10-30', '06:36:17', 'กะชัง 6', 6, 'กำลังทำงานอยู่');

-- --------------------------------------------------------

--
-- Table structure for table `ordermenu`
--

CREATE TABLE `ordermenu` (
  `orderMenu_code` int(11) NOT NULL,
  `tableNumber` int(9) NOT NULL,
  `orderMenu_type` varchar(11) NOT NULL,
  `orderMenu_name` varchar(50) NOT NULL,
  `orderMenu_amt` int(3) NOT NULL,
  `orderMenu_price` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ordermenu`
--

INSERT INTO `ordermenu` (`orderMenu_code`, `tableNumber`, `orderMenu_type`, `orderMenu_name`, `orderMenu_amt`, `orderMenu_price`) VALUES
(31, 301022001, 'อาหาร', 'ปลาแซลม่อนแช่น้ำปลา', 1, 250),
(32, 301022001, 'อาหาร', 'ปลาพงราดซอสสับปะรด', 1, 350),
(33, 301022001, 'อาหาร', 'ออเดิร์ฟรวม', 1, 300),
(34, 301022001, 'อาหาร', 'กระเพาะปลาผัดแห้งเนื้อปู', 1, 250),
(35, 301022001, 'อาหาร', 'เนื้อปลาคังลวกจิ้ม ', 1, 220),
(36, 301022001, 'อาหาร', 'ผัดฉ่าปลาคังกระทะร้อน', 1, 220),
(37, 301022001, 'อาหาร', 'ต้มยำกุ้งกราม', 1, 400),
(38, 301022001, 'อาหาร', 'ต้มยำกุ้งเล็ก+มันกุ้ง มะพร้าวอ่อน', 1, 220),
(39, 301022001, 'เครื่องดื่ม', 'น้ำแข็ง (โถ)', 1, 60),
(40, 301022001, 'เครื่องดื่ม', 'น้ำแข็ง (เล็ก)', 1, 30),
(41, 301022001, 'เครื่องดื่ม', 'น้ำโพลาลิส', 1, 20);

-- --------------------------------------------------------

--
-- Table structure for table `table`
--

CREATE TABLE `table` (
  `table_code` int(3) NOT NULL,
  `table_zone` varchar(20) NOT NULL,
  `table_amount` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `table`
--

INSERT INTO `table` (`table_code`, `table_zone`, `table_amount`) VALUES
(1, 'หน้าเวที', 5);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` varchar(20) NOT NULL,
  `user_pass` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `user_pass`) VALUES
('1234', '1234'),
('jame', '1234'),
('jame1', '1234');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `calculate`
--
ALTER TABLE `calculate`
  ADD PRIMARY KEY (`cal_code`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`emp_code`);

--
-- Indexes for table `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`menu_code`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`tableNumber`);

--
-- Indexes for table `ordermenu`
--
ALTER TABLE `ordermenu`
  ADD PRIMARY KEY (`orderMenu_code`),
  ADD KEY `Test` (`tableNumber`);

--
-- Indexes for table `table`
--
ALTER TABLE `table`
  ADD PRIMARY KEY (`table_code`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `ordermenu`
--
ALTER TABLE `ordermenu`
  MODIFY `orderMenu_code` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `ordermenu`
--
ALTER TABLE `ordermenu`
  ADD CONSTRAINT `Test` FOREIGN KEY (`tableNumber`) REFERENCES `order` (`tableNumber`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
