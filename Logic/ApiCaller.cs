using System;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;

namespace TransactionDataApiSettlement.Logic
{
    public class ApiCaller
    {
        public async Task<string> postAsync(string url, string data, string token = "")
        {

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            // Pass the handler to httpclient(from you are calling api)
            /*  httpClient = new HttpClient();*/

            string responseAsString = "";
            try
            {
                var httpClient = new HttpClient(clientHandler);
                using (httpClient)
                {
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/xml");
                    if (!token.Equals(""))
                        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);



                    using (var response = await httpClient.PostAsync(url, content))
                    {
                        responseAsString = await response.Content.ReadAsStringAsync();
                    }
                }

                return responseAsString;
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        public async Task<string> postAsyncjson(string url, string data, string token = "")
        {

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            // Pass the handler to httpclient(from you are calling api)
            /*  httpClient = new HttpClient();*/

            string responseAsString = "";
            try
            {
                var httpClient = new HttpClient(clientHandler);
                using (httpClient)
                {
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                    if (!token.Equals(""))
                        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);



                    using (var response = await httpClient.PostAsync(url, content))
                    {
                        responseAsString = await response.Content.ReadAsStringAsync();
                    }
                }

                return responseAsString;
            }
            catch (Exception ex)
            {

            }

            return null;
        }


        public async Task<string> putAsync(string url, string data, string id = "", string dataType = "", string token = "")
        {
            string responseAsString = "";
            try
            {
                if (!id.Equals("") && !dataType.Equals(""))
                {
                    url = url + "/" + id;
                }
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                var httpClient = new HttpClient(clientHandler);
                using (httpClient)
                {
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                    if (!token.Equals(""))
                        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    using (var response = await httpClient.PutAsync(url, content))
                    {
                        responseAsString = await response.Content.ReadAsStringAsync();
                    }
                }

                return responseAsString;
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        public async Task<string> getAsync(string url, string id = "", string dataType = "", string token = "")
        {
            string responseAsString = "";
            try
            {
                if (!id.Equals(""))
                {
                    url = url + "/" + id;
                }
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                var httpClient = new HttpClient(clientHandler);
                using (httpClient)
                {
                    if (!token.Equals(""))
                        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    using (var response = await httpClient.GetAsync(url))
                    {
                        responseAsString = await response.Content.ReadAsStringAsync();
                    }
                }

                return responseAsString;
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        public async Task<string> getAllAsync(string url, string token = "")
        {
            string responseAsString = "";
            try
            {
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                var client = new HttpClient(clientHandler);
                using (client)
                {
                    if (!token.Equals(""))
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    var response = client.GetAsync(url).Result;
                    responseAsString = await response.Content.ReadAsStringAsync();
                }
                return responseAsString;
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        public async Task<string> deleteAsync(string url, int id, string token = "")
        {
            string responseAsString = "";
            try
            {
                if (!id.Equals(""))
                {
                    url = url + "/" + id;
                }
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                var httpClient = new HttpClient(clientHandler);
                using (httpClient)
                {
                    if (!token.Equals(""))
                        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    using (var response = await httpClient.DeleteAsync(url))
                    {
                        responseAsString = await response.Content.ReadAsStringAsync();
                    }
                }

                return responseAsString;
            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }
}

