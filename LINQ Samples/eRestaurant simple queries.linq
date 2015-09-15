<Query Kind="Statements">
  <Connection>
    <ID>01fe9a26-8f6c-4446-9b9f-82ae63ab33d1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//step 1 connect to the desired database
//click on Add connection
//take defaults press Next
//Change server to . (dot), select existing database from drop down list
//optionally press Test Connection
//press OK
//remember to check the Connection drop down list to see which database is the active connection

//result should show database Tables in connection object area
//expanding a table will reveal the table attributes and and relationships.

//view Waiter data
Waiters

//query syntax to also view Waiter data
from item in Waiters
select item

//method syntax to view Waiter data
Waiters.Select (item => item)

//alter the query syntax into a C# statement
var results = from item in Waiters
				select item;
results.Dump();

//once the query is create, tested, you will be able to
//transfer the query with minor modifications into your
//BLL methods
//public List<pocoObject> SomeBLLMethodName()
//{
	//content to your DAL object : var contextvariable
	//do your query
//	var results = from item in contextvariable.Waiters
//				select item;
//	return results.ToList();
//}