using System.Data.Entity;

namespace SimpleWPFApp.Data
{
    public partial class TaskDb : DbContext
    {
        public TaskDb() : base("name=Task"){}

        public virtual DbSet<Package> Package { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {}
    }
}