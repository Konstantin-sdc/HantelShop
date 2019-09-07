namespace HantelShop.Models {

    /// <summary>Производитель</summary>
    public class Manufacturer : AbstractBase {

        /// <summary>Создаёт новый экземпляр класса <see cref="Manufacturer"/></summary>
        /// <param name="name">Имя</param>
        public Manufacturer(string name) : base(name) { }

        /// <summary>Адрес сайта</summary>
        public string Site { get; set; }

    }
}