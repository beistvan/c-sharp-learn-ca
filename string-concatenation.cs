using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Once upon a time, ";
      string middle = "there was a princess and the prince, ";
      string end = "and they lived happily afterall.";

      // Concatenate the string and the variables
      string story = beginning + middle + end;

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}

