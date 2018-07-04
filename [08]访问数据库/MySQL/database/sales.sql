/*
Navicat MySQL Data Transfer
Date: 2018-05-26 16:33:54
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for product
-- ----------------------------
DROP TABLE IF EXISTS `product`;
CREATE TABLE `product` (
  `CODE` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Descript` varchar(255) DEFAULT NULL,
  `Numbers` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`CODE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of product
-- ----------------------------
INSERT INTO `product` VALUES ('9001', 'hello', null, '1');
INSERT INTO `product` VALUES ('9002', 'world', null, '2');
INSERT INTO `product` VALUES ('9003', 'xxx', null, '0');
