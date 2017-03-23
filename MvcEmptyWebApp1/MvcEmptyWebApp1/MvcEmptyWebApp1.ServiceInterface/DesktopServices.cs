using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using MvcEmptyWebApp1.ServiceModel;

namespace MvcEmptyWebApp1.ServiceInterface
{    
    public class DesktopServices : Service
    {
        Desktop[] desktops = new Desktop[]
        {
            new Desktop { ID = 1, UUID = "UUID1",  Name = "N1", Description="D1" },
            new Desktop { ID = 2, UUID = "UUID2",  Name = "N2", Description="D2"  },
            new Desktop { ID = 3, UUID = "UUID3",  Name = "N3", Description="D3"  },
            new Desktop { ID = 1, UUID = "UUID4",  Name = "N4", Description="D4"  }
        };

        //https://github.com/ServiceStack/ServiceStack/wiki/New-API
        //Handles any HTTP Verb
        public object Any(Desktop request)
        {
            return new HelloResponse { Result = "Hello, {0}!".Fmt(request.Name) };
        }

        //Only concerned with GET/Search actions
        public object Get(Desktop request)
        {
            return new DesktopResponse { Result = "Hello, {0}!".Fmt(request.Name), Desktops = desktops };
        }

        //Only concerned with POST action
        public object Post(Desktop request)
        {
            return new   { Result = "Hello, {0}!".Fmt(request.Name) };
        }

        //Only concerned with PATCH action
        public object Patch(Desktop request)
        {
            return new DesktopResponse { Result = "Hello, {0}!".Fmt(request.Name) };
        }

        //Only concerned with DELETE action
        public object Delete(Desktop request)
        {
            return new DesktopResponse { Result = "Hello, {0}!".Fmt(request.Name) };
        }
    }
}