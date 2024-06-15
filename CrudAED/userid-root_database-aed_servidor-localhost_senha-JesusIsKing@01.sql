create database aed
default character set utf8mb4
default collate utf8mb4_general_ci;

use aed;

create table if not exists pessoas(
id int not null auto_increment primary key,
codigoUsuario varchar(10) not null,
nome varchar(10) not null,
sobrenome varchar(10),
sexo varchar(10),
dataNascimento varchar(10),
telefone varchar(12),
cargo varchar(15)
) default char set utf8mb4;

describe pessoas;

alter table pessoas
modify column codigoUsuario varchar(255);
alter table pessoas
modify column nome varchar(255);
alter table pessoas
modify column sobrenome varchar(255);
alter table pessoas
modify column dataNascimento varchar(50);
alter table pessoas
modify column telefone varchar(50);
alter table pessoas
modify column cargo varchar(255);

truncate pessoas;

select* from pessoas;

alter table pessoas
modify column telefone varchar(20);