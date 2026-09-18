using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    //This is our ORM 
    //We se this class to connect to our database and perform CRUD operations on our entities
    public class ApplicationDbContext :DbContext
    {
        //constructor that takes in DbContextOptions and passes it to the base class constructor
        //we invoke the base constructor to initialize the DbContext with the options provided
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //We will have a DbSet for each entity we want to map to a table in the database
        //We have access becuase the entities are in the Domain project and we have a reference to the Application project in the Infrastructure project
        //Application refernce Domain project and Infrastructure project reference Application project
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Property> Properties { get; set; }
    }
}
