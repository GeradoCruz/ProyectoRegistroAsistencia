-- Migracion para equipo1_staff_asistence
-- La tabla tblasistencia ya no distingue entrada/salida con la columna "tipo".
-- Cada registro (clic del trabajador) solo guarda fecha + hora exacta (registro).
-- El PRIMER registro del dia es el que se usa para calificar Puntual/Retardo/Falta,
-- y esa incidencia se guarda en tblincidencias.

USE `equipo1_staff_asistence`;

ALTER TABLE `tblasistencia`
  DROP COLUMN `tipo`;
