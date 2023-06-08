using System.Text;
using System.Xml.Linq;
using DataCiteAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;



namespace DataCiteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProgeController : ControllerBase
    {  
        
        
        [HttpPost("GetAllClient")]
        public async Task<IActionResult> GetAllClient(string consortium_id)
        {
            var httpClient1 = new HttpClient();
            var response = await httpClient1.GetAsync($"https://api.datacite.org/providers?consortium-id={consortium_id}");

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode);
            }

            var content = await response.Content.ReadAsStringAsync();
            var deserializedDataCite = JsonConvert.DeserializeObject<Rootobject>(content);

            var infoBuilder = new StringBuilder();
            int count = 0;
            foreach (var provider in deserializedDataCite.data)
            {
                infoBuilder.AppendLine($"> Provider: {provider.id}");

                var tasks = new List<Task>();
                

                foreach (var client in provider.relationships.clients.data)
                {
                    
                    count=count+1;
                    //add client_id to session if not exist else add to list
                    if (HttpContext.Session.GetString("client_id") == null)
                    {
                        HttpContext.Session.SetString("client_id", client.id);
                    }
                    else
                    {
                        var client_id = HttpContext.Session.GetString("client_id");
                        client_id = client_id + "," + client.id;
                        HttpContext.Session.SetString("client_id", client_id);
                    }
                   
                }

                await Task.WhenAll(tasks); // Wait for all requests to complete before moving to the next provider.
            }

            return Content("Count Client_Id =" +count.ToString() + " --> " +( count/10) + " Page of 10 ", "application/text");

        }




        [HttpGet(Name = "consortium_id")]
        public async Task<IActionResult> Get(string consortium_id, CancellationToken cancellationToken,double timeOut = 1,int pagenumber=1)
        {
           //check if client_id exist in session else call GetAllClient
            if (HttpContext.Session.GetString("client_id") == null)
            {
                await GetAllClient(consortium_id);
            }

            var infoBuilder = new StringBuilder();

            //split client_id from session and add to list of client_id
            //chech page number is low 1 
            if (pagenumber < 1)
            {
                pagenumber = 1;
            }


            var client_id = HttpContext.Session.GetString("client_id");
            var client_id_list = client_id.Split(",").ToList().Skip((pagenumber-1)*5).Take(5).ToList();


                var tasks = new List<Task>();

                foreach (var client in client_id_list )
                {
                    infoBuilder.AppendLine($"   >> Client: {client}");
                    HttpClient httpClient = null;
                   
                      
                    try
                    {
                        httpClient = new HttpClient();
                        httpClient.Timeout = TimeSpan.FromSeconds(timeOut);

                     

                        var DOIresponse = await httpClient.GetAsync($"https://api.datacite.org/dois?client-id={client}", cancellationToken);
                        DOIresponse.EnsureSuccessStatusCode();

                        var DOIcontent = await DOIresponse.Content.ReadAsStringAsync();
                        var deserializedDOI = JsonConvert.DeserializeObject<DOICls>(DOIcontent);

                        var DOICount = deserializedDOI.meta.total;
                        infoBuilder.AppendLine($"** {client} DOI Count: {DOICount}");
                    }
                    catch (TaskCanceledException ex)
                    {
                        // Handle the timeout exception here
                        infoBuilder.AppendLine($"The HTTP request timed out after "+timeOut+" seconds: {ex.Message}");
                    }
                    catch (HttpRequestException ex)
                    {
                        // Handle other types of HTTP request exceptions here
                        infoBuilder.AppendLine($"An HTTP error occurred: {ex.Message}");
                    }
                    finally
                    {
                        if (httpClient != null)
                        {
                            httpClient.Dispose(); // Dispose the HttpClient to free up resources
                        }
                    }






                }

                await Task.WhenAll(tasks); // Wait for all requests to complete before moving to the next provider.
            

            return Content(infoBuilder.ToString(), "application/text");
        }


    }
}
