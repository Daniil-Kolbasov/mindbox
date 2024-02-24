SELECT p.Name, g.Name
FROM Product AS p
LEFT JOIN Category AS g ON g.Id = p.CategoryId;
