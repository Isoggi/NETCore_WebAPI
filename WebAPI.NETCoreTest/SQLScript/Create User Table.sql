-- Table: public.User

-- DROP TABLE public."User";

CREATE TABLE public."User"
(
    "Id" bigint NOT NULL,
    "User_Id" character(255) COLLATE pg_catalog."default" NOT NULL,
    "Password" character(255) COLLATE pg_catalog."default" NOT NULL,
    "Name" character(255) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT "User_Id" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."User"
    OWNER to "testDB_Access";