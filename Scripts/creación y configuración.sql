-- Creacion base de datos TBTBGlobal
-- drop database tbtbglobal;

create database TBTBGlobal;

use TBTBGlobal;

-- Creación de la tabla directores
CREATE TABLE directores (
    director_id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    fecha_nacimiento DATE
);

-- Creación de la tabla peliculas
CREATE TABLE peliculas (
    pelicula_id INT AUTO_INCREMENT PRIMARY KEY, -- primary key
    titulo VARCHAR(255) NOT NULL UNIQUE, -- valor unico
    fecha_estreno DATE,
    genero VARCHAR(100),
    fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP, -- valor por defecto
	director_id INT,
    FOREIGN KEY (director_id) REFERENCES directores(director_id)
);

-- Creación de la tabla actores
CREATE TABLE actores (
    actor_id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    fecha_nacimiento DATE
);

-- Creación de la tabla intermedia peliculas_actores para la relación muchos a muchos
CREATE TABLE peliculas_actores (
    pelicula_id INT,
    actor_id INT,
    FOREIGN KEY (pelicula_id) REFERENCES peliculas(pelicula_id),
    FOREIGN KEY (actor_id) REFERENCES actores(actor_id),
    PRIMARY KEY (pelicula_id, actor_id)
);

