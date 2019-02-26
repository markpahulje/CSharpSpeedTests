using System.Linq; 
using System.Diagnostics;
using System;


     
public static class Program
{
 public static string ReplaceAtStringManipulation(this string s, int idx, char replaceChar)
    {
  if (string.IsNullOrEmpty(s) || idx >= s.Length || idx < 0) 
                    return s; 
 
        return s.Remove(idx, 1).Insert(idx, replaceChar.ToString());
    }
 
 public static string ReplaceAtLinq(this string value, int index, char newchar)
 {
  if (value.Length <= index)
   return value;
  else
   return string.Concat(value.Select((c, i) => i == index ? newchar : c));
 }

 public static string ReplaceAtCharArray(this string input, uint index, char newChar)
 {
  if (string.IsNullOrEmpty(input) || index >= input.Length) 
   return input;

  char[] chars = input.ToCharArray();
  chars[index] = newChar;
  return new string(chars);
 }

 public static void Main()
 {
  Stopwatch sw = new Stopwatch();
  sw.Start();
  Console.WriteLine("ReplaceAtCharArraySSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSs".ReplaceAtCharArray(70,'X')); 
  sw.Stop();
  Console.WriteLine("in {0} ticks.",sw.ElapsedTicks.ToString("N0")); 
  
  sw.Restart();
  Console.WriteLine("ReplaceAtLinqSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS".ReplaceAtLinq(70,'Y')); 
  sw.Stop();
  Console.WriteLine("in {0} ticks.",sw.ElapsedTicks.ToString("N0")); 
  
  sw.Restart();
  Console.WriteLine("ReplaceAtStringManipulationSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS".ReplaceAtStringManipulation(70,'Z')); 
  sw.Stop();
  Console.WriteLine("in {0} ticks.",sw.ElapsedTicks.ToString("N0")); 
  
 }
}
