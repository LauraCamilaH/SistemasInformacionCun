-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-11-2018 a las 06:26:59
-- Versión del servidor: 5.6.17
-- Versión de PHP: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `inventario_cun`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asignacion`
--

CREATE TABLE IF NOT EXISTS `asignacion` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `OPERACION` enum('ASIGNAR','QUITAR') NOT NULL,
  `ELEMENTO` enum('MONITOR','CPU','IMPRESORA') NOT NULL,
  `ID_PERSONA` int(11) DEFAULT NULL,
  `ID_ELEMENTO` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_PERSONA_ASIGNACION_idx` (`ID_PERSONA`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Volcado de datos para la tabla `asignacion`
--

INSERT INTO `asignacion` (`ID`, `OPERACION`, `ELEMENTO`, `ID_PERSONA`, `ID_ELEMENTO`) VALUES
(1, 'ASIGNAR', 'MONITOR', 1, 1),
(2, 'ASIGNAR', 'CPU', 1, 1),
(3, 'ASIGNAR', 'MONITOR', 1, 1),
(4, 'ASIGNAR', 'CPU', 1, 1),
(5, 'ASIGNAR', 'MONITOR', 3, 2),
(6, 'ASIGNAR', 'CPU', 3, 2),
(7, 'ASIGNAR', 'CPU', 3, 2),
(8, 'ASIGNAR', 'MONITOR', 4, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cpu`
--

CREATE TABLE IF NOT EXISTS `cpu` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `SERIE` varchar(6) NOT NULL,
  `MARCA` varchar(15) NOT NULL,
  `FECHA_INGRESO` date NOT NULL,
  `PRECIO_COMPRA` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `SERIE` (`SERIE`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=23 ;

--
-- Volcado de datos para la tabla `cpu`
--

INSERT INTO `cpu` (`ID`, `SERIE`, `MARCA`, `FECHA_INGRESO`, `PRECIO_COMPRA`) VALUES
(1, 'CPU111', 'DELL', '2018-11-19', 90000),
(2, 'CPU112', 'DELL', '2018-11-06', 80000),
(5, 'CPU113', 'DELL', '2018-11-02', 80000),
(6, 'CPU114', 'LENOVO', '2018-11-04', 80000),
(7, 'CPU117', 'LENOVO', '2018-11-04', 80000),
(8, 'CPU118', 'LENOVO', '2019-11-02', 80000),
(15, 'CPU222', 'LENOVO', '2018-11-09', 80000),
(17, 'CPU532', 'PATO', '2018-11-01', 12340),
(22, 'IMP336', 'DELL', '2018-10-12', 1000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `impresora`
--

CREATE TABLE IF NOT EXISTS `impresora` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `SERIE` varchar(6) NOT NULL,
  `MARCA` varchar(15) NOT NULL,
  `FECHA_INGRESO` date NOT NULL,
  `PRECIO_COMPRA` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `SERIE` (`SERIE`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=12 ;

--
-- Volcado de datos para la tabla `impresora`
--

INSERT INTO `impresora` (`ID`, `SERIE`, `MARCA`, `FECHA_INGRESO`, `PRECIO_COMPRA`) VALUES
(2, 'IMP112', 'CANON', '2018-11-16', 40000),
(3, 'IMP114', 'PANASONIC', '2018-11-11', 4000),
(4, 'IMP115', 'PANASONIC', '2018-11-07', 40000),
(5, 'IMP116', 'EPSON', '2018-11-11', 4000),
(6, 'IMP117', 'SAMSUNG', '2018-11-07', 40000),
(7, 'IMP118', 'SAMSUNG', '2018-11-11', 4000),
(8, 'IMP119', 'EPSON', '2018-11-07', 40000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `monitor`
--

CREATE TABLE IF NOT EXISTS `monitor` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `SERIE` varchar(6) NOT NULL,
  `MARCA` varchar(15) NOT NULL,
  `FECHA_INGRESO` date NOT NULL,
  `PRECIO_COMPRA` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `SERIE` (`SERIE`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=8 ;

--
-- Volcado de datos para la tabla `monitor`
--

INSERT INTO `monitor` (`ID`, `SERIE`, `MARCA`, `FECHA_INGRESO`, `PRECIO_COMPRA`) VALUES
(1, 'MON111', 'DELL', '2018-11-08', 50000),
(2, 'MON112', 'ASUS', '2018-11-01', 50000),
(4, 'MON114', 'ASUS', '2018-11-01', 50000),
(5, 'MON115', 'DELL', '2018-11-08', 50000),
(6, 'MON116', 'ASUS', '2018-11-01', 50000),
(7, 'ser111', 'dell', '2015-12-18', 1234567);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `persona`
--

CREATE TABLE IF NOT EXISTS `persona` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CEDULA` varchar(20) NOT NULL,
  `PRIMER_NOMBRE` varchar(15) NOT NULL,
  `SEG_NOMBRE` varchar(15) NOT NULL,
  `APELLIDO` varchar(15) NOT NULL,
  `CIUDAD` varchar(45) NOT NULL,
  `ID_MONITOR` int(11) DEFAULT NULL,
  `ID_CPU` int(11) DEFAULT NULL,
  `ID_IMPRESORA` int(11) DEFAULT NULL,
  `CARGO` varchar(45) NOT NULL,
  `SUELDO` decimal(20,0) NOT NULL,
  `FECHA_INGRESO` date DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `CEDULA` (`CEDULA`),
  KEY `FK_PERSONA_CPU_idx` (`ID_CPU`),
  KEY `FK_PERSONA_MONITOR_idx` (`ID_MONITOR`),
  KEY `FK_PERSONA_IMPRESORA_idx` (`ID_IMPRESORA`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=15 ;

--
-- Volcado de datos para la tabla `persona`
--

INSERT INTO `persona` (`ID`, `CEDULA`, `PRIMER_NOMBRE`, `SEG_NOMBRE`, `APELLIDO`, `CIUDAD`, `ID_MONITOR`, `ID_CPU`, `ID_IMPRESORA`, `CARGO`, `SUELDO`, `FECHA_INGRESO`) VALUES
(1, '11111', 'Laura ', 'Camila', 'Hurtado', 'Bogota', NULL, NULL, NULL, 'ing sistemas ', '200000', '2018-11-05'),
(2, '111112', 'Andres ', 'Esteban', 'Bonilla', 'Sogamoso', NULL, NULL, NULL, 'Consultor', '200000', '2018-11-01'),
(3, '11113', 'Angy ', 'Liliana', 'Alarcon', 'Bogota', NULL, NULL, NULL, ' aux administrativa ', '20000', '2018-11-05'),
(4, '111114', 'Paula ', 'Andrea', 'Caceres', 'Duitama', NULL, NULL, NULL, 'Contador', '200000', '2018-11-01'),
(5, '11115', 'Carlos ', 'Roman', 'Ceballos', 'Bogota', NULL, NULL, NULL, ' Gerente ', '200000', '2018-11-04'),
(6, '111116', 'Diego ', 'Andres', 'Perez', 'Medellin', NULL, NULL, NULL, 'profesor', '200000', '2018-11-02'),
(7, '11120', 'Jorge', 'Alexander', 'Castaneda', 'chia', NULL, NULL, NULL, 'ing sistemas ', '200000', '2018-11-03'),
(8, '111121', 'Claudia', 'Maria', 'Duarte', 'Bogota', NULL, NULL, NULL, 'Consultor', '200000', '2018-11-01'),
(13, '11130', 'Jorge', 'Alexander', 'Castaneda', 'chia', NULL, NULL, NULL, 'ing sistemas ', '200000', '2018-11-03'),
(14, '11133', 'Claudia', 'Maria', 'Duarte', 'Bogota', NULL, NULL, NULL, 'Consultor', '200000', '2018-11-01');

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `asignacion`
--
ALTER TABLE `asignacion`
  ADD CONSTRAINT `FK_PERSONA_ASIGNACION` FOREIGN KEY (`ID_PERSONA`) REFERENCES `persona` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `persona`
--
ALTER TABLE `persona`
  ADD CONSTRAINT `FK_PERSONA_CPU` FOREIGN KEY (`ID_CPU`) REFERENCES `cpu` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_PERSONA_IMPRESORA` FOREIGN KEY (`ID_IMPRESORA`) REFERENCES `impresora` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_PERSONA_MONITOR` FOREIGN KEY (`ID_MONITOR`) REFERENCES `monitor` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
