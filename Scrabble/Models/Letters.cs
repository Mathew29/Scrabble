using System;
using System.Collections.Generic;

namespace Letters.Models
{
  public class Words
  {
    private string _words;
    Dictionary<char, int> scrabbleDict = new Dictionary<char, int>()
    {{'A', 1},{'E', 1},{'I', 1},{'O', 1},{'U', 1},{'L', 1},{'N', 1},{'R', 1},{'S', 1},{'T', 1},
    {'G', 2}, {'D', 2},
    {'B', 3},{'C', 3},{'M', 3},{'P', 3},
    {'F', 4},{'H', 4},{'V', 4},{'W', 4},{'Y', 4},
    {'K', 5},
    {'J', 8},{'X', 8},
    {'Q', 10},{'Z', 10}
  };

  public Words ()
  {

  }
  //
  // public int GetValueFromLetter()
  // {
  //   if (_word == 'A')
  //   {
  //     int letter = 1;
  //     return letter;
  //   }
  //     return 0;
  // }
  public int ReturnValueFromDictionary(string words)
  {

    string input = words.ToUpper();
    int value = 0;
    char[] letters = input.ToCharArray();
    foreach(char letter in letters)
    {
      if(scrabbleDict.ContainsKey(letter))
      {
        value += scrabbleDict[letter];
      }
    }
    return value;

  }

  // char[] letters = word.ToCharArray();
  // total = 0;
  // for (int i = 0; i < letters.Length; i++)
  // {
  //   if (letters[i] == Dictionary<char, int>)
  //   {
  //     total += 1;

  // char[] letters = word.ToCharArray();
  // total = 0;
  // for (int i = 0; i < letters.Length; i++)
  // {
  //   foreach (Dictionary<char, int> item in scrabbleDict)
  // {
  //   return item.Key;
  //   }
  //   if (letters[i] == )
  // }

  }
}
