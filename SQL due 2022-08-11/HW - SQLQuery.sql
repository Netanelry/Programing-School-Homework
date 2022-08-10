USE [HackerUs]

-- Q1
SELECT * FROM [Students]

-- Q2
SELECT FirstName, LastName FROM [Students]

--Q3
SELECT DISTINCT FirstName FROM [Students]

--Q4
SELECT FirstName, LastName FROM [Students]
WHERE Age < 80

--Q5
SELECT * FROM [Students]
WHERE Id = 1

--Q6
SELECT * FROM [Students]
WHERE FirstName = 'Ami' and LastName = 'Sason'

--Q7
SELECT * FROM [Students]
WHERE FirstName in ('Ami' , 'Yael') and Age > 20

--Q8
SELECT * FROM [Students]
WHERE Age  is NULL

--Q9
SELECT * FROM [Students]
WHERE Age  is NOT NULL

--Q10
SELECT FirstName FROM [Students]
ORDER BY FirstName ASC

--Q11
SELECT * FROM [Students]
ORDER BY Age DESC

--Q12
SELECT TOP 2 * FROM [Students]
ORDER BY Age DESC

--Q13
SELECT * FROM [Students]
WHERE FirstName LIKE 'A%' and Age > 20

--Q14
INSERT INTO [Courses] (CourseName)
SELECT 'Gaming'
WHERE NOT EXISTS (
SELECT (CourseName) FROM [Courses] WHERE CourseName = 'Gaming') 
SELECT * FROM [Courses]

--Q15
UPDATE [Students]
SET Age = 70
WHERE Age > 80