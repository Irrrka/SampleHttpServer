using MyHttpServer.Enums;
using MyHttpServer.Models;

namespace MyHttpServer
{
    public static class HttpResponseBuilder
    {
        public static HttpResponse InternalServerError()
        {
            string content =
                "<!DOCTYPE html>

< html lang = "en" xmlns = "http://www.w3.org/1999/xhtml" >
   < head >
   
       < meta charset = "utf-8" />
    
        < title > Internal Server Error</ title >
       </ head >
       < body >
       
           < h1 > Ooops!</ h1 >
          </ body >
          </ html > ";
            var response = new HttpResponse(ResponseStatusCode.Internal_Server_Error);
            response.ContentAsUTF8 = content;
            return response;
        }

        public static HttpResponse ResourseNotFound()
        {
            string content =
                "<!DOCTYPE html>

< html lang = "en" xmlns = "http://www.w3.org/1999/xhtml" >
   < head >
   
       < meta charset = "utf-8" />
    
        < title > Resourse Not Found!</ title >
       </ head >
       < body >
       
           < h1 > I'm sorry!</h1>
          </ body >
          </ html > ";
            var response = new HttpResponse(ResponseStatusCode.Page_Not_Found);
            response.ContentAsUTF8 = content;
            return response;
        }

    }
}
