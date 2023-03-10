using Microsoft.EntityFrameworkCore;

namespace SalesApi.Models;

public class SalesDbContext :  DbContext {

public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<OrderLines> OrderLines { get; set; }
    
    public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options) { }


}
