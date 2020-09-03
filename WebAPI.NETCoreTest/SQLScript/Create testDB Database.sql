-- Database: testDB

-- DROP DATABASE "testDB";

CREATE DATABASE "testDB"
    WITH 
    OWNER = "testDB_Access"
    ENCODING = 'UTF8'
    LC_COLLATE = 'Indonesian_Indonesia.1252'
    LC_CTYPE = 'Indonesian_Indonesia.1252'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;

COMMENT ON DATABASE "testDB"
    IS 'A database, best used for testing.';