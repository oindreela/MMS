using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SongBO
{
    public List<Song> FindSong(List<Song> SongList, string type)
    {
        var newlist = from p in SongList
                      where p.SongType == type
                      select p;
        List<Song> sList = newlist.ToList();
        return sList;
    }
    public List<Song> FindSong(List<Song> SongList, DateTime dateCreated)
    {
        var newlist = from p in SongList
                      where p.DateDownloaded==dateCreated
                      select p;
        List<Song> sList = newlist.ToList();
        return sList;
    }
    public List<Song> FindSong(List<Song> SongList, double rating)
    {
        var newlist = from p in SongList
                      where p.Rating == rating
                      select p;
        List<Song> sList = newlist.ToList();
        return sList;
    }
}