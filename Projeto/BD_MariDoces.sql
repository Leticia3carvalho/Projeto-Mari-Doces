CREATE DATABASE db_doceria;
USE db_doceria;

CREATE TABLE tb_usuarios (
	id_usuario int auto_increment,
    cpf varchar (12),
    nome varchar(50),
    email varchar (150),
    senha varchar (50),
    /*pontos int (4)*/
    
    primary key (id_usuario)
);

CREATE TABLE tb_categorias (
	id_categoria int auto_increment,
    nome_categoria varchar(20),
    
    primary key (id_categoria)
);

CREATE TABLE tb_sabores (
	id_sabor int auto_increment,
	nome_sabor varchar(20),
    
    primary key (id_sabor)
);

CREATE TABLE tb_produtos (
	id_produto int auto_increment,
    
    imagem varchar (150),
    nome varchar (20),
    descricao varchar (150),
    valor decimal (6,2),
    
    /*quantidade int ,*/
    id_categoria int,
	id_sabor int,
    
    primary key (id_produto),
    foreign key (id_categoria) references tb_categorias(id_categoria),
	foreign key (id_sabor) references tb_sabores(id_sabor)
);

CREATE TABLE tb_notas_fiscais(
	id_nota_fiscal varchar(20),
    
	valor_total decimal (6,2),
    forma_de_pagamento varchar(20),
	/*status_pagamento varchar(20),*/
    
	id_usuario varchar(20),
    /*id_item varchar(20),*/
	
    primary key (id_nota_fiscal),
	foreign key (id_usuario) references tb_usuarios(id_usuario)
    /*foreign key (id_item) references tb_nf_item(id_item)*/
);

CREATE TABLE tb_nf_item(
	id_nf_item int auto_increment,
    
    quantidade_produto int(4),
	id_produto int,
    id_nota_fiscal varchar(20),
    
	primary key (id_nf_item),
	foreign key (id_produto) references tb_produtos(id_produto),
    foreign key (id_nota_fiscal) references tb_notas_fiscais(id_nota_fiscal)
);

CREATE TABLE tb_sabor (
	id_sabores varchar (20),
    
	primary key(id_sabores)


);
SELECT * FROM tb_produtos;




/* comentarios*/


/*SELECT * FROM tb_produtos 
INNER JOIN tb_categorias ON id_categoria = 
WHERE  /*quantidade > 0 */

/*CREATE TABLE tb_nf_pagamentos(
	id_pagamento varchar(20),
    status_pagamento varchar(20),
	forma_de_pagamento varchar(20),
   /* id_nota_fiscal varchar(20),*/
    
	/*primary key (id_pagamento)
    /*foreign key (id_nota_fiscal) references tb_notas_fiscais(id_nota_fiscal)
);*/



 /*alter table
drop table tb;
*/

/*INSERT INTO tb_usuarios (nome, pontos)
VALUES 
('Maria', 100), 
('João', 200), 
('Ana', 300), 
('Carlos', 150), 
('Beatriz', 250), 
('Lucas', 180), 
('Fernanda', 220), 
('Ricardo', 190), 
('Juliana', 210), 
('Gabriel', 170);
select * from tb_usuarios; */