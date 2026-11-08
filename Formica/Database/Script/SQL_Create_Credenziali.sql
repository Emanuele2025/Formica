-- Script Date: 25/10/2026 19:37  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [Credenziali] (
  [IdCredenziale] INTEGER PRIMARY KEY AUTOINCREMENT
, [Titolo] text NOT NULL
, [UserName] text NULL
, [Email] text NULL
, [Password] text NOT NULL
, [Nota] text NULL
);
