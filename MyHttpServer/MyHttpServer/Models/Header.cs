using MyHttpServer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyHttpServer.Models
{
    public class Header
    {
        public Header(HeaderType type)
        {
            this.Type = type;
            this.ContentType = "text/html";
            this.Cookies = new CookieCollection();
        }

        public HeaderType Type { get; set; }
        public string ContentType { get; set; }
        public string ContentLenght { get; set; }
        public CookieCollection Cookies { get; set; }
        public Dictionary<string, string> OtherParameters { get; set; }
        public object ContentLength { get; internal set; }

        public override string ToString()
        {
            StringBuilder header = new StringBuilder();
            header.AppendLine("Content type: " + this.ContentType);
            if (this.Cookies.Count>0)
            {
                if (Type == HeaderType.HttpRequest)
                {
                    header.AppendLine("Cookie: " + this.Cookies.ToString());
                }
                else if (Type==HeaderType.HttpResponse)
                {
                    foreach (var cookie in this.Cookies)
                    {
                        header.AppendLine("Set cookie: " + cookie);
                    }
                    
                }
            }
            if (this.ContentLenght!=null)
            {
                header.AppendLine("Content-Lenght: "+this.ContentLenght);
            }
            foreach (var other in OtherParameters)
            {
                header.AppendLine($"{other.Key}: {other.Value}");
            }
            header.AppendLine();
            header.AppendLine();
            return header.ToString();
        }
    }
}
