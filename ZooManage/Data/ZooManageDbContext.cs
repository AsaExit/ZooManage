using Microsoft.EntityFrameworkCore;
using ZooManage.Models;

namespace ZooManage.Data
{
    public class ZooManageDbContext:DbContext
    {
        public ZooManageDbContext(DbContextOptions<ZooManageDbContext> options) : base(options) { }
        public DbSet<Animal>? Animals { get; set; }
        public DbSet<Veterinary>? Veterinaries { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

           

        //    modelBuilder.Entity<Animal>().HasData(new Animal {Id= 11, AnimalName = "Tiger", Species = "Mammel", AnimalNickName = "Lilla Missen" });
        //    modelBuilder.Entity<Animal>().HasData(new Animal {Id= 12, AnimalName = "Cow", Species = "Mammel", AnimalNickName = "Muis" });
        //}
    }
}
