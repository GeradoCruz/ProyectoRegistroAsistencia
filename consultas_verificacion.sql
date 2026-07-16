-- Consultas de verificacion para equipo1_staff_asistence
-- Copia y pega cada bloque por separado en SQLyog para revisar los datos.

USE `equipo1_staff_asistence`;

-- 1) Conteo rapido por tabla (para confirmar que todo se cargo)
SELECT 'tbldepartamento' AS tabla, COUNT(*) AS registros FROM tbldepartamento
UNION ALL SELECT 'tblpuestos', COUNT(*) FROM tblpuestos
UNION ALL SELECT 'tblsemestres', COUNT(*) FROM tblsemestres
UNION ALL SELECT 'tbltrabajador', COUNT(*) FROM tbltrabajador
UNION ALL SELECT 'tblusuarios', COUNT(*) FROM tblusuarios
UNION ALL SELECT 'tblhorario_trabajo', COUNT(*) FROM tblhorario_trabajo
UNION ALL SELECT 'tblasistencia', COUNT(*) FROM tblasistencia
UNION ALL SELECT 'tblincidencias', COUNT(*) FROM tblincidencias;

-- 2) Todas las asistencias con el nombre del trabajador, ordenadas por fecha y hora
SELECT t.clave_trabajador, CONCAT(t.nombre, ' ', t.a_paterno) AS nombre,
       a.fecha, a.registro
FROM tblasistencia a
JOIN tbltrabajador t ON t.id_trabajador = a.id_trabajador
ORDER BY a.fecha, a.registro;

-- 3) Todas las incidencias con estatus (Justificada / Pendiente)
SELECT t.clave_trabajador, CONCAT(t.nombre, ' ', t.a_paterno) AS nombre,
       i.fecha, i.tipo_incidencia,
       CASE WHEN i.justificacion IS NULL THEN 'Pendiente' ELSE 'Justificada' END AS estatus,
       i.justificacion
FROM tblincidencias i
JOIN tbltrabajador t ON t.id_trabajador = i.id_trabajador
ORDER BY i.fecha;

-- 4) Resumen por trabajador de la semana 1 (06 al 10 de julio 2026)
SELECT t.clave_trabajador, CONCAT(t.nombre, ' ', t.a_paterno) AS nombre,
       COUNT(DISTINCT a.fecha) AS dias_registrados,
       SUM(i.tipo_incidencia = 'Retardo') AS retardos,
       SUM(i.tipo_incidencia = 'Falta') AS faltas
FROM tbltrabajador t
LEFT JOIN tblasistencia a ON a.id_trabajador = t.id_trabajador
       AND a.fecha BETWEEN '2026-07-06' AND '2026-07-10'
LEFT JOIN tblincidencias i ON i.id_asistencia = a.id_asistencia
GROUP BY t.id_trabajador;

-- 5) Resumen por trabajador de la semana 2 (29 de junio al 03 de julio 2026)
SELECT t.clave_trabajador, CONCAT(t.nombre, ' ', t.a_paterno) AS nombre,
       COUNT(DISTINCT a.fecha) AS dias_registrados,
       SUM(i.tipo_incidencia = 'Retardo') AS retardos,
       SUM(i.tipo_incidencia = 'Falta') AS faltas
FROM tbltrabajador t
LEFT JOIN tblasistencia a ON a.id_trabajador = t.id_trabajador
       AND a.fecha BETWEEN '2026-06-29' AND '2026-07-03'
LEFT JOIN tblincidencias i ON i.id_asistencia = a.id_asistencia
GROUP BY t.id_trabajador;

-- 6) Incidencias pendientes de justificar (todas, sin importar la semana)
SELECT t.clave_trabajador, CONCAT(t.nombre, ' ', t.a_paterno) AS nombre,
       i.fecha, i.tipo_incidencia
FROM tblincidencias i
JOIN tbltrabajador t ON t.id_trabajador = i.id_trabajador
WHERE i.justificacion IS NULL
ORDER BY i.fecha;

-- 7) Comparativo por departamento (incidencias de ambas semanas)
SELECT d.nombre_departamento, COUNT(*) AS total_incidencias
FROM tblincidencias i
JOIN tbltrabajador t ON t.id_trabajador = i.id_trabajador
JOIN tbldepartamento d ON d.id_departamento = t.id_departamento
GROUP BY d.id_departamento
ORDER BY total_incidencias DESC;

-- 8) Verificar que cada incidencia corresponde REALMENTE al primer registro
--    del dia (si esto regresa filas, hay una incidencia mal generada)
SELECT i.id_incidencia, t.clave_trabajador, i.fecha, i.tipo_incidencia
FROM tblincidencias i
JOIN tblasistencia a ON a.id_asistencia = i.id_asistencia
JOIN tbltrabajador t ON t.id_trabajador = i.id_trabajador
WHERE a.registro <> (
    SELECT MIN(a2.registro) FROM tblasistencia a2
    WHERE a2.id_trabajador = a.id_trabajador AND a2.fecha = a.fecha
);

-- 9) Ausencias totales: dias con horario asignado pero sin ningun registro
--    (ejemplo fijo para Kevin el viernes 2026-07-10 y Ana el viernes 2026-07-03)
SELECT t.clave_trabajador, CONCAT(t.nombre, ' ', t.a_paterno) AS nombre, h.dia, h.hora_entrada
FROM tblhorario_trabajo h
JOIN tbltrabajador t ON t.id_trabajador = h.id_trabajador
WHERE h.id_trabajador IN (1, 2)
  AND NOT EXISTS (
        SELECT 1 FROM tblasistencia a
        WHERE a.id_trabajador = h.id_trabajador
          AND a.fecha IN ('2026-07-10', '2026-07-03')
  );
