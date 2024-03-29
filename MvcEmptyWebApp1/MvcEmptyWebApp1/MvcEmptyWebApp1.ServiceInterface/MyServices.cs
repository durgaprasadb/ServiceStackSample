﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using MvcEmptyWebApp1.ServiceModel;

namespace MvcEmptyWebApp1.ServiceInterface
{
    
    public class MyServices : Service
    {

        //Handles any HTTP Verb
        public object Any(Hello request)
        {
            return new HelloResponse { Result = "Hello, {0}!".Fmt(request.Name) };
        }
    }
}