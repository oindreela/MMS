using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Song:IComparable
{
    string _name;
    string _artist;
    string _songType;
    double _rating;
    int _numberOfDownloads;
    DateTime _dateDownloaded;

    public Song() { }
    public Song(string name, string artist, string songType, DateTime dateDownloaded,double rating, int numberOfDownloads)
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
        Song s1 = new Song(a[0], a[1], a[2], DateTime.ParseExact(a[3], "dd-MM-yyyy", null), Double.Parse(a[4]), int.Parse(a[5]));
        return s1;
    }

    public int CompareTo(object obj)
    {
        Song s = (Song)obj;
        return this._name.CompareTo(s.Name);
    }
}