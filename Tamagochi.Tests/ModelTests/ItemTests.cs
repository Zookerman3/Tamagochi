using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Game.Models;
using System;

namespace Game.Tests
{
  [TestClass]
  public class TamagochiTests : IDisposable
  {

    public void Dispose()
    {
      Tamagochi.ClearAll();
    }

    [TestMethod]
    public void TamagochiConstructor_CreatesInstanceOfTamagochi_Tamagochi()
    {
      Tamagochi newTamagochi = new Tamagochi("test");
      Assert.AreEqual(typeof(Tamagochi), newTamagochi.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";

      //Act
      Tamagochi newTamagochi = new Tamagochi(description);
      string result = newTamagochi.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Tamagochi newTamagochi = new Tamagochi(description);

      //Act
      string updatedDescription = "Do the dishes";
      newTamagochi.Description = updatedDescription;
      string result = newTamagochi.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_TamagochiList()
    {
      // Arrange
      List<Tamagochi> newList = new List<Tamagochi> { };

      // Act
      List<Tamagochi> result = Tamagochi.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Tamagochi newTamagochi1 = new Tamagochi(description01);
      Tamagochi newTamagochi2 = new Tamagochi(description02);
      List<Tamagochi> newList = new List<Tamagochi> { newTamagochi1, newTamagochi2 };

      //Act
      List<Tamagochi> result = Tamagochi.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}