USE [master]
GO

ALTER DATABASE School SET SINGLE_USER WITH ROLLBACK IMMEDIATE
GO

DROP DATABASE IF EXISTS School;
GO

CREATE DATABASE School;
GO

USE School;
GO

DROP TABLE IF EXISTS Enrollments;
DROP TABLE IF EXISTS Courses;
DROP TABLE IF EXISTS Instructors;
DROP TABLE IF EXISTS Students;
GO

-- Creating the Schema
CREATE TABLE Students (
	stdID		INT				NOT NULL PRIMARY KEY,
	stdName		NVARCHAR(20)	NOT NULL,
	);

CREATE TABLE Instructors (
	InstID		INT				NOT NULL PRIMARY KEY,
	InstName	NVARCHAR(20)	NOT NULL,
	);

CREATE TABLE Courses (
	CourseID		INT				NOT NULL PRIMARY KEY,
	CourseName		NVARCHAR(30)	NOT NULL,
	CourseDesc		NVARCHAR(150),
	InstID			INT				FOREIGN KEY REFERENCES Instructors(InstID)
	);

CREATE TABLE Enrollments (
	CourseID	INT		FOREIGN KEY REFERENCES Courses(CourseID),
	stdID		INT		FOREIGN KEY	REFERENCES	Students(stdID)
	);
GO

-- ######################################
-- Inserting data into students
INSERT INTO Students VALUES (1101, 'Haley');
INSERT INTO Students VALUES (1247, 'Alexis');
INSERT INTO Students VALUES (1316, 'Austin');
INSERT INTO Students VALUES (1381, 'Tiffany');
INSERT INTO Students VALUES (1468, 'Kris');
INSERT INTO Students VALUES (1510, 'Jordan');
INSERT INTO Students VALUES (1641, 'Brittany');
INSERT INTO Students VALUES (1689, 'Gabriel');
INSERT INTO Students VALUES (1709, 'Cassandra');
INSERT INTO Students VALUES (1782, 'Andrew');
INSERT INTO Students VALUES (1911, 'Gabriel');
GO

-- ######################################
-- Inserting data into instructors
INSERT INTO Instructors VALUES(201, 'Julie Zelenski');
INSERT INTO Instructors VALUES(202, 'Dan Jurafsky');
INSERT INTO Instructors VALUES(203, 'Jennifer Widom');
INSERT INTO Instructors VALUES(204, 'Mehran Sahami');
INSERT INTO Instructors VALUES(205, 'Alex S. Aiken');
INSERT INTO Instructors VALUES(206, 'Andrew Ng');
INSERT INTO Instructors VALUES(207, 'Eric Roberts');
INSERT INTO Instructors VALUES(208, 'Jerry R. Cain');
GO

-- ######################################
-- Inserting data into Courses
INSERT INTO Courses VALUES(1070, 'CS106A', 'Programming Methodology', 208);
INSERT INTO Courses VALUES(620, 'CS106B', 'Programming Abstractions', 207);
INSERT INTO Courses VALUES(500, 'CS107', 'Computer Organization and Systems', 201);
INSERT INTO Courses VALUES(280, 'CS109', 'Introduction to Probability for Computer Scientists', 204);
INSERT INTO Courses VALUES(60, 'CS124', 'From Languages to Information', 202);
INSERT INTO Courses VALUES(90, 'CS143', 'Compilers', 205);
INSERT INTO Courses VALUES(103, 'CS145', 'Introduction to Databases', 203);
INSERT INTO Courses VALUES(180, 'CS221', 'Artificial Intelligence: Principles and Techniques', 206);
GO

-- ######################################
-- Inserting data into Enrollments
INSERT INTO Enrollments VALUES(60, 1316);
INSERT INTO Enrollments VALUES(60, 1381);
INSERT INTO Enrollments VALUES(90, 1101);
INSERT INTO Enrollments VALUES(90, 1247);
INSERT INTO Enrollments VALUES(90, 1709);
INSERT INTO Enrollments VALUES(103, 1316);
INSERT INTO Enrollments VALUES(103, 1468);
INSERT INTO Enrollments VALUES(103, 1641);
INSERT INTO Enrollments VALUES(103, 1911);
INSERT INTO Enrollments VALUES(180, 1101);
INSERT INTO Enrollments VALUES(180, 1468);
INSERT INTO Enrollments VALUES(180, 1510);
INSERT INTO Enrollments VALUES(180, 1689);
INSERT INTO Enrollments VALUES(180, 1782);
INSERT INTO Enrollments VALUES(280, 1247);
INSERT INTO Enrollments VALUES(280, 1911);
INSERT INTO Enrollments VALUES(500, 1468);
INSERT INTO Enrollments VALUES(500, 1689);
INSERT INTO Enrollments VALUES(620, 1510);
INSERT INTO Enrollments VALUES(620, 1911);
INSERT INTO Enrollments VALUES(1070, 1101);
INSERT INTO Enrollments VALUES(1070, 1510);
INSERT INTO Enrollments VALUES(1070, 1709);
GO

-- ######################################
-- return all students name with there ids
CREATE PROCEDURE Students_getAll
AS
	BEGIN
		SELECT *
		FROM Students
		ORDER BY stdID;
	END
GO

-- ######################################
-- return a specific student using the student id
CREATE PROCEDURE Students_getByID (@stdID INT)
AS
	BEGIN
		SELECT *
		FROM Students 
		Where stdID = @stdID;
	END
GO

-- ######################################
-- return students from a specific course given the course id
CREATE PROCEDURE Students_getByCourse (@CourseID INT)
AS
	BEGIN
		SELECT s.stdID, stdName
		FROM Students AS s
		JOIN Enrollments AS e
			ON s.stdID = e.stdID
		Where e.CourseID = @CourseID
		ORDER BY s.stdID;
	END
GO

-- ######################################
-- return students in courses by a specifc instructor given the instructor id
CREATE PROCEDURE Students_getByInstructor (@InstID INT)
AS
	BEGIN
		SELECT s.stdID, stdName
		FROM Students AS s
		JOIN Enrollments AS e
			ON s.stdID = e.stdID
		JOIN Courses AS c
			ON e.CourseID = c.CourseID
		Where c.InstID = @InstID
		ORDER BY s.stdID, c.CourseID;
	END
GO

-- ######################################
-- add data to Students
CREATE PROCEDURE Students_addStudent (@stdID INT, @stdName NVARCHAR(20))
AS
	BEGIN
		INSERT INTO Students VALUES (@stdID, @stdName);
	END
GO

-- ######################################
-- delete data from students
CREATE PROCEDURE Students_removeByID (@stdID INT)
AS
	BEGIN
		DELETE FROM Students
		WHERE stdID = @stdID;
	END
GO

-- ######################################
-- get all courses information
CREATE PROCEDURE Courses_getAll
AS
	BEGIN
		SELECT *
		FROM Courses 
		ORDER BY CourseID;
	END
GO

-- ######################################
-- get a course information by its id
CREATE PROCEDURE Courses_getByID (@CourseID INT)
AS
	BEGIN
		SELECT *
		FROM  Courses
		Where CourseID = @CourseID;
	END
GO

-- ######################################
-- get courses for a specific instructor
CREATE PROCEDURE Courses_getByIntructor	(@InstID INT)
AS
	BEGIN
		SELECT *
		FROM Courses 
		Where InstID = @InstID
		ORDER BY CourseID;
	END
GO

-- ######################################
-- get courses for a specific student
CREATE Procedure Courses_getByStudent (@stdID INT)
AS
	BEGIN
		SELECT c.CourseID, CourseName, CourseDesc, InstID
		FROM Courses AS c
		JOIN Enrollments AS e
			ON e.CourseID = c.CourseID
		WHERE e.stdID = @stdID
		ORDER BY CourseID;
	END
GO

-- ######################################
--Add Courses
CREATE PROCEDURE Courses_addCourse (@CourseID INT, @CourseName NVARCHAR(20), @CourseDesc NVARCHAR(200), @InstID INT)
AS
	BEGIN
		INSERT INTO Courses VALUES(@CourseID, @CourseName, @CourseDesc, @InstID);
	END
GO

-- ######################################
-- remove course by id
CREATE PROCEDURE Courses_removeByCourseID (@CourseID INT)
AS
	BEGIN
		DELETE FROM Courses
		WHERE CourseID = @CourseID;
	END
GO

-- ######################################
-- remove course by id
CREATE PROCEDURE Courses_removeByInstructorID (@InstID INT)
AS
	BEGIN
		DELETE FROM Courses
		WHERE InstID = @InstID;
	END
GO

-- ######################################
-- get all Instructors
CREATE PROCEDURE Instructors_getAll
AS
	BEGIN
		SELECT * 
		FROM Instructors 
		ORDER BY instID;
	END
GO

-- ######################################
-- get specific instructor by id
CREATE PROCEDURE Instructors_getByID (@InstID INT)
AS
	BEGIN
		SELECT *
		FROM Instructors
		WHERE InstID = @InstID;
	END
GO

-- ######################################
-- get all instructors teaching a specific course givin the course id
CREATE PROCEDURE Instructors_getByCourse (@CourseID INT)
AS
	BEGIN
		SELECT i.InstID, InstName
		FROM Instructors AS i
		JOIN Courses AS c
			ON i.InstID = c.InstID
		WHERE CourseID = @CourseID
		ORDER BY i.InstID;
	END
GO

-- ######################################
-- get all instructors for a specific student
CREATE PROCEDURE Instructors_getByStudent (@stdID INT)
AS
	BEGIN
		SELECT i.InstID, InstName
		FROM Instructors AS i
		JOIN Courses AS c
			ON i.InstID = c.InstID
		JOIN Enrollments AS e
			ON c.CourseID = e.CourseID
		WHERE e.stdID = @stdID
		ORDER BY i.InstID;
	END
GO

-- ######################################
-- add instructor
CREATE PROCEDURE Instrucors_addInstructor (@InstID INT, @InstName NVARCHAR(20))
AS
	BEGIN
		INSERT INTO Instructors VALUES (@instID, @InstName);
	END
GO

-- ######################################
-- remove instructor by id
CREATE PROCEDURE Instructors_removeByID (@InstID INT)
AS
	BEGIN
		DELETE FROM Instructors
		WHERE InstID = @InstID;
	END
GO

-- ######################################
-- get all enrollments
CREATE PROCEDURE Enrollments_GetAll 
AS
	BEGIN
		SELECT * FROM Enrollments
	END
GO

-- ######################################
-- get enrollments by student id
CREATE PROCEDURE Enrollments_GetByStudent (@stdID INT)
AS
	BEGIN
		SELECT * FROM Enrollments WHERE stdID = @stdID
	END
GO

-- ######################################
-- get enrollments by course id
CREATE PROCEDURE Enrollments_GetByCourse (@CourseID INT)
AS
	BEGIN
		SELECT * FROM Enrollments WHERE CourseID = @CourseID
	END
GO

-- ######################################
-- get enrollments by course id
CREATE PROCEDURE Enrollments_GetByInstructor (@InstID INT)
AS
	BEGIN
		SELECT e.CourseID, e.stdID 
		FROM Enrollments AS e
		JOIN Courses AS c
		ON e.CourseID = c.CourseID
		WHERE InstID = @InstID
	END
GO

-- ######################################
-- get enrollments by course id	and student id
CREATE PROCEDURE Enrollments_GetByCourseAndStudent (@stdID INT, @CourseID INT)
AS
	BEGIN
		SELECT * FROM Enrollments WHERE CourseID = @CourseID AND stdID = @stdID
	END
GO

-- ######################################
-- add enrollments
CREATE PROCEDURE Enrollments_addEnrollment (@CourseID INT, @stdID INT)
AS
	BEGIN
		INSERT INTO Enrollments VALUES (@CourseID, @stdID);
	END
GO

-- ######################################
-- remove enrollments by student
CREATE PROCEDURE Enrollments_removeByStudentID (@stdID INT)
AS
	BEGIN
		DELETE FROM Enrollments
		WHERE stdID = @stdID;
	END
GO

-- ######################################
-- remove enrollments by course
CREATE PROCEDURE Enrollments_removeByCourseID (@CourseID INT)
AS
	BEGIN
		DELETE FROM Enrollments
		WHERE CourseID = @CourseID;
	END
GO

-- ######################################
-- remove enrollments by student and course
CREATE PROCEDURE Enrollments_removeByCourseAndStudent (@CourseID INT, @stdID INT)
AS
	BEGIN
		DELETE FROM Enrollments
		WHERE stdID = @stdID AND CourseID = @CourseID;
	END
GO