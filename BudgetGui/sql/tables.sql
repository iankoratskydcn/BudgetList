CREATE TABLE _user(
    userId VARCHAR(10) PRIMARY KEY,
    fName VARCHAR(50) NOT NULL,
    lName VARCHAR(50) NOT NULL,
    username VARCHAR(50) NOT NULL,
    _password VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL,
    DOB VARCHAR(10),
    streetnum INT,
    street VARCHAR(100),
    city VARCHAR(50),
    state VARCHAR(50),
    zip INT,
    age INT, --should be changed to derived attribute
    profilePicture VARCHAR(100) --No idea how to do this unless its holding the link to the picture
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
    itemId INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    sellerId INT NOT NULL, --Sells relationship
    buyerId INT, --Buys relationship
    postDate DATE,
    purchaseDate TIMESTAMP,--Buys relationship attribute
    title VARCHAR(255) NOT NULL,
    description VARCHAR(1000),
    itemPrice DECIMAL(10,2), --change to just itemPrice
    photoUrl VARCHAR(255),
    basePrice DECIMAL(10,2), --change to just itemPrice
    endDate DATE,--consider dropping this attribute
    minimum DECIMAL(10,2),--drop this attribute
    buyerId INT, --Buys relationship
    rateing DECIMAL(2,1),
    purchaseDate TIMESTAMP,--Buys relationship attribute
    currencyType VARCHAR(50),--Buys relationship attribute
    amount DECIMAL(10,2),--Buys relationship attribute
    CONSTRAINT fk_seller FOREIGN KEY(sellerId) REFERENCES _user(userId),
    CONSTRAINT fk_buyerId FOREIGN KEY(buyerId) REFERENCES _user(userId)
);

CREATE TABLE logs(
    logId INT PRIMARY KEY NOT NULL,
    userId INT NOT NULL,
    timeDate DATE,
    type VARCHAR(50),
    dataJson VARCHAR(255),
    CONSTRAINT fk_userId FOREIGN KEY(userId) REFERENCES _user(userId)
);

