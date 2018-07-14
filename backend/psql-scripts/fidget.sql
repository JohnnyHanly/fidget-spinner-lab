
CREATE TABLE Stores(
    store_id Serial PRIMARY KEY,
    name varchar(50),
    phone varchar(15)
);

CREATE TABLE Fidget_Spinners(
fidget_id Serial PRIMARY KEY,
fidget_name varchar(50),
spokes integer,
bearings integer,
weights varchar(50),
special_feature varchar(50),
price float
);

CREATE TABLE Store_Inventory(
    inventory_id Serial PRIMARY KEY,
    store_id integer REFERENCES Stores(store_id),
    fidget_id integer REFERENCES Fidget_Spinners(fidget_id),
    quantity integer,
    in_stock boolean

);

CREATE TABLE Sales_Records(
    sale_id Serial PRIMARY KEY,
    fidget_id integer REFERENCES Fidget_Spinners(fidget_id),
    store_id integer REFERENCES Stores(store_id),
    quantity integer

);

INSERT INTO Fidget_Spinners(fidget_name,spokes,bearings,weights,special_feature,price)
VALUES
('Red Heat',2,3,'heavy','none',2.99),
('Blue Valentine',3,4,'light','none',2.99),
('Green Earth',2,3,'medium','none',3.99),
('Chrominum',3,3,'heavy','chrome paint',10.99),
('Platinum Blonde',3,4,'heavy','chrome paint',149.99),
('Batman Spinner',3,5,'medium','light up',49.99),
('Fortnite Spinner',3,3,'super heavy','none',1.99),
('SpiderMan Spinner',3,3,'light','light up',69.99);


INSERT INTO Stores(name,phone)
VALUES
('Toys R Us','245-535-3535'),
('Target','454-332-6364'),
('Best Buy','562-666-6346'),
('Gamestop','435-545-3135');



INSERT INTO Store_Inventory(store_id,fidget_id,quantity,in_stock)
VALUES
(1,1,12,true),
(1,2,30,true),
(1,3,2,true),
(1,4,7,true),
(1,5,5,true),
(1,6,34,true),
(1,7,9,true),
(1,8,0,false),
(2,1,10,true),
(2,2,30,true),
(2,3,34,true),
(2,4,0,false),
(2,5,5,true),
(2,6,34,true),
(2,7,9,true),
(2,8,0,false),
(3,1,10,true),
(3,2,30,true),
(3,3,2,true),
(3,4,3,true),
(3,5,45,true),
(3,6,11,true),
(3,7,24,true),
(3,8,0,false),
(4,1,10,true),
(4,2,0,false),
(4,3,2,true),
(4,4,7,true),
(4,5,5,true),
(4,6,34,true),
(4,7,9,true),
(4,8,0,false);

INSERT INTO Sales_Records(store_id,fidget_id,quantity)
VALUES
(1,1,4),
(1,2,3),
(1,3,45),
(1,4,12),
(1,5,3),
(1,6,5),
(1,7,8),
(1,8,54),
(2,1,3),
(2,2,9),
(2,3,8),
(2,4,7),
(2,5,46),
(2,6,4),
(2,7,7),
(2,8,13),
(3,1,21),
(3,2,4),
(3,3,6),
(3,4,8),
(3,5,42),
(3,6,32),
(3,7,21),
(3,8,23),
(4,1,16),
(4,2,4),
(4,3,0),
(4,4,4),
(4,5,2),
(4,6,1),
(4,7,8),
(4,8,5);


 






