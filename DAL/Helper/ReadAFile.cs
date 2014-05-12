using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using System.Data;
using Core.PresenceInfo;
using System.IO;

namespace BLL
{
    class ReadAFile
    {
        public string FilePath { get; set; }

        #region constructor

        public ReadAFile()
        {
            this.FilePath = @"c:\Users\jkeedhoo\Documents\Visual Studio 2013\Projects\latecomerDAL\latecomerDAL\LatecomerDocument.XML";
        }

        public ReadAFile(string filePathName)
        {
            this.FilePath = filePathName;
        }

        #endregion

        public List<Absent> ReadXMLFile()
        {
            List<Absent> newLatecomerList = new List<Absent>();
            DataSet ds = null;
            try
            {
                string xmlFile = this.FilePath;

                ds = new DataSet();

                ds.ReadXml(xmlFile);

                foreach (DataRow row in ds.Tables[0].AsEnumerable())
                {
                    Absent tempArrivedStudent = new Absent();
                    string studentID = "";
                    string timeArrived = "";
                    studentID = row.Field<string>("StudentID");
                    timeArrived = row.Field<string>("TimeArrived");

                    //how to convert studentID from string to student type?
                    tempArrivedStudent.student = studentID;
                    tempArrivedStudent.timeArrived = double.Parse(timeArrived);

                    newLatecomerList.Add(tempArrivedStudent);
                    
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
            return newLatecomerList;
        }
    }
}
