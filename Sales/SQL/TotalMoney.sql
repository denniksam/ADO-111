SELECT 
	ROUND( SUM( S.Cnt * P.Price ), 2 ) AS TotalMoney
FROM 
	Sales S 
	JOIN Products P ON S.Id_product = P.Id
WHERE 
	CAST( S.Moment AS DATE ) = '2022-01-19'