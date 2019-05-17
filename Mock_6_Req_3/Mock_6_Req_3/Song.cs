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
    public Song(string name, string artist, string songType, double rating, int numberOfDownloads, DateTime dateDownloaded)
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

    public static Song CreateSong(string details)
    {
        string[] a = details.Split(',');
        Song s1 = new Song(a[0], a[1], a[2], Double.Parse(a[3]), int.Parse(a[4]), DateTime.ParseExact(a[5], "dd-MM-yyyy", null));
        return s1;
    }
}