using Microsoft.EntityFrameworkCore;
using FactInterventionApi.Models;

namespace FactInterventionApi.Models
{
    public class FactInterventionContext : DbContext
    {
        public FactInterventionContext(DbContextOptions<FactInterventionContext> options)
            : base(options)
        {
        }
                 protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
    /////////This is where relations between tables in DB are specified
               
                modelBuilder.Entity<Building>()
                .HasKey(b => b.Id);

                modelBuilder.Entity<Battery>()
                .HasKey(x => x.Id);

                modelBuilder.Entity<Column>()
                .HasKey(x => x.Id);

                modelBuilder.Entity<Elevator>()
                .HasKey(x => x.Id);

                modelBuilder.Entity<Lead>()
                .HasKey(x => x.id);

                modelBuilder.Entity<Intervention>()  // New - for intervention
                .HasKey(x => x.id);

                modelBuilder.Entity<Customer>()  // New - for customers
                .HasKey(x => x.Id);

                // modelBuilder.Entity<Address>()  // New - for addresses
                // .HasKey(x => x.id);

                
                modelBuilder.Entity<Customer>()
                .HasMany(x => x.buildings) //customer has_many :buildings
                .WithOne( y => y.Customer)
                .HasForeignKey(z => z.customer_Id);
                
                modelBuilder.Entity<Building>()
                .HasMany(x => x.batteries) //building has_many    :batteries
                .WithOne( y => y.Building)
                .HasForeignKey(z => z.building_id);                
                
                // modelBuilder.Entity<Building>()
                // .HasOne(x => x.Address) //building belongs_to    :addresses
                // .WithOne( y => y.Building)
                // .HasForeignKey(z => z.building_id); 

                // modelBuilder.Entity<Address>()
                // .HasOne(x => x.Building) //building belongs_to    :addresses
                // .WithOne( y => y.Address)
                // .HasForeignKey(z => z.address_id);
                
                modelBuilder.Entity<Battery>()
                .HasMany(x => x.columns) //battery has_many :columns
                .WithOne(y => y.Battery)
                .HasForeignKey(z => z.battery_id);                

                modelBuilder.Entity<Column>() 
                .HasOne(x => x.Battery) //column belongs_to  :battery
                .WithMany(y => y.columns)
                .HasForeignKey(z => z.battery_id);

                modelBuilder.Entity<Column>() 
                .HasMany(x => x.elevators) //column has_many    :elevators
                .WithOne(y => y.columns)
                .HasForeignKey(z => z.column_id);

                modelBuilder.Entity<Elevator>() 
                .HasOne(x => x.columns) //elevator belongs_to :column
                .WithMany(y => y.elevators)
                .HasForeignKey(z => z.column_id);                
            }
        public DbSet<Battery> batteries { get; set; }
        public DbSet<Building> buildings { get; set; }
        public DbSet<Column> columns { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Elevator> elevators { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Lead> leads { get; set; }
        public DbSet<Intervention> interventions { get; set; }
    }
}