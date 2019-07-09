using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
    */
      Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>()
      { { "Emily", "Space Fan" }, { "Addam", "Podcast Fan" }
      };

      // Add several more words and their definitions
      wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
      wordsAndDefinitions.Add("Heather", "Danish Fan");

      /*
          Use square brackets to get the definition of two of the
          words and then output them to the console
      */
      Console.WriteLine(wordsAndDefinitions["Heather"]);
      Console.WriteLine(wordsAndDefinitions["Awesome"]);
      /*
          Below, loop over the wordsAndDefinitions dictionary to get the following output:
              The definition of (WORD) is (DEFINITION)
              The definition of (WORD) is (DEFINITION)
              The definition of (WORD) is (DEFINITION)
      */
      foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
      {
        Console.WriteLine($"The definition of {word.Key} is {word.Value}");
      }
    }
  }
}
