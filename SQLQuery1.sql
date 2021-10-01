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

insert into tbSetores(nome_Setor) values('Recepção');--1-Recepção 

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
	ocupação bit,--Vazio
);

   insert into tbQuartos(ocupação) values('0');--1.....
   insert into tbQuartos(ocupação) values('0');
   insert into tbQuartos(ocupação) values('0');
   insert into tbQuartos(ocupação) values('0');
   insert into tbQuartos(ocupação) values('0');
   insert into tbQuartos(ocupação) values('1');
   insert into tbQuartos(ocupação) values('1');
   insert into tbQuartos(ocupação) values('1');
   insert into tbQuartos(ocupação) values('0');
   insert into tbQuartos(ocupação) values('0');--10.

------------------------------------------------------------------------------

Create table tbServiços(
   id_Serviço int identity(1,1) primary key,
   tipo_Serviço varchar(50)
);

insert into tbServiços(tipo_Serviço) values('Serviço Básico');----1-Básico
insert into tbServiços(tipo_Serviço) values('Serviço Premium');--2-premium

--------------------------------------------------------------------------------------------------
Create table Agendamentos(
    id_Agendamento int identity(1,1) primary key,--1
	id_Quarto int FOREIGN KEY REFERENCES tbQuartos(id_Quarto),--Quarto 1
	check_In varchar(50), --2021-09-29 14:19:00
	check_Out varchar(50),--2021-09-30 14:19:00
	id_Serviço int FOREIGN KEY REFERENCES tbServiços(id_Serviço),--1 - Serviço Básico
	numero_Pessoas int,--1
	Valor_Estadia float,--20
	id_Cliente int FOREIGN KEY REFERENCES tbClientes(id_Cliente),--1 - 
	id_Funcionario int FOREIGN KEY REFERENCES tbFuncionarios(id_Funcionario)
	--Id: 1 - thiago - cpf: 987654321 - dependentes 0 -Cargo: Recepcionista - Setor Recepção	
);

select * from Agendamentos;

---DROPADA----------------------------------------------------------------------------
/*
Create table tbAgendamento(
    id_Agendamento int identity(1,1) primary key,--1
	id_Quarto int FOREIGN KEY REFERENCES tbQuartos(id_Quarto),--Quarto 1
	check_In datetime, --2021-09-29 14:19:00
	check_Out datetime,--2021-09-30 14:19:00
	id_Serviço int FOREIGN KEY REFERENCES tbServiços(id_Serviço),--1 - Serviço Básico
	numero_Pessoas int,--1
	Valor_Estadia float,--20
	id_Cliente int FOREIGN KEY REFERENCES tbClientes(id_Cliente),--1 - 
	id_Funcionario int FOREIGN KEY REFERENCES tbFuncionarios(id_Funcionario)
	--Id: 1 - thiago - cpf: 987654321 - dependentes 0 -Cargo: Recepcionista - Setor Recepção
);

drop table tbAgendamentos;
*/