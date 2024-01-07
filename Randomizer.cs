using AutoBogus;

namespace Jvu.Test.SharedLib.NonTsDeps
{
  public class Randomizer
  {
    public string RandomString => AutoFaker.Generate<string>();
    public int RandomInt => AutoFaker.Generate<int>();
    public bool RandomBool => AutoFaker.Generate<bool>();
    
    public T GetRandom<T>()
    {
      return AutoFaker.Generate<T>();
    }
  }
}
