DROP DATABASE IF EXISTS tarefa_07;

CREATE DATABASE tarefa_07;

USE tarefa_07;

CREATE TABLE Villain (
	Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(45) NOT NULL,
    Crimes_qtd INT NOT NULL
);

CREATE TABLE Agent(
	Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(45) NOT NULL,
    Address VARCHAR(45) NOT NULL,
    Birth DATE NOT NULL,
    Skill VARCHAR(45) NOT NULL,
    Sex ENUM("M", "F") NOT NULL,
    Email VARCHAR(45) NOT NULL
);

CREATE TABLE Mission(
	Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Mission_Date DATE NOT NULL,
    Nome VARCHAR(45) NOT NULL,
    Mission_Local VARCHAR(45) NOT NULL,
    Duration INT NOT NULL,
    IdVillain INT NOT NULL,
    CONSTRAINT fk_VillainMission FOREIGN KEY (IdVillain) REFERENCES Villain(Id)
);

CREATE TABLE Agent_Has_Mission(
	IdAgent INT NOT NULL,
    IdMission INT NOT NULL,
    CONSTRAINT pk_Agent_Has_Mission PRIMARY KEY (IdAgent, IdMission),
    CONSTRAINT fk_AgentId FOREIGN KEY (IdAgent) REFERENCES Agent(Id),
    CONSTRAINT fk_MissionId FOREIGN KEY (IdMission) REFERENCES Mission(Id)
);

INSERT INTO Villain (Nome, Crimes_qtd) VALUES
('Freeza', 150), ('Cell', 94), ('Majin Buu', 312), ('Kaidou', 140), ('Big mom', 45);

INSERT INTO Agent (Nome, Address, Birth, Skill, Sex, Email) VALUES
('Goku', 'Planet Vegeta', '1984-12-3', 'Ki', 'M', 'goku@hotmail.com'),
('Vegeta', 'Planet Vegeta', '1984-12-3','Ki', 'M','vegeta@gmail.com'),
('Illaoi', 'Bilgewater', '1950-1-1', 'God of movement', 'F', 'illaoi@yahoo.com'),
('Kratos', 'Sparta', '0-0-0', 'Rage of sparta', 'M', 'kratos@gmail.com'),
('Luffy', 'East blue', '1990-08-12', 'Gommu gommu no mi', 'M', 'luffy@outlook.com');

INSERT INTO Mission (Mission_Date, Nome, Mission_Local, Duration, IdVillain) VALUES
('2022-12-02', 'Dragonborn', 'Skyrim', 37, 1), ('2022-09-05', 'Nerevarin', 'Morrowind', 72, 3),
('2022-01-16', 'Eleven', 'Hawkins', 29, 4), ('2022-07-21', 'The last sayanjin', 'Upside down', 310, 5),
('2022-06-27', 'Ace', 'Marineford', 134, 2);

INSERT INTO Agent_Has_Mission (IdAgent, IdMission) VALUES
(5, 1), (3, 2), (1, 3), (4, 2), (5, 4);

SELECT A.Nome AS "Hero", A.Email, M.Nome AS 'Mission', M.Mission_Date FROM Agent AS A 
JOIN Mission AS M JOIN Agent_Has_Mission AS X 
ON  X.IdAgent = A.Id AND X.IdMission = M.Id;

SELECT M.Nome AS "Mission", M.Mission_Date, M.Duration, V.Nome AS 'Villain' FROM Mission AS M JOIN Villain AS V 
ON M.Id = V.Id;

SELECT A.Nome AS Hero, M.Nome AS Mission, V.Nome AS 'Villain' FROM Agent AS A 
JOIN Mission AS M JOIN Villain AS V JOIN Agent_Has_mission AS X
ON  X.IdAgent = A.Id AND X.IdMission = M.Id AND M.IdVillain = V.Id;