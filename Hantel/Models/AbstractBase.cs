using System.ComponentModel.DataAnnotations;

namespace HantelShop.Models {

  /// <summary>Абстрактный класс. Базовый набор данных</summary>
  public abstract class AbstractBase {
    /// <summary>Создаёт пустой экземпляр</summary>
    protected AbstractBase() { }
    /// <summary>Создаёт экземпляр с определённым именем</summary>
    /// <param name="name">Имя</param>
    protected AbstractBase(string name) {
      Name = name;
    }

    /// <summary>Ключ</summary>
    [Key]
    public int Id { get; set; }
    /// <summary>Наименование</summary>
    public string Name { get; set; }
    /// <summary>Описание</summary>
    public string Description { get; set; }
    /// <summary>Артикул или код</summary>
    public string Code { get; set; }
  }

  /// <summary>Абстрактный класс для неструктурных свойств.</summary>
  public abstract class AbstractElement : AbstractBase {
    /// <summary>Создаёт новый экземпляр</summary>
    protected AbstractElement() { }
    /// <summary>Создаёт экземпляр с заданным именем</summary>
    /// <param name="name">Имя</param>
    protected AbstractElement(string name) : base(name) { }
    /// <summary>Создаёт экземпляр с заданным именем и моделью</summary>
    /// <param name="name">Имя</param>
    /// <param name="model">Модель</param>
    protected AbstractElement(string name, string model) : base(name) {
      Model = model;
    }
    /// <summary>Производитель</summary>
    public Manufacturer Manufacturer { get; set; }
    /// <summary>Модель</summary>
    public string Model { get; set; }
    /// <summary>Единица измерения</summary>
    public MetricUnit Unit { get; set; }
  }

  /// <summary>Единица измерения</summary>
  public class MetricUnit : AbstractBase {
    /// <summary>Создаёт новый экземпляр класса <see cref="MetricUnit"/></summary>
    /// <param name="name">Имя</param>
    public MetricUnit(string name) : base(name) { }
  }

  /// <summary>Деталь гантели. Абстрактный класс.</summary>
  public abstract class HantelDetail : AbstractElement {
    /// <summary>Создаёт новый экземпляр класса <see cref="HantelDetail"/></summary>
    /// <param name="name">Имя</param>
    protected HantelDetail(string name) : base(name) { }
    /// <summary>Создаёт новый экземпляр класса <see cref="HantelDetail"/></summary>
    /// <param name="name">Имя</param>
    /// <param name="model">Модель</param>
    public HantelDetail(string name, string model) : base(name, model) { }
    /// <summary>Создаёт новый экземпляр класса <see cref="HantelDetail"/></summary>
    /// <param name="name">Имя</param>
    /// <param name="model">Модель</param>
    /// <param name="weight">Вес</param>
    public HantelDetail(string name, string model, int weight) : base(name, model) {
      Weight = weight;
    }

    /// <summary>Материал корпуса</summary>
    public Material BodyMaterial { get; set; }
    /// <summary>Материал покрытия</summary>
    public Material CoatingMaterial { get; set; }
    /// <summary>Форма</summary>
    public Form Form { get; set; }
    /// <summary>Место покрытия</summary>
    public CoatingPlace CoatingPlace { get; set; }

    //Рельеф поверхности SurfaceRelief

    /// <summary>Масса</summary>
    public int Weight { get; set; }
    /// <summary>Длина</summary>
    public int Length { get; set; }
    /// <summary>Посадочный диаметр</summary>
    public int LandingDiameter { get; set; }
    /// <summary>Габаритный диаметр</summary>
    public int OverallDiameter { get; set; }
  }

  /// <summary>Форма предмета</summary>
  public class Form : AbstractBase {
    /// <summary>Создаёт новый экземпляр класса <see cref="Form"/></summary>
    /// <param name="name">Имя</param>
    public Form(string name) : base(name) { }
  }

  /// <summary>Место покрытия</summary>
  public class CoatingPlace : AbstractBase {
    /// <summary>Создаёт новый экземпляр класса <see cref="CoatingPlace"/></summary>
    /// <param name="name">Имя</param>
    public CoatingPlace(string name) : base(name) { }
  }
}