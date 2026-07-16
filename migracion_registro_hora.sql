-- Migracion para equipo1_staff_asistence
-- El campo "registro" de tblasistencia solo debe guardar la hora, no fecha+hora
-- (la fecha ya se guarda aparte en la columna "fecha").

USE `equipo1_staff_asistence`;

ALTER TABLE `tblasistencia`
  MODIFY COLUMN `registro` TIME NOT NULL;
