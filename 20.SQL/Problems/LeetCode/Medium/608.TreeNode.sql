-- https://leetcode.com/problems/tree-node/

SELECT id, 'Root' AS type 
FROM Tree 
WHERE p_id IS NULL

UNION
SELECT id, 'Inner' as type
FROM Tree t
WHERE EXISTS(select 1 
            FROM Tree
            WHERE p_id = t.id) AND p_id IS NOT NULL

UNION
SELECT id, 'Leaf' as type
FROM Tree t
WHERE NOT EXISTS(select 1 
            FROM Tree
            WHERE p_id = t.id) AND p_id IS NOT NULL