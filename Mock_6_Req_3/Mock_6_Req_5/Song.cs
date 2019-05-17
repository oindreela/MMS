using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Song
{
    string _name;
    string _artist;
    string _songType;
    double _rating;
    int _numberOfDownloads;
    DateTime _dateDownloaded;

    public Song() { }
    public Song(string name, string artist, string songType, DateTime dateDownloaded, double rating, int numberOfDownloads)
    {
        _name = name;
        _artist = artist;
        _songType = songType;
        _rating = rating;
        _numberOfDownloads = numberOfDownloads;
        _dateDownloaded = dateDownloaded;
    }

    public string Name { get { return _name; } set { _name = value; } }
    public string Artist { get { return _artist; } set { _artist = value; } }
    public string SongType { get { return _songType; } set { _songType = value; } }
    public double Rating { get { return _rating; } set { _rating = value; } }
    public int NumberOfDownloads { get { return _numberOfDownloads; } set { _numberOfDownloads = value; } }
    public DateTime DateDownloaded { get { return _dateDownloaded; } set { _dateDownloaded = value; } }

    public static SortedDictionary<string, int> CalculateTypeCount(List<Song> list)
    {
        SortedDictionary<string, int> a = new SortedDictionary<string, int>();
        List<string> x = new List<string>();
        foreach(Song s in list)
        {
            x.Add(s.SongType);
        }

        foreach(string z in x.Distinct())
        {    int count = 0;
            foreach (Song p in list)
            {
                if (z == p.SongType)
                    count++;
            }
            a.Add(z, count);
        }
        return a;

    }




}