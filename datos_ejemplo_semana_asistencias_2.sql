-- Segunda semana de datos de ejemplo (Lunes 29 de junio a Viernes 03 de julio de 2026)
-- para los mismos trabajadores TR-001 a TR-005. Es un agregado: no borra nada,
-- solo suma mas registros para tener dos semanas completas y poder comparar
-- una semana contra otra en los reportes.
--
-- Variedad distinta a la primera semana para que se note el cambio semana a semana:
--   - Kevin: mezcla de Falta y Retardo (antes solo tuvo un Retardo)
--   - Ana Laura: Retardo pendiente + ausencia total el viernes (antes fue Falta)
--   - Jorge: Falta en el turno de la manana (antes fue Retardo)
--   - Maria Fernanda: semana perfecta (antes tuvo una Falta)
--   - Roberto: ya NO es semana perfecta, tiene Retardo y Falta (contraste con la semana 1)

USE `equipo1_staff_asistence`;

-- ================= Kevin Solares (id_trabajador = 1) =================
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-06-29', '08:20:00', 1); -- Lunes: Falta (pendiente)
SET @id := LAST_INSERT_ID();
INSERT INTO tblincidencias (tipo_incidencia, justificacion, fecha, id_trabajador, id_asistencia)
VALUES ('Falta', NULL, '2026-06-29', 1, @id);

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-06-30', '07:58:00', 1); -- Martes: Puntual
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-01', '08:08:00', 1); -- Miercoles: Puntual

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-02', '08:12:00', 1); -- Jueves: Retardo (justificada)
SET @id := LAST_INSERT_ID();
INSERT INTO tblincidencias (tipo_incidencia, justificacion, fecha, id_trabajador, id_asistencia)
VALUES ('Retardo', 'Se le atendio y se le recordo el reglamento', '2026-07-02', 1, @id);

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-03', '08:00:00', 1); -- Viernes: Puntual

-- ================= Ana Laura Hernandez (id_trabajador = 2, Lun/Mie/Vie) =================
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-06-29', '09:15:00', 2); -- Lunes: Retardo (pendiente)
SET @id := LAST_INSERT_ID();
INSERT INTO tblincidencias (tipo_incidencia, justificacion, fecha, id_trabajador, id_asistencia)
VALUES ('Retardo', NULL, '2026-06-29', 2, @id);

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-01', '09:00:00', 2); -- Miercoles: Puntual

-- Viernes 2026-07-03: sin ningun registro (ausencia total)

-- ================= Jorge Ivan Reyes (id_trabajador = 3, Mar/Jue turno partido) =================
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-06-30', '10:00:00', 3); -- Martes entrada: Puntual
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-06-30', '15:10:00', 3); -- Martes segundo bloque

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-02', '10:22:00', 3); -- Jueves entrada: Falta (pendiente)
SET @id := LAST_INSERT_ID();
INSERT INTO tblincidencias (tipo_incidencia, justificacion, fecha, id_trabajador, id_asistencia)
VALUES ('Falta', NULL, '2026-07-02', 3, @id);
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-02', '15:05:00', 3); -- Jueves segundo bloque

-- ================= Maria Fernanda Lopez (id_trabajador = 4, Lunes-Viernes, semana perfecta) =================
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-06-29', '07:55:00', 4);
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-06-30', '08:00:00', 4);
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-01', '08:05:00', 4);
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-02', '08:02:00', 4);
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-03', '08:00:00', 4);

-- ================= Roberto Carlos Juarez (id_trabajador = 5) =================
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-06-29', '08:18:00', 5); -- Lunes: Retardo (justificada)
SET @id := LAST_INSERT_ID();
INSERT INTO tblincidencias (tipo_incidencia, justificacion, fecha, id_trabajador, id_asistencia)
VALUES ('Retardo', 'Junta con direccion, aviso previo', '2026-06-29', 5, @id);

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-06-30', '08:00:00', 5); -- Martes: Puntual
INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-01', '08:00:00', 5); -- Miercoles: Puntual

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-02', '08:25:00', 5); -- Jueves: Falta (justificada)
SET @id := LAST_INSERT_ID();
INSERT INTO tblincidencias (tipo_incidencia, justificacion, fecha, id_trabajador, id_asistencia)
VALUES ('Falta', 'Tramite personal urgente, justificante entregado', '2026-07-02', 5, @id);

INSERT INTO tblasistencia (fecha, registro, id_trabajador) VALUES ('2026-07-03', '08:00:00', 5); -- Viernes: Puntual
