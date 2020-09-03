-- Role: "testDB_Access"
-- DROP ROLE "testDB_Access";

CREATE ROLE "testDB_Access" WITH
  LOGIN
  NOSUPERUSER
  INHERIT
  NOCREATEDB
  NOCREATEROLE
  NOREPLICATION
  ENCRYPTED PASSWORD 'md51ca0fb5dea3ba501778f197e8c9ebada';
-- Password is 'dbpassword'

COMMENT ON ROLE "testDB_Access" IS 'App user roles for testDB.';