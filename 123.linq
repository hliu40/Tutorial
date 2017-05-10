<Query Kind="Statements">
  <Connection>
    <ID>670f9743-7c09-4647-a61e-de1a5d1387a3</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
              select new
			  {
			    Name =m.Name,
				Tracks = from t in m.Tracks
				         select new
				{
				         TrackName = t.Name,
						 Album = t.Album.Title,
						 Artist = t.Album.Artist.Name,
						 ReleaseYear = t.Album.ReleaseYear,
						 ReleaseLabel =t.Album.ReleaseLabel ,
						 Genre=t.Genre.Name
						 
  				}
			  };
 results.Dump();			  