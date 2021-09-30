using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    public string Name {get; set;}
    // public int Id {get;}
    public List<Record> RecordList {get; set;}

    public Artist(string name)
    {
      Name = name;
      // Id = id;
      RecordList = new List<Record> {};
    }

    public void MakeRecordList()
    {
      List<Record> allRecords = Record.GetAll();
      foreach(Record record in allRecords)
      {
        if (Name == record.Artist)
        {
          RecordList.Add(record);
        }
      }
    }


  }
}