<Query Kind="Expression">
  <Connection>
    <ID>01fe9a26-8f6c-4446-9b9f-82ae63ab33d1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//where clause

//list all tables that hold more that 3 people
from row in Tables
where row.Capacity > 3
select row

//list all items that with more that 500 Calories
from foodies in Items
where foodies.Calories > 500 
select foodies

//list all items that with more that 500 Calories and selling for
//more than 10.00
from foodies in Items
where foodies.Calories > 500 &&
      foodies.CurrentPrice > 10.00m
select foodies

//list all items that with more that 500 Calories and 
//are Entrees on the menu.
//HINT: navigational properties of the database and LINQPad knowledge 
from foodies in Items
where foodies.Calories > 500 &&
      foodies.MenuCategory.Description.Equals("Entree")
select foodies