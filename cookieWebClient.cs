using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;

namespace GenWebScrape
{
    class cookieWebClient
    {
        //The cookies will be here.
        private CookieContainer _cookies = new CookieContainer();

        //In case you need to clear the cookies
        public void ClearCookies()
        {
            _cookies = new CookieContainer();
        }

        public HtmlDocument GetPage(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, image/jxr, */*";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";


            //This is the important part.
            request.CookieContainer = _cookies;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            var stream = response.GetResponseStream();

            //When you get the response from the website, the cookies will be stored
            //automatically in "_cookies".

            using (var reader = new StreamReader(stream))
            {
                string html = reader.ReadToEnd();
                var doc = new HtmlDocument();
                doc.LoadHtml(html);
                return doc;
            }
        }
    }
}
