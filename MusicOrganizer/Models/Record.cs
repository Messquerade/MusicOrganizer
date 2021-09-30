using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Record
  {
    public string Title { get; set; }
    public int Id{get;}
    private static List<Record> _instances = new List<Record>{};
    public string Artist {get; set;}

    

    public Record(string title)
    {
      Title = title;
      _instances.Add(this);
      Id = _instances.Count;
      Artist = "";
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Record> GetAll()
    {
      return _instances;
    }

    public static Record Find(int id)
    {
      return _instances[id - 1];
    }

    public void AddArtist(string name)
    {
      Artist = name;
    }
  }
}



