SELECT Date,
	AVG(SUM(Food_History_table.Calories)) OVER(ORDER BY Date
		ROWS BETWEEN 7 PRECEDING AND CURRENT ROW)
		AS Week_Average,
		ROUND(SUM(Food_History_table.Calories) ,2) AS Calories
FROM Food_History_Table
GROUP BY Food_History_table.Date
ORDER BY Food_History_table.Date DESC
