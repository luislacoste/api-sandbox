using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main()
    {
        // Example GridView data (replace this with your actual GridView data)
        System.Data.DataTable gridViewData = GetExampleGridViewData();

        // Example API URL
        string apiUrl = " http://localhost:3000/";

        // Convert GridView data to JSON
        string jsonData = ConvertGridViewToJson(gridViewData);


        // Send JSON data to the API
        await SendDataToApi(apiUrl, jsonData);
    }

    static System.Data.DataTable GetExampleGridViewData()
    {
        // Replace this with your actual logic to populate the DataTable
        var dataTable = new System.Data.DataTable();
        dataTable.Columns.Add("Name");
        dataTable.Columns.Add("Surname");
        
        // Example data
        dataTable.Rows.Add("Luis", "Lacoste");
        dataTable.Rows.Add("Juani", "Fransoy");

        return dataTable;
    }

    static string ConvertGridViewToJson(System.Data.DataTable gridViewData)
    {
        // Convert DataTable to JSON using Newtonsoft.Json
        string jsonData = JsonConvert.SerializeObject(gridViewData, Formatting.Indented);

        return jsonData;
    }

    static async Task SendDataToApi(string apiUrl, string jsonData)
    {
        using (HttpClient client = new HttpClient())
        {
            // Set the API endpoint URL
            client.BaseAddress = new Uri(apiUrl);

            // Prepare content to be sent as a POST request
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Send the POST request to the API
            HttpResponseMessage response = await client.PostAsync(apiUrl, content);

            // Check if the request was successful (HTTP 2xx)
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Data sent to API successfully.");
            }
            else
            {
                // Handle API error
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }
    }
}
