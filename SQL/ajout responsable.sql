CREATE TABLE IF NOT EXISTS responsable
(
  login VARCHAR(64) NULL ,
  pwd VARCHAR(64) NULL  
) 

INSERT INTO responsable (login,pwd) VALUES ('Mediatekresp', SHA2('Admin123!', 256))
