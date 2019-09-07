using System.Data.Entity;

namespace HantelShop.Models {
    public class HantelContext : DbContext {
        public HantelContext() : base("HantelDbConnection") { }

        public DbSet<Fixator> Fixators { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Grief> Griefs { get; set; }
        public DbSet<HantelClass> Hantels { get; set; }
        public DbSet<SeparableHantel> SeparableHantels { get; set; }
    }
}