create database Logistics;

use Logistics;

create table products
(
	id varchar(10) not null primary key,
	[name] nvarchar(50) not null,
	created_date datetime default getdate(),
	updated_date datetime default getdate(),
	isdeleted bit default 0
);

create table orders
(
	id varchar(10) not null primary key,
	customer_name nvarchar(100) not null,
	customer_address nvarchar(100) not null,
	customer_phone varchar(20) not null,
	customer_email varchar(50) not null,
	delivery_date datetime,
	delivery_address nvarchar(100),
	estimate_delivery_date datetime,
	created_date datetime default getdate(),
	updated_date datetime default getdate(),
	status bit default 0,
	isdeleted bit default 0
);

create table order_details
(
	id int  NOT NULL primary key identity,
	product_id varchar(10) foreign key references products(id),
	order_id varchar(10) foreign key references orders(id),
	total_price decimal,
	quantity int
);

create table accounts
(
	id varchar(10) not null primary key ,
	email varchar(50) not null,
	username varchar(10) not null,
	[password] nvarchar(100) not null,
	created_date datetime default getdate(),
	updated_date datetime default getdate(),
	isdeleted bit default 0
);

create table chats
(
	id int not null primary key identity,
	account_id varchar(10) foreign key references accounts(id),
	client_id int,
	[message] nvarchar(255) not null,
	is_admin bit,
	created_date datetime default getdate(),
	updated_date datetime default getdate(),
	isdeleted bit default 0
);

create table comments
(
	id int not null primary key identity,
	client_id int,
	content nvarchar(255) not null,
	count_stars int,
	created_date datetime default getdate(),
	updated_date datetime default getdate(),
	isdeleted bit default 0
);