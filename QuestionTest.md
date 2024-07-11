```csharp
class Engine {
 private string engineType;
 private void SetEngine(string type) {
  engineType = type;
 }
}
class ElectricEngine : Engine {
  public string CheckEngine() {
      return engineType;
 }
}
class Program {
 static void Main() {
  Engine engine = new Engine();
  engine.SetEngine("toyota"); //error
  Console.WriteLine(engine.CheckEngine()); //error
  
  ElectricEngine ee = new ElectricEngine();
  ee.SetEngine("tesla"); //error
  Console.WriteLine(ee.CheckEngine());
 }
}
```