create table product (id int, name text);
insert into product values(1, "p1"),(2,"p2"),(3,"p3");

create table category (id int, name text);
insert into category values(1, "c1"),(2,"c2"),(3,"c3");

create table prodcat (productID int , categoryID int);
insert into prodcat values(1, 3),(2,null),(3,1),(3,2);

select product.name as product , category.name as category from product
left outer join prodcat on product.id=prodcat.productID
left outer join category on prodcat.categoryID=category.id;
