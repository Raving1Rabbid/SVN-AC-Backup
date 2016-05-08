using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    class UserCoparer
    {
        #region Instances
        List<string> _UserToAdd;
        List<string> _UserToDelete;
        List<string> _AllUsers;
        ListManager _Manager;
        #endregion

        #region Constructors
        public UserCoparer()
        {
            _UserToAdd = new List<string>();
            _UserToDelete = new List<string>();
            _Manager = new ListManager();
            _AllUsers = _Manager.Exportlines;
        }
        #endregion

        #region Methodes
        /// <summary>
        /// rechnet sich den Unterschied der Anzahl der Existierenden User und der zu Existierenden Usern aus
        /// </summary>
        /// <returns></returns>
        public int Compare()
        {
            return _AllUsers.Count - _Manager.ExistingUsers.Count();
        }
        #endregion
    }
}
