SELECT d.name AS Department, e.name AS Employee, e.salary AS Salary
FROM Employee e
INNER JOIN Department d ON e.departmentId = d.id
WHERE 3 > (SELECT COUNT(DISTINCT e2.salary)
            FROM Employee e2
            WHERE e2.salary > e.salary AND e2.departmentId = e.departmentId)

-- Leetcode solutions
-- https://leetcode.com/problems/department-top-three-salaries/solutions/797620/three-solutions-window-function-subquery-and-join/?orderBy=hot

SELECT D.Name as Department, E.Name as Employee, E.Salary 
FROM Department D, Employee E, Employee E2  
WHERE D.ID = E.DepartmentId and E.DepartmentId = E2.DepartmentId and 
E.Salary <= E2.Salary
group by D.ID,E.Name having count(distinct E2.Salary) <= 3
order by D.Name, E.Salary desc

SELECT res.Department, res.Employee, res.Salary FROM
(
    SELECT d.Name AS Department, e.Name AS Employee, e.Salary,
           DENSE_Rank() OVER (PARTITION BY d.Name ORDER BY e.Salary DESC) AS Ranking
    FROM Employee e JOIN Department d ON e.DepartmentId = d.ID
) res WHERE Ranking <= 3;