CREATE TABLE categorias(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	);




CREATE TABLE produtos(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(150) NOT NULL,
	preco_unitario DECIMAL(10,2) NOT NULL,
	id_categoria INT NOT NULL, --coluna para referenciar a outra tabela

	FOREIGN KEY (id_categoria) REFERENCES categorias(id)
	);

INSERT INTO categorias(nome) VALUES
('Padaria'),
('Limpeza'),
('Higiene'),
('Frutas'),
('Verduras');

INSERT INTO produtos (nome, preco_unitario, id_categoria) VALUES
	('Ajax multiuso', 16.00, 2), -- Categoria Limpeza que possuí o id 2
	('Sabonete Dove', 4.99, 3); -- Categoria Higiene que possuí o id 3

SELECT * FROM produtos;
SELECT * FROM categorias;

CREATE TABLE estoques(
	id INT PRIMARY KEY IDENTITY(1,1),
	quantidade INT NOT NULL,
	id_produto INT NOT NULL,
	
	FOREIGN KEY (id_produto) REFERENCES produtos(id)
	);
