-- Script Date: 25/08/2026 21:37  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [Agenda] (
  [IdAgenda] INTEGER NOT NULL
, [Note] TEXT NOT NULL
, [DataEvento] DATETIME NOT NULL
, CONSTRAINT [PK_Agenda] PRIMARY KEY ([IdAgenda])
);
