CREATE TABLE message(
    sender VARCHAR(100),
    timeDate DATE,
    recipient VARCHAR(100),
    text1 VARCHAR(255),
    PRIMARY KEY(sender, timeDate)
);

CREATE TABLE user(
    userId INT PRIMARY KEY,
    fName VARCHAR(50),
    lName VARCHAR(50),
    DOB VARCHAR(10),
    streetnum INT,
    street VARCHAR(100),
    city VARCHAR(50),
    zip INT,
    age INT, //should be changed to derived attribute
    profilePicture VARCHAR(100) //No idea how to do this unless its holding the link to the picture
);

CREATE TABLE item(
    itemId INT PRIMARY KEY,
    seller VARCHAR(50),
    postDate DATE,
    title VARCHAR(100),
    description VARCHAR(255),
    photoUrl VARCHAR(255),
    basePrice DECIMAL(10,2),
    endDate DATE,
    minimum DECIMAL(10,2),
    buyerId INT,
    rating DECIMAL(2,1),
    text1 VARCHAR(255),
    CONSTRAINT fk_seller FOREIGN KEY(seller) REFERENCES user(seller),
    CONSTRAINT fk_buyerId FOREIGN KEY(buyerId) REFERENCES user(buyerId)
);

CREATE TABLE logs(
    logId INT PRIMARY KEY,
    userId INT,
    timeDate DATE,
    type VARCHAR(50),
    dataJson VARCHAR(255),
    CONSTRAINT fk_userId FOREIGN KEY(userId) REFERENCES user(userId)
);

CREATE TABLE bids(
    user VARCHAR(100),
    itemId INT,
    bidDate DATE,
    currency VARCHAR(50),
    amount DECIMAL(10,2),
    PRIMARY KEY(user, itemId, bidDate),
    CONSTRAINT fk_user FOREIGN KEY(user) REFERENCES user(user),
    CONSTRAINT fk_itemId FOREIGN KEY(itemId) REFERENCES item(itemId)
);