create table corsi(
id int not null primary key,
nome varchar(256),
anno int
);

create table studenti(
id int not null primary key,
nome varchar(32),
cognome varchar(32),
corso_id int references corsi(id)
);
