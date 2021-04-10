using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shared;

namespace BlazorContactsApi
{
    public class ContactsContext:  DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        
        public ContactsContext(DbContextOptions<ContactsContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact { Id = 1, Name = "Carol Mason", Address = "123 Test St", City = "Overland Park", State = "KS", Zip = "66202" },
                new Contact { Id = 2, Name = "Amy Montoni", Address = "234 MyStreet", City = "Overland Park", State = "KS", Zip = "66207" },
                new Contact { Id = 3, Name = "Robert Morris", Address = "123 Way", City = "Overland Park", State = "KS", Zip = "66207" },
                new Contact { Id = 4, Name = "Richard Thurmond", Address = "123 Example St", City = "Overland Park", State = "KS", Zip = "66202" },
                new Contact { Id = 5, Name = "Michelle Williams", Address = "110 Example St", City = "Overland Park", State = "KS", Zip = "66202" },
                new Contact { Id = 6, Name = "Herbert White", Address = "123 Second", City = "Overland Park", State = "KS", Zip = "66207" },
                new Contact { Id = 7, Name = "Rick Thames", Address = "234 First", City = "Overland Park", State = "KS", Zip = "66202" }
            );
        }
    }
}
