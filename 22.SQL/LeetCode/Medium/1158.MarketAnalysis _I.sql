-- https://leetcode.com/problems/market-analysis-i/submissions/

SELECT u.user_id AS buyer_id, u.join_date, COUNT(DISTINCT o.order_id) AS orders_in_2019
FROM Users u
LEFT JOIN Orders o ON u.user_id = o.buyer_id AND YEAR(o.order_date) = 2019
GROUP BY 1

SELECT USER_ID AS buyer_id, join_date,
    (SELECT COUNT(order_id) FROM ORDERS O WHERE O.BUYER_ID = U.USER_ID AND 
YEAR(ORDER_DATE) = '2019' ) AS orders_in_2019
FROM USERS U


