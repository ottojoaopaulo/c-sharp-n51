CREATE TABLE estantes(
	id INT PRIMARY KEY IDENTITY(1,1),
	NOME VARCHAR(25),
	);

SELECT id, nome FROM estantes;

CREATE TABLE estantes(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50) NOT NULL,
	sigla VARCHAR(3) NOT NULL,
	);

INSERT INTO estantes(nome, sigla) VALUES
('Temperos', 'A01'),
('Massas', 'A02');

