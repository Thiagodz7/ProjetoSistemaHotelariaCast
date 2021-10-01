Create table tbClientes(
    id_Cliente int identity(1,1) primary key,--1
	nome_Cliente  varchar(50),
	cpf int,
	idade int,
	telefone int,
);

-----------------------------------------------

Create table tbCargos(
    id_Cargo int identity(1,1) primary key,
	cargo varchar(50)
);

insert into tbCargos(cargo) values('Gerente');--1-Gerente
insert into tbCargos(cargo) values('Recepcionista');--2-Recepcionista

------------------------------------------

Create table tbSetores(
    id_Setor int identity(1,1) primary key,
	nome_Setor  varchar(50),
);

insert into tbSetores(nome_Setor) values('Recep��o');--1-Recep��o 

-----------------------------------------------------

Create table tbFuncionarios(
    id_Funcionario int identity(1,1) primary key,--1
	nome_Funcionario  varchar(50),
	cpf int,
	dependentes int,
	id_Cargo int FOREIGN KEY REFERENCES tbCargos(id_Cargo),
	id_Setor int FOREIGN KEY REFERENCES tbSetores(id_Setor)--1
);

insert into tbFuncionarios(nome_Funcionario,cpf,dependentes,id_Cargo,id_Setor) values('Administrador',123456789,0,1,1);
insert into tbFuncionarios(nome_Funcionario,cpf,dependentes,id_Cargo,id_Setor) values('thiago',987654321,0,2,1);

--------------------------------------------------------------
Create table tbQuartos(
    id_Quarto int identity(1,1) primary key,
	ocupa��o bit,--Vazio
);

   insert into tbQuartos(ocupa��o) values('0');--1.....
   insert into tbQuartos(ocupa��o) values('0');
   insert into tbQuartos(ocupa��o) values('0');
   insert into tbQuartos(ocupa��o) values('0');
   insert into tbQuartos(ocupa��o) values('0');
   insert into tbQuartos(ocupa��o) values('1');
   insert into tbQuartos(ocupa��o) values('1');
   insert into tbQuartos(ocupa��o) values('1');
   insert into tbQuartos(ocupa��o) values('0');
   insert into tbQuartos(ocupa��o) values('0');--10.

------------------------------------------------------------------------------

Create table tbServi�os(
   id_Servi�o int identity(1,1) primary key,
   tipo_Servi�o varchar(50)
);

insert into tbServi�os(tipo_Servi�o) values('Servi�o B�sico');----1-B�sico
insert into tbServi�os(tipo_Servi�o) values('Servi�o Premium');--2-premium

--------------------------------------------------------------------------------------------------
Create table Agendamentos(
    id_Agendamento int identity(1,1) primary key,--1
	id_Quarto int FOREIGN KEY REFERENCES tbQuartos(id_Quarto),--Quarto 1
	check_In varchar(50), --2021-09-29 14:19:00
	check_Out varchar(50),--2021-09-30 14:19:00
	id_Servi�o int FOREIGN KEY REFERENCES tbServi�os(id_Servi�o),--1 - Servi�o B�sico
	numero_Pessoas int,--1
	Valor_Estadia float,--20
	id_Cliente int FOREIGN KEY REFERENCES tbClientes(id_Cliente),--1 - 
	id_Funcionario int FOREIGN KEY REFERENCES tbFuncionarios(id_Funcionario)
	--Id: 1 - thiago - cpf: 987654321 - dependentes 0 -Cargo: Recepcionista - Setor Recep��o	
);

select * from Agendamentos;

---DROPADA----------------------------------------------------------------------------
/*
Create table tbAgendamento(
    id_Agendamento int identity(1,1) primary key,--1
	id_Quarto int FOREIGN KEY REFERENCES tbQuartos(id_Quarto),--Quarto 1
	check_In datetime, --2021-09-29 14:19:00
	check_Out datetime,--2021-09-30 14:19:00
	id_Servi�o int FOREIGN KEY REFERENCES tbServi�os(id_Servi�o),--1 - Servi�o B�sico
	numero_Pessoas int,--1
	Valor_Estadia float,--20
	id_Cliente int FOREIGN KEY REFERENCES tbClientes(id_Cliente),--1 - 
	id_Funcionario int FOREIGN KEY REFERENCES tbFuncionarios(id_Funcionario)
	--Id: 1 - thiago - cpf: 987654321 - dependentes 0 -Cargo: Recepcionista - Setor Recep��o
);

drop table tbAgendamentos;
*/