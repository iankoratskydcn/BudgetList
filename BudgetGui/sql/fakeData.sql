 INSERT INTO _user (userId, fName, lName, username, _password, email, DOB, street, city, state, zip, age)
VALUES
    (1, 'Joshua', 'Bernard', 'jbernard2024', 'Josh1234!', 'joshua@gmail.com', '2002-04-28', '4202 E. Fowler Avenue', 'Tampa', 'Florida', 33620, 21),
    (2, 'John', 'Doe', 'johndoe', 'Password1!', 'john@gmail.com', '1990-01-01', '123 Main Street','New York', 'New York', 10001, 32),
    (3, 'Jane', 'Smith', 'janesmith', 'Password2!', 'jane@gmail.com', '1985-05-15', '456 Broadway', 'Los Angeles', 'California', 90001, 37),
    (4, 'Alice', 'Johnson', 'alicejohnson', 'Password3!', 'alice@gmail.com', '1982-11-20', '789 Oak Avenue', 'Chicago', 'Illinois', 60601, 40),
    (5, 'Bob', 'Brown', 'bobbrown', 'Password4!', 'bob@gmail.com', '1978-07-10', '1011 Cedar Street', 'Houston', 'Texas', 77002, 44),
    (6, 'Emily', 'Taylor', 'emilytaylor', 'Password5!', 'emily@gmail.com', '1995-03-25', '1213 Elm Road', 'Miami', 'Florida', 33101, 29),
    (7, 'Daniel', 'Lujo', 'DLujo', 'Daniel1234!', 'daniel@gmail.com', '2002-01-05', '1213 E. Fowler Avenue', 'Tampa', 'Forida', 33620, 50),
    (8, 'Tommy', 'Wazoo', 'TWazoo', 'Twz1234!', 'tommy@gmail.com', '2002-01-09', '1213 E. Fowler Avenue', 'Tampa', 'Forida', 33620, 88);

INSERT INTO _message(sender,timeDate,recipient,text1)
VALUES
    (1, 'Joshua', 'Bernard', 'jbernard2024', 'Josh1234!', 'joshua@gmail.com', '2002-04-28', 4202, 'E. Fowler Avenue', 'Tampa', 'Florida', 33620, 21, 'http://example.com/joshua.jpg'),
    (2, 'John', 'Doe', 'johndoe', 'Password1!', 'john@gmail.com', '1990-01-01', 123, 'Main Street','New York', 'New York', 10001, 32, 'http://example.com/john.jpg'),
    (3, 'Jane', 'Smith', 'janesmith', 'Password2!', 'jane@gmail.com', '1985-05-15', 456, 'Broadway', 'Los Angeles', 'California', 90001, 37, 'http://example.com/jane.jpg'),
    (4, 'Alice', 'Johnson', 'alicejohnson', 'Password3!', 'alice@gmail.com', '1982-11-20', 789, 'Oak Avenue', 'Chicago', 'Illinois', 60601, 40, 'http://example.com/alice.jpg'),
    (5, 'Bob', 'Brown', 'bobbrown', 'Password4!', 'bob@gmail.com', '1978-07-10', 1011, 'Cedar Street', 'Houston', 'Texas', 77002, 44, 'http://example.com/bob.jpg'),
    (6, 'Emily', 'Taylor', 'emilytaylor', 'Password5!', 'emily@gmail.com', '1995-03-25', 1213, 'Elm Road', 'Miami', 'Florida', 33101, 29, 'http://example.com/emily.jpg'),
    (7, 'Daniel', 'Lujo', 'DLujo', 'Daniel1234!', 'daniel@gmail.com', '2002-01-05', 1213, 'E. Fowler Avenue', 'Tampa', 'Forida', 33620, 500, 'http://example.com/daniel.jpg'),
    (8, 'Tommy', 'Wazoo', 'TWazoo', 'Twz1234!', 'tommy@gmail.com', '2002-01-09', 1213, 'E. Fowler Avenue', 'Tampa', 'Forida', 33620, 88, 'http://example.com/daniel.jpg');