<Query Kind="Expression">
  <Connection>
    <ID>1f6a4b30-57f4-4825-8a8c-b4e5c6c67b27</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//anonymous data type queries
from food in Items
where food.MenuCategory.Description.Equals("Entree") 
		&& food.Active
orderby food.CurrentPrice descending
select new //POCOObjectName
	{
		Description = food.Description,
		Price = food.CurrentPrice,
		Cost = food.CurrentCost,
		Profit = food.CurrentPrice - food.CurrentCost
	}
	
from food in Items
where food.MenuCategory.Description.Equals("Entree") 
		&& food.Active
orderby food.CurrentPrice descending
select new
	{
		food.Description,
		food.CurrentPrice,
		food.CurrentCost
		//Profit = food.CurrentPrice - food.CurrentCost
	}