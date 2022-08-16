--Q1
SELECT Courses.CourseName, Lecturers.FirstName, Lecturers.LastName 
FROM [Courses]
LEFT JOIN [Lecturers] on Courses.LecturerId = Lecturers.Id
ORDER BY Courses.Id ASC , Lecturers.LastName ASC

--Q2
SELECT Courses.CourseName, Lecturers.FirstName, Lecturers.LastName 
FROM [Courses]
INNER JOIN [Lecturers] on Courses.LecturerId = Lecturers.Id
WHERE Courses.LecturerId IS NOT NULL
ORDER BY Courses.Id ASC , Lecturers.LastName ASC

--Q3
SELECT Lecturers.FirstName, Lecturers.LastName, Courses.CourseName 
FROM [Lecturers]
LEFT JOIN [Courses] on Lecturers.Id = Courses.LecturerId

--Q4
SELECT (CourseName) FROM [Courses]
WHERE LecturerId IS NULL

--Q5
SELECT Lecturers.FirstName, Lecturers.LastName, Courses.CourseName 
FROM [Lecturers]
LEFT JOIN [Courses] on Lecturers.Id = Courses.LecturerId
WHERE CourseName IS NULL

--Q6
SELECT * FROM [Courses]
FULL JOIN [Lecturers]
ON Courses.LecturerId = Lecturers.Id