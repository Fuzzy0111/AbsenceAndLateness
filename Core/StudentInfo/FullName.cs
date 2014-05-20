using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class FullName
    {
        #region Properties

        [StringLength(30)]
        public string First;
        public string Last;

        #endregion

        #region Constructor

        public FullName(string first, string last)
        {
            First = first;
            Last = last;
        }

        #endregion
    }
}
