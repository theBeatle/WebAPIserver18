namespace WebAPIworkers
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    /// <summary>
    /// Class-context for DataBase
    /// </summary>
    public class Factory : DbContext
    {
        /// <summary>
        /// Constructor method for DB contex class
        /// </summary>
        public Factory()
            : base("name=Factory")
        {
            Database.SetInitializer<Factory>(new CustomInit<Factory>());
        }
        /// <summary>
        /// Table for Workers
        /// </summary>
        public virtual DbSet<Worker> Workers { get; set; }
    }

    /// <summary>
    /// Model class for "Worker" entity
    /// </summary>
    public class Worker
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Worker's first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Worker's last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Worker's age
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Worker's salary, decimal type 
        /// </summary>
        public decimal Salary { get; set; }
    }
}