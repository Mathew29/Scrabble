using Microsoft.VisualStudio.TestTools.UnitTesting;
using Letters.Models;

namespace Letters.Tests
{
  [TestClass]
  public class LettersTests
  {

    // [TestMethod]
    // public void GetValueFromLetter_DoIntegersMatch_Int()
    // {
    //   // Arrange
    //   Words word = new Words('A');
    //
    //   int letter = word.GetValueFromLetter();
    //   // Act
    //
    //
    //   // Assert
    //   Assert.AreEqual(1, letter);
    // }
    [TestMethod]
    public void TakeLetterReturnOne_ReturnLetterValuesOne_Int()
    {
      string cat = "zgk";
      Words words = new Words();
      // Words word = new Words('I');
      // words.Words(cat, 3);
      Assert.AreEqual(17, words.ReturnValueFromDictionary(cat));
    }
  }
}
