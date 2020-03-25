
CREATE TABLE CUSTOMER_DETAILS ( 
CNIC VARCHAR(25) NOT NULL PRIMARY KEY,
FNAME VARCHAR(25) NOT NULL,   
LNAME VARCHAR(25) NOT NULL,   
PHONE_NUMBER VARCHAR(15) NOT NULL,   
EMAIL_ID VARCHAR(30) NOT NULL,    
PASSWORD1 VARCHAR(20) NOT NULL,
MEMBERSHIP_ID VARCHAR(25)   
); 

CREATE TABLE CAR_CATEGORY ( 
CATEGORY_NAME VARCHAR(25) NOT NULL PRIMARY KEY,      
COST_PER_DAY VARCHAR(25) NOT NULL,   
LATE_FEE_PER_DAY VARCHAR(25) NOT NULL   
); 

CREATE TABLE LOCATION_DETAILS ( 
ZIPCODE VARCHAR(10) NOT NULL PRIMARY KEY,
FROM_DATE DATE NOT NULL,   
RET_DATE DATE NOT NULL,
PICKUP_LOCATION VARCHAR(50) NOT NULL,
DROPOFF_LOCATION VARCHAR(50) NOT NULL
);

CREATE TABLE CAR ( 
REGISTRATION_NUMBER VARCHAR(25) NOT NULL PRIMARY KEY,   
MODEL_NAME VARCHAR(25) NOT NULL,   
MAKE VARCHAR(25) NOT NULL,     
AVAILABILITY_FLAG CHAR(1) NOT NULL,  
ZIPCODE VARCHAR(10) FOREIGN KEY REFERENCES LOCATION_DETAILS(ZIPCODE),   
CARFK1 VARCHAR(25) FOREIGN KEY REFERENCES CAR_CATEGORY(CATEGORY_NAME)
); 

CREATE TABLE DRIVER_DETAILS (
DRIVER_ID CHAR(8) NOT NULL PRIMARY KEY,
NAME VARCHAR(25) NOT NULL,
PHONE_NUMBER VARCHAR(25) NOT NULL,
REG_NO VARCHAR(25) FOREIGN KEY REFERENCES CAR(REGISTRATION_NUMBER)
);

/*
CREATE TABLE DISCOUNT_DETAILS ( 
DISCOUNT_CODE CHAR(4) NOT NULL PRIMARY KEY,   
DISCOUNT_NAME VARCHAR(25) NOT NULL,   
EXPIRY_DATE DATE NOT NULL,   
DISCOUNT_PERCENTAGE INT  NOT NULL,   
);
*/ 

CREATE TABLE BOOKING_DETAILS ( 
BOOKING_ID CHAR(5) NOT NULL PRIMARY KEY,
CATEGORY VARCHAR(25),
AVAILABLE VARCHAR(25),
DRIVER VARCHAR(25),
MAKE VARCHAR(25),
MODEL VARCHAR(25),

BOOKINGFK3 CHAR(7) FOREIGN KEY REFERENCES CAR(REGISTRATION_NUMBER),   
BOOKINGFK4 CHAR(8) FOREIGN KEY REFERENCES CUSTOMER_DETAILS(CNIC) 
);

CREATE TABLE BILLING_DETAILS ( 
BILL_ID CHAR(6) NOT NULL PRIMARY KEY,   
BILL_DATE DATE NOT NULL,      
DISCOUNT_AMOUNT INT NOT NULL,   
TOTAL_AMOUNT INT NOT NULL,   
TAX_AMOUNT INT NOT NULL,   
BOOKING_ID CHAR(5) FOREIGN KEY REFERENCES BOOKING_DETAILS(BOOKING_ID),   
TOTAL_FEE INT NOT NULL,   
); 

CREATE TABLE ADMIN_DETAILS (
ADMIN_ID CHAR(8) NOT NULL PRIMARY KEY,
PASSWORD2 VARCHAR(25) NOT NULL,
FNAME VARCHAR(25) NOT NULL,
LNAME VARCHAR(25) NOT NULL,
PHONE_NUMBER VARCHAR(25) NOT NULL, 
EMAIL_ID VARCHAR(30) NOT NULL,
);
INSERT INTO ADMIN_DETAILS VALUES ('ADM112', 'admin', 'ASIM', 'ZAFAR', 03009884749, 'asimzafar@gmail.com');

INSERT INTO CAR_CATEGORY VALUES ('ECONOMY',5000,500),
								('COMPACT',3000,300),
							    ('MID SIZE',2000,200),
								('STANDARD',2500, 250),
								('FULL SIZE',4000, 400), 
								('LUXURY CAR',7000, 700); 


INSERT INTO LOCATION_DETAILS VALUES ('L101','DALLAS LOVE FIELD AIRPORT', 'Herb Kelleher Way','Dallas','Texas',75235),
									('L102','LOS ANGELES INTL AIRPORT', 'World Way','Los Angeles','California',90045),
									('L103','DALLAS/ FORT WORTH INTL AIRPORT', 'International Pkwy','DFW Airport','Texas',75261);

INSERT INTO CAR VALUES	('ABX1234','CIVIC','HONDA', 'ECONOMY','L101','A'),
						('SDF4567','FIESTA','FORD', 'COMPACT','L102','B'),
						('WER3245','ACCENT','HYUNDAI', 'MID SIZE','L103','C');

INSERT INTO DRIVER_DETAILS VALUES ('A1601', 'Adnam', 'Khan', 0331922811, 33, 'ABX1234'),
								  ('B1801', 'Ahmad', 'Saqib', 0300822911, 28, 'SDF4567'),
								  ('C1803', 'Arslan', 'Saleem', 0315244246, 30, 'WER3245');

INSERT INTO DISCOUNT_DETAILS VALUES ('D678','IBM CORPORATE', '2018-01-25', 25);
INSERT INTO DISCOUNT_DETAILS VALUES ('D234','CTS CORPORATE', '2019-09-02' , 20);
INSERT INTO DISCOUNT_DETAILS VALUES ('D756','HOLIDAY SPECIAL', '2017-10-29', 10);

INSERT INTO RENTAL_CAR_INSURANCE VALUES('I201', 'COLLISION DAMAGE WAIVER', 'Covers theft and total damage to the rental car',15); 
INSERT INTO RENTAL_CAR_INSURANCE VALUES('I202', 'SUPPLEMENTAL LIABILITY PROTECTION', 'Covers damage done to others',12); 
INSERT INTO RENTAL_CAR_INSURANCE VALUES('I203', 'PERSONAL ACCIDENT INSURANCE', 'Covers medical costs for driver and passengers',10);

SELECT * FROM CUSTOMER_DETAILS
SELECT * FROM CAR_CATEGORY
SELECT * FROM BOOKING_DETAILS
SELECT * FROM LOCATION_DETAILS