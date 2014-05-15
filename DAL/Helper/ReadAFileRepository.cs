using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using Core.PresenceInfo;
using System.IO;

namespace DAL.Helper
{
    public class ReadAFileRepository: IReadAFileRepository
    {
        public string FilePath { get; set; }

        #region constructor

        public ReadAFileRepository()
        {
            this.FilePath = @"c:\Users\jkeedhoo\Documents\Visual Studio 2013\Projects\AbsenceAndLateness\DAL\AttendanceForm.xml";
        }

        public ReadAFileRepository(string filePathName)
        {
            this.FilePath = filePathName;
        }

        #endregion

        #region readXMLFile

        public List<LateTicket> ReadXMLFile()
        {
            List<LateTicket> newAttendanceList = new List<LateTicket>();
            DataSet ds = null;
            try
            {
                string xmlFile = this.FilePath;

                ds = new DataSet();

                ds.ReadXml(xmlFile);

                foreach (DataRow row in ds.Tables[0].AsEnumerable())
                {
                    
                    string studentID = "";
                    string timeArrived = "";
                    studentID = row.Field<string>("StudentID");
                    timeArrived = row.Field<string>("TimeArrived");
                                        
                    LateTicket tempArrivedStudent = new LateTicket();
                    tempArrivedStudent.TimeArrived = double.Parse(timeArrived);
                    tempArrivedStudent.StudentInfo.ID = studentID;
                    newAttendanceList.Add(tempArrivedStudent);                    
                }
            }

            catch (FileNotFoundException)
            { }

            catch (Exception)
            { }

            finally
            {
                if (ds != null)
                {
                    ds.Clear();
                }
            }
            return newAttendanceList;
        }
        #endregion
    }
}
