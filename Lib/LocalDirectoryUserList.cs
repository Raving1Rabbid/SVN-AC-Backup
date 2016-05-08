using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    class LocalDirectoryUserList
    {
        #region Instancevariable

        List<LocalDirectoryGroup> _AllLocalDirectoryGroups;
        List<LocalDirectoryUser> _AllLocalDirectoryUser;
        List<LocalDirectoryUser> _LocalDirectoryStudent;
        List<LocalDirectoryUser> _LocalDirectoryTeacher;
        List<LocalDirectoryUser> _LocalDirectoryAlumni;
        List<LocalDirectoryUser> _LocalDirectoryUserToIgnore;
        
        #endregion

        #region Properties

        internal List<LocalDirectoryGroup> AllLocalDirectoryGroups
        {
            get
            {
                return _AllLocalDirectoryGroups;
            }

            set
            {
                _AllLocalDirectoryGroups = value;
            }
        }

        public List<LocalDirectoryUser> AllLocalDirectoryUser
        {
            get { return _AllLocalDirectoryUser; }
            set { _AllLocalDirectoryUser = value; }
        }

        public List<LocalDirectoryUser> LocalDirectoryStudent
        {
            get { return _LocalDirectoryStudent; }
            set { _LocalDirectoryStudent = value; }
        }

        public List<LocalDirectoryUser> LocalDirectoryTeacher
        {
            get { return _LocalDirectoryTeacher; }
            set { _LocalDirectoryTeacher = value; }
        }

        public List<LocalDirectoryUser> LocalDirectoryAlumni
        {
            get { return _LocalDirectoryAlumni; }
            set { _LocalDirectoryAlumni = value; }
        }

        public List<LocalDirectoryUser> LocalDirectoryUserToIgnore
        {
            get { return _LocalDirectoryUserToIgnore; }
            set { _LocalDirectoryUserToIgnore = value; }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// setzt alle Benoetigten Variablen der Klasse
        /// </summary>
        /// <param name="UserGroup"></param>
        public LocalDirectoryUserList(List<LocalDirectoryGroup> UserGroup)
        {
            AllLocalDirectoryGroups = UserGroup;
        }

        /// <summary>
        /// Setzt alle benötigten Variablen in der Klasse
        /// </summary>
        /// <param name="IImportservice"></param>
        public LocalDirectoryUserList(List<LocalDirectoryUser> IImportservice)
        {
            AllLocalDirectoryUser = IImportservice;
        }
        #endregion
    }
}
