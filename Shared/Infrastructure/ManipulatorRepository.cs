using System.Data.Entity;
using System.Linq;
using Manipulator.Helpers;
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

            var mm = EntityManager.Manipulators
                .Where(m => m.Name == name)
                .Include(m => m.Sensors)
                .First();

            var manipulator = manipulatorQuery.FirstOrDefault();
            
            if (manipulator == null)
            {
                manipulator = new ControlObject() {Name = name};
                InitHelper.InitManipulator(manipulator, EntityManager);
            }

            return manipulator;
        }
    }
}