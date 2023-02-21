SELECT
max(M.Surname),
sum(S.Cnt*P.Price)
FROM
Managers M 
Join Sales S On M.id = S.ManagerId
Join Products P ON S.ProductId = P.Id
WHERE CAST(S.Moment AS DATE) = CAST(CURRENT_TIMESTAMP AS DATE)
GROUP BY 
M.Id
ORDER BY
2 DESC