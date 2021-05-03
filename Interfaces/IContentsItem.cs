using MvcLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLibrary.Interfaces
{
    public interface IContentsItem
    {
        IEnumerable<ContentsItem> getContents(string bookName);
    }
}
