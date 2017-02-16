using MyHttpServer.Enums;
using System.Text;

namespace MyHttpServer.Models
{
    public class HttpRequest
    {
        public HttpRequest(RequestMethod method, string url)
        {
            this.Method = method;
            this.Url = url;
            this.Header = new Header(HeaderType.HttpRequest);
        }
        public RequestMethod Method { get; set; }
        public string Url { get; set; }
        public Header Header { get; set; }
        public string Content { get; set; }

        public override string ToString()
        {
            StringBuilder request = new StringBuilder();
            request.AppendLine($"{this.Method.ToString()} {this.Url} HTTP/1.0");
            request.AppendLine($"{this.Header.ToString()}");
            if (!string.IsNullOrEmpty(Content) && Method==RequestMethod.POST)
            {
                request.AppendLine();
                request.AppendLine($"{this.Content}");
            }
            return request.ToString();
        }
    }
}
