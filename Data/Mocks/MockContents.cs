using MvcLibrary.Interfaces;
using MvcLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace MvcLibrary.Data.Mocks
{
    public class MockContents : IContentsItem
    {
        private string _bookname { get; set; }
        private List<ContentsItem> _getCharpters(string bookName)
        {
            List<ContentsItem> contentsItem = new List<ContentsItem>();
            XmlReaderSettings settings = new XmlReaderSettings();
            string filePath = Environment.CurrentDirectory + "/Data/XmlContentsData/" + bookName + ".xml";

            XmlReader reader = XmlReader.Create(filePath, settings);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Text:
                        contentsItem.Add(new ContentsItem { ChapterName = reader.Value });
                        break;
                }
            }
            reader.Close();
            return contentsItem;
        }

        public IEnumerable<ContentsItem> getContents(string bookName)
        {
                return _getCharpters(bookName);
        }
    }

    
}
