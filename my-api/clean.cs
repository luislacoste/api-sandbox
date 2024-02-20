using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace api_sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ask data");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");

            // Replace the URL with the actual endpoint you want to call
            string apiUrl = "https://api.example.com/data";

            // Create an instance of HttpClient
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Make a GET request
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    // Check if the request was successful (status code 200-299)
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and display the response content as a string
                        string content = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Response content: " + content);
                    }
                    else
                    {
                        Console.WriteLine("Error: " + response.StatusCode);
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("HTTP request error: " + e.Message);
                }
            }
        }
    }
}



using System;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;

class YourClass
{
    private void ConvertGridViewToJson(GridView gridView)
    {
        List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

        foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
        {
                if (!column.Visible)
                    continue;

                Dictionary<string, object> row = new Dictionary<string, object>();
                row["ColumnName"] = column.FieldName; // You may want to use the actual column name

                for (int rowHandle = 0; rowHandle < gridView.DataRowCount; rowHandle++)
                {
                    object cellValue = gridView.GetRowCellValue(rowHandle, column);
                    row[$"Row{rowHandle + 1}"] = cellValue;
                }

                rows.Add(row);
        }

        string json = Newtonsoft.Json.JsonConvert.SerializeObject(rows, Newtonsoft.Json.Formatting.Indented);

        // Now, 'json' contains the JSON representation of the GridView data
        Console.WriteLine(json);
    }
}