using System;
using Microsoft.EntityFrameworkCore;

namespace RESTauranter.Models
{
    public class RestContext: DbContext
    {
        public RestContext(DbContextOptions<RestContext> options) : base(options) {}        
        public DbSet<Reviews> reviews {get;set;}
    }
}