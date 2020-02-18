Create database AgendaIO13H
go
use AgendaIO13H
go
create table Roles
(
	codigoRol int identity(1,1) not null primary key, 
	descripcion varchar(64) not null
)
go
create table Usuarios
(
	codigoUsuario int identity(1,1) not null primary key,
	nombre varchar(128) not null,
	login varchar(128) not null,
	password varchar(128) not null,
	email varchar(128),
	codigoRol int not null,
	Constraint FK_Usuario_Rol foreign key (codigoRol) references Roles(codigoRol)
)
go
create table Contactos
(
	codigoContacto int identity(1,1) not null primary key,
	apellidos varchar(128) not null,
	nombres varchar(128) not null,
	codigoUsuario int not null,
	Constraint FK_Contacto_Usuario foreign key (codigoUsuario) references Usuarios(codigoUsuario)
)
go
create table Contacto_Direcciones
(
	codigoDireccion int identity(1,1) not null primary key,
	direccion varchar(128) not null,
	descricpion varchar(128) not null,
	codigoContacto int not null,
	Constraint FK_Direccion_Contacto foreign key (codigoContacto) references Contactos(codigoContacto)
)
go
create table Contacto_Telefonos
(
	codigoTelefono int identity(1,1) not null primary key,
	numero varchar(32),
	descripcion varchar(128) not null,
	codigoContacto int not null,
	Constraint FK_Telefono_Contacto foreign key (codigoContacto) references Contactos(codigoContacto)
)
go
create table Contacto_Email
(
	codigoEmail int identity(1,1) not null primary key,
	descripcion varchar(128) not null,
	codigoContacto int not null,
	Constraint FK_Email_Contacto foreign key (codigoContacto) references Contactos(codigoContacto)
)