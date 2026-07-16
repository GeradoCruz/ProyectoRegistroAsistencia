-- Datos de ejemplo de asistencias/incidencias para una semana completa
-- (Lunes 06 a Viernes 10 de julio de 2026) usando los trabajadores TR-001 a TR-005
-- ya creados en datos_ejemplo_staff_asistence.sql.
--
-- Cubre a proposito los escenarios de los reportes semanales:
--   - Puntual, Retardo y Falta
--   - Incidencias justificadas y pendientes
--   - Un trabajador con semana perfecta (Roberto)
--   - Una ausencia total (Kevin el viernes, no hay ningun registro)
--   - Turno partido con dos registros el mismo dia (Jorge)
--
-- No borra nada; solo agrega. Si ya corriste esto antes, vuelve a correr
-- primero migracion_tblasistencia.sql + datos_ejemplo_staff_asistence.sql
-- para partir de tablas limpias.

USE `equipo1_staff_asistence`;

-- ================= Kevin Solares (id_trabajador = 1, Lunes-Viernes 08:00) =================
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-06', '07:55:00', 1); -- Lunes: Puntual

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-07', '08:05:00', 1); -- Martes: Puntual

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-08', '08:15:00', 1); -- Miercoles: Retardo (justificada)
SET @id := LAST_INSERT_ID();
INSERT INTO tblincidencias (tipo_incidencia, justificacion, fecha, id_trabajador, id_asistencia)
VALUES ('Retardo', 'Trafico en la carretera, justificante entregado', '2026-07-08', 1, @id);

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-09', '08:00:00', 1); -- Jueves: Puntual

-- Viernes 2026-07-10: sin ningun registro (ausencia total, para el reporte 5)

-- ================= Ana Laura Hernandez (id_trabajador = 2, Lun/Mie/Vie 09:00) =================
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-06', '09:02:00', 2); -- Lunes: Puntual

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-08', '09:25:00', 2); -- Miercoles: Falta (pendiente)
SET @id := LAST_INSERT_ID();
INSERT INTO tblincidencias (tipo_incidencia, justificacion, fecha, id_trabajador, id_asistencia)
VALUES ('Falta', NULL, '2026-07-08', 2, @id);

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-10', '08:58:00', 2); -- Viernes: Puntual

-- ================= Jorge Ivan Reyes (id_trabajador = 3, Mar/Jue, turno partido) =================
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-07', '10:12:00', 3); -- Martes entrada: Retardo (pendiente)
SET @id := LAST_INSERT_ID();
INSERT INTO tblincidencias (tipo_incidencia, justificacion, fecha, id_trabajador, id_asistencia)
VALUES ('Retardo', NULL, '2026-07-07', 3, @id);
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-07', '15:03:00', 3); -- Martes segundo bloque (no se califica)

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-09', '10:05:00', 3); -- Jueves entrada: Puntual
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-09', '15:00:00', 3); -- Jueves segundo bloque

-- ================= Maria Fernanda Lopez (id_trabajador = 4, Lunes-Viernes 08:00) =================
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-06', '07:50:00', 4); -- Lunes: Puntual
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-07', '08:03:00', 4); -- Martes: Puntual
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-08', '08:00:00', 4); -- Miercoles: Puntual

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-09', '08:40:00', 4); -- Jueves: Falta (justificada)
SET @id := LAST_INSERT_ID();
INSERT INTO tblincidencias (tipo_incidencia, justificacion, fecha, id_trabajador, id_asistencia)
VALUES ('Falta', 'Cita medica, presento comprobante', '2026-07-09', 4, @id);

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-10', '07:58:00', 4); -- Viernes: Puntual

-- ================= Roberto Carlos Juarez (id_trabajador = 5, Lunes-Viernes 08:00, semana perfecta) =================
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-06', '08:00:00', 5);
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-07', '08:00:00', 5);
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-08', '08:00:00', 5);
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-09', '08:00:00', 5);
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-10', '08:00:00', 5);
