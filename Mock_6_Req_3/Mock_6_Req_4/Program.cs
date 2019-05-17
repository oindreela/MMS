using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<Song> songList = new List<Song>();
	    Console.WriteLine("Enter the number of the songs:");
	    int count = Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<count;i++)
        {
            string s = Console.ReadLine();
            Song a=Song.CreateSong(s);
            songList.Add(a);
        }
	    Console.WriteLine("Enter a type to sort:\n1.Sort by name\n2.Sort by Rating\n3.Sort by Popularity");
	    int choice=Convert.ToInt32(Console.ReadLine());
        //fill code here.
        switch (choice)
        {
            case 1:
                songList.Sort();
                Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", "Name", "Artist", "Song Type", "Date of Download", "Rating", "No of Downloads");
                foreach(Song s in songList)
                {
                    Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15:0.0} {5,15}", s.Name, s.Artist,s.SongType,s.DateDownloaded.ToString("dd-MM-yyyy"), s.Rating,s.NumberOfDownloads);
                    //fill code here.
                }
                break;
            case 2:
                RatingComparer a = new RatingComparer();
                songList.Sort(a);
                Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", "Name", "Artist", "Song Type", "Date of Download", "Rating", "No of Downloads");
                foreach (Song s in songList)
                {
                    Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15:0.0} {5,15}", s.Name, s.Artist, s.SongType, s.DateDownloaded.ToString("dd-MM-yyyy"), s.Rating, s.NumberOfDownloads);
                    //fill code here.
                }
                break;
            case 3:
                PopularityComparer b = new PopularityComparer();
                songList.Sort(b);
                Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", "Name", "Artist", "Song Type", "Date of Download", "Rating", "No of Downloads");
                foreach (Song s in songList)
                {
                    Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15:0.0} {5,15}", s.Name, s.Artist, s.SongType, s.DateDownloaded.ToString("dd-MM-yyyy"), s.Rating, s.NumberOfDownloads);
                    //fill code here.
                }
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }

	    
    }
}