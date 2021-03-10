create table `restaurants` (RestaurantId INT NOT NULL AUTO_INCREMENT,Name VARCHAR(50),Description VARCHAR(255),Address VARCHAR(255),CuisineId INT,PRIMARY KEY(RestaurantId));

insert into restaurants (RestaurantId, Name, Description, Address, CuisineId) values (1, 'Red Robins', 'American Burger estalishment', '1234 Main St', 5);
insert into restaurants (RestaurantId, Name, Description, Address, CuisineId) values (2, 'Outback Steakhouse', 'American BBQ', '2323 E Blvd', 5);
insert into restaurants (RestaurantId, Name, Description, Address, CuisineId) values (3, 'Spanish Tapas', 'Spanish cousine', '13005 Bellevue St', 8);
insert into restaurants (RestaurantId, Name, Description, Address, CuisineId) values (4, 'Pho #7', 'Vietnamese Noodle Soup', '39393 Portland Ave', 12);
insert into restaurants (RestaurantId, Name, Description, Address, CuisineId) values (5, 'El Saboraro', 'Authentic Hispanic food', '4942 S 98th St', 8);

