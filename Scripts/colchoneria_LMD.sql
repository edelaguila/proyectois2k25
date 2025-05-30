--
-- Volcado de datos para la tabla `ayuda`
--
SET SQL_SAFE_UPDATES = 0; -- desactivar el modo seguro
INSERT INTO `ayuda` (`Id_ayuda`, `Ruta`, `indice`, `estado`) VALUES
(1, 'AyudaNavegador.chm', 'AyudaNav.html', 1),
(2, 'AyudaReportes.chm', 'AyudaRep.html', 1),
(8, 'AyudaMonitoreoAlmacen.chm', 'AyudaMonAlmacen.html', 1);

--
-- Volcado de datos para la tabla `tbl_aplicaciones`
--

INSERT INTO `tbl_aplicaciones` (`Pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(1000, 'MDI SEGURIDAD', 'PARA SEGURIDAD', 1),
(1001, 'Mant. Usuario', 'PARA SEGURIDAD', 1),
(1002, 'Mant. Aplicación', 'PARA SEGURIDAD', 1),
(1003, 'Mant. Modulo', 'PARA SEGURIDAD', 1),
(1004, 'Mant. Perfil', 'PARA SEGURIDAD', 1),
(1101, 'Asign. Modulo Aplicacion', 'PARA SEGURIDAD', 1),
(1102, 'Asign. Aplicacion Perfil', 'PARA SEGURIDAD', 1),
(1103, 'Asign. Perfil Usuario', 'PARA SEGURIDAD', 1),
(1201, 'Pcs. Cambio Contraseña', 'PARA SEGURIDAD', 1),
(1301, 'Pcs. BITACORA', 'PARA SEGURIDAD', 1),
(2000, 'MDI LOGISTICA', 'PARA LOGISTICA', 1),
(3000, 'MDI COMPRAS Y VENTAS', 'PARA COMPRAS Y VENTAS', 1),
(5000, 'MDI PRODUCCIÓN', 'PARA PRODUCCIÓN', 1),
(6000, 'MDI NOMINAS', 'PARA NOMINAS', 1),
(6001, 'Mant. Trabajadores', 'PARA NOMINAS', 1),
(6002, 'Mant. Puestos de Trabajo', 'PARA NOMINAS', 1),
(6003, 'Mant. Departamentos', 'PARA NOMINAS', 1),
(6004, 'Mant. Contratos', 'PARA NOMINAS', 1),
(6005, 'Mant. Percepciones', 'PARA NOMINAS', 1),
(6006, 'Mant. Horas Extras', 'PARA NOMINAS', 1),
(6007, 'Mant. Faltas', 'PARA NOMINAS', 1),
(6101, 'Asgn. Puesto - Depto.', 'PARA NOMINAS', 1),
(6102, 'Asgn. Puesto - Trabajador', 'PARA NOMINAS', 1),
(6103, 'Asgn. Contrato Trabajador', 'PARA NOMINAS', 1),
(6104, 'Asgn. Prestaciones Contrato', 'PARA NOMINAS', 1),
(6105, 'Asgn. Prestaciones Individual', 'PARA NOMINAS', 1),
(6106, 'Prcs. Nomina', 'PARA NOMINAS', 1),
(6201, 'Rpt. Planillas', 'PARA NOMINAS', 1),
(6202, 'Rpt. Contratos', 'PARA NOMINAS', 1),
(6203, 'Rpt. Trabajadores', 'PARA NOMINAS', 1),
(6301, 'ACCESO SEGURIDAD', 'PARA NOMINAS', 1),
(7000, 'MDI BANCOS', 'PARA BANCOS', 1),
(8000, 'MDI CONTRABILIDAD', 'PARA CONTRABILIDAD', 1),
(9000, 'MDI CUENTAS CORRIENTES', 'PARA CUENTAS CORRIENTES', 1);

--
-- Volcado de datos para la tabla `tbl_consultainteligente`
--

INSERT INTO `tbl_consultainteligente` (`Pk_consultaID`, `nombre_consulta`, `tipo_consulta`, `consulta_SQLE`, `consulta_estatus`) VALUES
(1, '', 0, 'SELECT id_venta FROM venta;', 1),
(2, '', 0, 'SELECT SELECT id_venta FROM venta;id_venta AS * FROM venta;', 1),
(3, '', 0, 'SELECT * FROM venta;', 1),
(4, '', 0, 'SELECT * FROM venta;', 1),
(5, '', 0, 'SELECT * FROM venta;', 1),
(6, '', 0, 'SELECT * FROM venta;', 1),
(7, 'dsf', 0, 'SELECT * FROM venta;', 1),
(8, '', 0, 'SELECT * FROM venta;', 1),
(9, '', 0, 'SELECT * FROM venta;', 1),
(10, 'viccccccccc', 0, 'SELECT * FROM venta;', 1),
(11, 'consultaaaaa', 0, 'SELECT * FROM factura;', 1),
(12, '', 0, 'SELECT * FROM factura;', 1),
(13, 'jkjkkjk', 0, 'SELECT * FROM factura;', 1);

--
-- Volcado de datos para la tabla `tbl_modulos`
--

INSERT INTO `tbl_modulos` (`Pk_id_modulos`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(1000, 'SEGURIDAD', 'Seguridad', 1),
(2000, 'LOGISTICA', 'Logistica', 1),
(3000, 'COMPRAS Y VENTAS', 'Compras y Ventas', 1),
(5000, 'PRODUCCIÓN', 'Produccion', 1),
(6000, 'NOMINAS', 'Nominas', 1),
(7000, 'BANCOS', 'Bancos', 1),
(8000, 'CONTABILIDAD', 'Contabilidad', 1),
(9000, 'CUENTAS CORRIENTES', 'Cuentas Corrientes', 1);
--
-- Volcado de datos para la tabla `tbl_perfiles`
--

INSERT INTO `tbl_perfiles` (`Pk_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
(2, 'SEGURIDAD', 'contiene todos los permisos de seguridad', 1),
(3, 'LOGISTICA', 'contiene todos los permisos de logistica', 1),
(4, 'COMPRAS Y VENTAS', 'contiene todos los permisos de compras y ventas', 1),
(5, 'PRODUCCIÓN', 'contiene todos los permisos de producción', 1),
(6, 'NOMINAS', 'contiene todos los permisos de nominas', 1),
(7, 'BANCOS', 'contiene todos los permisos de bancos', 1),
(8, 'CONTABILIDAD', 'contiene todos los permisos de contabilidad', 1),
(9, 'AUDITOR', 'Permite la revisión y auditoría de actividades sin capacidad de modificar datos', 1),
(10, 'SOporte Técnico', 'Permite brindar asistencia técnica sin acceso completo a la administración', 1),
(11, 'ADMINISTRADOR', 'Acceso completo al sistema con ciertas restricciones según sea necesario', 1),
(12, 'GESTOR DE PROYECTOS', 'Permite gestionar proyectos y coordinar actividades sin acceso completo a la administración', 1),
(13, 'GESTOR DE DATOS', 'Permite gestionar y supervisar datos en distintos módulos sin acceso completo a la administración', 1),
(14, 'CUENTAS CORRIENTES', 'contiene todos los permisos de cuentas corrientes', 1);


--
-- Volcado de datos para la tabla `tbl_permisos_aplicacion_perfil`
--

INSERT INTO `tbl_permisos_aplicacion_perfil` (`PK_id_Aplicacion_Perfil`, `Fk_id_perfil`, `Fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES
(1, 1, 1000, 1, 1, 1, 1, 1),
(2, 1, 1001, 1, 1, 1, 1, 1),
(3, 1, 1002, 1, 1, 1, 1, 1),
(4, 1, 1003, 1, 1, 1, 1, 1),
(5, 1, 1004, 1, 1, 1, 1, 1),
(6, 1, 1101, 1, 1, 1, 1, 1),
(7, 1, 1102, 1, 1, 1, 1, 1),
(8, 1, 1103, 1, 1, 1, 1, 1),
(9, 1, 1201, 1, 1, 1, 1, 1),
(10, 1, 1301, 1, 1, 1, 1, 1),
(11, 1, 2000, 1, 1, 1, 1, 1),
(12, 1, 3000, 1, 1, 1, 1, 1),
(13, 1, 5000, 1, 1, 1, 1, 1),
(14, 1, 6000, 1, 1, 1, 1, 1),
(15, 1, 6001, 1, 1, 1, 1, 1),
(16, 1, 6002, 1, 1, 1, 1, 1),
(17, 1, 6003, 1, 1, 1, 1, 1),
(18, 1, 6004, 1, 1, 1, 1, 1),
(19, 1, 6005, 1, 1, 1, 1, 1),
(20, 1, 6006, 1, 1, 1, 1, 1),
(21, 1, 6007, 1, 1, 1, 1, 1),
(22, 1, 6101, 1, 1, 1, 1, 1),
(23, 1, 6102, 1, 1, 1, 1, 1),
(24, 1, 6103, 1, 1, 1, 1, 1),
(25, 1, 6104, 1, 1, 1, 1, 1),
(26, 1, 6105, 1, 1, 1, 1, 1),
(27, 1, 6106, 1, 1, 1, 1, 1),
(28, 1, 6201, 1, 1, 1, 1, 1),
(29, 1, 6202, 1, 1, 1, 1, 1),
(30, 1, 6203, 1, 1, 1, 1, 1),
(31, 1, 6301, 1, 1, 1, 1, 1),
(32, 1, 7000, 1, 1, 1, 1, 1),
(33, 1, 8000, 1, 1, 1, 1, 1),
(34, 1, 9000, 1, 1, 1, 1, 1),--
(35, 2, 1000, 1, 1, 1, 1, 1),
(36, 3, 2000, 1, 1, 1, 1, 1),
(37, 4, 3000, 1, 1, 1, 1, 1),
(38, 5, 5000, 1, 1, 1, 1, 1),
(39, 6, 6000, 1, 1, 1, 1, 1),
(40, 6, 6001, 1, 1, 1, 1, 1),
(41, 6, 6002, 1, 1, 1, 1, 1),
(42, 6, 6003, 1, 1, 1, 1, 1),
(43, 6, 6004, 1, 1, 1, 1, 1),
(44, 6, 6005, 1, 1, 1, 1, 1),
(45, 6, 6006, 1, 1, 1, 1, 1),
(46, 6, 6007, 1, 1, 1, 1, 1),
(47, 6, 6101, 1, 1, 1, 1, 1),
(48, 6, 6102, 1, 1, 1, 1, 1),
(49, 6, 6103, 1, 1, 1, 1, 1),
(50, 6, 6104, 1, 1, 1, 1, 1),
(51, 6, 6105, 1, 1, 1, 1, 1),
(52, 6, 6106, 1, 1, 1, 1, 1),
(53, 6, 6201, 1, 1, 1, 1, 1),
(54, 6, 6202, 1, 1, 1, 1, 1),
(55, 6, 6203, 1, 1, 1, 1, 1),
(56, 6, 6301, 1, 1, 1, 1, 1),
(57, 7, 7000, 1, 1, 1, 1, 1),
(58, 8, 8000, 1, 1, 1, 1, 1),
(59, 9, 9000, 1, 1, 1, 1, 1),
(60, 10, 1000, 1, 1, 1, 1, 1),
(61, 10, 1001, 1, 1, 1, 1, 1),
(62, 10, 1002, 1, 1, 1, 1, 1),
(63, 10, 1003, 1, 1, 1, 1, 1),
(64, 10, 1004, 1, 1, 1, 1, 1),
(65, 10, 1101, 1, 1, 1, 1, 1),
(66, 10, 1102, 1, 1, 1, 1, 1),
(67, 10, 1103, 1, 1, 1, 1, 1),
(68, 10, 1201, 1, 1, 1, 1, 1),
(69, 10, 1301, 1, 1, 1, 1, 1),
(70, 10, 2000, 1, 1, 1, 1, 1),
(71, 10, 3000, 1, 1, 1, 1, 1),
(72, 10, 5000, 1, 1, 1, 1, 1),
(73, 10, 6000, 1, 1, 1, 1, 1),
(74, 10, 6001, 1, 1, 1, 1, 1),
(75, 10, 6002, 1, 1, 1, 1, 1),
(76, 10, 6003, 1, 1, 1, 1, 1),
(77, 10, 6004, 1, 1, 1, 1, 1),
(78, 10, 6005, 1, 1, 1, 1, 1),
(79, 10, 6006, 1, 1, 1, 1, 1),
(80, 10, 6007, 1, 1, 1, 1, 1),
(81, 10, 6101, 1, 1, 1, 1, 1),
(82, 10, 6102, 1, 1, 1, 1, 1),
(83, 10, 6103, 1, 1, 1, 1, 1),
(84, 10, 6104, 1, 1, 1, 1, 1),
(85, 10, 6105, 1, 1, 1, 1, 1),
(86, 10, 6106, 1, 1, 1, 1, 1),
(87, 10, 6201, 1, 1, 1, 1, 1),
(88, 10, 6202, 1, 1, 1, 1, 1),
(89, 10, 6203, 1, 1, 1, 1, 1),
(90, 10, 6301, 1, 1, 1, 1, 1),
(91, 10, 7000, 1, 1, 1, 1, 1),
(92, 10, 8000, 1, 1, 1, 1, 1),
(93, 10, 9000, 1, 1, 1, 1, 1),
(94, 11, 1000, 1, 1, 1, 1, 1),
(95, 11, 1001, 1, 1, 1, 1, 1),
(96, 11, 1002, 1, 1, 1, 1, 1),
(97, 11, 1003, 1, 1, 1, 1, 1),
(98, 11, 1004, 1, 1, 1, 1, 1),
(99, 11, 1101, 1, 1, 1, 1, 1),
(100, 11, 1102, 1, 1, 1, 1, 1),
(101, 11, 1103, 1, 1, 1, 1, 1),
(102, 11, 1201, 1, 1, 1, 1, 1),
(103, 11, 1301, 1, 1, 1, 1, 1),
(104, 11, 2000, 1, 1, 1, 1, 1),
(105, 11, 3000, 1, 1, 1, 1, 1),
(106, 11, 5000, 1, 1, 1, 1, 1),
(107, 11, 6000, 1, 1, 1, 1, 1),
(108, 11, 6001, 1, 1, 1, 1, 1),
(109, 11, 6002, 1, 1, 1, 1, 1),
(110, 11, 6003, 1, 1, 1, 1, 1),
(111, 11, 6004, 1, 1, 1, 1, 1),
(112, 11, 6005, 1, 1, 1, 1, 1),
(113, 11, 6006, 1, 1, 1, 1, 1),
(114, 11, 6007, 1, 1, 1, 1, 1),
(115, 11, 6101, 1, 1, 1, 1, 1),
(116, 11, 6102, 1, 1, 1, 1, 1),
(117, 11, 6103, 1, 1, 1, 1, 1),
(118, 11, 6104, 1, 1, 1, 1, 1),
(119, 11, 6105, 1, 1, 1, 1, 1),
(120, 11, 6106, 1, 1, 1, 1, 1),
(121, 11, 6201, 1, 1, 1, 1, 1),
(122, 11, 6202, 1, 1, 1, 1, 1),
(123, 11, 6203, 1, 1, 1, 1, 1),
(124, 11, 6301, 1, 1, 1, 1, 1),
(125, 11, 7000, 1, 1, 1, 1, 1),
(126, 11, 8000, 1, 1, 1, 1, 1),
(127, 11, 9000, 1, 1, 1, 1, 1),
(128, 12, 1000, 1, 1, 1, 1, 1),
(129, 12, 1001, 1, 1, 1, 1, 1),
(130, 12, 1002, 1, 1, 1, 1, 1),
(131, 12, 1003, 1, 1, 1, 1, 1),
(132, 12, 1004, 1, 1, 1, 1, 1),
(133, 12, 1101, 1, 1, 1, 1, 1),
(134, 12, 1102, 1, 1, 1, 1, 1),
(135, 12, 1103, 1, 1, 1, 1, 1),
(136, 12, 1201, 1, 1, 1, 1, 1),
(137, 12, 1301, 1, 1, 1, 1, 1),
(138, 12, 2000, 1, 1, 1, 1, 1),
(139, 12, 3000, 1, 1, 1, 1, 1),
(140, 12, 5000, 1, 1, 1, 1, 1),
(141, 12, 6000, 1, 1, 1, 1, 1),
(142, 12, 6001, 1, 1, 1, 1, 1),
(143, 12, 6002, 1, 1, 1, 1, 1),
(144, 12, 6003, 1, 1, 1, 1, 1),
(145, 12, 6004, 1, 1, 1, 1, 1),
(146, 12, 6005, 1, 1, 1, 1, 1),
(147, 12, 6006, 1, 1, 1, 1, 1),
(148, 12, 6007, 1, 1, 1, 1, 1),
(149, 12, 6101, 1, 1, 1, 1, 1),
(150, 12, 6102, 1, 1, 1, 1, 1),
(151, 12, 6103, 1, 1, 1, 1, 1),
(152, 12, 6104, 1, 1, 1, 1, 1),
(153, 12, 6105, 1, 1, 1, 1, 1),
(154, 12, 6106, 1, 1, 1, 1, 1),
(155, 12, 6201, 1, 1, 1, 1, 1),
(156, 12, 6202, 1, 1, 1, 1, 1),
(157, 12, 6203, 1, 1, 1, 1, 1),
(158, 12, 6301, 1, 1, 1, 1, 1),
(159, 12, 7000, 1, 1, 1, 1, 1),
(160, 12, 8000, 1, 1, 1, 1, 1),
(161, 12, 9000, 1, 1, 1, 1, 1),
(162, 13, 1000, 1, 1, 1, 1, 1),
(163, 13, 1001, 1, 1, 1, 1, 1),
(164, 13, 1002, 1, 1, 1, 1, 1),
(165, 13, 1003, 1, 1, 1, 1, 1),
(166, 13, 1004, 1, 1, 1, 1, 1),
(167, 13, 1101, 1, 1, 1, 1, 1),
(168, 13, 1102, 1, 1, 1, 1, 1),
(169, 13, 1103, 1, 1, 1, 1, 1),
(170, 13, 1201, 1, 1, 1, 1, 1),
(171, 13, 1301, 1, 1, 1, 1, 1),
(172, 13, 2000, 1, 1, 1, 1, 1),
(173, 13, 3000, 1, 1, 1, 1, 1),
(174, 13, 5000, 1, 1, 1, 1, 1),
(175, 13, 6000, 1, 1, 1, 1, 1),
(176, 13, 6001, 1, 1, 1, 1, 1),
(177, 13, 6002, 1, 1, 1, 1, 1),
(178, 13, 6003, 1, 1, 1, 1, 1),
(179, 13, 6004, 1, 1, 1, 1, 1),
(180, 13, 6005, 1, 1, 1, 1, 1),
(181, 13, 6006, 1, 1, 1, 1, 1),
(182, 13, 6007, 1, 1, 1, 1, 1),
(183, 13, 6101, 1, 1, 1, 1, 1),
(184, 13, 6102, 1, 1, 1, 1, 1),
(185, 13, 6103, 1, 1, 1, 1, 1),
(186, 13, 6104, 1, 1, 1, 1, 1),
(187, 13, 6105, 1, 1, 1, 1, 1),
(188, 13, 6106, 1, 1, 1, 1, 1),
(189, 13, 6201, 1, 1, 1, 1, 1),
(190, 13, 6202, 1, 1, 1, 1, 1),
(191, 13, 6203, 1, 1, 1, 1, 1),
(192, 13, 6301, 1, 1, 1, 1, 1),
(193, 13, 7000, 1, 1, 1, 1, 1),
(194, 13, 8000, 1, 1, 1, 1, 1),
(195, 13, 9000, 1, 1, 1, 1, 1),
(196, 14, 1000, 1, 1, 1, 1, 1),
(197, 14, 1001, 1, 1, 1, 1, 1),
(198, 14, 1002, 1, 1, 1, 1, 1),
(199, 14, 1003, 1, 1, 1, 1, 1),
(200, 14, 1004, 1, 1, 1, 1, 1),
(201, 14, 1101, 1, 1, 1, 1, 1),
(202, 14, 1102, 1, 1, 1, 1, 1),
(203, 14, 1103, 1, 1, 1, 1, 1),
(204, 14, 1201, 1, 1, 1, 1, 1),
(205, 14, 1301, 1, 1, 1, 1, 1),
(206, 14, 2000, 1, 1, 1, 1, 1),
(207, 14, 3000, 1, 1, 1, 1, 1),
(208, 14, 5000, 1, 1, 1, 1, 1),
(209, 14, 6000, 1, 1, 1, 1, 1),
(210, 14, 6001, 1, 1, 1, 1, 1),
(211, 14, 6002, 1, 1, 1, 1, 1),
(212, 14, 6003, 1, 1, 1, 1, 1),
(213, 14, 6004, 1, 1, 1, 1, 1),
(214, 14, 6005, 1, 1, 1, 1, 1),
(215, 14, 6006, 1, 1, 1, 1, 1),
(216, 14, 6007, 1, 1, 1, 1, 1),
(217, 14, 6101, 1, 1, 1, 1, 1),
(218, 14, 6102, 1, 1, 1, 1, 1),
(219, 14, 6103, 1, 1, 1, 1, 1),
(220, 14, 6104, 1, 1, 1, 1, 1),
(221, 14, 6105, 1, 1, 1, 1, 1),
(222, 14, 6106, 1, 1, 1, 1, 1),
(223, 14, 6201, 1, 1, 1, 1, 1),
(224, 14, 6202, 1, 1, 1, 1, 1),
(225, 14, 6203, 1, 1, 1, 1, 1),
(226, 14, 6301, 1, 1, 1, 1, 1),
(227, 14, 7000, 1, 1, 1, 1, 1),
(228, 14, 8000, 1, 1, 1, 1, 1),
(229, 14, 9000, 1, 1, 1, 1, 1);
--
-- Volcado de datos para la tabla `tbl_usuarios`
--

INSERT INTO `tbl_usuarios` (`Pk_id_usuario`, `nombre_usuario`, `apellido_usuario`, `username_usuario`, `password_usuario`, `email_usuario`, `ultima_conexion_usuario`, `estado_usuario`, `pregunta`, `respuesta`) VALUES
(1, 'admin', 'admin', 'admin', '52c88f064ed5ed9161d01f634f5e3bfcf5c77fec94fb398b6690e1b41178eb6c', 'esduardo@gmail.com', '2024-09-21 00:55:40', 1, 'COLOR FAVORITO', 'ROJO'),
(2, 'Ismar', 'Cortez', 'Ismar', 'ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f', 'icortezs@miumg.edu.gt', '2024-09-17 17:32:03', 1, 'Nombre de familiar', 'Eunice');

--
-- Volcado de datos para la tabla `tbl_asignaciones_perfils_usuario`
--

INSERT INTO `tbl_asignaciones_perfils_usuario` (`PK_id_Perfil_Usuario`, `Fk_id_usuario`, `Fk_id_perfil`) VALUES
(1, 1, 1);

--
-- Volcado de datos para la tabla `tbl_asignacion_modulo_aplicacion`
--

INSERT INTO `tbl_asignacion_modulo_aplicacion` (`Fk_id_modulos`, `Fk_id_aplicacion`) VALUES
(1000, 1000),
(1000, 1001),
(1000, 1002),
(1000, 1003),
(1000, 1004),
(1000, 1102),
(1000, 1103),
(1000, 1201),
(1000, 1301),
(2000, 2000),
(3000, 3000),
(5000, 5000),
(6000, 6000),
(6000, 6001),
(6000, 6002),
(6000, 6003),
(6000, 6004),
(6000, 6005),
(6000, 6006),
(6000, 6007),
(6000, 6101),
(6000, 6102),
(6000, 6103),
(6000, 6104),
(6000, 6105),
(6000, 6106),
(6000, 6201),
(6000, 6202),
(6000, 6203),
(6000, 6301),
(7000, 7000),
(8000, 8000),
(9000, 9000);

--
-- Volcado de datos para la tabla `tbl_permisos_aplicaciones_usuario`
--

INSERT INTO `tbl_permisos_aplicaciones_usuario` (`PK_id_Aplicacion_Usuario`, `Fk_id_usuario`, `Fk_id_aplicacion`, `guardar_permiso`, `buscar_permiso`, `modificar_permiso`, `eliminar_permiso`, `imprimir_permiso`) VALUES
(1, 1, 1002, 1, 1, 1, 1, 0),
(2, 1, 2000, 0, 0, 0, 0, 0),
(3, 1, 1000, 1, 1, 1, 1, 1),
(4, 1, 8000, 0, 0, 0, 0, 0),
(6, 1, 1000, 1, 1, 1, 1, 1),
(7, 1, 1000, 0, 0, 0, 0, 1),
(8, 1, 9000, 0, 0, 0, 0, 0);

-- Se actualiza la contraseña de admin, ya que no debe ingresarse hasheado manualmente
UPDATE `tbl_usuarios` SET `password_usuario` = 'HO0aGo4nM94=' WHERE `Pk_id_usuario` = 1;

-- Se eliminó el usuario 2 porque solo el admin debe crearse desde la base de datos
DELETE FROM `tbl_usuarios` WHERE `Pk_id_usuario` = 2;

-- Se hashea la contraseña
UPDATE tbl_usuarios
SET password_usuario = SHA2('HO0aGo4nM94=', 256) 
WHERE username_usuario = 'admin';
--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`id_venta`, `monto`, `nombre_cliente`, `nombre_empleado`, `estado`) VALUES
(1, 111, 'Josue', 'David', 1),
(2, 222, 'Fernando', 'David', 1),
(3, 100, 'Josue David', 'Joel Lopez', 1),
(4, 400, 'Sebastian', 'Victor', 1),
(5, 555, 'Brayan', 'Daniel', 1),
(6, 8888, 'pedro', 'perez', 1),
(7, 555, 'roro', 'pablo', 1),
(8, 444, 'shiro', 'rodolfo', 1),
(9, 999, 'Brayan', 'Daniel', 1),
(10, 111, 'shiro', 'sh', 1),
(11, 88, 'lol', 'lol', 1),
(12, 1111, 'lll', 'lll', 1),
(13, 1111, 'www', 'www', 1),
(14, 56456, 'wwww', 'qqq', 1),
(15, 111223, 'hola', 'hol', 1),
(16, 2222, 'yy', 'yyy', 1),
(17, 555, 'ggg', 'ggg', 1),
(18, 100, 'ahora', 'ddd', 1),
(19, 100, 'pedro', 'lucas', 1),
(20, 555, 'cliente', 'empleado', 1),
(21, 200, 'cliente', 'empleado', 1),
(22, 200, 'rrr', 'www', 1),
(23, 333, 'www', 'qqq', 1),
(24, 33, 'eee', 'xxx', 1),
(25, 600, 'ññ', 'lll', 1),
(26, 6456, 'qqq', 'fff', 1),
(27, 555, 'ddd', 'aaa', 1),
(28, 666, 'qqq', 'aaa', 1),
(29, 666, 'cliente', 'empleado', 1),
(30, 888, 'Cliente1', 'Empleado122', 1),
(31, 6666, 'ClientePrueba', 'EmpleadoPrueba', 1),
(32, 6666, 'qq', 'qqq', 1),
(33, 999, 'cliente', 'emple', 1),
(34, 333, 'cli', 'emp', 1),
(35, 65, 'pedro', 'juan', 1),
(36, 65656, 'djf', 'kjk', 1),
(37, 0, '', '', 1),
(38, 0, '', '', 1);


-- LMD DE LOGISTICA INICIO
INSERT INTO Tbl_Productos (codigoProducto, nombreProducto, pesoProducto, precioUnitario, clasificacion, stock, empaque, comisionInventario, comisionCosto, estado, fk_id_marca, fk_id_linea)
VALUES
(1001, 'Colchón Queen', '20 kg', 250.00, 'Dormitorio', 100, 'Caja', 0.10, 0.20, 1, 1, 2),
(1002, 'Colchón King', '25 kg', 350.00, 'Dormitorio', 50, 'Caja', 0.15, 0.20, 1, 3, 1),
(1003, 'Sofá 3 Plazas', '80 kg', 500.00, 'Sala', 30, 'Desarmado', 0.10, 0.20, 1, 2, 3),
(1004, 'Almohada Visc.', '1 kg', 30.00, 'Accesorios', 200, 'Bolsa', 0.15, 0.30, 1, 1, 2),
(1005, 'Mesa de Centro', '25 kg', 120.00, 'Sala', 60, 'Desarmado', 0.10, 0.25, 1, 2, 3);

INSERT INTO TBL_BODEGAS (NOMBRE_BODEGA, UBICACION, CAPACIDAD, FECHA_REGISTRO, estado) 
VALUES 
('Bodega Central', 'Av. Principal 100', 100, '2024-10-23', 1),
('Bodega Norte', 'Calle Norte 200', 80, '2024-10-23', 1),
('Bodega Sur', 'Calle Sur 300', 60, '2024-10-23', 1);


INSERT INTO TBL_EXISTENCIAS_BODEGA (Fk_ID_BODEGA, Fk_ID_PRODUCTO, CANTIDAD_ACTUAL, CANTIDAD_INICIAL)
VALUES
(1, 1, 20, 20),  -- Colchón Queen en Bodega Central
(1, 2, 15, 15),  -- Colchón King en Bodega Central
(2, 3, 10, 10);  -- Sofá 3 Plazas en Bodega Norte

INSERT INTO TBL_AUDITORIAS (Fk_ID_BODEGA, Fk_ID_PRODUCTO, FECHA_AUDITORIA, DISCREPANCIA_DETECTADA, CANTIDAD_REGISTRADA, CANTIDAD_FISICA, OBSERVACIONES)
VALUES 
(1, 1, CURDATE(), FALSE, 20, 20, 'Auditoría de rutina, todo en orden.'),
(2, 3, CURDATE(), TRUE, 8, 10, 'Discrepancia detectada en el Sofá 3 Plazas.');

-- LMD DE LOGISTICA FINAL


-- LMD DE CONTABILIDAD

-- INSERT DE ENCABEZADOS DE CUENTA
INSERT INTO `tbl_encabezadoclasecuenta` (`Pk_id_encabezadocuenta`, `nombre_tipocuenta`, `estado`) VALUES 
('1', 'Activos', '1'),
('2', 'Pasivos', '1'),
('3', 'Patrimonio', '1'),
('4', 'Ingresos', '1'),
('5', 'Gastos', '1');

-- INSERT EN LA TIPO CUENTA
INSERT INTO `tbl_tipocuenta` (`PK_id_tipocuenta`, `nombre_tipocuenta`, `serie_tipocuenta`, `estado`) 
VALUES 
('1', 'Padre', 'P', '1'),
('2', 'Hija', 'H', '1');

-- Insertar tipos principales de pólizas
INSERT INTO `tbl_tipopoliza` (`Pk_id_tipopoliza`, `tipo`, `estado`) VALUES
(2, 'Diario', 1),
(3, 'Ingreso', 1),
(4, 'Egreso', 1),
(5, 'Ajuste', 1),
(6, 'Provisión', 1),
(7, 'Transferencia', 1),
(8, 'Cancelación', 1),
(9, 'Anticipo', 1),
(10, 'Reclasificación', 1),
(11, 'Cierre de Mes', 1),
(12, 'Apertura de Ejercicio', 1);

-- INSERT EN LA TABLA TIPO DE OPERACION
INSERT INTO `tbl_tipooperacion` (`Pk_id_tipooperacion`, `nombre`, `estado`) 
VALUES 
('1', 'Cargo', '1'),
('2', 'Abono', '1');

-- INSERT EN LA TABLA DE CUENTAS
INSERT INTO tbl_cuentas (Pk_id_cuenta, Pk_id_tipocuenta, Pk_id_encabezadocuenta, nombre_cuenta, cargo_mes, abono_mes, saldo_ant, saldo_act, cargo_acumulado, abono_acumulado, Pk_id_cuenta_enlace, es_efectivo, estado)
VALUES
-- Activos
(1, 1, 1, 'Activo', 0, 0, 0, 0, 0, 0, NULL, 1, 1),
(2, 1, 1, 'Activo Corriente', 0, 0, 0, 0, 0, 0, 1, 1, 1),
(3, 2, 1, 'Caja', 0, 0, 0, 0, 0, 0, 2, 1, 1),
(4, 1, 1, 'Bancos', 0, 0, 0, 0, 0, 0, 2, 1, 1),
(5, 2, 1, 'Banco Industrial', 0, 0, 0, 0, 0, 0, 4, 1, 1),
(6, 2, 1, 'Banco G&T Continental', 0, 0, 0, 0, 0, 0, 4, 1, 1),
(7, 2, 1, 'Banco Agromercantil', 0, 0, 0, 0, 0, 0, 4, 1, 1),
(8, 2, 1, 'Cuentas por Cobrar', 0, 0, 0, 0, 0, 0, 2, 0, 1),
(9, 2, 1, 'Clientes', 0, 0, 0, 0, 0, 0, 8, 0, 1),
(10, 2, 1, 'Deudores Diversos', 0, 0, 0, 0, 0, 0, 8, 0, 1),
(11, 2, 1, 'Documentos por Cobrar', 0, 0, 0, 0, 0, 0, 8, 0, 1),
(12, 2, 1, 'Activos Fijos', 0, 0, 0, 0, 0, 0, 1, 0, 1),
(13, 2, 1, 'Propiedades', 0, 0, 0, 0, 0, 0, 12, 0, 1),
(14, 2, 1, 'Maquinaria', 0, 0, 0, 0, 0, 0, 12, 0, 1),
(15, 2, 1, 'Equipo de Oficina', 0, 0, 0, 0, 0, 0, 12, 0, 1),
(16, 2, 1, 'Vehículos', 0, 0, 0, 0, 0, 0, 12, 0, 1),
(17, 2, 1, 'Terrenos', 0, 0, 0, 0, 0, 0, 12, 0, 1),
(18, 2, 1, 'Construcciones en Proceso', 0, 0, 0, 0, 0, 0, 12, 0, 1),
(19, 2, 1, 'Inversiones a Largo Plazo', 0, 0, 0, 0, 0, 0, 2, 0, 1),
(20, 2, 1, 'Instrumentos Financieros a Largo Plazo', 0, 0, 0, 0, 0, 0, 19, 0, 1),
(21, 1, 1, 'Inventarios', 0, 0, 0, 0, 0, 0, 2, 0, 1),
(22, 2, 1, 'Inventario de Productos Terminados', 0, 0, 0, 0, 0, 0, 21, 0, 1),
(23, 2, 1, 'Inventario de Materia Prima', 0, 0, 0, 0, 0, 0, 21, 0, 1),
(24, 1, 1, 'Inversiones a Corto Plazo', 0, 0, 0, 0, 0, 0, 2, 0, 1),
(25, 2, 1, 'Instrumentos Financieros', 0, 0, 0, 0, 0, 0, 24, 0, 1),
(26, 2, 1, 'Fondos Mutuos', 0, 0, 0, 0, 0, 0, 24, 0, 1),
(27, 2, 1, 'Acciones y Participaciones', 0, 0, 0, 0, 0, 0, 19, 0, 1),
(28, 1, 1, 'Intangibles', 0, 0, 0, 0, 0, 0, 2, 0, 1),
(29, 2, 1, 'Patentes', 0, 0, 0, 0, 0, 0, 28, 0, 1),
(30, 2, 1, 'Marcas Registradas', 0, 0, 0, 0, 0, 0, 28, 0, 1),
(31, 2, 1, 'Créditos Comerciales', 0, 0, 0, 0, 0, 0, 8, 0, 1),
(32, 2, 1, 'Anticipos a Proveedores', 0, 0, 0, 0, 0, 0, 8, 0, 1),
(33, 2, 1, 'Propiedades en Leasing', 0, 0, 0, 0, 0, 0, 12, 0, 1),
(34, 2, 1, 'Inversiones Financieras', 0, 0, 0, 0, 0, 0, 19, 0, 1),
(35, 2, 1, 'Depósitos a Plazo Fijo', 0, 0, 0, 0, 0, 0, 19, 0, 1),
(36, 2, 1, 'Cuentas por Cobrar a Largo Plazo', 0, 0, 0, 0, 0, 0, 19, 0, 1),
(37, 2, 1, 'Préstamos a Empleados', 0, 0, 0, 0, 0, 0, 19, 0, 1),
(38, 1, 1, 'Valores y Bonos', 0, 0, 0, 0, 0, 0, 24, 0, 1),
(39, 2, 1, 'Acciones en Subsidiarias', 0, 0, 0, 0, 0, 0, 24, 0, 1),
(40, 2, 1, 'Fideicomisos', 0, 0, 0, 0, 0, 0, 24, 0, 1),
(41, 1, 1, 'Activos No Corrientes', 0, 0, 0, 0, 0, 0, 1, 0, 1),
(42, 2, 1, 'Terrenos', 0, 0, 0, 0, 0, 0, 41, 0, 1),
(43, 2, 1, 'Edificios', 0, 0, 0, 0, 0, 0, 41, 0, 1),
(44, 2, 1, 'Maquinaria', 0, 0, 0, 0, 0, 0, 41, 0, 1),
(45, 2, 1, 'Equipo de Transporte', 0, 0, 0, 0, 0, 0, 41, 0, 1),
(46, 2, 1, 'Mobiliario y Equipo', 0, 0, 0, 0, 0, 0, 41, 0, 1),
(47, 2, 1, 'Equipos de Cómputo', 0, 0, 0, 0, 0, 0, 41, 0, 1),
(48, 1, 1, 'Intangibles', 0, 0, 0, 0, 0, 0, 41, 0, 1),
(49, 2, 1, 'Patentes y Marcas', 0, 0, 0, 0, 0, 0, 48, 0, 1),
(50, 2, 1, 'Depreciación Acumulada', 0, 0, 0, 0, 0, 0, 41, 0, 1),
-- Pasivos Corrientes
(51, 1, 2, 'Pasivo', 0, 0, 0, 0, 0, 0, NULL, 1, 1),
(52, 1, 2, 'Pasivo Corriente', 0, 0, 0, 0, 0, 0, 51, 1, 1),
(53, 1, 2, 'Cuentas por Pagar', 0, 0, 0, 0, 0, 0, 52, 1, 1),
(54, 2, 2, 'Proveedores', 0, 0, 0, 0, 0, 0, 53, 1, 1),
(55, 2, 2, 'Acreedores Diversos', 0, 0, 0, 0, 0, 0, 53, 0, 1),
(56, 2, 2, 'Documentos por Pagar', 0, 0, 0, 0, 0, 0, 53, 0, 1),
(57, 2, 2, 'Préstamos Bancarios a Corto Plazo', 0, 0, 0, 0, 0, 0, 52, 1, 1),
(58, 2, 2, 'Obligaciones por Pagar', 0, 0, 0, 0, 0, 0, 52, 0, 1),
(59, 2, 2, 'Anticipos de Clientes', 0, 0, 0, 0, 0, 0, 52, 0, 1),
(60, 1, 2, 'Impuestos por Pagar', 0, 0, 0, 0, 0, 0, 52, 1, 1),
(61, 2, 2, 'IVA por Pagar', 0, 0, 0, 0, 0, 0, 60, 0, 1),
(62, 2, 2, 'ISR por Pagar', 0, 0, 0, 0, 0, 0, 60, 0, 1),
(63, 2, 2, 'Sueldos por Pagar', 0, 0, 0, 0, 0, 0, 52, 0, 1),
(64, 2, 2, 'Retenciones por Pagar', 0, 0, 0, 0, 0, 0, 52, 0, 1),
(65, 2, 2, 'Provisiones de Bonos', 0, 0, 0, 0, 0, 0, 52, 0, 1),
(66, 1, 2, 'Pasivo No Corriente', 0, 0, 0, 0, 0, 0, 51, 0, 1),
(67, 2, 2, 'Préstamos Bancarios a Largo Plazo', 0, 0, 0, 0, 0, 0, 66, 1, 1),
(68, 2, 2, 'Obligaciones Financieras', 0, 0, 0, 0, 0, 0, 66, 0, 1),
(69, 2, 2, 'Cuentas por Pagar a Largo Plazo', 0, 0, 0, 0, 0, 0, 66, 0, 1),
(70, 2, 2, 'Bonos por Pagar', 0, 0, 0, 0, 0, 0, 66, 1, 1),
(71, 2, 2, 'Obligaciones Laborales', 0, 0, 0, 0, 0, 0, 66, 0, 1),
(72, 2, 2, 'Pasivos Diferidos', 0, 0, 0, 0, 0, 0, 66, 0, 1),
(73, 2, 2, 'Provisiones para Contingencias', 0, 0, 0, 0, 0, 0, 66, 0, 1),
(74, 2, 2, 'Arrendamientos por Pagar', 0, 0, 0, 0, 0, 0, 66, 0, 1),
(75, 2, 2, 'Créditos Hipotecarios', 0, 0, 0, 0, 0, 0, 66, 1, 1),
-- Capital
(78, 1, 3, 'Capital', 0, 0, 0, 0, 0, 0, NULL, 0, 1),
(79, 2, 3, 'Capital Social', 0, 0, 0, 0, 0, 0, 78, 0, 1),
(80, 2, 3, 'Reservas', 0, 0, 0, 0, 0, 0, 78, 0, 1),
(81, 2, 3, 'Ganancias Retenidas', 0, 0, 0, 0, 0, 0, 78, 0, 1),
(82, 2, 3, 'Resultados del Ejercicio', 0, 0, 0, 0, 0, 0, 78, 0, 1),
(83, 2, 3, 'Capital Adicional', 0, 0, 0, 0, 0, 0, 78, 0, 1),
(84, 2, 3, 'Ajustes de Capital', 0, 0, 0, 0, 0, 0, 78, 0, 1),
-- Ingresos
(85, 1, 4, 'Ingresos', 0, 0, 0, 0, 0, 0, NULL, 0, 1),
(86, 2, 4, 'Ventas de Productos', 0, 0, 0, 0, 0, 0, 85, 1, 1),
(87, 2, 4, 'Servicios de Consultoría', 0, 0, 0, 0, 0, 0, 85, 1, 1),
(88, 2, 4, 'Comisiones de Venta', 0, 0, 0, 0, 0, 0, 85, 1, 1),
(89, 2, 4, 'Renta de Equipos', 0, 0, 0, 0, 0, 0, 85, 1, 1),
(90, 2, 4, 'Honorarios Profesionales', 0, 0, 0, 0, 0, 0, 85, 1, 1),
(91, 2, 4, 'Ingresos por Licencias y Regalías', 0, 0, 0, 0, 0, 0, 85, 1, 1),
(92, 2, 4, 'Intereses Ganados', 0, 0, 0, 0, 0, 0, 85, 1, 1),
(93, 2, 4, 'Ventas de Mercadería', 0, 0, 0, 0, 0, 0, 85, 1, 1),
(94, 2, 4, 'Ventas Internacionales', 0, 0, 0, 0, 0, 0, 85, 1, 1),
(95, 2, 4, 'Ingresos por Publicidad', 0, 0, 0, 0, 0, 0, 85, 1, 1),
(96, 2, 4, 'Servicios de Capacitación', 0, 0, 0, 0, 0, 0, 85, 1, 1),
(97, 2, 4, 'Consultoría de TI', 0, 0, 0, 0, 0, 0, 85, 1, 1),
(98, 2, 4, 'Suscripciones', 0, 0, 0, 0, 0, 0, 85, 1, 1),
(99, 2, 4, 'Renta de Propiedades', 0, 0, 0, 0, 0, 0, 85, 1, 1),
(100, 2, 4, 'Donaciones', 0, 0, 0, 0, 0, 0, 85, 1, 1),
-- Egresos
(101, 1, 5, 'Egresos', 0, 0, 0, 0, 0, 0, NULL, 1, 1),
(102, 2, 5, 'Sueldos y Salarios', 0, 0, 0, 0, 0, 0, 101, 1, 1),
(103, 2, 5, 'IGSS', 0, 0, 0, 0, 0, 0, 101, 1, 1),
(104, 2, 5, 'Horas Extras', 0, 0, 0, 0, 0, 0, 101, 1, 1),
(105, 2, 5, 'Anticipos', 0, 0, 0, 0, 0, 0, 101, 1, 1),
(106, 2, 5, 'Faltas', 0, 0, 0, 0, 0, 0, 101, 1, 1),
(107, 2, 5, 'Bono 14', 0, 0, 0, 0, 0, 0, 101, 1, 1),
(108, 2, 5, 'Aguinaldo', 0, 0, 0, 0, 0, 0, 101, 1, 1),
(109, 2, 5, 'Vacaciones', 0, 0, 0, 0, 0, 0, 101, 1, 1),
(110, 2, 5, 'Alquileres', 0, 0, 0, 0, 0, 0, 101, 1, 1),
(111, 2, 5, 'Servicios Públicos', 0, 0, 0, 0, 0, 0, 101, 1, 1),
(112, 2, 5, 'Mantenimiento y Reparaciones', 0, 0, 0, 0, 0, 0, 101, 1, 1),
(113, 2, 5, 'Gastos de Viaje', 0, 0, 0, 0, 0, 0, 101, 1, 1),
(114, 2, 5, 'Seguros', 0, 0, 0, 0, 0, 0, 101, 1, 1),
(115, 2, 5, 'Depreciación de Activos', 0, 0, 0, 0, 0, 0, 101, 1, 1),
(116, 2, 5, 'Otros Gastos', 0, 0, 0, 0, 0, 0, 101, 1, 1);

-- Inserciones para tbl_historico_cuentas
INSERT INTO tbl_historico_cuentas (Pk_id_cuenta, mes, anio, cargo_mes, abono_mes, saldo_ant, saldo_act, cargo_acumulado, abono_acumulado, saldoanual) VALUES
(1, 1, 2024, 100.00, 100.00, 500.00, 1500.00, 800.00, 1000.00, 0.00),
(2, 1, 2024, 150.00, 150.00, 1000.00, 3000.00, 800.00, 1000.00, 0.00),
(3, 1, 2024, 75.00, 75.00, 700.00, 2200.00, 800.00, 1000.00, 0.00),
(4, 1, 2024, 0.00, 100.00, 3000.00, 2500.00, 800.00, 1000.00, 0.00),
(5, 1, 2024, 50.00, 50.00, 1200.00, 500.00, 800.00, 1000.00, 0.00),
(6, 1, 2024, 25.00, 25.00, 0.00, 5000.00, 800.00, 1000.00, 0.00),
(1, 2, 2024, 100.00, 100.00, 500.00, 1500.00, 800.00, 1000.00, 0.00),
(2, 2, 2024, 150.00, 150.00, 1000.00, 3000.00, 800.00, 1000.00, 0.00),
(3, 2, 2024, 75.00, 75.00, 700.00, 2200.00, 800.00, 1000.00, 0.00),
(4, 2, 2024, 0.00, 100.00, 3000.00, 2500.00, 800.00, 1000.00, 0.00),
(5, 2, 2024, 50.00, 50.00, 1200.00, 500.00, 800.00, 1000.00, 0.00),
(6, 2, 2024, 25.00, 25.00, 0.00, 5000.00, 800.00, 1000.00, 0.00),
(1, 3, 2024, 100.00, 100.00, 500.00, 1500.00, 800.00, 1000.00, 0.00),
(2, 3, 2024, 150.00, 150.00, 1000.00, 3000.00, 800.00, 1000.00, 0.00),
(3, 3, 2024, 75.00, 75.00, 700.00, 2200.00, 800.00, 1000.00, 0.00),
(4, 3, 2024, 0.00, 100.00, 3000.00, 2500.00, 800.00, 1000.00, 0.00),
(5, 3, 2024, 50.00, 50.00, 1200.00, 500.00, 800.00, 1000.00, 0.00),
(6, 3, 2024, 25.00, 25.00, 0.00, 5000.00, 800.00, 1000.00, 0.00),
(1, 4, 2024, 100.00, 100.00, 500.00, 1500.00, 800.00, 1000.00, 0.00),
(2, 4, 2024, 150.00, 150.00, 1000.00, 3000.00, 800.00, 1000.00, 0.00),
(3, 4, 2024, 75.00, 75.00, 700.00, 2200.00, 800.00, 1000.00, 0.00),
(4, 4, 2024, 0.00, 100.00, 3000.00, 2500.00, 800.00, 1000.00, 0.00),
(5, 4, 2024, 50.00, 50.00, 1200.00, 500.00, 800.00, 1000.00, 0.00),
(6, 4, 2024, 25.00, 25.00, 0.00, 5000.00, 800.00, 1000.00, 0.00),
(1, 5, 2024, 100.00, 100.00, 500.00, 1500.00, 800.00, 1000.00, 0.00),
(2, 5, 2024, 150.00, 150.00, 1000.00, 3000.00, 800.00, 1000.00, 0.00),
(3, 5, 2024, 75.00, 75.00, 700.00, 2200.00, 800.00, 1000.00, 0.00),
(4, 5, 2024, 0.00, 100.00, 3000.00, 2500.00, 800.00, 1000.00, 0.00),
(5, 5, 2024, 50.00, 50.00, 1200.00, 500.00, 800.00, 1000.00, 0.00),
(6, 5, 2024, 25.00, 25.00, 0.00, 5000.00, 800.00, 1000.00, 0.00),
(1, 6, 2024, 100.00, 100.00, 500.00, 1500.00, 800.00, 1000.00, 0.00),
(2, 6, 2024, 150.00, 150.00, 1000.00, 3000.00, 800.00, 1000.00, 0.00),
(3, 6, 2024, 75.00, 75.00, 700.00, 2200.00, 800.00, 1000.00, 0.00),
(4, 6, 2024, 0.00, 100.00, 3000.00, 2500.00, 800.00, 1000.00, 0.00),
(5, 6, 2024, 50.00, 50.00, 1200.00, 500.00, 800.00, 1000.00, 0.00),
(6, 6, 2024, 25.00, 25.00, 0.00, 5000.00, 800.00, 1000.00, 0.00),
(1, 7, 2024, 100.00, 100.00, 500.00, 1500.00, 800.00, 1000.00, 0.00),
(2, 7, 2024, 150.00, 150.00, 1000.00, 3000.00, 800.00, 1000.00, 0.00),
(3, 7, 2024, 75.00, 75.00, 700.00, 2200.00, 800.00, 1000.00, 0.00),
(4, 7, 2024, 0.00, 100.00, 3000.00, 2500.00, 800.00, 1000.00, 0.00),
(5, 7, 2024, 50.00, 50.00, 1200.00, 500.00, 800.00, 1000.00, 0.00),
(6, 7, 2024, 25.00, 25.00, 0.00, 5000.00, 800.00, 1000.00, 0.00),
(1, 8, 2024, 100.00, 100.00, 500.00, 1500.00, 800.00, 1000.00, 0.00),
(2, 8, 2024, 150.00, 150.00, 1000.00, 3000.00, 800.00, 1000.00, 0.00),
(3, 8, 2024, 75.00, 75.00, 700.00, 2200.00, 800.00, 1000.00, 0.00),
(4, 8, 2024, 0.00, 100.00, 3000.00, 2500.00, 800.00, 1000.00, 0.00),
(5, 8, 2024, 50.00, 50.00, 1200.00, 500.00, 800.00, 1000.00, 0.00),
(6, 8, 2024, 25.00, 25.00, 0.00, 5000.00, 800.00, 1000.00, 0.00),
(1, 9, 2024, 100.00, 100.00, 500.00, 1500.00, 800.00, 1000.00, 0.00),
(2, 9, 2024, 150.00, 150.00, 1000.00, 3000.00, 800.00, 1000.00, 0.00),
(3, 9, 2024, 75.00, 75.00, 700.00, 2200.00, 800.00, 1000.00, 0.00),
(4, 9, 2024, 0.00, 100.00, 3000.00, 2500.00, 800.00, 1000.00, 0.00),
(5, 9, 2024, 50.00, 50.00, 1200.00, 500.00, 800.00, 1000.00, 0.00),
(6, 9, 2024, 25.00, 25.00, 0.00, 5000.00, 800.00, 1000.00, 0.00),
(1, 10, 2024, 100.00, 100.00, 500.00, 1500.00, 800.00, 1000.00, 0.00),
(2, 10, 2024, 150.00, 150.00, 1000.00, 3000.00, 800.00, 1000.00, 0.00),
(3, 10, 2024, 75.00, 75.00, 700.00, 2200.00, 800.00, 1000.00, 0.00),
(4, 10, 2024, 0.00, 100.00, 3000.00, 2500.00, 800.00, 1000.00, 0.00),
(5, 10, 2024, 50.00, 50.00, 1200.00, 500.00, 800.00, 1000.00, 0.00),
(6, 10, 2024, 25.00, 25.00, 0.00, 5000.00, 800.00, 1000.00, 0.00);

-- LMD DE CONTABILIDAD FINAL

-- LMD de Nominas
-- Ingresos obligatorios Nominas
INSERT INTO tbl_dedu_perp (dedu_perp_clase, dedu_perp_concepto, dedu_perp_tipo, dedu_perp_aplicacion, dedu_perp_excepcion, dedu_perp_monto, estado) 
VALUES ('Deduccion','Faltas', 'Porcentaje', 'Todos', 0, 20.00, 1);

INSERT INTO tbl_dedu_perp (dedu_perp_clase, dedu_perp_concepto, dedu_perp_tipo, dedu_perp_aplicacion, dedu_perp_excepcion, dedu_perp_monto, estado) 
VALUES ('Percepcion','Anticipo', 'Monto', 'Todos', 0, 1, 1);

INSERT INTO tbl_dedu_perp (dedu_perp_clase, dedu_perp_concepto, dedu_perp_tipo, dedu_perp_aplicacion, dedu_perp_excepcion, dedu_perp_monto, estado) 
VALUES ('Percepcion','Horas Extras', 'Monto', 'Todos', 0, 1, 1);

INSERT INTO tbl_dedu_perp (dedu_perp_clase, dedu_perp_concepto, dedu_perp_tipo, dedu_perp_aplicacion, dedu_perp_excepcion, dedu_perp_monto,estado) 
VALUES ('Bono 14','Bono 14','Porcentaje','Todos',0,0.0833,1);

INSERT INTO tbl_dedu_perp (dedu_perp_clase, dedu_perp_concepto,dedu_perp_tipo,dedu_perp_aplicacion,dedu_perp_excepcion,dedu_perp_monto,estado) 
VALUES ('Aguinaldo','Aguinaldo','Porcentaje','Todos',0,0.0833,1);

INSERT INTO tbl_dedu_perp (dedu_perp_clase,dedu_perp_concepto,dedu_perp_tipo,dedu_perp_aplicacion,dedu_perp_excepcion,dedu_perp_monto,estado) 
VALUES ('Vacaciones','Vacaciones','Porcentaje','Todos',0, 0.0575 ,1);

-- Para seguridad

insert into tbl_aplicaciones (pk_id_aplicacion, nombre_aplicacion, descripcion_aplicacion, estado_aplicacion) values
(6008, "Mant. Anticipos", "PARA NOMINAS", 1);

INSERT INTO Tbl_aplicaciones (Pk_id_aplicacion,nombre_aplicacion,descripcion_aplicacion,estado_aplicacion) 
VALUES (6107,'Cálculo liquidaciones','PARA NÓMINAS',1);

SET SQL_SAFE_UPDATES = 1; -- activar el modo seguro

-- CONTABILIDAD 07/11/2024
UPDATE tbl_cuentas
SET Pk_id_tipocuenta = 1
WHERE Pk_id_cuenta = 8;

-- cuentas corrientes 07/11/2024

-- Insertar registros en Tbl_cobrador
INSERT INTO Tbl_cobrador (Fk_id_empleado, cobrador_nombre, cobrador_direccion, cobrador_telefono, cobrador_depto, estado)
VALUES 
(1, 'Pedro López', 'Av. Central, Ciudad', 5551234, 'Departamento 1', 1),
(2, 'Sofía Martínez', 'Calle Principal, Ciudad', 5555678, 'Departamento 2', 1),
(3, 'Carlos Ramírez', 'Zona Sur, Ciudad', 5559876, 'Departamento 3', 0);


-- Insertar registros en Tbl_transaccion_cuentas
INSERT INTO Tbl_transaccion_cuentas (tran_nombre, tran_efecto, estado)
VALUES 
('Pago en Efectivo', '-', 1),
('Pago con Tarjeta de Credito', '-', 1),
('Transferencia Bancaria', '-', 1),
('Pago con Tarjeta de Débito', '-', 1),
('Pago con cheque', '-', 1),
('Factura', '+', 1),
('Nota de Crédito', '-', 1),
('Nota de Débito', '+', 1);


-- LMD DE NOMINAS 09-11-2024
-- Insertar datos en tbl_puestos_trabajo
INSERT INTO tbl_puestos_trabajo (puestos_nombre_puesto, puestos_descripcion, estado) VALUES 
('Desarrollador', 'Responsable de desarrollar software', 1),
('Analista', 'Analiza los requisitos del proyecto', 1),
('Gerente', 'Gerente de proyectos', 1);

-- Insertar datos en tbl_departamentos
INSERT INTO tbl_departamentos (departamentos_nombre_departamento, departamentos_descripcion, estado) VALUES 
('Tecnología', 'Departamento de IT', 1),
('Recursos Humanos', 'Gestión de personal', 1),
('Finanzas', 'Gestión de recursos financieros', 1);

-- Insertar datos en tbl_empleados
INSERT INTO tbl_empleados (empleados_nombre, empleados_apellido, empleados_fecha_nacimiento, empleados_no_identificacion, empleados_codigo_postal, empleados_fecha_alta, empleados_fecha_baja, empleados_causa_baja, fk_id_departamento, fk_id_puestos, estado) VALUES 
('Juan', 'Pérez', '1990-05-14', '1234567890', '01001', '2022-01-10', '2024-04-15', 'Renuncia voluntaria', 1, 1, 1),
('Ana', 'López', '1985-08-25', '9876543210', '01002', '2021-05-15', '2024-06-01', 'Fin de contrato', 2, 2, 1),
('Luis', 'Gómez', '1978-11-03', '1122334455', '01003', '2020-03-20', '2024-09-30', 'Jubilación', 3, 3, 1);

-- Insertar datos en tbl_contratos
INSERT INTO tbl_contratos (contratos_fecha_creacion, contratos_salario, contratos_tipo_contrato, fk_clave_empleado, estado) VALUES 
('2022-01-10', 3500.00, 'Indefinido', 1, 1),
('2021-05-15', 2500.00, 'Temporal', 2, 1),
('2020-03-20', 4000.00, 'Indefinido', 3, 1);

-- --------------------------------------------------------------------------------------------------------------
-- Insertar datos en tbl_proveedores
INSERT INTO tbl_proveedores 
(Pk_prov_id, Prov_nombre, Prov_direccion, Prov_telefono, Prov_email, Prov_fechaRegistro, estado, Proveedor_deuda)
VALUES
(1, 'Distribuidora El Sol', 'Calle 123, Zona 1', '5555-1234', 'contacto@elsol.com', '2024-01-10', 1, 0.00),
(2, 'TechImport S.A.', 'Av. Reforma 45, Zona 9', '5555-5678', 'ventas@techimport.com', '2024-02-15', 1, 0.00),
(3, 'Insumos Médicos XYZ', 'Boulevard Vista Hermosa, Zona 15', '5555-8910', 'ventas@insumosxyz.com', '2024-03-20', 1, 0.00);

-- Insertar datos en tbl_facturas de proveedores
INSERT INTO tbl_factura_proveedor 
(Pk_id_FacturaProv, Fk_id_compra, Fk_numero_factura, Fk_No_serial_factura, Fk_prov_id, fecha_emision, fecha_vencimiento, Total_a_pagar, saldo)
VALUES
(5001, 1001, 'FAC-001', 'SRL-001', 1, '2024-03-01', '2024-04-01', 1500.00, 1500.00),  -- Proveedor 1
(5002, 1002, 'FAC-002', 'SRL-002', 2, '2024-03-05', '2024-04-05', 2000.00, 2000.00),  -- Proveedor 2
(5003, 1003, 'FAC-003', 'SRL-003', 2, '2024-03-10', '2024-04-10', 1800.00, 1800.00),  -- Proveedor 2
(5004, 1004, 'FAC-004', 'SRL-004', 3, '2024-03-15', '2024-04-15', 2200.00, 2200.00),  -- Proveedor 3
(5005, 1005, 'FAC-005', 'SRL-005', 3, '2024-03-20', '2024-04-20', 2500.00, 2500.00);  -- Proveedor 3


-- Insertar datos en tbl_encabezado de compras
INSERT INTO tbl_encabezado_compras 
(id_compra, numero_factura, No_serial_factura, id_proveedor, fecha_compra)
VALUES
(1001, 'FAC-001', 'SRL-001', 1, '2024-03-01'),  -- Proveedor 1
(1002, 'FAC-002', 'SRL-002', 2, '2024-03-05'),  -- Proveedor 2
(1003, 'FAC-003', 'SRL-003', 2, '2024-03-10'),  -- Proveedor 2
(1004, 'FAC-004', 'SRL-004', 3, '2024-03-15'),  -- Proveedor 3
(1005, 'FAC-005', 'SRL-005', 3, '2024-03-20');  -- Proveedor 3

-- 1. Insertar proveedor
INSERT INTO Tbl_proveedores (Pk_prov_id, Prov_nombre, Prov_direccion, Prov_telefono, Prov_email, Prov_fechaRegistro)
VALUES (4, 'Proveedor X', 'Dirección X', '123456789', 'proveedorx@mail.com', '2024-01-01'),
(5, 'Proveedor y', 'Dirección y', '987654321', 'proveedory@mail.com', '2024-01-01');

-- 2. Insertar encabezado de compra
INSERT INTO tbl_encabezado_compras (id_compra, numero_factura, No_serial_factura, id_proveedor, fecha_compra)
VALUES (100, 'FAC-001', 'SER-001', 1, '2024-01-15');

-- 3. Insertar factura proveedor
INSERT INTO Tbl_Factura_Proveedor (Fk_id_compra, Fk_numero_factura, Fk_No_serial_factura, Fk_prov_id, fecha_emision, fecha_vencimiento, Total_a_pagar, saldo)
VALUES (100, 'FAC-001', 'SER-001', 1, '2024-01-15', '2024-03-15', 1000.00, 1000.00);

-- IMPORTANTE: Obtener el ID de la factura recién creada:
-- Supongamos que es el 1 (Pk_id_FacturaProv = 1)

-- 4. Insertar deudas de proveedor (varias fechas)
INSERT INTO Tbl_Deudas_Proveedores (Fk_id_proveedor, deuda_monto, deuda_fecha_inicio, deuda_fecha_vencimiento, deuda_descripcion, deuda_estado, transaccion_tipo, Efecto_trans, Fk_id_factura)
VALUES 
(1, 500.00, '2024-01-20', '2024-03-20', 'Deuda 1', 1, 'Compra', 'Negativo', 1),
(1, 250.00, '2024-02-10', '2024-04-10', 'Deuda 2', 1, 'Compra', 'Negativo', 1),
(2, 500.00, '2025-01-20', '2024-03-20', 'Deuda 1', 1, 'Compra', 'Negativo', 1),
(2, 250.00, '2025-02-10', '2024-04-10', 'Deuda 2', 1, 'Compra', 'Negativo', 1),
(5, 750.00, '2024-03-01', '2024-05-01', 'Deuda 3', 1, 'Compra', 'Negativo', 1),
(4, 750.00, '2024-03-01', '2024-05-01', 'Deuda 3', 1, 'Compra', 'Negativo', 1);

INSERT INTO tbl_empleados (
    empleados_nombre, empleados_apellido, empleados_fecha_nacimiento,
    empleados_no_identificacion, empleados_codigo_postal, empleados_fecha_alta,
    empleados_fecha_baja, empleados_causa_baja, fk_id_departamento, fk_id_puestos, estado
) VALUES (
    'Luis', 'García', '1990-03-15',
    'DPI-123456789', '01010', '2023-01-01',
    NULL, NULL, 1, 1, 1
);

INSERT INTO Tbl_cobrador (
    Fk_id_empleado, cobrador_nombre, cobrador_direccion,
    cobrador_telefono, cobrador_depto, estado
) VALUES (
    1, 'Luis García', 'Zona 10, Ciudad', 55551234, 'Guatemala', 1
);

INSERT INTO Tbl_clientes (
    Pk_id_cliente, Clientes_nombre, Clientes_apellido, Clientes_nit,
    Clientes_telefon, Clientes_direccion, Clientes_No_Cuenta,
    Cliente_email, Cliente_Tipo, Cliente_lim_credito,
    Cliente_dias_credito, Fecha_Registro
) VALUES (
    6, 'Ana', 'Lopez', '1234567-8',
    '5555-1234', 'Colonia Centro', 'CT-001',
    'ana@example.com', 'Crédito', 5000.00,
    30, '2024-06-01'
);

INSERT INTO Tbl_clientes (
    Pk_id_cliente,
    Clientes_nombre,
    Clientes_apellido,
    Clientes_nit,
    Clientes_telefon,
    Clientes_direccion,
    Clientes_No_Cuenta,
    estado,
    Cliente_email,
    Cliente_Tipo,
    Cliente_lim_credito,
    Cliente_dias_credito,
    Fecha_Registro
)
VALUES (
    7,
    'Andrea',
    'Gómez',
    '9876543-2',
    '4498765432',
    'Zona 5, Guatemala',
    'CTA-002',
    1,
    'andrea.gomez@example.com',
    'Crédito',
    5000.00,
    30,
    '2025-05-20'
);


INSERT INTO Tbl_Factura_Cliente (
    Fk_id_venta, Fk_No_serie, Fk_No_de_facV,
    id_clienteFact, fecha_emision, fecha_vencimiento,
    Total_a_pagar, saldo
) VALUES (
    101, 'SER001', NULL,
    1, '2024-06-10', '2024-07-10',
    1500.00, 1500.00
);

INSERT INTO Tbl_Deudas_Clientes (
    Fk_id_cliente, Fk_id_cobrador, Fk_id_factura,
    deuda_monto, deuda_fecha_inicio_deuda, deuda_fecha_vencimiento_deuda,
    deuda_descripcion_deuda, deuda_estado
) VALUES (
    6, 1, 1,
    1500.00, '2024-06-10', '2024-07-10',
    'Compra de productos varios a crédito', 1
);

INSERT INTO Tbl_Deudas_Clientes (
    Fk_id_cliente,
    Fk_id_cobrador,
    Fk_id_factura,
    deuda_monto,
    deuda_fecha_inicio_deuda,
    deuda_fecha_vencimiento_deuda,
    deuda_descripcion_deuda,
    deuda_estado
)
VALUES (
    7,                      
    1,                      
    1,                      
    1500.75,                
    '2025-05-01',           
    '2025-06-01',           
    'Pago pendiente por servicios prestados', 
    1                       
);

INSERT INTO tbl_vendedores (
    Pk_id_vendedor, vendedores_nombre, vendedores_apellido, 
    vendedores_sueldo, vendedores_direccion, vendedores_telefono, 
    Fk_id_empleado, estado
) VALUES
(1, 'Carlos', 'Ramírez', 850.50, 'Ciudad', '55345678', 1, 1),
(2, 'Lucía', 'Gómez', 920.00, 'Ciudad', '55345789', 1, 1),
(3, 'Marco', 'López', 880.75, 'Ciudad', '55456890', 2, 1),
(4, 'Ana', 'Pérez', 910.25, 'Ciudad', '55567891', 3, 1);
select* from tbl_vendedores;
-- Insertar varias comisiones para el primer vendedor (Carlos)
INSERT INTO tbl_comisiones_encabezado (
    Pk_id_comisionEnc,
    Fk_id_vendedor, 
    Comisiones_fecha_, 
    Comisiones_total_venta, 
    Comisiones_total_comision
) VALUES 
(1,1, '2025-01-01', 10000.00, 1000.00),
(2,1, '2025-01-08', 15000.00, 1500.00),
(3,1, '2025-01-15', 12000.00, 1200.00),
(4,2, '2025-01-15', 12000.00, 1000.00);

INSERT INTO tbl_factura (
    Pk_id_factura, Fk_id_cliente, Fk_id_pedidoEnc, 
    factura_fecha, factura_formPago, 
    factura_subtotal, factura_iva, factura_total
) VALUES
(1, 1, 2, '2025-03-03', 'Transferencia', 600.00, 90.00, 690.00),
(2, 2, 1, '2025-02-03', 'Efectivo', 450.00, 67.50, 517.50),
(3, 1, 3, '2025-04-03', 'Tarjeta de Crédito', 700.00, 105.00, 805.00),
(4, 2, 1, '2025-01-03', 'Tarjeta de Crédito', 300.00, 205.00, 505.00);

INSERT INTO tbl_pedido_encabezado (
    Pk_id_PedidoEnc, Fk_id_cliente, Fk_id_vendedor, 
    PedidoEncfecha, PedidoEnc_total
) VALUES
(1, 1, 1, '2025-02-15', 5000.00),
(2, 2, 2, '2025-03-15', 3200.00),
(3, 3, 3, '2025-01-15', 7500.00),
(4, 2, 3, '2025-02-15', 8500.00);


INSERT INTO tbl_pedido_detalle (
    Fk_id_pedidoEnc, Fk_id_producto, Fk_id_cotizacionEnc,
    PedidoDet_cantidad, PedidoEnc_precio, PedidoEnc_total
) VALUES
(1, 1, 1, 200, 35.00, 7000.00),
(2, 2, 2, 150, 40.00, 6000.00),
(3, 3, 3, 100, 55.00, 5500.00),
(4, 2, 3, 200, 35.00, 4500.00);


INSERT INTO tbl_recetas (
    Pk_id_receta, Fk_id_producto, descripcion, cantidad, 
    area, cama, estado, dias, horas
) VALUES
(1, 1, 'Antibiótico A', 30, 'Pediatría', 'Cama 1', 1, 10, 8.00),
(2, 2, 'Analgésico B', 20, 'Urgencias', 'Cama 2', 1, 5, 6.00),
(3, 3, 'Suero C', 15, 'Medicina Interna', 'Cama 3', 1, 3, 4.00),
(4, 2, 'Suero A', 15, 'Medicina Interna', 'Cama 4', 1, 4, 5.00);


INSERT INTO tbl_factura_cliente 
(Fk_id_venta, Fk_No_serie, Fk_No_de_facV, id_clienteFact, fecha_emision, fecha_vencimiento, Total_a_pagar, saldo)
VALUES
(1001, '123ABC', 1, 1, '2024-05-01', '2024-05-15', 1200.00, 1200.00), -- Carlos Ramírez
(1002, '123ABC', 2, 2, '2024-05-03', '2024-05-17', 800.00, 800.00),   -- María González
(1003, '456DEF', 3, 3, '2024-05-05', '2024-05-20', 1500.00, 1500.00), -- José Martínez
(1004, '789GHI', 4, 4, '2024-05-06', '2024-05-21', 600.00, 600.00),   -- Ana Hernández
(1005, '789GHI', 5, 5, '2024-05-07', '2024-05-22', 950.00, 950.00);   -- Luis López

INSERT INTO tbl_clientes 
(Pk_id_cliente, Clientes_nombre, Clientes_apellido, Clientes_nit, Clientes_telefon, 
 Clientes_direccion, Clientes_No_Cuenta, estado, Cliente_email, Cliente_Tipo, 
 Cliente_lim_credito, Cliente_dias_credito, Fecha_Registro)
VALUES
(1, 'Carlos', 'Ramírez', '1234567-8', '5555-1111', 'Zona 1, Ciudad', '10001', 1, 'carlos.ramirez@mail.com', 'Crédito', 5000.00, 30, '2024-01-15'),
(2, 'María', 'González', '2345678-9', '5555-2222', 'Zona 3, Ciudad', '10002', 1, 'maria.gonzalez@mail.com', 'Contado', 0.00, 0, '2024-02-01'),
(3, 'José', 'Martínez', '3456789-0', '5555-3333', 'Zona 7, Ciudad', '10003', 1, 'jose.martinez@mail.com', 'Crédito', 8000.00, 45, '2024-03-10'),
(4, 'Ana', 'Hernández', '4567890-1', '5555-4444', 'Zona 9, Ciudad', '10004', 1, 'ana.hernandez@mail.com', 'Contado', 0.00, 0, '2024-04-05'),
(5, 'Luis', 'López', '5678901-2', '5555-5555', 'Zona 11, Ciudad', '10005', 1, 'luis.lopez@mail.com', 'Crédito', 6000.00, 60, '2024-05-01');


SELECT 
    Tbl_factura.Pk_id_factura AS IdVenta,
    Tbl_factura.factura_fecha AS FechaVenta,
    Tbl_Productos.nombreProducto AS Producto,
    Tbl_Marca.nombre_Marca AS Marca,
    Tbl_Linea.nombre_linea AS Linea,
    Tbl_pedido_detalle.PedidoDet_cantidad AS CantidadVendida,
    Tbl_factura.factura_total AS Total,
    Tbl_Productos.comisionInventario AS Comision
FROM Tbl_factura
JOIN Tbl_pedido_encabezado ON Tbl_factura.Fk_id_pedidoEnc = Tbl_pedido_encabezado.Pk_id_PedidoEnc
JOIN Tbl_pedido_detalle ON Tbl_pedido_encabezado.Pk_id_PedidoEnc = Tbl_pedido_detalle.Fk_id_pedidoEnc
JOIN Tbl_Productos ON Tbl_pedido_detalle.Fk_id_producto = Tbl_Productos.Pk_id_Producto
JOIN Tbl_Marca ON Tbl_Productos.fk_id_marca = Tbl_Marca.Pk_id_Marca
JOIN Tbl_Linea ON Tbl_Productos.fk_id_linea = Tbl_Linea.Pk_id_linea
WHERE Tbl_factura.factura_fecha BETWEEN '2025-01-01' AND '2025-05-19' ;