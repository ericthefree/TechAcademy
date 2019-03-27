/* Create a database for a library management system */
CREATE DATABASE db_libraryManagement;
GO

USE db_libraryManagement;
GO

/* Create a table LIBRARY_BRANCH with primary key BranchID, and BranchName and BranchAddress */
CREATE TABLE tbl_library_branch (
	branch_id INT PRIMARY KEY NOT NULL IDENTITY(1001,1),
	branch_name VARCHAR(30) NOT NULL,
	branch_address VARCHAR(100) NOT NULL

);

/* Create a table PUBLISHER with primary key PublisherName, and PublisherAddress and PublisherPhone */
CREATE TABLE tbl_publisher (
	publisher_id INT NOT NULL PRIMARY KEY,
	publisher_name VARCHAR(50) NOT NULL,
	publisher_address VARCHAR(100) NOT NULL,
	publisher_phone VARCHAR(20) NOT NULL

);

/* Create a table Books with primary key BookID and Title and PublisherName with constraint against table PUBLISHER */
/* There must be at least two books written by 'Stephen King' located at the 'Central' branch. */
CREATE TABLE tbl_books (
	books_id INT PRIMARY KEY NOT NULL IDENTITY(100001,1),
	books_title VARCHAR(100) NOT NULL,
	books_author VARCHAR(40) NOT NULL,
	books_publisher_name INT CONSTRAINT fk_books_publisher_name FOREIGN KEY REFERENCES tbl_publisher(publisher_id) ON UPDATE CASCADE ON DELETE CASCADE
	
);

/* Create a table BOOK_AUTHORS with constraint BookID against table BOOKS and additional entry AuthorName */
CREATE TABLE tbl_book_authors (
	ba_book_id INT NOT NULL CONSTRAINT fk_ba_book_id FOREIGN KEY REFERENCES tbl_books(books_id) ON UPDATE CASCADE ON DELETE CASCADE,
	ba_author_name VARCHAR(50) NOT NULL

);

/* Createa a table BOOK_COPIES with key constraint BookID against table BOOKS and BranchID against table LIBRARY_BRANCH 
	with additional entry Number_Of_Copies */
CREATE TABLE tbl_book_copies (
	bc_book_id INT NOT NULL CONSTRAINT fk_bc_book_id FOREIGN KEY REFERENCES tbl_books(books_id) ON UPDATE CASCADE ON DELETE CASCADE,
	bc_branch_id INT NOT NULL CONSTRAINT fk_bc_branch_id FOREIGN KEY REFERENCES tbl_library_branch(branch_id) ON UPDATE CASCADE ON DELETE CASCADE,	
	bc_number_of_copies INT NOT NULL

);

/* Create a table BORROWER with primary key CardNo, and Name and Address and Phone */
CREATE TABLE tbl_borrower (
	borrower_card_no INT PRIMARY KEY NOT NULL IDENTITY(100001,1),
	borrower_name VARCHAR(40) NOT NULL,
	borrower_address VARCHAR(100) NOT NULL,
	borrower_phone VARCHAR(20) NOT NULL

);

/* Create a table BOOK_LOANS with key constrainst BookID against table BOOKS, BranchID against table LIBRARY_BRANCH and CardNo against BORROWER
	with additional entries DateOut and DateDue */
CREATE TABLE tbl_book_loans (
	bl_book_id INT NOT NULL CONSTRAINT fk_bl_book_id FOREIGN KEY REFERENCES tbl_books(books_id) ON UPDATE CASCADE ON DELETE CASCADE,
	bl_branch_id INT NOT NULL CONSTRAINT fk_branch_id FOREIGN KEY REFERENCES tbl_library_branch(branch_id) ON UPDATE CASCADE ON DELETE CASCADE,
	bl_card_no INT NOT NULL CONSTRAINT fk_bl_card_no FOREIGN KEY REFERENCES tbl_borrower(borrower_card_no) ON UPDATE CASCADE ON DELETE CASCADE,
	bl_date_out VARCHAR(30) NOT NULL,
	bl_date_due VARCHAR(30) NOT NULL

);

/* There is a library branch called 'Sharpstown' and one called 'Central'. */
/* There are at least 4 branches in the LIBRARY_BRANCH table. */
INSERT INTO tbl_library_branch
	(branch_name, branch_address)
	VALUES
	('Sharpstown','233 Valley View Drive, Oklahoma City, OK 73118'),
	('Central','14823 NE Sherry Street, Moore, OK 73071'),
	('Southbank','1201 Plane View Road, Enid, OK 73705'),
	('Grandview','East Ketchum Avenue, Grand Lake Town, OK 74349')

;

/* Enter data for publisher list */
INSERT INTO tbl_publisher
	(publisher_id, publisher_name, publisher_address, publisher_phone)
	VALUES
	('100001','Council Oak Books','2 W 6th St # 262, Tulsa, OK 74119','(918) 743-2665'),
	('100002','Gretchen Cagle Publications','1199 W Country Club Rd, Claremore, OK 74017','(918) 342-1080'),
	('100003','Harrison House Publishers','PO Box 35035, Tulsa, OK 35035','(918) 523-5700'),
	('100004','New Forums Press','1018 South Lewis Street, Stillwater, OK 74074','(405) 372-6158'),
	('100005','RoadRunner Press','122 NW 32nd Street, Oklahoma City, OK 73118','(405) 524-6205'),
	('100006','Picador USA','175 Fifth Avenue, New York, NY 10010','(646) 307-5421')
;

/* There is a book called 'The Lost Tribe' found in the 'Sharpstown' branch. */
/* There are at least 20 books in the BOOK table. */
/* Each library branch has at least 10 book titles, and at least two copies of each of those titles. */
/* There must be at least two books written by 'Stephen King' located at the 'Central' branch. */
INSERT INTO tbl_books
	(books_publisher_name,books_title,books_author)
	VALUES
	('100001','The Lost Tribe','Mark Lee'),('100001','In Search of Lost Time','Marcel Proust'),
	('100002','Don Quixote','Miguel de Cervantes'),('100003','Ulysses','James Joyce'),
	('100002','The Great Gatsby','F. Scott Fitzgerald'),('100004','Moby Dick','Herman Melville'),
	('100005','Hamlet','William Shakespeare'),('100001','War and Peace','Leo Tolstoy'),
	('100002','The Odyssey','Homer'),('100001','One Hundred Years of Solitude','Gabriel Garcia Marquez'),
	('100002','The Divine Comedy','Dante Alighieri'),('100003','The Brothers Karamzov','Fyodor Dostroyevsky'),
	('100003','Madame Bovary','Gustave Flaubert'),('100004','The Adventures of Huckleberry Finn','Mark Twain'),
	('100002','The Iliad','Homer'),('100001','Lolita','Vladimir Nabokov'),
	('100001','Crime and Punishment','Fyodor Dostoyevsky'),('100004','Alice''Adventures in Wonderland','Lewis Carroll'),
	('100004','Wuthering Heights','Emily Brontë'),('100003','Pride and Prejudice','Jane Austen'),
	('100002','The Cather in the Rye','J. D. Salinger'),('100001','The Sound and the Fury','William Faulkner'),
	('100006','To the Lighthouse','Virginia Woolf'),('100006','Heart of Darkness','Joseph Conrad'),
	('100003','Anna Karenina','Leo Tolstoy'),('100005','Nineteen Eighty Four','George Orwell'),
	('100003','Great Expectations','Charles Dickens'),('100004','Gulliver''s Travels','Jonathan Swift'),
	('100006','It','Stephen King'),('100006','The Shining','Stephen King'),
	('100006','Misery','Stephen King'),('100006','Pet Sematary','Stephen King')
;

/* There are at least 10 authors in the BOOK_AUTHORS table. */
INSERT INTO tbl_book_authors
	(ba_book_id, ba_author_name)
	VALUES
	('100001','Mark Lee'),('100002','Marcel Proust'),('100003','Miguel de Cervantes'),('100004','James Joyce'),('100005','F. Scott Fitzgerald'),
	('100006','Herman Melville'),('100007','William Shakespeare'),('100008','Leo Tolstoy'),('100009','Homer'),('100010','Gabriel Garcia Marquez'),
	('100011','Dante Alighieri'),('100012','Fyodor Dostroyevsky'),('100013','Gustave Flaubert'),('100014','Mark Twain'),('100015', 'Homer'),
	('100016','Vladimir Nabokov'),('100017', 'Fyodor Dostoyevsky'),('100018','Lewis Carroll'),('100019','Emily Brontë'),('100020','Jane Austen'),
	('100021','J. D. Salinger'),('100022','William Faulkner'),('100023','Virginia Woolf'),('100024','Joseph Conrad'),('100025','Leo Tolstoy'),
	('100026','George Orwell'),('100027','Charles Dickens'),('100028','Jonathan Swift'),('100029','Stephen King'),('100030','Stephen King'),
	('100031','Stephen King'),('100032','Stephen King')
;

/* Each library branch has at least 10 book titles, and at least two copies of each of those titles. */
INSERT INTO tbl_book_copies
	(bc_book_id, bc_branch_id, bc_number_of_copies)
	VALUES
	('100001','1001','2'),('100002','1001','7'),('100003','1001','2'),('100004','1001','6'),('100005','1001','2'),('100006','1001','6'),
	('100007','1001','3'),('100008','1001','6'),('100009','1001','3'),('100010','1001','5'),('100011','1001','3'),('100012','1001','5'),
	('100013','1001','4'),('100014','1001','5'),('100015','1001','4'),('100016','1001','4'),('100017','1001','4'),('100018','1001','4'),
	('100019','1001','5'),('100020','1001','4'),('100021','1001','5'),('100022','1001','3'),('100023','1001','5'),('100024','1001','3'),
	('100025','1001','6'),('100026','1001','3'),('100027','1001','6'),('100028','1001','2'),('100029','1001','6'),('100030','1001','2'),
	('100031','1001','7'),('100032','1001','2'),
	

	('100001','1002','3'),('100002','1002','8'),('100003','1002','3'),('100004','1002','7'),('100005','1002','3'),('100006','1002','7'),
	('100007','1002','4'),('100008','1002','7'),('100009','1002','4'),('100010','1002','6'),('100011','1002','4'),('100012','1002','6'),
	('100013','1002','5'),('100014','1002','6'),('100015','1002','5'),('100016','1002','5'),('100017','1002','5'),('100018','1002','5'),
	('100019','1002','6'),('100020','1002','5'),('100021','1002','6'),('100022','1002','4'),('100023','1002','6'),('100024','1002','4'),
	('100025','1002','7'),('100026','1002','4'),('100027','1002','7'),('100028','1002','3'),('100029','1002','7'),('100030','1002','3'),
	('100031','1002','8'),('100032','1002','3'),
	

	('100001','1003','4'),('100002','1003','9'),('100003','1003','4'),('100004','1003','8'),('100005','1003','4'),('100006','1003','8'),
	('100007','1003','5'),('100008','1003','8'),('100009','1003','5'),('100010','1003','7'),('100011','1003','5'),('100012','1003','7'),
	('100013','1003','6'),('100014','1003','7'),('100015','1003','6'),('100016','1003','6'),('100017','1003','6'),('100018','1003','6'),
	('100019','1003','7'),('100020','1003','6'),('100021','1003','7'),('100022','1003','5'),('100023','1003','7'),('100024','1003','5'),
	('100025','1003','8'),('100026','1003','5'),('100027','1003','8'),('100028','1003','4'),('100029','1003','8'),('100030','1003','4'),
	('100031','1003','9'),('100032','1003','4'),
	

	('100001','1004','5'),('100002','1004','10'),('100003','1004','5'),('100004','1004','9'),('100005','1004','5'),('100006','1004','9'),
	('100007','1004','6'),('100008','1004','9'),('100009','1004','6'),('100010','1004','8'),('100011','1004','6'),('100012','1004','8'),
	('100013','1004','7'),('100014','1004','8'),('100015','1004','7'),('100016','1004','7'),('100017','1004','7'),('100018','1004','7'),
	('100019','1004','8'),('100020','1004','7'),('100021','1004','8'),('100022','1004','6'),('100023','1004','8'),('100024','1004','6'),
	('100025','1004','9'),('100026','1004','6'),('100027','1004','9'),('100028','1004','5'),('100029','1004','9'),('100030','1004','5'),
	('100031','1004','10'),('100032','1004','5')
	
;

/* There are at least 8 borrowers in the BORROWER table, and at least 2 of those borrowers have more than 5 books loaned to them. */
INSERT INTO tbl_borrower
	(borrower_name, borrower_address, borrower_phone)
	VALUES
	('James Brown','123 South Sherry, Norman, OK 73067','(405) 831-3123'),
	('Marty Olson','1105 James Street, Moore, OK 73085','(405) 235-5123'),
	('Jennifer Brown','623 Meeks Avenue, Enid, OK 76842','(405) 442-2311'),
	('Matthew King','6623 First Street, Oklahoma City, OK 70232','(405) 632-3342'),
	('Patricia Young','18412 Pine View Avenue, Tulsa, OK 76002','(405) 632-2451'),
	('Betty James','812 Morningview, Derby, Kansas 67037','(321) 788-4290'),
	('Mark Goodwin','815 Bush Street, Grand Lakes, OK 77003','(405) 232-2235'),
	('Sean Meeks','23621 Maple Blvd, Central, OK 78022','(405) 723-2345'),
	('Bill Hicks','23621 Maple Blvd, Central, OK 78022','(405) 723-2345'),
	('Mary Emory','2123 Everest Street, Grove, OK 78012','(405) 435-3245'),
	('Josh Jones','323 East First Street, Oklahoma City, OK 70232','(405) 845-2342'),
	('Richard Hill','532 Overland Road, Stillwater, OK 73320','(405) 122-5422'),
	('Barbara Smith','23415 James Avenue, Amarillo, TX 84234','(613) 231-2342')	
;

/* There are at least 8 borrowers in the BORROWER table, and at least 2 of those borrowers have more than 5 books loaned to them. */
/* There are at least 50 loans in the BOOK_LOANS table. */
INSERT INTO tbl_book_loans
	(bl_book_id, bl_branch_id, bl_card_no, bl_date_out, bl_date_due)
	VALUES
	('100001','1001','100001','August 8, 2018','December 8, 2018'),('100002','1001','100001','August 8, 2018','December 8, 2018'),('100003','1001','100001','August 8, 2018','December 8, 2018'),('100004','1001','100001','August 8, 2018','December 8, 2018'),('100005','1001','100001','August 8, 2018','December 8, 2018'),
	('100001','1002','100002','September 3, 2018','January 3, 2019'),('100002','1002','100002','September 3, 2018','January 3, 2019'),('100003','1002','100002','September 3, 2018','January 3, 2019'),('100004','1002','100002','September 3, 2018','January 3, 2019'),('100005','1002','100002','September 3, 2018','January 3, 2019'),
	('100001','1003','100003','October 3, 2018','February 3, 2019'),('100002','1003','100003','October 3, 2018','February 3, 2019'),('100003','1003','100003','October 3, 2018','February 3, 2019'),('100004','1003','100003','October 3, 2018','February 3, 2019'),('100005','1003','100003','October 3, 2018','February 3, 2019'),
	('100003','1004','100004','November 2, 2018','March 2, 2019'),('100003','1003','100004','November 2, 2018','March 2, 2019'),('100004','1001','100004','November 2, 2018','March 2, 2019'),('100005','1001','100004','November 2, 2018','March 2, 2019'),('100006','1001','100004','November 2, 2018','March 2, 2019'),
	('100003','1002','100005','August 31, 2018','December 31, 2018'),('100004','1002','100005','August 31, 2018','December 31, 2018'),('100005','1003','100007','August 1, 2018','December 1, 2018'),('100006','1004','100008','June 20, 2018','October 20, 2018'),
	('100007','1001','100006','October 31, 2018','February 28, 2019'),('100008','1002','100005','August 31, 2018','December 31, 2018'),('100009','1003','100007','August 1, 2018','December 1, 2018'),('100010','1004','100008','June 20, 2018','October 20, 2018'),
	('100011','1001','100006','October 31, 2018','February 28, 2019'),('100012','1002','100005','August 31, 2018','December 31, 2018'),('100013','1003','100007','August 1, 2018','December 1, 2018'),('100014','1004','100008','June 20, 2018','October 20, 2018'),
	('100015','1001','100006','October 31, 2018','February 28, 2019'),('100016','1002','100005','August 31, 2018','December 31, 2018'),('100017','1003','100007','August 1, 2018','December 1, 2018'),('100018','1004','100008','June 20, 2018','October 20, 2018'),
	('100019','1001','100006','October 31, 2018','February 28, 2019'),('100020','1002','100005','August 31, 2018','December 31, 2018'),('100021','1003','100007','August 1, 2018','December 1, 2018'),('100022','1004','100008','June 20, 2018','October 20, 2018'),
	('100023','1001','100006','October 31, 2018','February 28, 2019'),('100024','1002','100005','August 31, 2018','December 31, 2018'),('100025','1003','100007','August 1, 2018','December 1, 2018'),('100026','1004','100008','June 20, 2018','October 20, 2018'),
	('100027','1001','100006','October 31, 2018','February 28, 2019'),('100028','1002','100005','August 31, 2018','December 31, 2018'),('100029','1003','100007','August 1, 2018','December 1, 2018'),('100030','1004','100008','June 20, 2018','October 20, 2018'),
	('100031','1001','100006','October 31, 2018','February 28, 2019'),('100032','1002','100005','August 31, 2018','December 31, 2018')
;

/* How many copies of the book titled "The Lost Tribe" are owned by the library branch whose name is "Sharpstown"? */
CREATE PROC getBookCopiesByBranchName

@bookTitle VARCHAR(50), @branchName VARCHAR(40)
AS
BEGIN
	SELECT a2.branch_name AS 'Branch Name:',a3.books_title AS 'Book Title', a1.bc_number_of_copies AS 'Number of Copies:'
		FROM tbl_book_copies a1
		INNER JOIN tbl_library_branch a2 ON a2.branch_id = a1.bc_branch_id
		INNER JOIN tbl_books a3 ON a3.books_id = a1.bc_book_id
		WHERE a3.books_title LIKE @bookTitle AND a2.branch_name LIKE @branchName
	;
END

EXEC getBookCopiesByBranchName 'The Lost Tribe', 'Sharpstown'

/* How many copies of the book titled "The Lost Tribe" are owned by each library branch? */
CREATE PROC getNumCopiesOwnedByEachBranch
@bookTitle VARCHAR(50)
AS
BEGIN
	SELECT a2.branch_name AS 'Branch Name:',
		a3.books_title AS 'Book Title',
		a1.bc_number_of_copies AS 'Number of Copies:'
		FROM tbl_book_copies a1
		INNER JOIN tbl_library_branch a2 ON a2.branch_id = a1.bc_branch_id
		INNER JOIN tbl_books a3 ON a3.books_id = a1.bc_book_id
		WHERE a3.books_title LIKE @bookTitle
	;
END

EXEC getNumCopiesOwnedByEachBranch 'The Lost Tribe'

/*  Retrieve the names of all borrowers who do not have any books checked out. */
CREATE PROC getBorrowerNamesWithNoBooksCheckedOut
AS
BEGIN
	SELECT a1.borrower_name AS 'Borrower Name:'
		FROM tbl_borrower a1
		LEFT JOIN tbl_book_loans a2 ON a2.bl_card_no = a1.borrower_card_no
		WHERE a2.bl_card_no IS NULL
	;
END

EXEC getBorrowerNamesWithNoBooksCheckedOut

/* For each book that is loaned out from the "Sharpstown" branch and whose DueDate is today, retrieve the book title, the borrower's name, and the borrower's address. */
CREATE PROC getLoanedBooksByBranchDueOnDate

@branchName VARCHAR(50), @dueDate VARCHAR(50)
AS
BEGIN
	SELECT a1.branch_name AS 'Branch Name:',a3.books_title AS 'Book Title:',a4.borrower_name AS 'Borrower Name:', a4.borrower_address AS 'Borrower Address:', a2.bl_date_due AS 'Date Due:'
		FROM tbl_library_branch a1
		INNER JOIN tbl_book_loans a2 ON a2.bl_branch_id = a1.branch_id
		INNER JOIN tbl_books a3 ON a3.books_id = a2.bl_book_id
		INNER JOIN tbl_borrower a4 ON a4.borrower_card_no = a2.bl_card_no
		WHERE a1.branch_name = @branchName AND a2.bl_date_due LIKE @dueDate
	;
END

/* I would expect that there would be more to this that would make sure it can do a comparison to the date entered and the date in the column
	my date data was in the format of MonthName day, four digit year like December 8, 2018.  I would expect if a person entered a numerical data
	that the value would return null.  Not sure if we were supposed to take it that far or not, but this is where I left this */
EXEC getLoanedBooksByBranchDueOnDate 'Sharpstown', 'December 8, 2018'

/* For each library branch, retrieve the branch name and the total number of books loaned out from that branch. */
CREATE PROC getLoanedBooksByBranch
AS
BEGIN
	SELECT a1.branch_name AS 'Library Branch Name:', COUNT(a1.branch_name) AS 'Number of Books Loaned Out:'
		FROM tbl_library_branch a1
		INNER JOIN tbl_book_loans a2 ON a2.bl_branch_id = a1.branch_id
		GROUP BY a1.branch_name
	;
END

EXEC getLoanedBooksByBranch

/* Retrieve the names, addresses, and the number of books checked out for all borrowers who have more than five books checked out. */
CREATE PROC getBorrowersNumberBooksLoanedOutGreaterThan

@numberBooks INT
AS
BEGIN
	SELECT a1.borrower_name AS 'Borrower Name:', a1.borrower_address AS 'Address:', COUNT(a1.borrower_name) AS 'Number of Books Loaned Out:'
		FROM tbl_borrower a1
		INNER JOIN tbl_book_loans a2 ON a2.bl_card_no = a1.borrower_card_no
		GROUP BY a1.borrower_name, a1.borrower_address
		HAVING COUNT(a1.borrower_name) > @numberBooks
	;
END

EXEC getBorrowersNumberBooksLoanedOutGreaterThan 5

/* For each book authored (or co-authored) by "Stephen King", retrieve the title and the number of copies owned by the library branch whose name is "Central". */
CREATE PROC getBookTitleAndCopiesOwnedByBranch

@bookAuthor VARCHAR(50),
@branch VARCHAR(40)
AS
BEGIN
	SELECT a1.books_title AS 'Book Title:',COUNT(a2.bc_number_of_copies) AS 'Number of Copies:'
		FROM tbl_books a1
		INNER JOIN tbl_book_copies a2 ON a2.bc_book_id = a1.books_id
		INNER JOIN tbl_library_branch a3 ON a3.branch_id = a2.bc_branch_id
		WHERE a3.branch_name = @branch AND a1.books_author = @bookAuthor
		GROUP BY a1.books_title
	;
END

EXEC getBookTitleAndCopiesOwnedByBranch 'Stephen King', 'Central'
