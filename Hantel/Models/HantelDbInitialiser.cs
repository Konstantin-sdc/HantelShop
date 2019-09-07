using System.Data.Entity;

namespace HantelShop.Models {
    public class HantelDbInitialiser : DropCreateDatabaseAlways<HantelContext> {
        protected override void Seed(HantelContext db) {
            db.Cargos.Add(new Cargo("Груз01"));
            db.Fixators.Add(new Fixator("Fixator01"));
            db.Griefs.Add(new Grief("Grief01"));
            db.Hantels.Add(new HantelClass("Hantel01"));
            db.SeparableHantels.Add(new SeparableHantel("SeparableHantel01"));
            base.Seed(db);
        }
    }
}