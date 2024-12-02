CREATE DATABASE IF NOT EXISTS db_agenda;

USE db_agenda;

-- TABELA DE USUÁRIOS

CREATE TABLE IF NOT EXISTS tb_usuarios (
	nome VARCHAR(100) NOT NULL,
    usuario VARCHAR(50) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
);

-- TABELA DE CONTATOS

CREATE TABLE IF NOT EXISTS tb_contatos (
    id_contato INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    endereco VARCHAR(50),
    email VARCHAR(50) NOT NULL,
    usuario VARCHAR(50),

    CONSTRAINT fk_usuarios_contatos
    FOREIGN KEY (usuario)
    REFERENCES tb_usuarios (usuario)
    -- remove todos valores das outras tabelas de uma vez
    ON DELETE CASCADE
);

-- TABELA DE TELEFONES

CREATE TABLE IF NOT EXISTS tb_telefones (
    id_telefone INT AUTO_INCREMENT PRIMARY KEY,
    telefone VARCHAR(15) NOT NULL,
    descricao VARCHAR(250),
    id_contato INT NOT NULL,

    CONSTRAINT fk_contatos_telefones
    FOREIGN KEY (id_contato)
    REFERENCES tb_contatos (id_contato)
    ON DELETE CASCADE
);

-- TABELA DE CATEGORIAS

CREATE TABLE IF NOT EXISTS tb_categorias (
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL,
    categoria VARCHAR(100) NOT NULL,

    CONSTRAINT fk_usuarios_categorias
    FOREIGN KEY (usuario)
    REFERENCES tb_usuarios(usuario)
    ON DELETE CASCADE
);

-- TABELA DE AFINIDADES

CREATE TABLE IF NOT EXISTS tb_afinidades (
    id_afinidade INT AUTO_INCREMENT PRIMARY KEY,
    id_contato INT NOT NULL,
    id_categoria INT NOT NULL,

    CONSTRAINT fk_contatos_afinidades
    FOREIGN KEY (id_contato)
    REFERENCES tb_contatos(id_contato)
    ON DELETE CASCADE,

    CONSTRAINT fk_categorias_afinidades
    FOREIGN KEY (id_categoria)
    REFERENCES tb_categorias(id_categoria)
    ON DELETE CASCADE
);

-- TABELA DE LOGS

CREATE TABLE IF NOT EXISTS tb_logs (
    id_log INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL,
    dt_alteracao DATETIME DEFAULT CURRENT_TIMESTAMP() NOT NULL,
    descricao VARCHAR(250) NOT NULL
);

-- USUÁRIO ADMIN

INSERT INTO tb_usuarios VALUES ("Vitor", "vito", "6969", "rotiv");

CREATE USER 'vitor'@'%' IDENTIFIED BY 'rotiv';
GRANT ALL PRIVILEGES ON db_agenda.* TO 'vitor'@'%' WITH GRANT OPTION;

-- TRIGGER SET PROPRIETARIO CATEGORIA

DELIMITER $$

CREATE TRIGGER tr_insert_categoria
    BEFORE
    INSERT
    ON tb_categorias
    FOR EACH ROW
BEGIN
    SET NEW.usuario = SUBSTRING_INDEX(USER(), '@', 1);
END;

$$

DELIMITER ;

-- TRIGGER LOG INSERT CATEGORIA

DELIMITER $$

CREATE TRIGGER tr_log_insert_categoria
    AFTER
    INSERT
    ON tb_categorias
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("CATEGORIA INSERIDA: ", NEW.categoria)
    );
END;

$$

DELIMITER ;

-- TRIGGER LOG DELETE CATEGORIA

DELIMITER $$

CREATE TRIGGER tr_log_delete_categoria
    AFTER
    DELETE
    ON tb_categorias
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("CATEGORIA DELETADA: ", OLD.categoria, ". PROPRIETÁRIO: ", OLD.usuario)
    );
END;

$$

DELIMITER ;

-- TRIGGER LOG UPDATE CATEGORIA

DELIMITER $$

CREATE TRIGGER tr_log_update_categoria
    AFTER
    UPDATE
    ON tb_categorias
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("NOME DA CATEGORIA ALTERADO DE: ", OLD.categoria, " PARA: ", NEW.categoria)
    );
END;

$$

DELIMITER ;