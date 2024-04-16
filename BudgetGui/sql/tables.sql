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
    age INT --should be changed to derived attribute
    );

CREATE TABLE _message(
    sender INT NOT NULL,
    timeDate DATE NOT NULL,
    recipient INT NOT NULL,
    text1 VARCHAR(255),
    PRIMARY KEY(sender, timeDate),
    CONSTRAINT fk_sender FOREIGN KEY(sender) REFERENCES _user(userId),
    CONSTRAINT fk_recipient FOREIGN KEY(recipient) REFERENCES _user(userId)
);

CREATE TABLE item(--This table needs NOT NULL constrainsts for sellerID and buyerID
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
    amount DECIMAL(10,2),--Buys relationship attribute
    CONSTRAINT fk_seller FOREIGN KEY(sellerId) REFERENCES _user(userId),
    CONSTRAINT fk_buyerId FOREIGN KEY(buyerId) REFERENCES _user(userId)
);

CREATE TABLE savedItems(
    creatorUserId NOT NULL,
    savedUserId INT NOT NULL,
	itemId VARCHAR(10) NOT NULL,
	PRIMARY KEY(userId, itemId),
	CONSTRAINT fk_userId FOREIGN KEY(userId) REFERENCES _user(userId),
	CONSTRAINT fk_itemId FOREIGN KEY(itemId) REFERENCES item(itemId)
);



)

