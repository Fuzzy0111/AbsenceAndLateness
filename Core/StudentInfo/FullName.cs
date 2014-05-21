namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FullName
    {   
        #region Constructor

        public FullName(string first, string last)
        {
            this.First = first;
            this.Last = last;
        }

        #endregion

        #region Properties

        public string First 
        { 
            get; 
            set; 
        }

        public string Last 
        { 
            get; 
            set; 
        }

        #endregion
    }
}
