use PathOfExile

BEGIN TRANSACTION

CREATE TABLE Classes
(
	classes_id int identity(1,1),
	classes_name varchar(100) not null,
	starting_str int not null,
	starting_dex int not null,
	starting_int int not null,
	classes_image varchar(1000) not null,

	constraint pk_Classes primary key(classes_id),
);

CREATE TABLE Ascendancy
(
	ascendancy_id int identity(1,1),
	classes_id int not null,
	ascendancy_name varchar(100) not null,
	ascendancy_image varchar(1000) not null,

	constraint pk_Ascendancy primary key(ascendancy_id),
	constraint fk_Classes foreign key(classes_id) references Classes(classes_id),
);

CREATE TABLE Currency
(
	currency_id int identity(1,1),
	currency_name varchar(200) not null,
	stack_size int not null,
	description_text varchar(1000) not null,
	currency_image varchar(100) not null,
	trade_description varchar(5000) not null,

	constraint pk_Currency primary key(currency_id),

);

	CREATE TABLE Forum_Post
(
	forum_id int identity(1,1),
	username varchar(200) not null,
	subject varchar(200) not null,
	message varchar(max) not null,
	post_date datetime default getdate(),

	constraint pk_Forum_Post primary key(forum_id),
);


COMMIT