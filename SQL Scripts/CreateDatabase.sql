CREATE DATABASE IF NOT EXISTS fuelled_client_tracker;
USE fuelled_client_tracker;

CREATE TABLE Clients (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(255),
    Email VARCHAR(255),
    StartDate DATETIME NULL,
    RenewalDate DATETIME NULL,
    PolicyTypesCSV TEXT,
    OnboardingStage INT
);
