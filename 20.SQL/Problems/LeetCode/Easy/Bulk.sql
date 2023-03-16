-- 1757. Recyclable and Low Fat Products
-- https://leetcode.com/problems/recyclable-and-low-fat-products/

SELECT product_id
FROM Products
WHERE low_fats = 'Y' AND recyclable = 'Y'

-- 1741. Find Total Time Spent by Each Employee
-- https://leetcode.com/problems/find-total-time-spent-by-each-employee/

SELECT event_day AS day, emp_id, sum(out_time - in_time) AS total_time
FROM Employees
GROUP BY event_day, emp_id

-- 1693. Daily Leads and Partners
-- https://leetcode.com/problems/daily-leads-and-partners/

SELECT date_id, make_name, COUNT(DISTINCT lead_id) AS unique_leads,COUNT(DISTINCT partner_id) AS unique_partners 
FROM DailySales
GROUP BY date_id, make_name 

-- 1741. Find Total Time Spent by Each Employee
-- https://leetcode.com/problems/find-total-time-spent-by-each-employee/

SELECT event_day AS day, emp_id, sum(out_time - in_time) AS total_time
FROM Employees
GROUP BY event_day, emp_id

-- 1795. Rearrange Products Table
-- https://leetcode.com/problems/rearrange-products-table/

SELECT product_id, 'store1' as store, store1 as price 
FROM Products
WHERE store1 IS NOT NULL

UNION
SELECT product_id, 'store2' as store, store2 as price
FROM Products
WHERE store2 IS NOT NULL

UNION
SELECT product_id, 'store3' as store, store3 as price
FROM Products
WHERE store3 IS NOT NULL

-- 1587. Bank Account Summary II
-- https://leetcode.com/problems/bank-account-summary-ii/

SELECT name, SUM(amount) as balance
FROM Users u
INNER JOIN Transactions t ON u.account =  t.account
GROUP BY t.account
HAVING SUM(amount) > 10000

-- 511. Game Play Analysis I
-- https://leetcode.com/problems/game-play-analysis-i/

SELECT player_id, MIN(event_date) as first_login 
FROM Activity
GROUP BY player_id

-- 586. Customer Placing the Largest Number of Orders
-- https://leetcode.com/problems/customer-placing-the-largest-number-of-orders/

SELECT TOP 1 customer_number
FROM Orders
GROUP BY customer_number
ORDER BY COUNT(customer_number) DESC

-- 1484. Group Sold Products By The Date
-- https://leetcode.com/problems/group-sold-products-by-the-date/

-- MySQL
SELECT sell_date, COUNT(DISTINCT product) as num_sold,
        GROUP_CONCAT(DISTINCT product) as products
FROM Activities
GROUP BY sell_date

-- SQL
WITH dist AS (
  SELECT DISTINCT * FROM Activities
)

SELECT sell_date, COUNT(DISTINCT product) as num_sold,
        STRING_AGG(product, ',') WITHIN GROUP (ORDER BY product ASC) AS products 
FROM dist
GROUP BY sell_date
ORDER BY 1 ASC

-- 584. Find Customer Referee
-- https://leetcode.com/problems/find-customer-referee/

SELECT name
FROM Customer
WHERE referee_id <> 2 or referee_id is null

-- 1050. Actors and Directors Who Cooperated At Least Three Times
-- https://leetcode.com/problems/actors-and-directors-who-cooperated-at-least-three-times/

SELECT actor_id, director_id 
FROM ActorDirector 
GROUP BY actor_id, director_id
HAVING COUNT(*) >= 3

-- 182. Duplicate Emails
-- https://leetcode.com/problems/duplicate-emails/

SELECT email AS "Email"
FROM Person
GROUP BY email
HAVING COUNT(*) > 1

-- 1729. Find Followers Count
-- https://leetcode.com/problems/find-followers-count/

SELECT user_id, COUNT(follower_id) AS "followers_count"
FROM Followers
GROUP BY user_id
ORDER BY user_id

-- 595. Big Countries
-- https://leetcode.com/problems/big-countries/

SELECT name, population, area
FROM World
WHERE area >= 3000000 OR population >= 25000000

-- 595. Big Countries
-- https://leetcode.com/problems/big-countries/

SELECT name, population, area
FROM World
WHERE area >= 3000000 OR population >= 25000000

-- 1084. Sales Analysis III
-- https://leetcode.com/problems/sales-analysis-iii/

SELECT DISTINCT p.product_id, p.product_name
FROM Product p
LEFT JOIN Sales s ON p.product_id = s.product_id
WHERE sale_date BETWEEN '2019-01-01' AND '2019-03-31' 
        AND p.product_id NOT IN (SELECT DISTINCT s1.product_id
                                FROM Sales s1
                                WHERE s1.sale_date NOT BETWEEN '2019-01-01' AND '2019-03-31')

-- 1148. Article Views I
-- https://leetcode.com/problems/article-views-i/

SELECT DISTINCT author_id AS id 
FROM Views
WHERE author_id = viewer_id 
ORDER BY author_id

-- 1965. Employees With Missing Information
-- https://leetcode.com/problems/employees-with-missing-information/

SELECT employee_id 
FROM Employees
WHERE employee_id NOT IN (SELECT employee_id
                            FROM Salaries)
UNION
SELECT employee_id 
FROM Salaries
WHERE employee_id NOT IN (SELECT employee_id
                            FROM Employees)
ORDER BY employee_id 

-- 175. Combine Two Tables
-- https://leetcode.com/problems/combine-two-tables/

SELECT p.firstName, p.lastName, a.city, a.state
FROM Person p
LEFT JOIN Address a ON p.personId = a.personId

-- 620. Not Boring Movies
-- https://leetcode.com/problems/not-boring-movies/

SELECT *
FROM Cinema
WHERE (id % 2) <> 0 and description <> 'boring'
order by rating desc

-- 596. Classes More Than 5 Students
-- https://leetcode.com/problems/classes-more-than-5-students/

SELECT class
FROM Courses
GROUP BY class
HAVING COUNT(*) >= 5

-- 1407. Top Travellers
-- https://leetcode.com/problems/top-travellers/

SELECT u.name, COALESCE(SUM(r.distance), 0) as travelled_distance 
FROM Users u
LEFT JOIN Rides r ON u.id = r.user_id
GROUP BY u.id, u.name
ORDER BY SUM(r.distance) DESC

-- 183. Customers Who Never Order
-- https://leetcode.com/problems/customers-who-never-order/

SELECT name as Customers
FROM Customers c
WHERE id NOT IN (SELECT customerId
                FROM Orders)

-- 1407. Top Travellers
-- https://leetcode.com/problems/top-travellers/

SELECT u.name, COALESCE(SUM(r.distance), 0) as travelled_distance 
FROM Users u
LEFT JOIN Rides r ON u.id = r.user_id
GROUP BY u.id, u.name
ORDER BY SUM(r.distance) DESC

-- 1890. The Latest Login in 2020
-- https://leetcode.com/problems/the-latest-login-in-2020/

SELECT user_id, MAX(time_stamp) AS last_stamp
FROM Logins
WHERE YEAR(time_stamp) = 2020
GROUP BY user_id

-- 1890. The Latest Login in 2020
-- https://leetcode.com/problems/the-latest-login-in-2020/

SELECT user_id, MAX(time_stamp) AS last_stamp
FROM Logins
WHERE YEAR(time_stamp) = 2020
GROUP BY user_id

-- 1581. Customer Who Visited but Did Not Make Any Transactions
-- https://leetcode.com/problems/customer-who-visited-but-did-not-make-any-transactions/

SELECT v.customer_id, COUNT(v.visit_id) AS count_no_trans 
FROM Visits v
LEFT JOIN Transactions t ON v.visit_id = t.visit_id
WHERE amount IS NULL
GROUP BY v.customer_id 

-- 627. Swap Salary
-- https://leetcode.com/problems/swap-salary/

UPDATE Salary 
SET sex =
CASE
    WHEN sex = 'm' THEN 'f'
    WHEN sex = 'f' THEN 'm'
END

-- 1873. Calculate Special Bonus
-- https://leetcode.com/problems/calculate-special-bonus/

 (SELECT employee_id, salary AS bonus
 FROM Employees 
 WHERE name NOT LIKE 'M%' AND mod(employee_id, 2) != 0

 UNION
 SELECT employee_id, 0 AS bonus
 FROM Employees
 WHERE name LIKE 'M%' OR mod(employee_id,2) = 0)
 ORDER BY employee_id

-- 1179. Reformat Department Table
-- https://leetcode.com/problems/reformat-department-table/

 SELECT id,
    SUM(IF (month = 'Jan', revenue, NULL)) AS Jan_Revenue,
    SUM(IF (month = "Feb", revenue, null)) AS Feb_Revenue,
    SUM(IF (month = "Mar", revenue, null)) AS Mar_Revenue,
    SUM(IF (month = "Apr", revenue, null)) AS Apr_Revenue,
    SUM(IF (month = "May", revenue, null)) AS May_Revenue,
    SUM(IF (month = "Jun", revenue, null)) AS Jun_Revenue,
    SUM(IF (month = "Jul", revenue, null)) AS Jul_Revenue,
    SUM(IF (month = "Aug", revenue, null)) AS Aug_Revenue,
    SUM(IF (month = "Sep", revenue, null)) AS Sep_Revenue,
    SUM(IF (month = "Oct", revenue, null)) AS Oct_Revenue,
    SUM(IF (month = "Nov", revenue, null)) AS Nov_Revenue,
    SUM(IF (month = "Dec", revenue, null)) AS Dec_Revenue
FROM Department
GROUP BY id;

-- 586. Customer Placing the Largest Number of Orders
-- https://leetcode.com/problems/customer-placing-the-largest-number-of-orders/

SELECT TOP 1 customer_number
FROM Orders
GROUP BY customer_number
ORDER BY COUNT(customer_number) DESC

-- 181. Employees Earning More Than Their Managers
-- https://leetcode.com/problems/employees-earning-more-than-their-managers/

SELECT name AS Employee
FROM Employee e
WHERE salary > (SELECT salary
        FROM Employee
        WHERE id = e.managerId)

-- 1667. Fix Names in a Table
-- https://leetcode.com/problems/fix-names-in-a-table/

SELECT user_id, CONCAT(UPPER(SUBSTR(name,0, 1)),LOWER(SUBSTR(name,2))) AS name
FROM Users
ORDER BY user_id

 -- 1141. User Activity for the Past 30 Days I
 -- https://leetcode.com/problems/user-activity-for-the-past-30-days-i/

SELECT activity_date AS day, COUNT(DISTINCT user_id) AS active_users
FROM Activity
GROUP BY activity_date
HAVING activity_date BETWEEN '2019-06-28' AND '2019-07-27'

-- 197. Rising Temperature
-- https://leetcode.com/problems/rising-temperature/

SELECT w1.id
FROM Weather w1
JOIN Weather w2 ON w2.recordDate = w1.recordDate - 1
WHERE w1.temperature > w2.temperature

-- 1527. Patients With a Condition
-- https://leetcode.com/problems/patients-with-a-condition/

SELECT *
FROM Patients
WHERE conditions LIKE '% DIAB1%' OR conditions LIKE 'DIAB1%'

-- 196. Delete Duplicate Emails
-- https://leetcode.com/problems/delete-duplicate-emails/submissions/913673557/
-- No ORACLE

 WITH CTE AS(
     SELECT id, email, 
         ROW_NUMBER() OVER(PARTITION BY email ORDER BY id ASC) AS row_num
     FROM Person
 )

 DELETE
 FROM Person
 WHERE id IN (
     SELECT id
     FROM CTE
     WHERE row_num > 1
 )

 