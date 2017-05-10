<Query Kind="Statements">
  <Connection>
    <ID>670f9743-7c09-4647-a61e-de1a5d1387a3</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres 
              orderby g.Name
			  select new {
			  
			            Genre = g.Name,
						TracksCount = g.Tracks.Count()
			};
results.Dump("Query Math 1");
