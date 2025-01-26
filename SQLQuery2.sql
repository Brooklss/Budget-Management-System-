CREATE TABLE categories(
id INT PRIMARY KEY IDENTITY(1,1),
category VARCHAR(MAX) NULL,
type VARCHAR(MAX) NULL,
status VARCHAR(MAX) NULL,
date_inserted Date NULL
)
select * from categories
INSERT INTO categories (category, type, status, date_inserted)
VALUES ('Scholarship', 'Income', 'Active', GETDATE());
DELETE FROM categories
WHERE id = 3;