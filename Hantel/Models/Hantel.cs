namespace HantelShop.Models {

  /// <summary>Рукоять (гриф)</summary>
  public class Grief : HantelDetail {
    
    /// <summary>Создаёт новый экземпляр класса <see cref="Grief"/></summary>
    /// <param name="name">Имя</param>
    public Grief(string name) : base(name) { }
    
    /// <summary>Длина части, на которую навешивается груз.</summary>
    /// <remarks>Считается с одной стороны, от рукояти до края.</remarks>
    public int CargoLength { get; set; }
    
    /// <summary>Диаметр части, на которуюнавешивается груз.</summary>
    public int CargoDiameter { get; set; }
    
    /// <summary>Длина рукояти</summary>
    public int HandleLength { get; set; }
    
    /// <summary>Диаметр рукояти</summary>
    public int HandleDiameter { get; set; }
  }

  /// <summary>Фиксатор</summary>
  public class Fixator : HantelDetail {
    /// <summary>Создаёт новый экземпляр класса <see cref="Fixator"/></summary>
    /// <param name="name">Имя</param>
    public Fixator(string name) : base(name) { }
    /// <summary>Тип фиксатора</summary>
    public FixatorType FixatorType { get; set; }
  }

  public class FixatorType : AbstractBase {
    /// <summary>Создаёт новый экземпляр класса <see cref="FixatorType"/></summary>
    /// <param name="name">Имя</param>
    public FixatorType(string name) : base(name) {}
  }

  /// <summary>Груз</summary>
  public class Cargo : HantelDetail {
    /// <summary>Создаёт новый экземпляр класса <see cref="Cargo"/></summary>
    /// <param name="name">Имя</param>
    public Cargo(string name) : base(name) { }
    /// <summary>Материал наполнителя</summary>
    public Material FillerMaterial { get; set; }
  }

  /// <summary>Гантель</summary>
  public class HantelClass : Cargo {
    /// <summary>Создаёт новый экземпляр класса <see cref="HantelClass"/></summary>
    /// <param name="name">Имя</param>
    public HantelClass(string name) : base(name) { }
    /// <summary>Гриф</summary>
    public Grief Grief { get; set; }
    /// <summary>Груз</summary>
    public Cargo CargoPart { get; set; }
  }

  public class SeparableHantel : HantelClass {
    /// <summary>Создаёт новый экземпляр класса <see cref="SeparableHantel"/></summary>
    /// <param name="name">Имя</param>
    public SeparableHantel(string name) : base(name) {
    }
    /// <summary>Фиксатор</summary>
    public Fixator Fixator { get; set; }
  }
}