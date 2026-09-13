-- Script Date: 13/09/2026 18:06  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [Attivita] (
  [IdAttivita] INTEGER NOT NULL
, [Nome] TEXT NOT NULL
, [Descrizione] TEXT NULL
, [Aperto] DATETIME NULL
, [Chiuso] DATETIME NULL
, [IdStato] INTEGER NULL
, [IdProgetto] INTEGER NULL
, [Urgente] INTEGER NULL
, [Nota] TEXT NULL
, CONSTRAINT [PK_Attivita] PRIMARY KEY ([IdAttivita])
);
