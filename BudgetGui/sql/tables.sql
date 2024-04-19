CREATE TABLE _user(
    userId INT PRIMARY KEY,
    fName VARCHAR(50) NOT NULL,
    lName VARCHAR(50) NOT NULL,
    username VARCHAR(50) NOT NULL,
    _password VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL,
    DOB VARCHAR(10),
    street VARCHAR(100),
    city VARCHAR(50),
    state VARCHAR(50),
    zip INT,
    age INT, --should be changed to derived attribute
    profile_pic VARCHAR(128)
    );

CREATE TABLE _message(
    sender INT NOT NULL,
    timeDate DATE NOT NULL,
    recipient INT NOT NULL,
    text1 VARCHAR(1024),
    PRIMARY KEY(sender, timeDate),
    CONSTRAINT fk_sender FOREIGN KEY(sender) REFERENCES _user(userId),
    CONSTRAINT fk_recipient FOREIGN KEY(recipient) REFERENCES _user(userId)
);

CREATE TABLE item(
    itemId INT PRIMARY KEY NOT NULL,
    sellerId INT NOT NULL, --Sells relationship
    buyerId INT, --Buys relationship
    postDate DATE,
    purchaseDate TIMESTAMP,--Buys relationship attribute
    title VARCHAR(100) NOT NULL,
    description VARCHAR(255),
    itemPrice DECIMAL(10,2), --change to just itemPrice
    photoUrl VARCHAR(255),
    rating DECIMAL(2,1), --Should change to user rating, not item
    currencyType VARCHAR(50),--Buys relationship attribute
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
    currencyType VARCHAR(50),
    itemPrice DECIMAL(10,2),
	PRIMARY KEY(savedUserId, itemId),
	CONSTRAINT fk_userId FOREIGN KEY(savedUserId) REFERENCES _user(userId),
	CONSTRAINT fk_itemId FOREIGN KEY(itemId) REFERENCES item(itemId)
);



