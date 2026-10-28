-- Script Date: 25/10/2026 19:37  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [Credenziali] (
  [IdCredenziale] bigint NOT NULL
, [Titolo] text NOT NULL
, [UserName] text NULL
, [Email] text NULL
, [Password] text NOT NULL
, [Nota] text NULL
, CONSTRAINT [sqlite_master_PK_Credenziali] PRIMARY KEY ([IdCredenziale])
);
