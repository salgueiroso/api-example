using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace api_example
{
    public class Rds
    {
        public IEnumerable<DBInstance> DBInstances { get; set; }
    }

    public class DBInstance
    {

        public Endpoint Endpoint { get; set; }
    }

    public class Endpoint
    {

        public string Address { get; set; }
    }
}