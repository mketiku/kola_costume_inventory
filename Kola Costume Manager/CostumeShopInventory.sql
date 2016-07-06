-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 07, 2015 at 04:18 PM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `CostumeShopInventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `accessories`
--

CREATE TABLE IF NOT EXISTS `accessories` (
  `id` int(100) NOT NULL,
  `gender` varchar(6) DEFAULT NULL,
  `era` varchar(100) DEFAULT NULL,
  `materials` varchar(100) DEFAULT NULL,
  `hats_brim_size` varchar(100) DEFAULT NULL,
  `hats_type` varchar(100) DEFAULT NULL,
  `shoes_size` varchar(100) DEFAULT NULL,
  `shoes_heal_height` varchar(100) DEFAULT NULL,
  `shoes_style` varchar(100) DEFAULT NULL,
  `scarves_and_shawls_fiber_type` varchar(100) DEFAULT NULL,
  `scarves_and_shawls_size` varchar(100) DEFAULT NULL,
  `scarves_and_shawls_shape` varchar(100) DEFAULT NULL,
  `gloves_use` varchar(100) DEFAULT NULL,
  `gloves_length` varchar(100) DEFAULT NULL,
  `belts_style` varchar(100) DEFAULT NULL,
  `belts_waist_measurement` varchar(100) DEFAULT NULL,
  `handbags_style` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `gender` (`gender`),
  KEY `era` (`era`),
  KEY `materials` (`materials`),
  KEY `hats_brim_size` (`hats_brim_size`),
  KEY `hats_type` (`hats_type`),
  KEY `shoes_size` (`shoes_size`),
  KEY `shoes_heal_height` (`shoes_heal_height`),
  KEY `shoes_style` (`shoes_style`),
  KEY `scarves_and_shawls_fiber_type` (`scarves_and_shawls_fiber_type`),
  KEY `scarves_and_shawls_size` (`scarves_and_shawls_size`),
  KEY `scarves_and_shawls_shape` (`scarves_and_shawls_shape`),
  KEY `gloves_use` (`gloves_use`),
  KEY `gloves_length` (`gloves_length`),
  KEY `belts_style` (`belts_style`),
  KEY `belts_waist_measurement` (`belts_waist_measurement`),
  KEY `handbags_style` (`handbags_style`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `belts_style`
--

CREATE TABLE IF NOT EXISTS `belts_style` (
  `belts_style` varchar(100) NOT NULL,
  PRIMARY KEY (`belts_style`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `belts_style`
--

INSERT INTO `belts_style` (`belts_style`) VALUES
('casual '),
('embellished'),
('formal'),
('occupational'),
('skinny'),
('woven');

-- --------------------------------------------------------

--
-- Table structure for table `belts_waist_measurement`
--

CREATE TABLE IF NOT EXISTS `belts_waist_measurement` (
  `belts_waist_measurement` varchar(100) NOT NULL,
  PRIMARY KEY (`belts_waist_measurement`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `belts_waist_measurement`
--

INSERT INTO `belts_waist_measurement` (`belts_waist_measurement`) VALUES
('24-26”'),
('27-29”'),
('30-32”'),
('33-35”'),
('35-37”'),
('38-40”'),
('41-43”'),
('44-46”'),
('47-49”'),
('50-52”'),
('53-55”'),
('56-58”'),
('59-62”'),
('63+”'),
('<24”');

-- --------------------------------------------------------

--
-- Table structure for table `blouses`
--

CREATE TABLE IF NOT EXISTS `blouses` (
  `blouses` varchar(100) NOT NULL,
  PRIMARY KEY (`blouses`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `blouses`
--

INSERT INTO `blouses` (`blouses`) VALUES
('long sleeve'),
('occupational'),
('short sleeve_cap sleeve'),
('short sleeve_flutter sleeve'),
('short sleeve_normal sleeve'),
('sleeveless');

-- --------------------------------------------------------

--
-- Table structure for table `chest_size`
--

CREATE TABLE IF NOT EXISTS `chest_size` (
  `chest_size` varchar(10) NOT NULL,
  PRIMARY KEY (`chest_size`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `chest_size`
--

INSERT INTO `chest_size` (`chest_size`) VALUES
('24-26”'),
('27-29”'),
('30-32”'),
('32-34”'),
('35-37”'),
('38-40”'),
('40-42”'),
('43-45”'),
('46-48”'),
('49-51”'),
('52-54”'),
('55-57”'),
('58-60”'),
('61-63”'),
('64”+');

-- --------------------------------------------------------

--
-- Table structure for table `clothing`
--

CREATE TABLE IF NOT EXISTS `clothing` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `gender` varchar(6) DEFAULT NULL,
  `era` varchar(100) DEFAULT NULL,
  `chest_size` varchar(10) DEFAULT NULL,
  `waist_size` varchar(10) DEFAULT NULL,
  `hips_size` varchar(10) DEFAULT NULL,
  `color` varchar(20) DEFAULT NULL,
  `pattern` varchar(20) DEFAULT NULL,
  `pants` varchar(20) DEFAULT NULL,
  `skirts_length` varchar(20) DEFAULT NULL,
  `skirts_shape` varchar(20) DEFAULT NULL,
  `skirts_formality` varchar(20) DEFAULT NULL,
  `shorts` varchar(20) DEFAULT NULL,
  `shirts_woven` varchar(20) DEFAULT NULL,
  `shirts_knit` varchar(20) DEFAULT NULL,
  `shirts_occupational` varchar(20) DEFAULT NULL,
  `jackets_and_blazers` varchar(20) DEFAULT NULL,
  `blouses` varchar(100) DEFAULT NULL,
  `sweaters` varchar(100) DEFAULT NULL,
  `sweatshirts` varchar(100) DEFAULT NULL,
  `dresses_length` varchar(100) DEFAULT NULL,
  `dresses_shape` varchar(100) DEFAULT NULL,
  `dresses_sleeves_straps` varchar(100) DEFAULT NULL,
  `suit` varchar(100) DEFAULT NULL,
  `jumpsuits_and_tracksuits` varchar(100) DEFAULT NULL,
  `outerwear` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `gender` (`gender`),
  KEY `era` (`era`),
  KEY `chest_size` (`chest_size`),
  KEY `waist_size` (`waist_size`),
  KEY `hips_size` (`hips_size`),
  KEY `color` (`color`),
  KEY `pattern` (`pattern`),
  KEY `pants` (`pants`),
  KEY `skirts_length` (`skirts_length`),
  KEY `skirts_shape` (`skirts_shape`),
  KEY `skirts_formality` (`skirts_formality`),
  KEY `shorts` (`shorts`),
  KEY `shirts_woven` (`shirts_woven`),
  KEY `shirts_knit` (`shirts_knit`),
  KEY `shirts_occupational` (`shirts_occupational`),
  KEY `jackets_and_blazers` (`jackets_and_blazers`),
  KEY `blouses` (`blouses`),
  KEY `sweaters` (`sweaters`),
  KEY `sweatshirts` (`sweatshirts`),
  KEY `dresses_length` (`dresses_length`),
  KEY `dresses_shape` (`dresses_shape`),
  KEY `dresses_sleeves_straps` (`dresses_sleeves_straps`),
  KEY `suit` (`suit`),
  KEY `jumpsuits_and_tracksuits` (`jumpsuits_and_tracksuits`),
  KEY `outerwear` (`outerwear`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `color`
--

CREATE TABLE IF NOT EXISTS `color` (
  `color` varchar(20) NOT NULL,
  PRIMARY KEY (`color`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `color`
--

INSERT INTO `color` (`color`) VALUES
('black'),
('blue'),
('brown'),
('cool'),
('green'),
('multi'),
('neutral'),
('orange'),
('pink'),
('purple'),
('red'),
('tan'),
('warm'),
('white'),
('yellow');

-- --------------------------------------------------------

--
-- Table structure for table `dresses_length`
--

CREATE TABLE IF NOT EXISTS `dresses_length` (
  `dresses_length` varchar(100) NOT NULL,
  PRIMARY KEY (`dresses_length`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dresses_length`
--

INSERT INTO `dresses_length` (`dresses_length`) VALUES
('full length'),
('knee length'),
('mini'),
('tea length');

-- --------------------------------------------------------

--
-- Table structure for table `dresses_shape`
--

CREATE TABLE IF NOT EXISTS `dresses_shape` (
  `dresses_shape` varchar(100) NOT NULL,
  PRIMARY KEY (`dresses_shape`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dresses_shape`
--

INSERT INTO `dresses_shape` (`dresses_shape`) VALUES
('a-line'),
('asymmetric'),
('bodycon'),
('empire'),
('hourglass'),
('mermaid'),
('princess'),
('sheath'),
('shirtdress'),
('smock'),
('sundress'),
('wraparound');

-- --------------------------------------------------------

--
-- Table structure for table `dresses_sleeves_straps`
--

CREATE TABLE IF NOT EXISTS `dresses_sleeves_straps` (
  `dresses_sleeves_straps` varchar(100) NOT NULL,
  PRIMARY KEY (`dresses_sleeves_straps`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dresses_sleeves_straps`
--

INSERT INTO `dresses_sleeves_straps` (`dresses_sleeves_straps`) VALUES
('halter'),
('long sleeve'),
('one shoulder'),
('short sleeve'),
('strapless');

-- --------------------------------------------------------

--
-- Table structure for table `era`
--

CREATE TABLE IF NOT EXISTS `era` (
  `era` varchar(100) NOT NULL,
  PRIMARY KEY (`era`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `era`
--

INSERT INTO `era` (`era`) VALUES
('1900s'),
('1910s'),
('1920s'),
('1930s'),
('1940s'),
('1950s'),
('1960s'),
('1970s'),
('1980s'),
('ancient (greeks/romans/celts)'),
('cavalier (1600-1700)'),
('civil war/ early victorian (1830-1860)'),
('colonial (1700-1800)'),
('contemporary'),
('fantasy'),
('high victorian (1860-1890)'),
('medieval/renaissance (1200-1500)'),
('non-western (asian, indian, balinese, african, south american, european)'),
('regency/empire (1800-1820)'),
('tudor/elizabethan (1500-1600)');

-- --------------------------------------------------------

--
-- Table structure for table `gender`
--

CREATE TABLE IF NOT EXISTS `gender` (
  `gender` varchar(6) NOT NULL,
  PRIMARY KEY (`gender`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `gender`
--

INSERT INTO `gender` (`gender`) VALUES
('men'),
('unisex'),
('women');

-- --------------------------------------------------------

--
-- Table structure for table `gloves_length`
--

CREATE TABLE IF NOT EXISTS `gloves_length` (
  `gloves_length` varchar(100) NOT NULL,
  PRIMARY KEY (`gloves_length`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `gloves_length`
--

INSERT INTO `gloves_length` (`gloves_length`) VALUES
('elbow'),
('opera'),
('wrist');

-- --------------------------------------------------------

--
-- Table structure for table `gloves_use`
--

CREATE TABLE IF NOT EXISTS `gloves_use` (
  `gloves_use` varchar(100) NOT NULL,
  PRIMARY KEY (`gloves_use`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `gloves_use`
--

INSERT INTO `gloves_use` (`gloves_use`) VALUES
('formal'),
('utility'),
('winter');

-- --------------------------------------------------------

--
-- Table structure for table `handbags_style`
--

CREATE TABLE IF NOT EXISTS `handbags_style` (
  `handbags_style` varchar(100) NOT NULL,
  PRIMARY KEY (`handbags_style`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `handbags_style`
--

INSERT INTO `handbags_style` (`handbags_style`) VALUES
('backpack'),
('clutch'),
('cross body'),
('messenger'),
('tote');

-- --------------------------------------------------------

--
-- Table structure for table `hats_brim_size`
--

CREATE TABLE IF NOT EXISTS `hats_brim_size` (
  `hats_brim_size` varchar(100) NOT NULL,
  PRIMARY KEY (`hats_brim_size`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hats_brim_size`
--

INSERT INTO `hats_brim_size` (`hats_brim_size`) VALUES
('1-2”'),
('3-4”'),
('4+”'),
('brimless');

-- --------------------------------------------------------

--
-- Table structure for table `hats_type`
--

CREATE TABLE IF NOT EXISTS `hats_type` (
  `hats_type` varchar(100) NOT NULL,
  PRIMARY KEY (`hats_type`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hats_type`
--

INSERT INTO `hats_type` (`hats_type`) VALUES
('academic hats_biretta'),
('academic hats_mortarboard'),
('balaclavas'),
('baseball and trucker hats'),
('berets'),
('boaters'),
('bowlers'),
('bucket hats'),
('cadet caps'),
('clippy hats'),
('coifs'),
('derby'),
('driving caps/newsboys'),
('drover'),
('ethnic hats'),
('fantasy hats'),
('fedoras'),
('fez'),
('greek fisherman hats'),
('homburg'),
('hood'),
('knit hats'),
('occupational'),
('pork pie'),
('religious hats'),
('ring hats'),
('top hat'),
('toques/beanies'),
('tricorn/bicorn'),
('trilby'),
('turban'),
('walking hat'),
('wedding veil');

-- --------------------------------------------------------

--
-- Table structure for table `hips_size`
--

CREATE TABLE IF NOT EXISTS `hips_size` (
  `hips_size` varchar(10) NOT NULL,
  PRIMARY KEY (`hips_size`),
  FULLTEXT KEY `hips_size` (`hips_size`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hips_size`
--

INSERT INTO `hips_size` (`hips_size`) VALUES
('24-26"'),
('27-29"'),
('30-32"'),
('32-34"'),
('35-37"'),
('38-40"'),
('40-42"'),
('43-45"'),
('46-48"'),
('49-51"'),
('52-54"'),
('55-57"'),
('58-60"'),
('61-63"'),
('64"+');

-- --------------------------------------------------------

--
-- Table structure for table `jackets_and_blazers`
--

CREATE TABLE IF NOT EXISTS `jackets_and_blazers` (
  `jackets_and_blazers` varchar(20) NOT NULL,
  PRIMARY KEY (`jackets_and_blazers`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jackets_and_blazers`
--

INSERT INTO `jackets_and_blazers` (`jackets_and_blazers`) VALUES
('fashion'),
('occupational');

-- --------------------------------------------------------

--
-- Table structure for table `jumpsuits_and_tracksuits`
--

CREATE TABLE IF NOT EXISTS `jumpsuits_and_tracksuits` (
  `jumpsuits_and_tracksuits` varchar(100) NOT NULL,
  PRIMARY KEY (`jumpsuits_and_tracksuits`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jumpsuits_and_tracksuits`
--

INSERT INTO `jumpsuits_and_tracksuits` (`jumpsuits_and_tracksuits`) VALUES
('athletic'),
('occupational');

-- --------------------------------------------------------

--
-- Table structure for table `materials`
--

CREATE TABLE IF NOT EXISTS `materials` (
  `materials` varchar(100) NOT NULL,
  PRIMARY KEY (`materials`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `materials`
--

INSERT INTO `materials` (`materials`) VALUES
('fabric'),
('feathers'),
('felt'),
('flowers/foliage'),
('fur'),
('gemstones'),
('leather'),
('metal'),
('plastic'),
('straw'),
('vinyl'),
('webbing');

-- --------------------------------------------------------

--
-- Table structure for table `outerwear`
--

CREATE TABLE IF NOT EXISTS `outerwear` (
  `outerwear` varchar(100) NOT NULL,
  PRIMARY KEY (`outerwear`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `outerwear`
--

INSERT INTO `outerwear` (`outerwear`) VALUES
('cloaks/capes'),
('full length_heavyweight'),
('full length_lightweight'),
('occupational'),
('waist length_heavyweight'),
('waist length_lightweight');

-- --------------------------------------------------------

--
-- Table structure for table `pants`
--

CREATE TABLE IF NOT EXISTS `pants` (
  `pants` varchar(20) NOT NULL,
  PRIMARY KEY (`pants`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pants`
--

INSERT INTO `pants` (`pants`) VALUES
('athletic'),
('formal'),
('informal'),
('jeans'),
('occupational');

-- --------------------------------------------------------

--
-- Table structure for table `pattern`
--

CREATE TABLE IF NOT EXISTS `pattern` (
  `pattern` varchar(20) NOT NULL,
  PRIMARY KEY (`pattern`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pattern`
--

INSERT INTO `pattern` (`pattern`) VALUES
('asymmetric'),
('distressed'),
('dots'),
('floral'),
('geometric'),
('paisley'),
('plaid'),
('stripes');

-- --------------------------------------------------------

--
-- Table structure for table `scarves_and_shawls_fiber_type`
--

CREATE TABLE IF NOT EXISTS `scarves_and_shawls_fiber_type` (
  `scarves_and_shawls_fiber_type` varchar(100) NOT NULL,
  PRIMARY KEY (`scarves_and_shawls_fiber_type`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `scarves_and_shawls_fiber_type`
--

INSERT INTO `scarves_and_shawls_fiber_type` (`scarves_and_shawls_fiber_type`) VALUES
('cottony'),
('polarfleece'),
('silky'),
('wooly');

-- --------------------------------------------------------

--
-- Table structure for table `scarves_and_shawls_shape`
--

CREATE TABLE IF NOT EXISTS `scarves_and_shawls_shape` (
  `scarves_and_shawls_shape` varchar(100) NOT NULL,
  PRIMARY KEY (`scarves_and_shawls_shape`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `scarves_and_shawls_shape`
--

INSERT INTO `scarves_and_shawls_shape` (`scarves_and_shawls_shape`) VALUES
('oddball'),
('rectangular'),
('square'),
('triangular');

-- --------------------------------------------------------

--
-- Table structure for table `scarves_and_shawls_size`
--

CREATE TABLE IF NOT EXISTS `scarves_and_shawls_size` (
  `scarves_and_shawls_size` varchar(100) NOT NULL,
  PRIMARY KEY (`scarves_and_shawls_size`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `scarves_and_shawls_size`
--

INSERT INTO `scarves_and_shawls_size` (`scarves_and_shawls_size`) VALUES
('large (around shoulder sized)'),
('medium (around neck sized)'),
('small (head sized)'),
('xl (bigger than large)');

-- --------------------------------------------------------

--
-- Table structure for table `shirts_knit`
--

CREATE TABLE IF NOT EXISTS `shirts_knit` (
  `shirts_knit` varchar(20) NOT NULL,
  PRIMARY KEY (`shirts_knit`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shirts_knit`
--

INSERT INTO `shirts_knit` (`shirts_knit`) VALUES
('long sleeve'),
('polo'),
('short sleeve');

-- --------------------------------------------------------

--
-- Table structure for table `shirts_occupational`
--

CREATE TABLE IF NOT EXISTS `shirts_occupational` (
  `shirts_occupational` varchar(20) NOT NULL,
  PRIMARY KEY (`shirts_occupational`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shirts_occupational`
--

INSERT INTO `shirts_occupational` (`shirts_occupational`) VALUES
('military'),
('other');

-- --------------------------------------------------------

--
-- Table structure for table `shirts_woven`
--

CREATE TABLE IF NOT EXISTS `shirts_woven` (
  `shirts_woven` varchar(20) NOT NULL,
  PRIMARY KEY (`shirts_woven`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shirts_woven`
--

INSERT INTO `shirts_woven` (`shirts_woven`) VALUES
('collared_buttondown'),
('collared_mandarin'),
('collared_wing tip'),
('long sleeve'),
('not collared'),
('occupational'),
('short sleeve');

-- --------------------------------------------------------

--
-- Table structure for table `shoes_heal_height`
--

CREATE TABLE IF NOT EXISTS `shoes_heal_height` (
  `shoes_heal_height` varchar(100) NOT NULL,
  PRIMARY KEY (`shoes_heal_height`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shoes_heal_height`
--

INSERT INTO `shoes_heal_height` (`shoes_heal_height`) VALUES
('0-1”'),
('2-3”'),
('4-5”'),
('5”+');

-- --------------------------------------------------------

--
-- Table structure for table `shoes_size`
--

CREATE TABLE IF NOT EXISTS `shoes_size` (
  `shoes_size` varchar(100) NOT NULL,
  PRIMARY KEY (`shoes_size`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shoes_size`
--

INSERT INTO `shoes_size` (`shoes_size`) VALUES
('men’s 10/10.5'),
('men’s 11/11.5'),
('men’s 12/12.5'),
('men’s 13/13.5'),
('men’s 14/14.5'),
('men’s 15/15.5'),
('men’s 6/6.5'),
('men’s 7/7.5'),
('men’s 8/8.5'),
('men’s 9/9.5'),
('women’s 10/10.5'),
('women’s 11/11.5'),
('women’s 5/5.5'),
('women’s 6/6.5'),
('women’s 7/7.5'),
('women’s 8/8.5'),
('women’s 9/9.5');

-- --------------------------------------------------------

--
-- Table structure for table `shoes_style`
--

CREATE TABLE IF NOT EXISTS `shoes_style` (
  `shoes_style` varchar(100) NOT NULL,
  PRIMARY KEY (`shoes_style`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shoes_style`
--

INSERT INTO `shoes_style` (`shoes_style`) VALUES
('bedroom slipper'),
('boot_chukkas'),
('boot_combat'),
('boot_cowboy'),
('boot_heeled boot (bootie)'),
('boot_wellington'),
('character shoe'),
('dance shoe_ballet slipper'),
('dance shoe_jazz shoe'),
('dance shoe_pointer shoe'),
('espadrille'),
('loafer'),
('mary jane'),
('monkstrap'),
('mule'),
('oxfords'),
('peep toe'),
('platform'),
('pump'),
('sandal_athletic'),
('sandal_flip flop'),
('sandal_gladiator'),
('sandal_saltwater'),
('slingback'),
('sneakers/athletic_boat shoes'),
('sneakers/athletic_slip-ons'),
('sneakers/athletic_velcro'),
('t-strap'),
('wingtip');

-- --------------------------------------------------------

--
-- Table structure for table `shorts`
--

CREATE TABLE IF NOT EXISTS `shorts` (
  `shorts` varchar(20) NOT NULL,
  PRIMARY KEY (`shorts`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shorts`
--

INSERT INTO `shorts` (`shorts`) VALUES
('athletic'),
('everyday'),
('formal');

-- --------------------------------------------------------

--
-- Table structure for table `skirts_formality`
--

CREATE TABLE IF NOT EXISTS `skirts_formality` (
  `skirts_formality` varchar(20) NOT NULL,
  PRIMARY KEY (`skirts_formality`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `skirts_formality`
--

INSERT INTO `skirts_formality` (`skirts_formality`) VALUES
('casual'),
('formal'),
('occupational');

-- --------------------------------------------------------

--
-- Table structure for table `skirts_length`
--

CREATE TABLE IF NOT EXISTS `skirts_length` (
  `skirts_length` varchar(20) NOT NULL,
  PRIMARY KEY (`skirts_length`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `skirts_length`
--

INSERT INTO `skirts_length` (`skirts_length`) VALUES
('knee length'),
('maxi'),
('mini');

-- --------------------------------------------------------

--
-- Table structure for table `skirts_shape`
--

CREATE TABLE IF NOT EXISTS `skirts_shape` (
  `skirts_shape` varchar(20) NOT NULL,
  PRIMARY KEY (`skirts_shape`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `skirts_shape`
--

INSERT INTO `skirts_shape` (`skirts_shape`) VALUES
('a-line'),
('asymmetric'),
('ball gown'),
('bodycon'),
('bubble'),
('circle'),
('godet'),
('mermaid'),
('paneled'),
('pencil'),
('pleated'),
('tiered'),
('tulip'),
('wraparound'),
('yoked');

-- --------------------------------------------------------

--
-- Table structure for table `suit`
--

CREATE TABLE IF NOT EXISTS `suit` (
  `suit` varchar(100) NOT NULL,
  PRIMARY KEY (`suit`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `suit`
--

INSERT INTO `suit` (`suit`) VALUES
('three piece'),
('two piece');

-- --------------------------------------------------------

--
-- Table structure for table `sweaters`
--

CREATE TABLE IF NOT EXISTS `sweaters` (
  `sweaters` varchar(100) NOT NULL,
  PRIMARY KEY (`sweaters`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sweaters`
--

INSERT INTO `sweaters` (`sweaters`) VALUES
('cardigan_long sleeve'),
('cardigan_short sleeve'),
('pullover_long sleeve'),
('pullover_short sleeve'),
('pullover_turtleneck'),
('vests_button front'),
('vests_pullover');

-- --------------------------------------------------------

--
-- Table structure for table `sweatshirts`
--

CREATE TABLE IF NOT EXISTS `sweatshirts` (
  `sweatshirts` varchar(100) NOT NULL,
  PRIMARY KEY (`sweatshirts`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sweatshirts`
--

INSERT INTO `sweatshirts` (`sweatshirts`) VALUES
('crewneck_open front'),
('crewneck_pullover'),
('hooded_pullover'),
('hooded_zip front');

-- --------------------------------------------------------

--
-- Table structure for table `waist_size`
--

CREATE TABLE IF NOT EXISTS `waist_size` (
  `waist_size` varchar(10) NOT NULL,
  PRIMARY KEY (`waist_size`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `waist_size`
--

INSERT INTO `waist_size` (`waist_size`) VALUES
('24-26"'),
('27-29"'),
('30-32"'),
('32-34”'),
('35-37”'),
('38-40”'),
('40-42”'),
('43-45”'),
('46-48”'),
('49-51”'),
('52-54”'),
('55-57”'),
('58-60”'),
('61-63”'),
('64"+');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `accessories`
--
ALTER TABLE `accessories`
  ADD CONSTRAINT `accessories_ibfk_16` FOREIGN KEY (`handbags_style`) REFERENCES `handbags_style` (`handbags_style`),
  ADD CONSTRAINT `accessories_ibfk_1` FOREIGN KEY (`gender`) REFERENCES `gender` (`gender`),
  ADD CONSTRAINT `accessories_ibfk_10` FOREIGN KEY (`scarves_and_shawls_size`) REFERENCES `scarves_and_shawls_size` (`scarves_and_shawls_size`),
  ADD CONSTRAINT `accessories_ibfk_11` FOREIGN KEY (`scarves_and_shawls_shape`) REFERENCES `scarves_and_shawls_shape` (`scarves_and_shawls_shape`),
  ADD CONSTRAINT `accessories_ibfk_12` FOREIGN KEY (`gloves_use`) REFERENCES `gloves_use` (`gloves_use`),
  ADD CONSTRAINT `accessories_ibfk_13` FOREIGN KEY (`gloves_length`) REFERENCES `gloves_length` (`gloves_length`),
  ADD CONSTRAINT `accessories_ibfk_14` FOREIGN KEY (`belts_style`) REFERENCES `belts_style` (`belts_style`),
  ADD CONSTRAINT `accessories_ibfk_15` FOREIGN KEY (`belts_waist_measurement`) REFERENCES `belts_waist_measurement` (`belts_waist_measurement`),
  ADD CONSTRAINT `accessories_ibfk_2` FOREIGN KEY (`era`) REFERENCES `era` (`era`),
  ADD CONSTRAINT `accessories_ibfk_3` FOREIGN KEY (`materials`) REFERENCES `materials` (`materials`),
  ADD CONSTRAINT `accessories_ibfk_4` FOREIGN KEY (`hats_brim_size`) REFERENCES `hats_brim_size` (`hats_brim_size`),
  ADD CONSTRAINT `accessories_ibfk_5` FOREIGN KEY (`hats_type`) REFERENCES `hats_type` (`hats_type`),
  ADD CONSTRAINT `accessories_ibfk_6` FOREIGN KEY (`shoes_size`) REFERENCES `shoes_size` (`shoes_size`),
  ADD CONSTRAINT `accessories_ibfk_7` FOREIGN KEY (`shoes_heal_height`) REFERENCES `shoes_heal_height` (`shoes_heal_height`),
  ADD CONSTRAINT `accessories_ibfk_8` FOREIGN KEY (`shoes_style`) REFERENCES `shoes_style` (`shoes_style`),
  ADD CONSTRAINT `accessories_ibfk_9` FOREIGN KEY (`scarves_and_shawls_fiber_type`) REFERENCES `scarves_and_shawls_fiber_type` (`scarves_and_shawls_fiber_type`);

--
-- Constraints for table `clothing`
--
ALTER TABLE `clothing`
  ADD CONSTRAINT `clothing_ibfk_1` FOREIGN KEY (`gender`) REFERENCES `gender` (`gender`),
  ADD CONSTRAINT `clothing_ibfk_10` FOREIGN KEY (`skirts_shape`) REFERENCES `skirts_shape` (`skirts_shape`),
  ADD CONSTRAINT `clothing_ibfk_11` FOREIGN KEY (`skirts_formality`) REFERENCES `skirts_formality` (`skirts_formality`),
  ADD CONSTRAINT `clothing_ibfk_12` FOREIGN KEY (`shorts`) REFERENCES `shorts` (`shorts`),
  ADD CONSTRAINT `clothing_ibfk_13` FOREIGN KEY (`shirts_woven`) REFERENCES `shirts_woven` (`shirts_woven`),
  ADD CONSTRAINT `clothing_ibfk_14` FOREIGN KEY (`shirts_knit`) REFERENCES `shirts_knit` (`shirts_knit`),
  ADD CONSTRAINT `clothing_ibfk_15` FOREIGN KEY (`shirts_occupational`) REFERENCES `shirts_occupational` (`shirts_occupational`),
  ADD CONSTRAINT `clothing_ibfk_16` FOREIGN KEY (`jackets_and_blazers`) REFERENCES `jackets_and_blazers` (`jackets_and_blazers`),
  ADD CONSTRAINT `clothing_ibfk_17` FOREIGN KEY (`blouses`) REFERENCES `blouses` (`blouses`),
  ADD CONSTRAINT `clothing_ibfk_18` FOREIGN KEY (`sweaters`) REFERENCES `sweaters` (`sweaters`),
  ADD CONSTRAINT `clothing_ibfk_19` FOREIGN KEY (`sweatshirts`) REFERENCES `sweatshirts` (`sweatshirts`),
  ADD CONSTRAINT `clothing_ibfk_2` FOREIGN KEY (`era`) REFERENCES `era` (`era`),
  ADD CONSTRAINT `clothing_ibfk_20` FOREIGN KEY (`dresses_length`) REFERENCES `dresses_length` (`dresses_length`),
  ADD CONSTRAINT `clothing_ibfk_21` FOREIGN KEY (`dresses_shape`) REFERENCES `dresses_shape` (`dresses_shape`),
  ADD CONSTRAINT `clothing_ibfk_22` FOREIGN KEY (`dresses_sleeves_straps`) REFERENCES `dresses_sleeves_straps` (`dresses_sleeves_straps`),
  ADD CONSTRAINT `clothing_ibfk_23` FOREIGN KEY (`suit`) REFERENCES `suit` (`suit`),
  ADD CONSTRAINT `clothing_ibfk_24` FOREIGN KEY (`jumpsuits_and_tracksuits`) REFERENCES `jumpsuits_and_tracksuits` (`jumpsuits_and_tracksuits`),
  ADD CONSTRAINT `clothing_ibfk_25` FOREIGN KEY (`outerwear`) REFERENCES `outerwear` (`outerwear`),
  ADD CONSTRAINT `clothing_ibfk_3` FOREIGN KEY (`chest_size`) REFERENCES `chest_size` (`chest_size`),
  ADD CONSTRAINT `clothing_ibfk_4` FOREIGN KEY (`waist_size`) REFERENCES `waist_size` (`waist_size`),
  ADD CONSTRAINT `clothing_ibfk_5` FOREIGN KEY (`hips_size`) REFERENCES `hips_size` (`hips_size`),
  ADD CONSTRAINT `clothing_ibfk_6` FOREIGN KEY (`color`) REFERENCES `color` (`color`),
  ADD CONSTRAINT `clothing_ibfk_7` FOREIGN KEY (`pattern`) REFERENCES `pattern` (`pattern`),
  ADD CONSTRAINT `clothing_ibfk_8` FOREIGN KEY (`pants`) REFERENCES `pants` (`pants`),
  ADD CONSTRAINT `clothing_ibfk_9` FOREIGN KEY (`skirts_length`) REFERENCES `skirts_length` (`skirts_length`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
