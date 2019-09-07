using System.Data.Entity;
namespace HantelShop.Models {

  /// <summary>Товар</summary>
  public class Merchandise : AbstractElement {
    /// <summary>Создаёт новый экземпляр класса <see cref="Merchandise"/></summary>
    /// <param name="product">Продукт</param>
    public Merchandise(AbstractElement product) {
      Product = product;
      Name = product.Name;
    }
    /// <summary>Создаёт новый экземпляр класса <see cref="Merchandise"/></summary>
    /// <param name="name">Имя</param>
    /// <param name="product">Продукт</param>
    public Merchandise(string name, AbstractElement product) : base(name) {
      Product = product;
    }

    /// <summary>Продукт</summary>
    public AbstractElement Product { get; set; }
    /// <summary>Цена за единицу</summary>
    public decimal Price { get; set; }
  }

  /// <summary>Абстрактный класс для взаимодействий с товаром</summary>
  public abstract class MerchandiseAction : AbstractBase {
    /// <summary>Создаёт новый экземпляр класса <see cref="Merchandise"/></summary>
    /// <param name="merchandise">Товар</param>
    protected MerchandiseAction(Merchandise merchandise) {
      Merchandise = merchandise;
    }
    /// <summary>Товар</summary>
    public Merchandise Merchandise { get; set; }
  }

  /// <summary>Товар на складе</summary>
  public class Storage : MerchandiseAction {
    /// <summary>Создаёт новый экземпляр класса <see cref="Storage"/></summary>
    /// <param name="merchandise">Товар</param>
    /// <param name="count">Количество</param>
    public Storage(Merchandise merchandise, int count = 1) : base(merchandise) {
      Merchandise = merchandise;
      Name = merchandise.Name;
      Count = count;
    }
    /// <summary>Доступное количество</summary>
    public double Count { get; set; }
  }

  /// <summary>Покупка</summary>
  public class Purchase : Storage {
    /// <summary>Создаёт новый экземпляр класса <see cref="Purchase"/></summary>
    /// <param name="merchandise">Товар</param> 
    /// <param name="user">Пользователь</param>
    /// <param name="count">Количество</param>
    public Purchase(ApplicationUser user, Merchandise merchandise, int count = 1) : base(merchandise, count) {
    }

    /// <summary>Покупатель</summary>
    public ApplicationUser User { get; set; }
    /// <summary>Стоимость</summary>
    public decimal Cost { get; set; }
  }

  /// <summary>Товар в избранном</summary>
  public class Favorite : MerchandiseAction {
    /// <summary>Создаёт новый экземпляр класса <see cref="Favorite"/></summary>
    /// <param name="merchandise">Товар</param>
    /// <param name="user">Пользователь</param>
    public Favorite(Merchandise merchandise, ApplicationUser user) : base(merchandise) {
      Merchandise = merchandise;
      User = user;
    }
    /// <summary>Пользователь</summary>
    public ApplicationUser User { get; set; }
  }
}