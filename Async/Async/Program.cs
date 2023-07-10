using Async;
using Newtonsoft.Json;

HttpClient client = new();
string apiUrl = "https://api.chucknorris.io/jokes/random";
var response = await client.GetAsync(apiUrl);

string responseBody = await response.Content.ReadAsStringAsync();
ChuckNorrisJoke joke = JsonConvert.DeserializeObject<ChuckNorrisJoke>(responseBody);

Console.WriteLine($"Joke: {joke.Value}");