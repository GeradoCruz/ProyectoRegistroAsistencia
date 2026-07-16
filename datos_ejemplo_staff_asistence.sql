-- Datos de ejemplo para equipo1_staff_asistence
-- Borra TODOS los registros de TODAS las tablas y los reemplaza con datos
-- de prueba. tblasistencia y tblincidencias se dejan vacias a proposito,
-- para que puedas probar el registro de asistencia en vivo desde la app
-- (esas tablas se llenan solas al usar frmRegistroAsistencia).

USE `equipo1_staff_asistence`;

SET FOREIGN_KEY_CHECKS = 0;

TRUNCATE TABLE `tblincidencias`;
TRUNCATE TABLE `tblasistencia`;
TRUNCATE TABLE `tblhorario_trabajo`;
TRUNCATE TABLE `tblusuarios`;
TRUNCATE TABLE `tbltrabajador`;
TRUNCATE TABLE `tblsemestres`;
TRUNCATE TABLE `tblpuestos`;
TRUNCATE TABLE `tbldepartamento`;

SET FOREIGN_KEY_CHECKS = 1;

-- ================= tbldepartamento =================
INSERT INTO `tbldepartamento` (`nombre_departamento`, `descripcion`) VALUES
('Sistemas Computacionales', 'Ingenieria en Sistemas Computacionales'),
('Gestion y Administracion de PyMES', 'Gestion y Administracion de Pequenas y Medianas Empresas'),
('Mecatronica', 'Ingenieria en Mecatronica'),
('Servicios Escolares', 'Control escolar y administracion academica');

-- ================= tblpuestos =================
INSERT INTO `tblpuestos` (`nombre_puesto`, `id_departamento`) VALUES
('Docente', 1),
('Docente', 2),
('Docente', 3),
('Auxiliar Administrativo', 4),
('Jefe de Departamento', 1);

-- ================= tblsemestres =================
INSERT INTO `tblsemestres` (`semestre`) VALUES
('Ene-Jun26'),
('Ago-Dic25');

-- ================= tbltrabajador =================
INSERT INTO `tbltrabajador`
(`clave_trabajador`, `nombre`, `a_paterno`, `a_materno`, `telefono`, `email`, `sexo`, `fecha_ingreso`, `municipio`, `localidad`, `cp`, `numero_calle`, `id_departamento`, `id_puesto`, `estatus`) VALUES
('TR-001', 'Kevin', 'Solares', 'Martinez', '7711234501', 'kevin.solares@uthh.edu.mx', 'M', '2022-08-15', 'Huejutla de Reyes', 'Centro', '43000', 12, 1, 1, 'activo'),
('TR-002', 'Ana Laura', 'Hernandez', 'Perez', '7711234502', 'ana.hernandez@uthh.edu.mx', 'F', '2021-01-10', 'Huejutla de Reyes', 'Centro', '43000', 45, 2, 2, 'activo'),
('TR-003', 'Jorge Ivan', 'Reyes', 'Cruz', '7711234503', 'jorge.reyes@uthh.edu.mx', 'M', '2023-02-20', 'Huejutla de Reyes', 'Centro', '43000', 8, 3, 3, 'activo'),
('TR-004', 'Maria Fernanda', 'Lopez', 'Gomez', '7711234504', 'maria.lopez@uthh.edu.mx', 'F', '2020-09-01', 'Huejutla de Reyes', 'Centro', '43000', 21, 4, 4, 'activo'),
('TR-005', 'Roberto Carlos', 'Juarez', 'Silva', '7711234505', 'roberto.juarez@uthh.edu.mx', 'M', '2019-03-05', 'Huejutla de Reyes', 'Centro', '43000', 33, 1, 5, 'activo');

-- ================= tblusuarios =================
-- Contrasena en texto plano de cada cuenta (se guarda hasheada con MD5, igual que hace clsLogin):
--   kevin.solares    -> Uthh2026*   (administrador)
--   maria.lopez      -> Uthh2026*   (auxiliar_reportes)
--   roberto.juarez   -> Uthh2026*   (jefe_departamento)
INSERT INTO `tblusuarios` (`nombre_usuario`, `password`, `perfil`, `id_trabajador`) VALUES
('kevin.solares', MD5('Uthh2026*'), 'administrador', 1),
('maria.lopez', MD5('Uthh2026*'), 'auxiliar_reportes', 4),
('roberto.juarez', MD5('Uthh2026*'), 'jefe_departamento', 5);

-- ================= tblhorario_trabajo =================
-- Lunes a viernes para la mayoria; Jorge tiene turno partido (dos bloques el mismo dia).
INSERT INTO `tblhorario_trabajo` (`hora_entrada`, `hora_salida`, `dia`, `id_semestre`, `id_trabajador`) VALUES
('08:00:00', '14:00:00', 'Lunes', 1, 1),
('08:00:00', '14:00:00', 'Martes', 1, 1),
('08:00:00', '14:00:00', 'Miercoles', 1, 1),
('08:00:00', '14:00:00', 'Jueves', 1, 1),
('08:00:00', '14:00:00', 'Viernes', 1, 1),

('09:00:00', '15:00:00', 'Lunes', 1, 2),
('09:00:00', '15:00:00', 'Miercoles', 1, 2),
('09:00:00', '15:00:00', 'Viernes', 1, 2),

('10:00:00', '13:00:00', 'Martes', 1, 3),
('15:00:00', '18:00:00', 'Martes', 1, 3),
('10:00:00', '13:00:00', 'Jueves', 1, 3),
('15:00:00', '18:00:00', 'Jueves', 1, 3),

('08:00:00', '16:00:00', 'Lunes', 1, 4),
('08:00:00', '16:00:00', 'Martes', 1, 4),
('08:00:00', '16:00:00', 'Miercoles', 1, 4),
('08:00:00', '16:00:00', 'Jueves', 1, 4),
('08:00:00', '16:00:00', 'Viernes', 1, 4),

('08:00:00', '14:00:00', 'Lunes', 1, 5),
('08:00:00', '14:00:00', 'Martes', 1, 5),
('08:00:00', '14:00:00', 'Miercoles', 1, 5),
('08:00:00', '14:00:00', 'Jueves', 1, 5),
('08:00:00', '14:00:00', 'Viernes', 1, 5);

-- tblasistencia y tblincidencias quedan vacias (0 registros) a proposito.
