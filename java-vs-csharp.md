# Taal Java vs C#

**BIAS WARNING**

En een nuance: project met Kotlin op het Java-platform, hartstikke modern en mooi.

Maar _de taal_ Java vs C#?

- C# heeft extension methods
- C# heeft properties
  - lombok legt het af tegen hoe C# ze implementeert
- C# heeft object initializers. Scheelt een hoop constructors en gewoon prettiger qua leesbaarheid
  ```cs
  var bla = new Ding { Iets = "hoi", Bla = "Huh" };
  ```
- C# heeft operator overloading. zo fijn:
  ```cs
  if (bla == "hoi")
  // ipv
  if ("hoi".equals(bla))
  ```
- C# heeft async/await
- C# heeft LINQ
  - Java streams zijn ok.
- Bij C# hoef je niet elke exception to definieren
- C# heeft using en await using
- C# heeft checked exceptions voor omgaan met arithmetic overflow
- Methoden bij Java classes zijn `virtual` by default

qua runtime:

- .NET heeft runtime generics, maakt een hoop dingen mooier
  - geen Integer/Boolean/Double classes voor nullability, maar 
    `Nullable<int>`, `Nullable<double>` - ook te schrijven als `int?` en `double?`
  - DI: `builder.Services.AddTransient<IMyService, MyService>();`
  - serialization: `JsonSerializer.Deserialize<Product>(jsonString);`

  Java's generics zijn compile-time, @ runtime heb je te maken met `List<Object>`



