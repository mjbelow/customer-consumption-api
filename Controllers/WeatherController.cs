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
    public class WeatherController : JsonApiController<Weather, Guid> 
    {
        public WeatherController (IJsonApiOptions jsonApiOptions,  ILoggerFactory loggerFactory, IResourceService<Weather, Guid> resourceService) : base(jsonApiOptions, resourceService, loggerFactory)
        {

        }
    }
}
