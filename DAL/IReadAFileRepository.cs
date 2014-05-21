namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Core.PresenceInfo;

    public interface IReadAFileRepository
    {
        List<LateTicket> ReadXMLFile();
    }
}
