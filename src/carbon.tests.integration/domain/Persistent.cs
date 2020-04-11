using System;
using System.Linq;
using carbon.core.domain.model;
using carbon.persistence.features;
using carbon.runner.database.transforms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NUnit.Framework;

namespace carbon.tests.integration.domain
{
    [TestFixture]
    public class Persistent
    {
        private string ConnectionString { get; } =
            "server=zeryter.xyz;database=carbonTest;user=carbonTest;password=the_game";

        private DbContext GetDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            var options = optionsBuilder.UseMySql(ConnectionString);
            return new CoreDbContext(options.Options);
        }
        
        [SetUp]
        public void Setup()
        {
            var obj = new Runner(
                ConnectionString, 
                false, 
                true, 
                 dbName: "carbonTest");

        }
    }
}