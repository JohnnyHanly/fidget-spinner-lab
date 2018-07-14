using Microsoft.EntityFrameworkCore;

namespace fidget_spinner_lab
{
    public class StoreContext : DbContext
    {
        public DbSet<Store> stores { get; set; }
        public DbSet<Fidget_Spinner> fidget_spinners { get; set; }

        public DbSet<Store_Inventory> store_inventory { get; set; }

        public DbSet<Sale_Record> sales_records {get;set;}

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }
    }

}