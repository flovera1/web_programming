using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

using System.Text.Json;

// var client = new RestClient();
// var request = new RestRequest("http://webservies.be/eurosong/Songs", Method.Get);
// var response = client.Execute(request);
// Console.WriteLine(response.Content);
// List<Song> songs = System.Text.Json.JsonSerializer.Deserialize<List<Song>>(response.Content);
// Console.WriteLine(String.Join("\n", songs));
// int id = Convert.ToInt32(Console.ReadLine());
// Song song = (Song)songs.Find(x => x.id == id);
// Console.WriteLine(song);
// request = new RestRequest("http://webservies.be/eurosong/Artists/"+song.artist, Method.Get);
// response = client.Execute(request);
// Artist artist = System.Text.Json.JsonSerializer.Deserialize<Artist>(response.Content);
// Console.WriteLine("Artist\n");
// Console.WriteLine(artist);
// Console.WriteLine("Song\n");
// Console.WriteLine(song);
var client = new RestClient("https://spotify-scraper.p.rapidapi.com/v1/track/download?track=Lego%20House%20Ed%20Sheeran");
var request = new RestRequest(Method.Get.ToString());
request.AddHeader("X-RapidAPI-Key", "C0QHv9iomBmshvp2PBbkSC2zOH2hp1XOZNYjsndZwWze1PUod2");
request.AddHeader("X-RapidAPI-Host", "spotify-scraper.p.rapidapi.com");
RestResponse response = client.Execute(request);
Console.WriteLine(response.Content);



