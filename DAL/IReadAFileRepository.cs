using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.PresenceInfo;

namespace DAL
{
    public interface IReadAFileRepository
    {
        List<Late> ReadXMLFile();
    }
}
