INSERT INTO _user (userId, fName, lName, username, _password, email, DOB, streetnum, street, city, state, zip, age, profilePicture)
VALUES
    ('1', 'Joshua', 'Bernard', 'jbernard2024', 'Josh1234!', 'joshua@gmail.com', '2002-04-28', 4202, 'E. Fowler Avenue', 'Tampa', 'Florida', 33620, 21, 'http://example.com/joshua.jpg'),
    ('2', 'John', 'Doe', 'johndoe', 'Password1!', 'john@gmail.com', '1990-01-01', 123, 'Main Street','New York', 'New York', 10001, 32, 'http://example.com/john.jpg'),
    ('3', 'Jane', 'Smith', 'janesmith', 'Password2!', 'jane@gmail.com', '1985-05-15', 456, 'Broadway', 'Los Angeles', 'California', 90001, 37, 'http://example.com/jane.jpg'),
    ('4', 'Alice', 'Johnson', 'alicejohnson', 'Password3!', 'alice@gmail.com', '1982-11-20', 789, 'Oak Avenue', 'Chicago', 'Illinois', 60601, 40, 'http://example.com/alice.jpg'),
    ('5', 'Bob', 'Brown', 'bobbrown', 'Password4!', 'bob@gmail.com', '1978-07-10', 1011, 'Cedar Street', 'Houston', 'Texas', 77002, 44, 'http://example.com/bob.jpg'),
    ('6', 'Emily', 'Taylor', 'emilytaylor', 'Password5!', 'emily@gmail.com', '1995-03-25', 1213, 'Elm Road', 'Miami', 'Florida', 33101, 29, 'http://example.com/emily.jpg'),
    ('7', 'Daniel', 'Lujo', 'DLujo', 'Daniel1234!', 'daniel@gmail.com', '2002-01-05', 1213, 'E. Fowler Avenue', 'Tampa', 'Forida', 33620, 500, 'http://example.com/daniel.jpg'),
    ('8', 'Tommy', 'Wazoo', 'TWazoo', 'Twz1234!', 'tommy@gmail.com', '2002-01-09', 1213, 'E. Fowler Avenue', 'Tampa', 'Forida', 33620, 88, 'http://example.com/daniel.jpg');

INSERT INTO _message(sender,timeDate,recipient,text1)
VALUES
    ('2', '2024-03-28 11:00:00','1', 'Hello, I''ve purchased your item. When can I pick it up?'),
    ('3', '2024-03-28 11:01:00','1', 'Hello, I''ve purchased your item. When can I pick it up?'),
    ('4', '2024-03-28 11:02:00','1', 'Hello, I''ve purchased your item. When can I pick it up?'),
    ('5', '2024-03-28 11:03:00','1', 'Hello, I''ve purchased your item. When can I pick it up?'),
    ('6', '2024-03-28 11:04:00','1', 'Hello, I''ve purchased your item. When can I pick it up?'),
    ('7', '2024-03-28 11:05:00','1', 'Hello, I''ve purchased your item. When can I pick it up?'),
    ('8', '2024-03-28 11:06:00','1', 'Hello, I''ve purchased your item. When can I pick it up?'),

    ('1', '2024-03-28 11:10:00','2', 'Hi, congratulations on your purchase! You can pick it up anytime after 3 pm tomorrow.'),
    ('1', '2024-03-28 11:11:00','3', 'Hi, congratulations on your purchase! You can pick it up anytime after 3 pm tomorrow.'),
    ('1', '2024-03-28 11:12:00','4', 'Hi, congratulations on your purchase! You can pick it up anytime after 3 pm tomorrow.'),
    ('1', '2024-03-28 11:13:00','5', 'Hi, congratulations on your purchase! You can pick it up anytime after 3 pm tomorrow.'),
    ('1', '2024-03-28 11:14:00','6', 'Hi, congratulations on your purchase! You can pick it up anytime after 3 pm tomorrow.'),
    ('1', '2024-03-28 11:15:00','7', 'Hi, congratulations on your purchase! You can pick it up anytime after 3 pm tomorrow.'),
    ('1', '2024-03-28 11:16:00','8', 'Hi, congratulations on your purchase! You can pick it up anytime after 3 pm tomorrow.'),

    ('2', '2024-03-28 11:17:00','1', 'Great, I''ll see you then.'),
    ('3', '2024-03-28 11:18:00','1', 'Great, I''ll see you then.'),
    ('4', '2024-03-28 11:19:00','1', 'Great, I''ll see you then.'),
    ('5', '2024-03-28 11:20:00','1', 'Great, I''ll see you then.'),
    ('6', '2024-03-28 11:21:00','1', 'Great, I''ll see you then.'),
    ('7', '2024-03-28 11:22:00','1', 'Great, I''ll see you then.'),
    ('8', '2024-03-28 11:23:00','1', 'Great, I''ll see you then.');