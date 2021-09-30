using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ParentClassTests
  {
    [TestMethod]
    public void RecordConstructor_CreatesInstanceOfRecord_Record()
    {
    Record newRecord = new Record("test");
    Assert.AreEqual(typeof(Record), newRecord.GetType());
    }
    
    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
    string title = "Test";
    Record newRecord = new Record(title);
    string result = newRecord.Title;

    Assert.AreEqual(title, result);
    }

    

  }
}