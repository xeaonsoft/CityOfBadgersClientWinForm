using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityOfBadgersClientWinForm
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
        public static string MakeRequest(string uri/*, HttpVerb method = HttpVerb.GET*/)
        {
            try
            {



                var request = (HttpWebRequest)WebRequest.Create(uri);



                string apiKey = Base64.Base64Encode(Properties.Resources.CobApiKey);
                request.Headers.Add("CobAPIKey", apiKey);



                //request.Method = method.ToString();
                //request.ContentLength = 0;
                //request.ContentType = this.ContentType;

                //if (!string.IsNullOrEmpty(this.PostData) && (this.Method == HttpVerb.POST || this.Method == HttpVerb.PUT))
                //{

                //    //var bytes = RestEncoding.Iso88591Instance.GetBytes(PostData); //LES ACCENTS FONCTIONNENT PAS !!
                //    var bytes = RestEncoding.UTF8Instance.GetBytes(PostData);

                //    request.ContentLength = bytes.Length;

                //    using (var writeStream = request.GetRequestStream())
                //    {
                //        writeStream.Write(bytes, 0, bytes.Length);
                //    }
                //}

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    var responseValue = string.Empty;

                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        var message = String.Format("Request failed. Received HTTP {0}", response.StatusCode);
                        throw new ApplicationException(message);
                    }

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
                    //error = ex.Message;
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return null;
                    //throw ex;
                }
                using (var reader = new StreamReader(ex.Response.GetResponseStream()))
                {
                    string responseValue = reader.ReadToEnd();
                    return responseValue;
                }

                //throw ex;
            }
            catch (Exception ex)
            {
                //error = ex.Message;
                throw ex;
            }
        } // end:MakeRequest
    }
}
