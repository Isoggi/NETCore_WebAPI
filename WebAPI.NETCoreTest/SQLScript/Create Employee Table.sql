-- Table: public.Employee

-- DROP TABLE public."Employee";

CREATE TABLE public."Employee"
(
    "Id" bigint NOT NULL,
    "NIK" bigint,
    "Name" character(255) COLLATE pg_catalog."default",
    "Birthdate" date,
    "Sex" character(255) COLLATE pg_catalog."default",
    "Department" character(255) COLLATE pg_catalog."default",
    "Role" character(255) COLLATE pg_catalog."default",
    CONSTRAINT "employeeTable_Id" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Employee"
    OWNER to "testDB_Access";

COMMENT ON TABLE public."Employee"
    IS 'Employee table.';