using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFramework;
using MySqlConnector;
using OrderManagement;

public class AppDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // 连接字符串为你的 MySQL 数据库连接信息
        optionsBuilder.UseMySQL("server=localhost; database=myDatabase; user=myUser; password=myPassword;");
    }
}

