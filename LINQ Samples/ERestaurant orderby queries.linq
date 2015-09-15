<Query Kind="Expression">
  <Connection>
    <ID>01fe9a26-8f6c-4446-9b9f-82ae63ab33d1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//orderby

//default ascending
from food in Items
orderby food.Description
select food

//default descending
from food in Items
orderby food.CurrentPrice descending
select food

//default descending and ascending
from food in Items
orderby food.CurrentPrice descending, food.Calories ascending
select food

//default descending and ascending
from food in Items
orderby food.CurrentPrice descending, food.Calories ascending
where food.MenuCategory.Description.Equals("Entree")

select food