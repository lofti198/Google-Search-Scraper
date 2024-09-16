using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class GoogleSearch
{
    private static readonly string apiKey = "YOUR_GOOGLE_API_KEY";  // Replace with your Google API key
    private static readonly string cx = "YOUR_CSE_ID";  // Replace with your Custom Search Engine ID

    public static async Task Main(string[] args)
    {
        string query = "YOUR_SEARCH_QUERY";  // Replace with your search query
        string searchResults = await SearchGoogle(query);
        Console.WriteLine(searchResults);
    }

    public static async Task<string> SearchGoogle(string query)
    {
        using (HttpClient client = new HttpClient())
        {
            // Build the query URL for the Google Custom Search API
            string url = $"https://www.googleapis.com/customsearch/v1?key={apiKey}&cx={cx}&q={Uri.EscapeDataString(query)}";

            // Send the request and get the response
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            // Parse the response content
            string content = await response.Content.ReadAsStringAsync();
            JObject jsonResponse = JObject.Parse(content);

            // Extract relevant search result information
            JArray items = (JArray)jsonResponse["items"];
            string resultString = "";

            if (items != null)
            {
                foreach (var item in items)
                {
                    string title = (string)item["title"];
                    string link = (string)item["link"];
                    string snippet = (string)item["snippet"];

                    resultString += $"Title: {title}\nLink: {link}\nSnippet: {snippet}\n\n";
                }
            }
            else
            {
                resultString = "No results found.";
            }

            return resultString;
        }
    }
}
