-- DROP DATABASE siu;
CREATE DATABASE siu;
USE siu;
-- -----------------------------------------------------
-- Table `Universidad`
-- -----------------------------------------------------
CREATE TABLE universidad
 (
  id_universidad VARCHAR(15),
  nombre_universidad VARCHAR(45),
  direccion_universidad VARCHAR(45),
  telefono_universidad VARCHAR(45),
  email_universidad VARCHAR(20),
  PRIMARY KEY (id_universidad)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;
insert into universidad values("0001","Universidad Mariano Galvez","Zona2","12345678","umg@miumg.edu.gt");
-- -----------------------------------------------------
-- Table `educativo`.`Alumnos`
-- -----------------------------------------------------
CREATE TABLE alumnos
 (
  carnet_alumno VARCHAR(15),
  nombre_alumno VARCHAR(45),
  direccion_alumno VARCHAR(45),
  telefono_alumno VARCHAR(45),
  email_alumno VARCHAR(20),
  estatus_alumno VARCHAR(1),
  PRIMARY KEY (carnet_alumno)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;
insert into alumnos values ("0901","George Mayén","Zona18","12345678","george@gmail.com",1);
insert into alumnos values ("0902","Juan Perez","Zona1","12345678","juan@gmail.com",0);
-- -----------------------------------------------------
-- Table `educativo`.`Maestros`
-- -----------------------------------------------------
CREATE TABLE maestros
(
  codigo_maestro VARCHAR(5),
  nombre_maestro VARCHAR(45),
  direccion_maestro VARCHAR(45),
  telefono_maetro VARCHAR(45),
  email_maestro VARCHAR(20),
  estatus_maestro VARCHAR(1),
  PRIMARY KEY (codigo_maestro)
 ) ENGINE = InnoDB DEFAULT CHARSET=latin1;
 insert into maestros values ("0911","Luis Perez","Zona9","12345678","luis@gmail.com",1);
  insert into maestros values ("0912","Pedro Perez","Zona9","12345678","pedro@gmail.com",1);
-- -----------------------------------------------------
-- Table `educativo`.`Facultades`
-- -----------------------------------------------------
CREATE TABLE facultades
(
  codigo_facultad VARCHAR(5),
   id_universidad VARCHAR(15),
  nombre_facultad VARCHAR(45),
  estatus_facultad VARCHAR(1),
  PRIMARY KEY (codigo_facultad),
  FOREIGN KEY (id_universidad) REFERENCES universidad(id_universidad)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;
insert into facultades values("1901","0001","Ingeniería",1);
insert into facultades values("1501","0001","Humanidades",1);
-- -----------------------------------------------------
-- Table `educativo`.`Carreras`
-- -----------------------------------------------------
CREATE TABLE carreras
(
  codigo_carrera VARCHAR(5),
  nombre_carrera VARCHAR(45),
  codigo_facultad VARCHAR(5),
  estatus_carrera VARCHAR(1),
  PRIMARY KEY (codigo_carrera),
  FOREIGN KEY (codigo_facultad) REFERENCES facultades(codigo_facultad)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;
insert into carreras values(1101,"Ingeniería en sistemas","1901",1);
insert into carreras values(1102,"Ingeniería electronica","1901",1);
-- -----------------------------------------------------
-- Table `educativo`.`Cursos`
-- -----------------------------------------------------
CREATE TABLE cursos
(
  codigo_curso VARCHAR(5),
  nombre_curso VARCHAR(45),
  estatus_curso VARCHAR(1),
  PRIMARY KEY (codigo_curso)
 ) ENGINE = InnoDB DEFAULT CHARSET=latin1;
 insert into cursos values(1,"Redes",1);
  insert into cursos values(2,"Analisis",1);
-- -----------------------------------------------------
-- Table `educativo`.`Secciones`
-- -----------------------------------------------------
CREATE TABLE secciones
(
  codigo_seccion VARCHAR(5),
  nombre_seccion VARCHAR(45),
  estatus_seccion VARCHAR(1),
  PRIMARY KEY (codigo_seccion)
 ) ENGINE = InnoDB DEFAULT CHARSET=latin1;
 insert into secciones values (101,"A",1);
  insert into secciones values (102,"B",1);
-- -----------------------------------------------------
-- Table `educativo`.`Sedes`
-- -----------------------------------------------------
CREATE TABLE sedes
(
  codigo_sede VARCHAR(5),
  nombre_sede VARCHAR(45),
  estatus_sede VARCHAR(1),
  PRIMARY KEY (codigo_sede)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;
insert into sedes values(109,"El naranjo",1);
insert into sedes values(108,"El Fiscal",1);
-- -----------------------------------------------------
-- Table `educativo`.`Aulas`
-- -----------------------------------------------------
CREATE TABLE aulas
(
  codigo_aula VARCHAR(5),
  nombre_aula VARCHAR(45),
  estatus_aula VARCHAR(1),
  PRIMARY KEY (codigo_aula)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;
insert into aulas values(1101,"Aula1",1);
insert into aulas values(1102,"Aula2",1);

CREATE TABLE jornadas
(
	codigo_jornada VARCHAR(5),
    nombre_jornada VARCHAR(45),
    estatus_jornada VARCHAR(1),
    PRIMARY KEY (codigo_jornada)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
insert into jornadas values(165,"Jornada Matutina",1);
insert into jornadas values(166,"Jornada Vespertina",0);
-- -----------------------------------------------------
-- Table `educativo`.`Asignacion_cursos_alumnos`
-- -----------------------------------------------------
CREATE TABLE asignacioncursosalumnos
(
  codigo_carrera VARCHAR(5),
  codigo_sede VARCHAR(5),
  codigo_jornada VARCHAR(5),
  codigo_seccion VARCHAR(5),
  codigo_aula VARCHAR(5),
  codigo_curso VARCHAR(5),
  carnet_alumno VARCHAR(15),
  nota_asignacioncursoalumnos FLOAT(10,2), 
  PRIMARY KEY (codigo_carrera, codigo_sede, codigo_jornada, codigo_seccion, codigo_aula, codigo_curso, carnet_alumno),
  FOREIGN KEY (codigo_carrera) REFERENCES carreras(codigo_carrera),
  FOREIGN KEY (codigo_sede) REFERENCES sedes(codigo_sede),
  FOREIGN KEY (codigo_jornada) REFERENCES jornadas(codigo_jornada),
  FOREIGN KEY (codigo_seccion) REFERENCES secciones(codigo_seccion),
  FOREIGN KEY (codigo_aula) REFERENCES aulas(codigo_aula),
  FOREIGN KEY (codigo_curso) REFERENCES cursos(codigo_curso),
  FOREIGN KEY (carnet_alumno) REFERENCES alumnos(carnet_alumno)
  ) ENGINE = InnoDB DEFAULT CHARSET=latin1;
  insert into asignacioncursosalumnos values(1101,109,165,101,1101,1,"0901",100);
-- -----------------------------------------------------
-- Table `educativo`.`Asignacion_cursos_maestros`
-- -----------------------------------------------------
CREATE TABLE asignacioncursosmastros
(
  codigo_carrera VARCHAR(5),
  codigo_sede VARCHAR(5),
  codigo_jornada VARCHAR(5),
  codigo_seccion VARCHAR(5),
  codigo_aula VARCHAR(5),
  codigo_curso VARCHAR(5),
  codigo_maestro VARCHAR(5),
  PRIMARY KEY (codigo_carrera, codigo_sede, codigo_jornada, codigo_seccion, codigo_aula, codigo_curso),
  FOREIGN KEY (codigo_carrera) REFERENCES carreras(codigo_carrera),
  FOREIGN KEY (codigo_sede) REFERENCES sedes(codigo_sede),
  FOREIGN KEY (codigo_jornada) REFERENCES jornadas(codigo_jornada),
  FOREIGN KEY (codigo_seccion) REFERENCES secciones(codigo_seccion),
  FOREIGN KEY (codigo_aula) REFERENCES aulas(codigo_aula),
  FOREIGN KEY (codigo_curso) REFERENCES cursos(codigo_curso),
  FOREIGN KEY (codigo_maestro) REFERENCES maestros(codigo_maestro)
  ) ENGINE = InnoDB DEFAULT CHARSET=latin1;
  insert into asignacioncursosmastros values(1101,109,165,101,1101,1,"0911");
  
  DROP TABLE IF EXISTS `tbl_permisosaplicacionesusuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_permisosaplicacionesusuario` (
  `fk_id_aplicacion` int NOT NULL,
  `fk_id_usuario` int NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT '0',
  `modificar_permiso` tinyint(1) DEFAULT '0',
  `eliminar_permiso` tinyint(1) DEFAULT '0',
  `buscar_permiso` tinyint(1) DEFAULT '0',
  `imprimir_permiso` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`fk_id_aplicacion`,`fk_id_usuario`),
  KEY `fk_id_usuario` (`fk_id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_permisosaplicacionesusuario`
--

LOCK TABLES `tbl_permisosaplicacionesusuario` WRITE;
/*!40000 ALTER TABLE `tbl_permisosaplicacionesusuario` DISABLE KEYS */;
INSERT INTO `tbl_permisosaplicacionesusuario` VALUES (2,1,0,0,0,0,0),(2,3,1,1,1,1,1),(2,6,1,1,1,1,1),(2,8,1,1,1,1,1),(1000,2,1,1,1,1,1),(1000,3,1,1,1,1,1),(1000,4,1,1,1,1,1),(1000,6,1,1,1,1,1),(1000,7,0,0,0,0,0),(1000,8,1,1,1,1,1),(2000,3,1,1,1,1,1),(2000,6,1,1,1,1,1),(2000,7,0,0,0,0,0),(2000,8,1,1,1,1,1),(3000,3,1,1,1,1,1),(3000,5,1,1,1,1,1),(3000,8,1,1,1,1,1);
/*!40000 ALTER TABLE `tbl_permisosaplicacionesusuario` ENABLE KEYS */;
UNLOCK TABLES;

