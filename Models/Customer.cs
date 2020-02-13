﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace customer_consumption_api.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }

        // 'Customers table' and 'Locations table' has many to many relationship.
        // We have a bridge table 'CustomersLocations'.
        public ICollection<CustomerLocation> CustomerLocations { get; set; }
    }
}