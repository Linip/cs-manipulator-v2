using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;
using Manipulator.Shared.Models;

namespace Manipulator.Shared.Infrastructure
{
    public class ManipulatorRepository
    {
        public readonly SqliteContext EntityManager;

        public ManipulatorRepository(SqliteContext dbContext)
        {
            EntityManager = dbContext;
        }
        
        public ControlObject FindOneByName(string name)
        {
            IQueryable<ControlObject> manipulatorQuery =
                from controlObject in EntityManager.Manipulators
                where controlObject.Name == name
                select controlObject;

            var manipulator = manipulatorQuery.FirstOrDefault();

            return manipulator ?? new ControlObject() {Name = name};
        }
    }
}