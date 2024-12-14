// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var httpClient = new HttpClient();
var url = "https://smsgw.preprod.citymall.com.mm/api/client/getclients"; // Replace with your API endpoint
int concurrentUsers = 200;

// Create a list of tasks representing concurrent users
var tasks = Enumerable.Range(1, concurrentUsers)
					  .Select(async user =>
					  {
						  var response = await httpClient.GetAsync(url);
						  var content = await response.Content.ReadAsStringAsync();

						  Console.WriteLine($"User {user} received: {response.StatusCode}, Content: {content}");
					  });

// Execute all tasks concurrently
await Task.WhenAll(tasks);

Console.WriteLine("All requests completed.");