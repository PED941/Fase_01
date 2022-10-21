create database ProyectoPED

use ProyectoPED

create table cliente(
cli_numero int identity(1,1) not null,
cli_nombre varchar(50),
cli_direccion varchar(50),
cli_profesion varchar(20),
cli_casa varchar(9),
cli_trabajo varchar(9),
cli_celular varchar(9),
cli_nac varchar(10),
cli_inscripcion varchar(13),
cli_email varchar(30),
cli_ingreso varchar(11),
cli_pago varchar(11),
cli_activo bit,
cli_foto varbinary(max),
cli_diasextras int,
);

create table ingresos(
ing_numero int identity(1,1) not null,
ing_cliente varchar(11),
ing_fecha varchar(13),
ing_hora varchar(5)
);

create table pago(
pag_numero int identity(1,1) not null,
pag_fecha varchar(13),
pag_descripcion varchar(50),
pag_monto decimal(12,2),
pag_vence varchar(13)
);

create table detalle_pago(
det_numero int identity(1,1) not null,
det_concepto varchar(25),
det_precio decimal(12,2),
det_pago varchar(11)
);

create table areas(
ar_numero int identity(1,1) not null,
ar_descripcion varchar(25),
ar_precio decimal(12,2)
);

create table usuario(
usr_numero int identity(1,1) not null,
usr_nombre varchar(11),
usr_usuario varchar(10),
usr_nivel varchar(10)
);

