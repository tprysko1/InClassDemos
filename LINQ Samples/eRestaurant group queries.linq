<Query Kind="Expression">
  <Connection>
    <ID>01fe9a26-8f6c-4446-9b9f-82ae63ab33d1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//grouping
from food in Items
group food by food.MenuCategory.Description

//requires the creation of an anonymous type
from food in Items
group food by new {food.MenuCategory.Description, food.CurrentPrice}