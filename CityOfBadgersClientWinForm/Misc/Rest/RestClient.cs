using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityOfBadgersClientTool
{
    internal class RestClient
    {
        public enum HttpVerb
        {
            GET,
            POST,
            PUT,
            DELETE
        }
        public static string MakeSimpleRequest(string uri)
        {
            try
            {

                var request = (HttpWebRequest)WebRequest.Create(uri);

                string apiKey = Base64.Base64Encode(Properties.Resources.CobApiKey);
                request.Headers.Add("CobAPIKey", apiKey);


                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    var responseValue = string.Empty;

                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new ApplicationException($"Request failed. Received HTTP {response.StatusCode}");


                    // grab the response
                    using (var responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (var reader = new StreamReader(responseStream))
                            {
                                responseValue = reader.ReadToEnd();
                            }
                        }
                    }

                    return responseValue;
                }

            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return null;
                }
                using (var reader = new StreamReader(ex.Response.GetResponseStream()))
                    return reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 


        public static string MakePostRequest(string uri, string postData)
        {
            try
            {



                var request = (HttpWebRequest)WebRequest.Create(uri);



                string apiKey = Base64.Base64Encode(Properties.Resources.CobApiKey);
                request.Headers.Add("CobAPIKey", apiKey);



                request.Method = HttpVerb.POST.ToString();
                request.ContentLength = 0;
                request.ContentType = "application/json";

                if (!string.IsNullOrEmpty(postData))
                {
                    var bytes = RestEncoding.UTF8Instance.GetBytes(postData);
                    request.ContentLength = bytes.Length;
                    using (var requestStream = request.GetRequestStream())
                        requestStream.Write(bytes, 0, bytes.Length);
                }

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    var responseValue = string.Empty;

                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new ApplicationException($"Request failed. Received HTTP {response.StatusCode}");

                    // grab the response
                    using (var responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (var reader = new StreamReader(responseStream))
                                responseValue = reader.ReadToEnd();
                        }
                    }
                    return responseValue;
                }

            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return null;
                }
                using (var reader = new StreamReader(ex.Response.GetResponseStream()))
                    return reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 



    }
}
