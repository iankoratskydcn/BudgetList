CREATE TABLE _user(
    userId INT PRIMARY KEY NOT NULL,
    fName VARCHAR(50) NOT NULL,
    lName VARCHAR(50) NOT NULL,
    username VARCHAR(50) NOT NULL,
    _password VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL,
    DOB VARCHAR(10),
    street VARCHAR(100),
    city VARCHAR(50),
    state VARCHAR(50),
    zip INT,
    profile_pic VARCHAR(128)
);

CREATE TABLE _message(
    messageId INT PRIMARY KEY,
    sender INT NOT NULL,
    timeDate DATE NOT NULL,
    recipient INT NOT NULL,
    text1 VARCHAR(1024),
    CHECK (sender != recipient),
    CONSTRAINT fk_sender FOREIGN KEY(sender) REFERENCES _user(userId),
    CONSTRAINT fk_recipient FOREIGN KEY(recipient) REFERENCES _user(userId)
);

CREATE TABLE item(
    itemId INT PRIMARY KEY NOT NULL,
    sellerId INT NOT NULL,
    buyerId INT,
    postDate DATE,
    purchaseDate TIMESTAMP,
    title VARCHAR(100) NOT NULL,
    description VARCHAR(1000),
    itemPrice DECIMAL(10,2),
    photoUrl VARCHAR(100),
    CHECK (sellerId != buyerId),
    CHECK (itemPrice >= 1 AND itemPrice <= 100000),
    CONSTRAINT fk_seller FOREIGN KEY(sellerId) REFERENCES _user(userId),
    CONSTRAINT fk_buyerId FOREIGN KEY(buyerId) REFERENCES _user(userId)
);

CREATE TABLE savedItems(
    itemId INT NOT NULL,
    title VARCHAR(100) NOT NULL,
    description VARCHAR(255),
    postDate DATE,
    creatorUserId INT NOT NULL,
    savedUserId INT NOT NULL,
    itemPrice DECIMAL(10,2),
    CHECK (creatorUserId != savedUserId),
	PRIMARY KEY(savedUserId, itemId),
	CONSTRAINT fk_userId FOREIGN KEY(savedUserId) REFERENCES _user(userId),
	CONSTRAINT fk_itemId FOREIGN KEY(itemId) REFERENCES item(itemId)
);

 CREATE VIEW IF NOT EXISTS itemSearch AS
 SELECT i.title, i.itemPrice, u.username, i.postDate, i.itemId, i.description
 FROM item i
 JOIN _user u ON u.userId = i.sellerId
 WHERE i.buyerId IS NULL;



