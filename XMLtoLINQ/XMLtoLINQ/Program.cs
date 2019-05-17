using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLtoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            //XDocument xmlDoc = XDocument.Load(@"C:\Users\CGI\source\repos\XMLtoLINQ\XMLtoLINQ\site.xml");
            //var q = from c in xmlDoc.Descendants("site")
            //        select (string)c.Element("name") + " -- " + (string)c.Element("url");
            //foreach (string name in q)
            //{
            //    Console.WriteLine("Site: " + name);
            //}

            //XDocument xmlDoc = XDocument.Load(@"C:\Users\CGI\source\repos\XMLtoLINQ\XMLtoLINQ\site.xml");
            //var q = from c in xmlDoc.Descendants("site")
            //        where c.Attribute("technical").Value == "true"
            //        select (string)c.Element("name") + " ==>" + (string)c.Element("url");
            //foreach (string name in q)
            //{
            //    Console.WriteLine("Site: " + name);
            //}


            //XDocument xmlDoc = XDocument.Load(@"C:\Users\CGI\source\repos\XMLtoLINQ\XMLtoLINQ\site.xml");
            //var q = from c in xmlDoc.Descendants("site")
            //        where c.Attribute("technical").Value == "true"
            //        select new
            //        {
            //            name = c.Element("name").Value,
            //            url = c.Element("url").Value
            //        };
            //foreach (var obj in q)
            //{
            //    Console.WriteLine("Site: " + obj.name + " -- " + obj.url);
            //}


            //XDocument xdocument = XDocument.Load(@"C:\Users\CGI\source\repos\XMLtoLINQ\XMLtoLINQ\Employee.xml");
            //xdocument.Save("Temp2.xml");
            //Console.WriteLine("Data Written to a file");
            //IEnumerable<XElement> employees = xdocument.Elements();
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}


            //XElement xelement = XElement.Load("Employee.xml");
            //IEnumerable<XElement>  employees = xelement.Elements();
            //Console.WriteLine("List of all Employee Names :");
            //foreach (var e in employees)
            //{
            //    Console.WriteLine(e.Element("Name").Value+" "+ e.Element("EmpID").Value);
            //}


            //XElement xelement = XElement.Load("Employee.xml");
            //var name = from nm in xelement.Elements("Employee")
            //           where (string)nm.Element("Sex") == "Female"
            //           select nm.Element("Name");
            //Console.WriteLine("Details of Female Employees:");
            //foreach (XElement xEle in name)
            //    Console.WriteLine(xEle.Value);

            //XElement xelement = XElement.Load("Employee.xml");
            //var homePhone = from phoneno in xelement.Elements("Employee")
            //                where (string)phoneno.Element("Sex") == "Female"
            //                select phoneno;
            //var name = from nm in xelement.Elements("Employee")
            //           where (string)nm.Element("Sex") == "Female"
            //           select nm.Element("Name");
            //Console.WriteLine("List HomePhone Nos.");
            //foreach (XElement xEle in homePhone)
            //{
            //    Console.WriteLine(xEle.Element("Name").Value + " "+xEle.Element("Phone").Value);
            //}


            //XElement xelement = XElement.Load("Employee.xml");
            //var name = from nm in xelement.Elements("Employee")
            //           where (string)nm.Element("Sex") == "Female"
            //           select nm;
            //Console.WriteLine("Details of Female Employees:");
            //foreach (XElement xEle in name)
            //{
            //    Console.WriteLine(xEle.Element("Name").Value);
            //    if (xEle.Element("Phone").Attribute("Type").Value == "Home")
            //        Console.WriteLine(xEle.Element("Phone").Value);

            //XElement obj1 = new XElement("Name", "parag");
            //XElement obj2 = new XElement("Id", "M0011");
            //XElement obj3 = new XElement("Users",
            //    new XElement("User",
            //    new XElement("Username", "user1"),
            //    new XElement("Password", "Password1")
            //    ),
            //    new XElement("User",
            //    new XElement("Username", "user2"),
            //    new XElement("Password", "Password2")
            //    ),
            //    new XElement("User",
            //    new XElement("Username", "user3"),
            //    new XElement("Password", "Password3")
            //    )
            //    );
            //XElement xEle = XElement.Load("User.xml");
            //xEle.Add(obj3);
            //xEle.Save("User.xml");
            //Console.WriteLine(obj3);
            //Console.WriteLine("Data Added inside  the file");

            //XElement obj3 = new XElement("Users",
            //     new XElement("User", new XAttribute("Type","Admin"),
            //     new XElement("Username", "user4"),
            //     new XElement("Password", "Password4")
            //     )
            //     );
            //XElement xEle = XElement.Load("User.xml");

            //Console.WriteLine(obj3);
            //xEle.Add(obj3);
            //xEle.Save("User.xml");


            //XElement xelement = XElement.Load("User.xml");
            //var name = from nm in xelement.Elements("User")
            //           where nm.Attribute("Type").Value == "Admin"
            //           select nm;
            //Console.WriteLine("Details of Admin:");
            //foreach (var x in name)
            //{
            //    Console.WriteLine(x.Element("Username").Value);
            //}

            //XElement xelement = XElement.Load("Employee.xml");
            //var name = from nm in xelement.Elements("Employee")
            //           where (string)nm.Element("Sex") == "Female"
            //           select nm;
            //Console.WriteLine("Details of Female Employees:");
            //foreach (XElement xEle in name)
            //{
            //    Console.WriteLine(xEle.Element("Name").Value);
            //    if (xEle.Element("Phone").Attribute("Type").Value == "Home")
            //        Console.WriteLine(xEle.Element("Phone").Value);

            //XDocument X_DOC = XDocument.Load(@"C:\Users\CGI\source\repos\XMLtoLINQ\XMLtoLINQ\site.xml");
            //X_DOC.Root.Elements("site").Remove();
            //X_DOC.Save(@"C:\Users\CGI\source\repos\XMLtoLINQ\XMLtoLINQ\site.xml");


            //XElement X_DOC = XElement.Load(@"C:\Users\CGI\source\repos\XMLtoLINQ\XMLtoLINQ\site.xml");
            //var res = from e in X_DOC.Elements()
            //          where e.Attribute("Techncal").Value == "true"
            //          select e;
            //XElement obj = (XElement)res;
            ////obj.Save(@"C: \Users\CGI\source\repos\XMLtoLINQ\XMLtoLINQ\site.xml");
            ////X_DOC.Save(@"C:\Users\CGI\source\repos\XMLtoLINQ\XMLtoLINQ\site.xml");


            //XDocument xdoc = XDocument.Load(@"C:\Users\CGI\source\repos\XMLtoLINQ\XMLtoLINQ\site.xml");
            //xdoc.Descendants("site").Where
            //    (x => x.Attribute("technical").Value == "true").Remove();
            //xdoc.Save(@"C:\Users\CGI\source\repos\XMLtoLINQ\XMLtoLINQ\site.xml");
            //Console.WriteLine("Deleted");
            //Console.ReadLine();

            XDocument xdoc = XDocument.Load(@"C:\Users\CGI\source\repos\XMLtoLINQ\XMLtoLINQ\site.xml");
            xdoc.Descendants("site").Where
                (x => x.Attribute("technical").Value != "true").Remove();
            xdoc.Save(@"C:\Users\CGI\source\repos\XMLtoLINQ\XMLtoLINQ\site.xml");
            Console.WriteLine("Deleted");
            Console.ReadLine();
        }
    }
}

