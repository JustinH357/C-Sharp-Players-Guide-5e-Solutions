Sword sword = new Sword(Materials.Iron,Gemstones.None,5,10);
Sword sword2 = sword with { materials = Materials.Bronze, gemstones = Gemstones.Sapphire, length = 3.5, crossguardWidth = 5 };
Sword sword3 = sword with { materials = Materials.Steel, gemstones = Gemstones.Diamond };

Console.WriteLine(sword);
Console.WriteLine(sword2);
Console.WriteLine(sword3);


public record Sword(Materials materials, Gemstones gemstones, double length, double crossguardWidth);

public enum Materials { Wood, Bronze, Iron, Steel, Binarium }
public enum Gemstones { Emerald, Amber, Sapphire, Diamond, Bitstone, None }

