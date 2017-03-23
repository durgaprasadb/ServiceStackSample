using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcEmptyWebApp1.ServiceModel
{
    [Route("/desktop")]
    [Route("/desktop/{uuid}")]
    public class Desktop : IReturn<DesktopResponse> 
    {
        public Desktop()
        {            
        }

        public int ID { get; set; }
        public string UUID { get; set; }
        public int Group_ID { get; set; }
        public string NameSpace { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_Date { get; set; }
        public int? Status { get; set; }
    }

    public class DesktopResponse : ApiResponse
    {
        public string Result { get; set; }

        public Desktop[] Desktops { get; set; }
    }

    public class ApiRequest
    {
        public string ApiKey { get; set; }

        public Desktop Desktop { get; set; }
    }

    public class ApiResponse
    {
        public bool Success = true;
        public string Message = "";
        public string ErrorCode = "";
    }
}
