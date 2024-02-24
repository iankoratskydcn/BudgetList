

CREATE TABLE _user(
    userId INT PRIMARY KEY,
    fName VARCHAR(50),
    lName VARCHAR(50),
    DOB VARCHAR(10),
    streetnum INT,
    street VARCHAR(100),
    city VARCHAR(50),
    zip INT,
    age INT, --should be changed to derived attribute
    profilePicture VARCHAR(100) --No idea how to do this unless its holding the link to the picture
);

CREATE TABLE _message(
    sender INT,
    timeDate DATE,
    recipient INT,
    text1 VARCHAR(255),
    PRIMARY KEY(sender, timeDate),
    
    CONSTRAINT fk_sender FOREIGN KEY(sender) REFERENCES _user(userId),
    CONSTRAINT fk_recipient FOREIGN KEY(recipient) REFERENCES _user(userId),
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
    CONSTRAINT fk_seller FOREIGN KEY(seller) REFERENCES _user(userId),
    CONSTRAINT fk_buyerId FOREIGN KEY(buyerId) REFERENCES _user(userId)
);

CREATE TABLE logs(
    logId INT PRIMARY KEY,
    _userId INT,
    timeDate DATE,
    type VARCHAR(50),
    dataJson VARCHAR(255),
    CONSTRAINT fk_userId FOREIGN KEY(userId) REFERENCES _user(userId)
);

CREATE TABLE bids(
    _user INT,
    itemId INT,
    bidDate DATE,
    currency VARCHAR(50),
    amount DECIMAL(10,2),
    PRIMARY KEY(_user, itemId, bidDate),
    CONSTRAINT fk_user FOREIGN KEY(_user) REFERENCES _user(userId),
    CONSTRAINT fk_itemId FOREIGN KEY(itemId) REFERENCES item(itemId)
);
