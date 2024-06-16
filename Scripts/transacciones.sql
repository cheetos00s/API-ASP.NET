use TBTBGlobal;

-- inserciones en tabla peliculas
/*
INSERT INTO directores (nombre, fecha_nacimiento) VALUES 
('Christopher Nolan', '1970-07-30'),
('Steven Spielberg', '1946-12-18'),
('Quentin Tarantino', '1963-03-27'),
('Martin Scorsese', '1942-11-17'),
('James Cameron', '1954-08-16');

-- inserciones en tabla peliculas

INSERT INTO peliculas (titulo, fecha_estreno, genero, director_id) VALUES 
('Inception', '2010-07-16', 'Sci-Fi', 1), -- Dirigida por Christopher Nolan
('Jurassic Park', '1993-06-11', 'Adventure', 2), -- Dirigida por Steven Spielberg
('Pulp Fiction', '1994-10-14', 'Crime', 3), -- Dirigida por Quentin Tarantino
('The Wolf of Wall Street', '2013-12-25', 'Biography', 4), -- Dirigida por Martin Scorsese
('Avatar', '2009-12-18', 'Sci-Fi', 5); -- Dirigida por James Cameron

-- inserciones en tabla actores

INSERT INTO actores (nombre, fecha_nacimiento) VALUES 
('Leonardo DiCaprio', '1974-11-11'),
('Samuel L. Jackson', '1948-12-21'),
('Morgan Freeman', '1937-06-01'),
('Matt Damon', '1970-10-08'),
('Kate Winslet', '1975-10-05');

-- inserciones en tabla peliculas_actores

INSERT INTO peliculas_actores (pelicula_id, actor_id) VALUES 
(1, 1), -- Inception - Leonardo DiCaprio
(2, 4), -- Jurassic Park - Samuel L. Jackson
(3, 2), -- Pulp Fiction - Samuel L. Jackson
(4, 1), -- The Wolf of Wall Street - Leonardo DiCaprio
(5, 5); -- Avatar - Kate Winslet
*/
/*
-- inner join

SELECT peliculas.pelicula_id, peliculas.titulo, directores.nombre as nombre_director 
FROM peliculas INNER JOIN directores ON
peliculas.director_id = directores.director_id;
*/
/*
-- left join

SELECT peliculas.pelicula_id, peliculas.titulo, actores.nombre AS nombre_actores 
FROM peliculas LEFT JOIN peliculas_actores on 
peliculas.pelicula_id = peliculas_actores.pelicula_id 
LEFT JOIN actores ON peliculas_actores.actor_id = actores.actor_id
*/
/*
-- union

SELECT nombre FROM actores UNION SELECT nombre FROM directores;
*/
/*
-- union

SELECT nombre FROM actores UNION SELECT titulo FROM peliculas;
*/

-- case
/*
SELECT pelicula_id, titulo, genero,
	CASE
		WHEN fecha_estreno < '2015-01-01' THEN  'la pelicula fue publicada antes del 2015'
        ELSE 'fue publicada despues del 2015'
	END AS estatus
FROM 
	peliculas;
*/
/*
-- case

SELECT 
    CASE 
        WHEN COUNT(DISTINCT pa.pelicula_id) > 1 THEN 'actuado en mas de una pelicula'
        ELSE NULL
    END AS tipo,
    a.nombre AS actor_nombre,
    COUNT(DISTINCT pa.pelicula_id) AS num_coincidencias
FROM 
    peliculas_actores pa
JOIN 
    actores a ON pa.actor_id = a.actor_id
GROUP BY 
    a.actor_id
HAVING 
    COUNT(DISTINCT pa.pelicula_id) > 1;
*/
/*
UPDATE actores 
	SET nombre = 'david cardenas', fecha_nacimiento = '2000-05-15'
    WHERE actor_id = 1;
    
SELECT * FROM actores;
*/


-- delete "al ser actores una entidad padre no 
-- es afectada por la eliminacion en cascada es decir, hay que
-- tener en cuenta el orden en que se hacen las eliminaciones"
/*
DELETE ac 
	FROM actores ac 
		JOIN peliculas_actores pa ON ac.actor_id = pa.actor_id
        JOIN peliculas pe ON pe.pelicula_id = pa.pelicula_id
	WHERE pe.director_id = 1;

-- eliminacion de un director por el id esta activada la eliminacion en cascada

DELETE FROM directores WHERE director_id = 1;

SELECT * FROM peliculas;
SELECT * FROM actores;
SELECT * FROM directores;
*/

