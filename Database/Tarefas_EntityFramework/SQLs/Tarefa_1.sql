DROP DATABASE IF EXISTS [SpaceX]

CREATE DATABASE [SpaceX]

USE [SpaceX]

CREATE TABLE [Galaxy] (
    [Id] INT NOT NULL IDENTITY (1, 1),
    [Name] VARCHAR(50) NOT NULL,
    [Mass] DECIMAL NOT NULL,
    [Size] DECIMAL NOT NULL,
    [Type] VARCHAR(50) NOT NULL,
    
    CONSTRAINT [PK_Galaxy] PRIMARY KEY([Id])
)

CREATE TABLE [Star] (
    [Id] INT NOT NULL IDENTITY (1, 1),
    [Name] VARCHAR(50) NOT NULL,
    [Mass] DECIMAL NOT NULL,
    [Size] DECIMAL NOT NULL,
    [Luminosity] DECIMAL NOT NULL,
    [GalaxyId] INT NOT NULL,

    CONSTRAINT [PK_Star] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Galaxy_Stars] FOREIGN KEY([GalaxyId]) REFERENCES [Galaxy]([Id])
)

CREATE TABLE [Planet] (
    [Id] INT NOT NULL IDENTITY (1, 1),
    [Name] VARCHAR(50) NOT NULL,
    [Mass] DECIMAL,
    [Size] DECIMAL NOT NULL,
    [Habitable] BIT NOT NULL,
    [Distance] DECIMAL NOT NULL,
    [StarId] INT NOT NULL,

    CONSTRAINT [PK_Planet] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Star_Planets] FOREIGN KEY([StarId]) REFERENCES [Star]([Id])
)