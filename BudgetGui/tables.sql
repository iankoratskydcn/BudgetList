CREATE TABLE route_points(
    sequencenum INT,
    roadid INT,
    speedlimit INT,
    streetnumber INT,
    
    latitude NUMERIC(14,11) NOT NULL,
    longitude NUMERIC(14,11) NOT NULL,
    
    PRIMARY KEY(sequencenum, roadid),
    CONSTRAINT fk_roadid FOREIGN KEY(roadid) REFERENCES roads(id)
);

CREATE TABLE polygon_points(
    sequencenum INT,
    regionid INT,
    
    latitude NUMERIC(14,11) NOT NULL,
    longitude NUMERIC(14,11) NOT NULL,
    
    PRIMARY KEY(sequencenum, roadid),
    CONSTRAINT fk_regionid FOREIGN KEY(regionid) REFERENCES region(id)
);

CREATE TABLE region(
    id INT,
    _name VARCHAR(100),
    _type VARCHAR(50),
    PRIMARY KEY(id),
);

CREATE TABLE roads(
    id INT,
    streetname VARCHAR(100),
    _type VARCHAR(50),
    PRIMARY KEY(id),
);

CREATE TABLE landmark(
    id INT,
    _name VARCHAR(100),
    imageURL VARCHAR(255),
    _type VARCHAR(25),
    streetnumber INT,

    zip INT,
    road INT,
    city INT,
    _state INT,

    PRIMARY KEY(id),
    
    CONSTRAINT fk_road FOREIGN KEY(road) REFERENCES roads(id),
    
    CONSTRAINT fk_zip FOREIGN KEY(zip) REFERENCES region(id),
    CONSTRAINT fk_city FOREIGN KEY(city) REFERENCES region(id),
    CONSTRAINT fk_state FOREIGN KEY(_state) REFERENCES region(id)
);