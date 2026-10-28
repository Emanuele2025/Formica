-- Script Date: 25/10/2026 19:34  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [Documenti] (
  [IdDocumento] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Titolo] text NOT NULL
, [Descrizione] text NULL
, [NomeFile] text NOT NULL
, [File] image NOT NULL
);
