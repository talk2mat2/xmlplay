// See https://aka.ms/new-console-template for more informationnam

using System.Xml;
using System.Text;
using System.Threading.Tasks;

namespace XmlPlay
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("working");
            XmlDocument doc = new XmlDocument();
            //doc.Load(@"C:\\Users\\Chukuwumasm\\Desktop\\projects\\cleanapi\\XmlPlay\\test.xml");
            string dir = AppDomain.CurrentDomain.BaseDirectory;

            string filePath = Path.Combine(dir, "test.xml");
            doc.Load(filePath);
        
            XmlNodeList ndelist = doc.SelectNodes("//books/book");

            foreach(XmlNode item in ndelist!)
            {
                XmlNode name = item.SelectSingleNode("name");
                XmlNode authur = item.SelectSingleNode("author");

                Console.WriteLine(name?.InnerText);
                Console.WriteLine(authur?.InnerText);
            }

        }
    }

}