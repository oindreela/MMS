using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<Song> list=new List<Song>();
	    SongBO sb = new SongBO();
	    Console.WriteLine("Enter the number of Songs:");
	    int n = Convert.ToInt32(Console.ReadLine());
	    for(int i=0;i<n;i++)
        {
            string s = Console.ReadLine();
            list.Add(Song.CreateSong(s));
        }
	    Console.WriteLine("Enter a search type:\n1.Song Type\n2.Date of Download\n3.Rating");
	    int choice=Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
                Console.WriteLine("Enter the type:");
                string s = Console.ReadLine();
                List<Song> stypeList = new SongBO().FindSong(list, s);
                Console.WriteLine();
                if (stypeList.Count == 0)
                {
                    Console.WriteLine("No song ");
                }
                else
                {
                    Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", "Name", "Artist", "Song Type", "Rating", "No of Download", "Date of Download");
                    foreach (Song c in stypeList)
                    {
                        Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", c.Name, c.Artist, c.SongType, c.Rating, c.NumberOfDownloads, c.DateDownloaded);
                    }
                }
                break;

            case 2:
                Console.WriteLine("Enter the type:");
                DateTime a = DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy",null);
                List<Song> dtypeList = new SongBO().FindSong(list, a);
                Console.WriteLine();
                if (dtypeList.Count == 0)
                {
                    Console.WriteLine("No such cab is present");
                }
                else
                {
                    Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", "Name", "Artist", "Song Type", "Rating", "No of Download", "Date of Download");
                    foreach (Song c in dtypeList)
                    {
                        Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", c.Name, c.Artist, c.SongType, c.Rating, c.NumberOfDownloads, c.DateDownloaded);
                    }
                }
                break;

            case 3:
                Console.WriteLine("Enter the type:");
                double x = double.Parse(Console.ReadLine());
                List<Song> xtypeList = new SongBO().FindSong(list, x);
                Console.WriteLine();
                if (xtypeList.Count == 0)
                {
                    Console.WriteLine("No such cab is present");
                }
                else
                {
                    Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", "Name", "Artist", "Song Type", "Rating", "No of Download", "Date of Download");
                    foreach (Song c in xtypeList)
                    {
                        Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", c.Name, c.Artist, c.SongType, c.Rating, c.NumberOfDownloads, c.DateDownloaded);
                    }
                }
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}