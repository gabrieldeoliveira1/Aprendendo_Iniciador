CREATE DATABASE Biblio_Sesi;
Use Biblio_Sesi;


CREATE TABLE Table_Cargo (
	CD_Cargo int primary key auto_increment not null,
    Cargo Varchar(45)
);

CREATE TABLE Table_Ano_Escolar (
	CD_Ano_Escolar int primary key auto_increment not null,
    Ano_Escolar varchar(45) -- 1° EF, 2° EF, 3° EF, 4° EF, 5° EF, 6° EF, 7° EF, 8° EF, 9° EF, 1° EM, 2° EM, 3° EM, Diretoria
);

CREATE TABLE Table_Unidade(
	CD_Unidade int primary key auto_increment not null,
    Nome_Unidade Varchar(45),
    Local_Unidade Varchar(45),
    IMG_Unidade Varchar(45),
    Descricao_Retirada Varchar(125)
);

CREATE TABLE Table_Livro (
	Order_Livro int primary key auto_increment,
	CD_Livro varchar(80) not null,
    Nome_Livro Varchar(80),
    Autor_Livro Varchar(80),
    QTD_estoque int,
    Numb_Paginas int,
    Edicao_Livro int,
    IMG_Livro Varchar(100),
    Descricao_Livro Varchar(2000),
    CFK_Unidade int,
    CONSTRAINT FK_Unidade FOREIGN KEY (CFK_Unidade) REFERENCES Table_Unidade(CD_Unidade)
);

CREATE TABLE Table_User (
	CD_User int primary key auto_increment,
	ID_Aluno Varchar(45) not null,
    NameUser Varchar(45),
    Nome_Completo Varchar(45),
    Senha Varchar(45),	
    IMG_User Varchar(45),
    CFK_Ano int,
	CFK_Cargo int,
    CFK_Unidade int,
    CONSTRAINT FK_Ano FOREIGN KEY (CFK_Ano) REFERENCES Table_Ano_Escolar(CD_Ano_Escolar),
    CONSTRAINT FK_Cargo FOREIGN KEY (CFK_Cargo) REFERENCES Table_Cargo(CD_Cargo),
    CONSTRAINT FK_Unit FOREIGN KEY (CFK_Unidade) REFERENCES Table_Unidade(CD_Unidade)
    ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Table_Adm (
	CD_Adm int primary key not null,
    NameUser_Adm Varchar(45),
    Senha_Adm Varchar(45),
    CFK_User int,
    constraint FK_Userss foreign key (CFK_User) references Table_User(CD_User)
    ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Table_Historico (
	CD_Hist int primary key auto_increment not null,
    DT_reserva datetime,
    DT_devolucao datetime,
    CFK_Livro int,
    CFK_User int,
    CONSTRAINT FK_Livro FOREIGN KEY (CFK_Livro) REFERENCES Table_Livro(Order_Livro),
    CONSTRAINT FK_User FOREIGN KEY (CFK_User) REFERENCES Table_User(CD_User)
);

CREATE TABLE Table_reservas(
    CD_Reservas int primary key auto_increment not null,
    DT_reserva datetime,
    DT_previsao_devolucao datetime,
    CFK_User int,
    CFK_Livro int,
    CONSTRAINT FK_Users foreign key (CFK_User) references Table_User(CD_User), 
    CONSTRAINT FK_Livros foreign key (CFK_Livro) references Table_Livro(Order_Livro)
    ON delete cascade
    ON update cascade
);

insert into Table_Cargo(Cargo) values("Gerente"), ("Aluno"), ("Professor"), ("Externo");
insert into Table_Ano_Escolar(Ano_Escolar) values ("1° EF"), ("2° EF"), ("3° EF"), ("4° EF"), ("5° EF"), ("6° EF"), ("7° EF"), ("8° EF"), ("9° EF"), ("1° EM"), ("2° EM"), ("3° EM"), ("Diretoria");
insert into Table_Unidade(Nome_Unidade, Local_Unidade, IMG_Unidade, Descricao_Retirada)
values ('SESI Curitiba', 'Av. Marechal Floriano Peixoto, 4585, Curitiba', "", 'Centro de educação, saúde e lazer; oferece cursos e atividades culturais.'),
('SESI São José dos Pinhais', 'Rua Jacob Macanhan, 221, São José dos Pinhais', "", 'Unidade focada em educação, com infraestrutura para esportes e lazer.'),
('SESI Ponta Grossa', 'Rua Dr. Colares, 285, Ponta Grossa', "", 'Oferece serviços de educação e eventos culturais, com ampla área de lazer.'),
('SESI Cascavel', 'Rua Minas Gerais, 221, Cascavel', "", 'Centro de educação e atividades esportivas; promove eventos comunitários.'),
('SESI Londrina', 'Av. Duque de Caxias, 1234, Londrina', "", 'Unidade que disponibiliza educação, saúde e atividades recreativas.'),
('SESI Internacional Curitiba', 'Av. Presidente Kennedy, 108, Curitiba', "", 'Unidade com foco em educação internacional e intercâmbio cultural.'),
('SESI Industrial Curitiba', 'Rua Jorge Schimmelpfeng, 2200, Curitiba', "", 'Centro voltado para educação técnica e industrial, com infraestrutura moderna.');

INSERT INTO Table_Livro (CD_Livro, Nome_Livro, Autor_Livro, QTD_estoque, Numb_Paginas, Edicao_Livro, Descricao_Livro, IMG_Livro, CFK_Unidade)
VALUES 
('320C111L2021', 'A Longa Marcha', 'King, Stephen', 10, 320, 1, 'Romance distópico que acompanha uma competição mortal onde apenas um sobreviverá. A história é cheia de suspense e drama, mostrando os desafios físicos e mentais dos competidores.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('480C222P2018', 'Pequenos Incêndios por Toda Parte', 'Ng, Celeste', 6, 480, 1, 'Explora as complexidades da maternidade e os segredos de uma comunidade suburbana. As relações entre as famílias e as consequências de suas ações são centrais na narrativa.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('400B333O2010', 'O Código Da Vinci', 'Brown, Dan', 15, 400, 1, 'Thriller que segue Robert Langdon enquanto ele desvenda segredos escondidos no Louvre. Cheio de mistérios e reviravoltas, este livro prende a atenção do leitor do início ao fim.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('350A444N2000', 'A Menina que Roubava Livros', 'Zusak, Markus', 8, 350, 1, 'A história de uma jovem na Alemanha nazista que encontra consolo nos livros roubados. A narrativa é emocionante e tocante, destacando a importância da literatura em tempos difíceis.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('270G555G1995', 'Guerra dos Tronos', 'Martin, George R. R.', 20, 270, 1, 'Primeiro livro da série As Crônicas de Gelo e Fogo, que introduz os conflitos entre as famílias nobres. Uma saga épica cheia de intrigas, batalhas e personagens complexos.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('390G666F2011', 'Fahrenheit 451', 'Bradbury, Ray', 12, 390, 1, 'Romance distópico sobre um futuro onde os livros são proibidos e queimados. A história aborda temas de censura, liberdade de expressão e o valor do conhecimento.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('450D777D2007', 'Divergente', 'Roth, Veronica', 9, 450, 1, 'Em uma Chicago futurista, Beatrice Prior deve escolher entre cinco facções para definir sua identidade. A narrativa explora escolhas pessoais, coragem e as consequências de desafiar o sistema.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('320R888C2019', 'Corte de Espinhos e Rosas', 'Maas, Sarah J.', 7, 320, 1, 'Romance de fantasia que segue Feyre Archeron enquanto navega por um mundo de feéricos e intrigas. Com uma trama envolvente e rica em detalhes, a história cativa os fãs do gênero.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('280L999O2012', 'O Lado Bom da Vida', 'Quick, Matthew', 10, 280, 1, 'Um homem tenta reconstruir sua vida após um colapso mental com a ajuda de uma mulher igualmente quebrada. O livro aborda temas de superação, amor e as dificuldades dos transtornos mentais.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('310P101T2015', 'A Tumba dos Ancestrais', 'Canavan, Trudi', 5, 310, 1, 'Uma aventura épica de fantasia com magos e segredos antigos. A narrativa leva os leitores a um mundo mágico cheio de mistérios e desafios, com personagens cativantes e tramas complexas.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('290M202S2020', 'Sapiens: Uma Breve História da Humanidade', 'Harari, Yuval Noah', 14, 290, 1, 'Exploração das principais revoluções que moldaram a humanidade. O autor aborda a evolução da espécie humana, destacando eventos chave que influenciaram nossa sociedade e cultura atuais.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('410H303V2016', 'A Vida Invisível de Addie LaRue', 'Schwab, V. E.', 8, 410, 1, 'A história de uma mulher que faz um pacto para viver para sempre, mas é esquecida por todos que conhece. Com uma narrativa envolvente, o livro explora temas de imortalidade e solidão.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('330C404M2008', 'Mar de Tranquilidade', 'Mandel, Emily St. John', 10, 330, 1, 'Um romance que explora vidas entrelaçadas e as consequências de um ato de violência. A história é rica em detalhes e personagens, oferecendo uma reflexão sobre a condição humana.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('360B505D2017', 'Duna', 'Herbert, Frank', 7, 360, 1, 'Clássico da ficção científica sobre política, religião e poder em um planeta deserto. A narrativa é complexa e cheia de intrigas, com personagens memoráveis e um mundo ricamente detalhado.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('380W606S2014', 'Sangue e Cinzas', 'Armentrout, Jennifer L.', 9, 380, 1, 'Romance de fantasia com uma protagonista forte e misteriosa. A história combina elementos de ação, romance e fantasia, cativando os leitores com sua trama envolvente e personagens bem desenvolvidos.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('430K707M2013', 'Mistborn: O Império Final', 'Sanderson, Brandon', 12, 430, 1, 'Primeiro livro da série Mistborn, onde um grupo de rebeldes planeja derrubar um império milenar. A narrativa é cheia de reviravoltas, com um sistema de magia único e personagens complexos.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('420F808A2010', 'A Arte da Guerra', 'Tzu, Sun', 20, 420, 1, 'Clássico tratado militar chinês sobre estratégia e tática. Embora escrito há milhares de anos, os ensinamentos do livro são aplicáveis em diversas áreas modernas, incluindo negócios e política.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('360G909C2005', 'Cem Anos de Solidão', 'García Márquez, Gabriel', 18, 360, 1, 'História épica da família Buendía em uma aldeia fictícia na Colômbia. Com uma narrativa rica e detalhada, o livro explora temas de amor, poder e destino ao longo de gerações.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('310K111B2018', 'O Prisioneiro do Céu', 'Zafón, Carlos Ruiz', 15, 310, 1, 'Terceiro livro da série O Cemitério dos Livros Esquecidos. A narrativa mistura mistério, romance e elementos góticos, cativando os leitores com sua trama intrincada e atmosfera envolvente.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('340S222R2009', 'O Senhor das Moscas', 'Golding, William', 12, 340, 1, 'Um grupo de meninos presos em uma ilha deserta tentam governar a si mesmos com consequências desastrosas. O livro aborda temas de civilização, barbárie e a natureza humana de forma intensa e perturbadora.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('350C333H2011', 'O Sol é Para Todos', 'Lee, Harper', 25, 350, 1, 'Clássico da literatura americana que aborda o racismo e a injustiça no sul dos EUA. A narrativa é comovente e poderosa, destacando a importância da empatia e da igualdade.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('390T444T2022', 'A Travessia', 'Evans, Richard Paul', 8, 390, 1, 'Um romance sobre perda, amor e redenção. A história é emocionante e inspiradora, explorando os desafios pessoais dos personagens e a força das conexões humanas.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('410H555H2017', 'O Hobbit', 'Tolkien, J. R. R.', 10, 410, 1, 'Prequela de O Senhor dos Anéis. Bilbo Bolseiro embarca em uma jornada épica. Com uma narrativa rica e envolvente, o livro é um clássico da literatura de fantasia.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('370B666G2019', 'O Guia do Mochileiro das Galáxias', 'Adams, Douglas', 14, 370, 1, 'Uma comédia de ficção científica que segue as aventuras de Arthur Dent pelo universo. O livro é cheio de humor, absurdos e reflexões filosóficas, cativando leitores com sua originalidade.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('280P777D2016', '1984', 'Orwell, George', 30, 280, 1, 'Romance distópico sobre um futuro totalitário e a vigilância do governo. A história é intensa e perturbadora, explorando temas de controle, liberdade e resistência.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('350S888B2014', 'A Biblioteca Invisível', 'Cogman, Genevieve', 5, 350, 1, 'Uma bibliotecária espiã viaja entre mundos para salvar livros raros. A narrativa mistura elementos de fantasia, mistério e aventura, criando uma trama envolvente e única.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('320L999C2011', 'O Código Élfico', 'Tolkien, J. R. R.', 8, 320, 1, 'História de fantasia sobre elfos, magia e guerra. A narrativa é rica em detalhes e personagens, transportando os leitores para um mundo mágico e cativante.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('360P101L2013', 'A Peste', 'Camus, Albert', 10, 360, 1, 'Romance que explora a resistência humana durante uma peste devastadora. A história é intensa e filosófica, abordando temas de solidariedade, sofrimento e a condição humana.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('420K202R2020', 'O Retrato de Dorian Gray', 'Wilde, Oscar', 7, 420, 1, 'História de um homem que permanece jovem enquanto seu retrato envelhece. A narrativa é rica em detalhes e simbolismos, explorando temas de moralidade, beleza e decadência.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('310H303S2005', 'Senhor dos Anéis: O Retorno do Rei', 'Tolkien, J. R. R.', 18, 310, 1, 'Último livro da trilogia O Senhor dos Anéis. A narrativa culmina em uma épica batalha entre o bem e o mal, com personagens memoráveis e um desfecho emocionante.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('340D404F2015', 'Fundação', 'Asimov, Isaac', 12, 340, 1, 'Primeiro livro da série Fundação sobre a queda de um império galáctico e a criação de uma nova civilização. A narrativa é cheia de intrigas políticas e científicas, cativando os fãs de ficção científica.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('390T505D2010', 'Duna: Messias de Duna', 'Herbert, Frank', 9, 390, 1, 'Segundo livro da série Duna que explora as consequências do poder absoluto. A narrativa é intensa e filosófica, abordando temas de política, religião e identidade.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('380C606G2018', 'Guerra Mundial Z', 'Brooks, Max', 20, 380, 1, 'Relatos fictícios de sobreviventes de uma guerra global contra zumbis. A narrativa é rica em detalhes e perspectivas, criando uma visão abrangente e assustadora do apocalipse zumbi.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('430F707O2003', 'Orgulho e Preconceito', 'Austen, Jane', 25, 430, 1, 'Clássico romance sobre amor e sociedade na Inglaterra do século XIX. A narrativa é envolvente e cativante, explorando temas de classe social, casamento e moralidade.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('280R808E2014', 'E o Vento Levou', 'Mitchell, Margaret', 15, 280, 1, 'Romance épico sobre a vida durante a Guerra Civil Americana. A narrativa é rica em detalhes históricos e personagens complexos, oferecendo uma visão profunda e emocionante desse período tumultuado.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('350G909A2011', 'Admirável Mundo Novo', 'Huxley, Aldous', 12, 350, 1, 'Romance distópico sobre um futuro onde a humanidade é controlada por tecnologias e drogas. A narrativa é provocativa e reflexiva, explorando temas de liberdade, controle e a natureza humana.', '', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1));

-- falta

Select * From Table_Cargo;
Select * From Table_Ano_Escolar;
Select * From Table_Unidade;
Select * From Table_Livro;
Select * From Table_User;
Select * From Table_Historico;
Select * From Table_reservas;



INSERT INTO Table_User (ID_Aluno, NameUser, Nome_Completo, Senha, IMG_User, CFK_Ano, CFK_Cargo, CFK_Unidade) VALUES ('123456789', 'JoãoDoe', 'João Pedro Doe', 'minhasenha123', 'joao.jpg', 7, 1, 1);
select Table_Livro.Nome_Livro, Table_Unidade.Nome_Unidade, Table_Livro.Descricao_Livro from Table_Livro Inner Join Table_Unidade on Table_Unidade.CD_Unidade = Table_Livro.CFK_Unidade where Table_Livro.CD_Livro = "320R888C2019";	

select Table_Livro.Nome_Livro, Table_Livro.CD_Livro, Table_Unidade.Nome_Unidade, Table_Livro.Descricao_Livro, Table_Unidade.CD_Unidade from Table_Livro Inner Join Table_Unidade on Table_Unidade.CD_Unidade = Table_Livro.CFK_Unidade;


select Table_User.ID_Aluno,
    Table_User.NameUser,
    Table_User.Nome_Completo,
    Table_User.Senha,	
    Table_User.IMG_User,
    Table_Ano_Escolar.Ano_Escolar,
	Table_Cargo.Cargo,
    Table_Unidade.Nome_Unidade 
    from Table_User 
    inner join Table_Ano_Escolar on Table_User.CFK_Ano = Table_Ano_Escolar.CD_Ano_Escolar
    inner join Table_Cargo on Table_User.CFK_Cargo = Table_Cargo.CD_Cargo
    inner join Table_Unidade on Table_User.CFK_Unidade = Table_Unidade.CD_Unidade;

