using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace MvcLibrary.Data
{
    public class XmlFileWriteAndRead
    {
        public static void xmlWriteBookFiles(string bookName, int chaptersCount = 2)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            string filePath = Environment.CurrentDirectory + "/Data/XmlContentsData/" + bookName + ".xml";
            settings.Indent = true;

            XmlWriter writer = XmlWriter.Create(filePath, settings);
            writer.WriteStartElement(bookName);
            writer.WriteStartElement("Chapters");
            for (int i = 1; i < chaptersCount+1; i++) 
            {
                writer.WriteElementString("Name", "Chapter " + i);
            }
            
            writer.Close();

        }

        public static void xmlReadFromBookFiles(string bookName)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            string filePath = Environment.CurrentDirectory + "/Data/XmlContentsData/" + bookName + ".xml";

            XmlReader reader = XmlReader.Create(filePath, settings);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if(reader.Name == "Name")
                        {
                           Console.Write(reader.Name + ": ");
                        }
                        break;
                    case XmlNodeType.Text:
                        Console.Write(reader.Value + "\n");
                        break;
                }
            }
                        
            reader.Close();
            Console.ReadKey();
        }
    }
}
