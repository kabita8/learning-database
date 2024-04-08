-- SQLite
--create table publishers
create table publishers(
id int primary key ,
name nvarchar(200),
address nvarchar(400),
phone varchar(10),
registration nvarchar(100)
);

--Create table Authordetails
create table AuthorDetails(
id int primary key,
Education nvarchar(200),
Publications nvarchar(400),
Organization varchar(10),
AuthorDetailed integer,
foreign key(AuthorDetailed) REFERENCES Authors(Id)
);

select * from AuthorDetails

--delete table
drop table Authors

--create table Authors
CREATE TABLE Authors(
Id integer PRIMARY KEY,
Name varchar(50),
Gender varchar(50),
Address nvarchar(50),
Email nvarchar(50),
Dob nvarchar(50),
AuthorsId integer,
FOREIGN KEY(AuthorsId) REFERENCES Books(Id)
);

select * from Authors
INSERT INTO Authors
VALUES(1, 'Bhupendra Singh Saud', 'Male', 'Nepal', 'kecpublication@gmail.com', '1980-03-09', 1),
    (2, 'Arjun Saud', 'Male', 'Nepal', 'kecpublication@gmail.com', '1985-09-04', 2);
INSERT INTO Authors
VALUES(3, 'Arjun Saud', 'Male', 'Nepal', 'kecpublication@gmail.com', '1980-03-09', 1);


--classwork 1: get authors details like name, contact details 

--classwork 2: create another books table (id, title ,edition ,prices,isbn,published)
--relate books and authors (one-to-many), foreign key on many side (authors)
--insert some rows is books and authors table
SELECT*FROM Books
CREATE TABLE Books(
Id INTEGER PRIMARY KEY,
Title nvarchar(200),
Edition nvarchar(400),
Price int,
ISBN nvarchar(50),
Publication DATE
);

insert into Books
values(null,'Cloud computing','second 2022',355,984-3464-785-3,'2022-04-06');
--one to  many
SELECT Books.Title, Authors.Name
FROM Books
JOIN Authors ON Books.Id = Authors.AuthorsId;
--one to many
SELECT Books.Title, COUNT(Authors.Id) AS AuthorCount
FROM Books
LEFT JOIN Authors ON Books.Id = Authors.AuthorsId
GROUP BY Books.Id, Books.Title;
--one to many
SELECT Authors.Name, Books.Title
FROM Authors
JOIN Books ON Authors.AuthorsId = Books.Id;