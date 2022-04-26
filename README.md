# Escola_Evelyn
ProjetoEscola

CREATE DATABASE BD_ESCOLA;
USE BD_ESCOLA;

Create table Escola(
id_esc int not null auto_increment,
nome_fantasia_esc varchar(100) not null,
rezao_social_esc varchar(100) not null,
cnpj_esc varchar(100) not null,
insc_esc varchar(100) not null,
tipo_esc varchar(20) not null,
data_criacao_esc date not null,
responsavel_esc varchar(100) not null,
responsavel_telefone_esc varchar(30) not null,
email_esc varchar(100) not null,
telefone_esc varchar(100) not null,
rua_esc varchar(100) not null,
numero_esc varchar(100) not null,
bairro_esc varchar(100) not null,
complemento_esc varchar(100) not null,
cep_esc varchar(100) not null,
cidade_esc varchar(100) not null,
estado_esc varchar(100) not null,
primary key(id_esc)
);


INSERT INTO Escola values(null, 'IFRO','Instituto Federal de Rondônia', 'XX.XXX.XXX/XXXX-XX', 'XXXXXX',
'Federal', '1975-11-20', 'MÃE', '(69) 9 9362-3530', 'ifro@gmail.com', '(69) 9 9362-3530', 'Três Marias', '123','Bom Bosco', 'XXXX', 'YYYYY-YY', 'Ji-Paraná', 'Rondònia');

select * from Escola;
desc ESCOLA;