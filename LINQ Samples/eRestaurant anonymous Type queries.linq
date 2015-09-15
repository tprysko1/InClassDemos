<Query Kind="Expression">
  <Connection>
    <ID>01fe9a26-8f6c-4446-9b9f-82ae63ab33d1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//anonymous type
from food in Items
where food.MenuCategory.Description.Equals("Entree") &&
		food.Active
orderby food.CurrentPrice descending
select new
		{
			Description = food.Description,
			Price = food.CurrentPrice,
			Cost = food.CurrentCost,
			Profit = food.CurrentPrice - food.CurrentCost
		}
		
from food in Items
where food.MenuCategory.Description.Equals("Entree") &&
		food.Active
orderby food.CurrentPrice descending
select new
		{
			food.Description,
			food.CurrentPrice,
			food.CurrentCost
			//Profit = food.CurrentPrice - food.CurrentCost
		}
		
