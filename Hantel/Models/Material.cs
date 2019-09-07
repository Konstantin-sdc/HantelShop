namespace HantelShop.Models {

    /// <summary>Материал</summary>
    public class Material : AbstractElement {
        /// <summary>Создаёт новый экземпляр класса <see cref="Material"/></summary>
        /// <param name="name">Имя</param>
        public Material(string name) : base(name) { }
        /// <summary>Плотность</summary>
        public double Density { get; set; }
    }

}