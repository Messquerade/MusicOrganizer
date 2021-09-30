using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistTests
  {
    [TestMethod]
    public void TestConstructor_CheckType_Artist()
    {
      Artist testArtist = new Artist("John Smith");
      Assert.AreEqual(typeof(Artist), testArtist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      Artist testArtist = new Artist("John Smith");
      Assert.AreEqual("John Smith", testArtist.Name);
    }

    [TestMethod]
    public void SetName_ReturnName_String()
    {
      Artist testArtist = new Artist("John Smith");
      testArtist.Name = "Jane Doe";
      Assert.AreEqual("Jane Doe", testArtist.Name);
    }

    [TestMethod]
    public void GetRecordList_ReturnEmptyList_List()
    {
      Artist testArtist = new Artist("John Smith");
      List<Record> testList = new List<Record> {};
      CollectionAssert.AreEqual(testList, testArtist.RecordList);
    }

    [TestMethod]
    public void MakeRecordList_SetRecordList_List()
    { 
      Record testRecord = new Record("test");
      testRecord.AddArtist("John Smith");
      List<Record> allRecordsByArtist = new List<Record> {testRecord};
      Artist testArtist = new Artist("John Smith");
      testArtist.MakeRecordList();
      CollectionAssert.AreEqual(allRecordsByArtist, testArtist.RecordList);
    }


  }
}