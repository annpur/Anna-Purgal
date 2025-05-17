-- Tworzenie tabeli
CREATE TABLE Uzytkownicy (
  ID INT PRIMARY KEY,
  Imie VARCHAR(50),
  Email VARCHAR(100)
);

-- Wstawianie danych
INSERT INTO Uzytkownicy (ID, Imie, Email)
VALUES (1, 'Anna', 'anna@example.com');

-- Zapytanie
SELECT * FROM Uzytkownicy;
