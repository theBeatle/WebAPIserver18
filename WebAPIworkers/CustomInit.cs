using System.Data.Entity;

namespace WebAPIworkers
{
    internal class CustomInit<T> : DropCreateDatabaseIfModelChanges<Factory>
    {
        protected override void Seed(Factory context)
        {
            base.Seed(context);
            context.Workers.Add(new Worker
            {
                FirstName = "Petro",
                LastName = "Petrenko",
                Age = 66,
                Salary = 13000m
            });

            context.Workers.Add(new Worker
            {
                FirstName = "Ivan",
                LastName = "Ivanenko",
                Age = 36,
                Salary = 19000m
            });

            context.Workers.Add(new Worker
            {
                FirstName = "Volodymur",
                LastName = "Klichko",
                Age = 44,
                Salary = 9999999m
            });
            context.SaveChanges();
        }
    }
}