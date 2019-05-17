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
	    Console.WriteLine("Enter the number of songs");
	    int n1=Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<n1;i++)
        {
            string s = Console.ReadLine();
            string[] s1 = s.Split(',');
            Song x = new Song(s1[0], s1[1], s1[2], DateTime.ParseExact(s1[3], "dd-MM-yyyy", null), double.Parse(s1[4]), int.Parse(s1[5]));
            list.Add(x);
        }
	   

        SortedDictionary<string, int>  a=Song.CalculateTypeCount(list);
        Console.WriteLine("{0} {1,15}", "Song type", "Count");
        foreach(var s in a)
        {
            Console.WriteLine("{0} {1,15}",s.Key,s.Value);
        }
    }
}