/*
Navicat MySQL Data Transfer

Date: 2018-05-29 19:30:02
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for cms_article
-- ----------------------------
DROP TABLE IF EXISTS `cms_article`;
CREATE TABLE `cms_article` (
  `ID` varchar(20) NOT NULL COMMENT '编号',
  `ColumnID` varchar(20) NOT NULL COMMENT '所属栏目编码',
  `Title` varchar(255) NOT NULL COMMENT '标题',
  `Content` varchar(2550) NOT NULL COMMENT '内容',
  `AuthorID` varchar(255) NOT NULL COMMENT '作者，必须在用户表中选择',
  `AuthorName` varchar(255) NOT NULL,
  `PostTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '发布日期',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='文章信息表';

-- ----------------------------
-- Records of cms_article
-- ----------------------------
INSERT INTO `cms_article` VALUES ('A0001', 'C001', 'JAVA入门', 'JAVA入门。。。', 'U001', '张帅', '2018-05-29 17:12:50');
INSERT INTO `cms_article` VALUES ('A0002', 'C001', 'NET Core电子书', 'NET Core电子书...', 'U002', '里斯', '2018-05-29 17:12:50');
INSERT INTO `cms_article` VALUES ('A0003', 'C001', 'JAVA进阶', 'JAVA进阶...', 'U001', '张帅', '2018-05-29 17:12:50');
INSERT INTO `cms_article` VALUES ('B0004', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0005', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0006', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0007', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0008', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0009', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0010', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0011', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0012', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0013', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0014', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0015', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0016', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0017', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0018', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0019', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0020', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0021', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0022', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0023', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0024', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0025', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0026', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:44');
INSERT INTO `cms_article` VALUES ('B0027', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:45');
INSERT INTO `cms_article` VALUES ('B0028', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:45');
INSERT INTO `cms_article` VALUES ('B0029', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:45');
INSERT INTO `cms_article` VALUES ('B0030', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:45');
INSERT INTO `cms_article` VALUES ('B0031', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:45');
INSERT INTO `cms_article` VALUES ('B0032', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:45');
INSERT INTO `cms_article` VALUES ('B0033', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:45');
INSERT INTO `cms_article` VALUES ('B0034', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:45');
INSERT INTO `cms_article` VALUES ('B0035', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:45');
INSERT INTO `cms_article` VALUES ('B0036', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:45');
INSERT INTO `cms_article` VALUES ('B0037', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:45');
INSERT INTO `cms_article` VALUES ('B0038', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:46');
INSERT INTO `cms_article` VALUES ('B0039', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:46');
INSERT INTO `cms_article` VALUES ('B0040', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:46');
INSERT INTO `cms_article` VALUES ('B0041', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:46');
INSERT INTO `cms_article` VALUES ('B0042', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:46');
INSERT INTO `cms_article` VALUES ('B0043', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:46');
INSERT INTO `cms_article` VALUES ('B0044', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:46');
INSERT INTO `cms_article` VALUES ('B0045', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:46');
INSERT INTO `cms_article` VALUES ('B0046', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:46');
INSERT INTO `cms_article` VALUES ('B0047', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:46');
INSERT INTO `cms_article` VALUES ('B0048', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:46');
INSERT INTO `cms_article` VALUES ('B0049', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:46');
INSERT INTO `cms_article` VALUES ('B0050', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:46');
INSERT INTO `cms_article` VALUES ('B0051', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0052', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0053', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0054', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0055', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0056', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0057', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0058', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0059', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0060', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0061', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0062', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0063', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0064', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0065', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0066', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0067', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0068', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0069', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0070', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0071', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0072', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0073', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0074', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0075', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0076', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:47');
INSERT INTO `cms_article` VALUES ('B0077', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0078', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0079', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0080', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0081', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0082', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0083', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0084', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0085', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0086', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0087', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0088', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0089', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0090', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0091', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0092', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0093', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0094', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0095', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0096', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0097', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0098', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0099', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0100', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0101', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0102', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0103', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0104', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0105', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0106', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0107', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0108', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0109', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0110', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0111', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0112', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0113', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0114', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:48');
INSERT INTO `cms_article` VALUES ('B0115', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0116', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0117', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0118', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0119', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0120', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0121', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0122', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0123', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0124', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0125', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0126', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0127', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0128', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0129', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0130', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0131', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0132', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0133', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0134', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0135', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0136', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0137', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0138', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0139', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0140', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0141', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0142', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0143', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0144', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0145', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0146', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0147', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0148', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0149', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0150', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0151', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0152', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0153', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:49');
INSERT INTO `cms_article` VALUES ('B0154', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0155', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0156', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0157', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0158', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0159', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0160', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0161', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0162', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0163', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0164', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0165', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0166', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0167', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0168', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0169', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0170', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0171', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0172', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0173', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0174', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0175', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0176', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0177', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0178', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0179', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');
INSERT INTO `cms_article` VALUES ('B0180', 'C002', '1001', '11001', 'U003', 'CS', '2018-05-29 19:25:50');

-- ----------------------------
-- Table structure for cms_column
-- ----------------------------
DROP TABLE IF EXISTS `cms_column`;
CREATE TABLE `cms_column` (
  `ID` varchar(20) NOT NULL COMMENT '序号',
  `Name` varchar(255) NOT NULL COMMENT '栏目名称',
  `Description` varchar(255) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='栏目信息表';

-- ----------------------------
-- Records of cms_column
-- ----------------------------
INSERT INTO `cms_column` VALUES ('C001', '电子书', '');
INSERT INTO `cms_column` VALUES ('C002', '笔记', '');
INSERT INTO `cms_column` VALUES ('C003', '资料', '');

-- ----------------------------
-- Table structure for sys_user
-- ----------------------------
DROP TABLE IF EXISTS `sys_user`;
CREATE TABLE `sys_user` (
  `UserID` varchar(255) NOT NULL COMMENT '用户ID',
  `Name` varchar(255) NOT NULL COMMENT '姓名',
  `TEL` varchar(255) NOT NULL COMMENT '电话',
  `loginname` varchar(255) DEFAULT NULL COMMENT '登陆名称',
  `password` varchar(255) DEFAULT NULL COMMENT '密码',
  `state` int(1) NOT NULL DEFAULT '1' COMMENT '状态：0-无效，1-有效',
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='用户信息表';

-- ----------------------------
-- Records of sys_user
-- ----------------------------
INSERT INTO `sys_user` VALUES ('U001', '张帅', '13305278122', 'zhangs', 'zs', '1');
INSERT INTO `sys_user` VALUES ('U002', '里斯', '13305149876', 'lis', 'ls', '1');
INSERT INTO `sys_user` VALUES ('U003', '测试', '13245678765', 'ches', 'cs', '1');
