create database ColegioInmaculada

create table estudiante(
 IdEstudiante int primary key not null,
 NombreEstudiante varchar(50) not null,
 Grado int not null,
 seccion char not null,
 AnioLectivo int not null,
);

create table Usuario(
 Idusuario int primary key not null,
 Contrasena varchar(10) not null,
);

create table Pagos(
 IdPagos int primary key not null,
 PagoMensualidad int,
 TarjetadeMensualidad int,
 tarjetadeCitas  int,
 TarjetadeReuniones int,
);

create table Caja(
 Fecha datetime,
 Monto decimal(9,2)
);

ALTER TABLE Pagos
ADD DomingoFamiliar int not null;
