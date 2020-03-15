using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JsonApiDotNetCore.Controllers;
using customer_consumption_api.Models;
using JsonApiDotNetCore.Services;
using JsonApiDotNetCore.Configuration;

namespace customer_consumption_api.Controllers
{
    public class CustomersController : JsonApiController<Customer, string> 
    {
        public CustomersController (IJsonApiOptions jsonApiOptions,  ILoggerFactory loggerFactory, IResourceService<Customer, string> resourceService) : base(jsonApiOptions, resourceService, loggerFactory)
        {

        }

    }
}
