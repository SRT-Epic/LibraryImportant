CREATE TABLE users (
    user_id INT PRIMARY KEY IDENTITY(1,1), 
    username VARCHAR(50) NOT NULL UNIQUE,   
    email VARCHAR(100) NOT NULL UNIQUE,  
    password VARCHAR(255) NOT NULL,       
    created_at DATETIME DEFAULT GETDATE() 
);
