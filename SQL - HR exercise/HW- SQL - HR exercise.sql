--Q1
SELECT employees.first_name, employees.last_name, employees.department_id, departments.department_name
FROM [employees]
RIGHT JOIN [departments]
ON employees.department_id = departments.department_id

--Q2
SELECT 
employees.first_name, employees.last_name, 
departments.department_name, 
locations.city, locations.state_province
FROM [employees]
JOIN [departments]
ON employees.department_id = departments.department_id
JOIN [locations]
ON departments.location_id = locations.location_id

--Q3
SELECT e.first_name, e.last_name, j.grade_level
FROM [employees] e
JOIN [job_grades] j
ON e.salary BETWEEN j.lowest_sal AND j.highest_sal

--Q4
SELECT e.first_name, e.last_name, e.department_id, d.department_name 
FROM [employees] e 
JOIN [departments] d 
ON e.department_id = e.department_id AND e.department_id IN (80, 40) 
ORDER BY e.last_name

--Q5
SELECT e.first_name, e.last_name, d.department_name, l.city, l.state_province 
FROM [employees] e 
JOIN [departments] d
ON e.department_id = d.department_id 
JOIN [locations] l 
ON d.location_id = l.location_id 
WHERE e.first_name LIKE '%z%'

--Q6
SELECT e.first_name, e.last_name, d.department_id, d.department_name 
FROM [employees] e 
RIGHT JOIN [departments] d 
ON e.department_id = d.department_id

--Q7
SELECT e1.first_name, e1.last_name, e1.salary 
FROM [employees] e1 
JOIN [employees] e2 
ON e1.salary < e2.salary AND e2.employee_id = 182

--Q8
SELECT e.first_name AS "Employee", m.first_name AS "Manager" 
FROM [employees] e 
JOIN [employees] m ON e.manager_id = m.employee_id

--Q9
SELECT d.department_name, l.city, l.state_province 
FROM  [departments] d 
JOIN [locations] l 
ON  d.location_id = l.location_id

--Q10
SELECT e.first_name, e.last_name, e.department_id, d.department_name 
FROM [employees] e 
LEFT JOIN [departments] d 
ON e.department_id = d.department_id

--Q11
SELECT e.first_name AS "Employee", m.first_name AS "Manager" 
FROM [employees] e 
LEFT JOIN [employees] m 
ON e.manager_id = m.employee_id

--Q12
SELECT e1.first_name, e1.last_name , e1.department_id 
FROM [employees] e1 
JOIN [employees] e2 
ON e1.department_id = e2.department_id AND e2.last_name = 'Taylor'


--Q13
SELECT j.job_title, d.department_name, e.first_name + ' ' + e.last_name AS employees, jh.start_date, jh.end_date
FROM [employees] e
INNER JOIN [departments] d ON d.department_id = e.department_id
INNER JOIN [jobs] j ON j.job_id = e.job_id 
INNER JOIN [job_history] jh ON jh.employee_id = e.employee_id
WHERE jh.start_date = '1993-01-01' 
AND jh.end_date BETWEEN '1993-01-01' AND '1997-08-31'

--Q14
SELECT j.job_title, e.first_name + ' ' + e.last_name AS employees ,e.salary, j.max_salary ,j.max_salary - e.salary AS salary_difference
FROM [employees] e
INNER JOIN [jobs] j ON j.job_id = e.job_id

--Q15
DECLARE @AVG_SALARY TABLE (department_id INT NOT NULL, average_salary DECIMAL(18,2)  NULL)
INSERT INTO @AVG_SALARY
SELECT e.department_id, AVG(e.salary) AS average_salary
FROM [employees] e
GROUP BY e.department_id

DECLARE @COUNT_COMMISION TABLE (department_id INT NOT NULL, num_of_employees_with_commision INT  NULL)
INSERT INTO @COUNT_COMMISION
SELECT e.department_id, COUNT(e.employee_id) AS number_of_employees_with_commision
FROM [employees] e
WHERE e.commission_pct > 0
GROUP BY e.department_id

SELECT d.department_name, AVG_SALARY.average_salary, ISNULL (COUNT_COMMISION.num_of_employees_with_commision,0) AS number_of_employees_with_commision
FROM [departments] d
INNER JOIN @AVG_SALARY AS AVG_SALARY ON AVG_SALARY.department_id = d.department_id
LEFT JOIN  @COUNT_COMMISION AS COUNT_COMMISION ON COUNT_COMMISION.department_id = d.department_id
ORDER BY average_salary DESC

--Q16
SELECT j.job_title, e.first_name + ' ' + e.last_name AS employees, j.max_salary - e.salary AS salary_difference
FROM [employees] e
INNER JOIN [jobs] j ON j.job_id = e.job_id
WHERE e.department_id  = 80

--Q17
SELECT c.country_name, l.city, d.department_name
FROM [countries] c
INNER JOIN [locations] l ON l.country_id = c.country_id
INNER JOIN [departments] d ON d.location_id = l.location_id


--Q18
SELECT department_name, first_name + ' ' + last_name AS name_of_manager 
FROM [departments] d 
JOIN [employees] e 
ON (D.manager_id=E.employee_id)

--Q19
SELECT j.job_title, CAST(AVG(e.salary) AS DECIMAL(18, 2)) AS avg_salary
FROM [employees] e
INNER JOIN [jobs] j ON j.job_id = e.job_id
GROUP BY j.job_title

--Q20
SELECT a.* 
FROM  [job_history] a 
JOIN [employees] m 
ON (a.employee_id = m.employee_id) 
WHERE salary >= 12000

/*
--Q21
SELECT country_name,city, COUNT(department_id)
	FROM countries 
		JOIN locations USING (country_id) 
		JOIN departments USING (location_id) 
WHERE department_id IN 
    (SELECT department_id 
		FROM employees 
	 GROUP BY department_id 
	 HAVING COUNT(department_id)>=2)
GROUP BY country_name,city;


--Q22
SELECT department_name, first_name + ' ' |+ last_name AS name_of_manager, city 
FROM [departments] d 
JOIN [employees] e 
ON (D.manager_id=E.employee_id) 
JOIN locations l USING (location_id)


--Q23
SELECT employee_id, job_title, end_date-start_date DAYS 
FROM job_history 
NATURAL JOIN jobs 
WHERE department_id=80

--Q24
SELECT first_name + ' ' + last_name AS Employee_name, salary
FROM [employees] 
JOIN departments USING (department_id) 
JOIN  locations USING (location_id) 
WHERE  city = 'London'

--Q25
SELECT CONCAT(e.first_name, ' ', e.last_name) AS Employee_name, j.job_title, h.*
FROM [employees] e
JOIN (SELECT MAX(start_date), MAX(end_date), employee_id
FROM [job_history]
GROUP BY employee_id) h 
ON e.employee_id=h.employee_id
JOIN jobs j ON j.job_id=e.job_id
WHERE e.commission_pct = 0

--Q26
SELECT d.department_name, e.*
FROM [departments] d
JOIN (SELECT count(employee_id), department_id
FROM [employees]
GROUP BY department_id) e USING (department_id)

--Q27
SELECT first_name + ' ' + last_name 
AS Employee_name, employee_id, country_name 
FROM [employees]
JOIN [departments] 
USING(department_id) 
JOIN [locations] 
USING(location_id) 
JOIN [countries] 
USING ( country_id)
*/