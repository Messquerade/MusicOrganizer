using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class RecordTests : IDisposable
  {
    public void Dispose()
    {
      Record.ClearAll();
    }

    [TestMethod]
    public void RecordConstructor_CreatesInstanceOfRecord_Record()
    {
    Record newRecord = new Record("test");
    Assert.AreEqual(typeof(Record), newRecord.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
    string title = "Test";
    Record newRecord = new Record(title);
    string result = newRecord.Title;

    Assert.AreEqual(title, result);
    }
 
    [TestMethod]
    public void GetId_ReturnId_Integer()
    {
      Record newRecord = new Record("Test");
      Assert.AreEqual(1, newRecord.Id);
    }

    [TestMethod]
    public void SetTitle_UpdateTitle_String()
    {
      Record newRecord = new Record("Test");
      newRecord.Title = "Updated Value";
      Assert.AreEqual("Updated Value", newRecord.Title);
    }
    

  }
}