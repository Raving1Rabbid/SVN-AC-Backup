using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class LocalDirectoryUser
    {
        #region instance variables
        string _Domain;
        string _UserID;
        string _SID;
        string _Firstname;
        string _LastName;
        string _FullName;
        string _Birthday;
        string _Mailaddress;
        List<LocalDirectoryGroup> LocalDirectoryGroupMembership;
        #endregion

        #region properties
        public string Domain
        {
            get { return _Domain; }
            set { _Domain = value; }
        }

        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        public string SID
        {
            get { return _SID; }
            set { _SID = value; }
        }

        public string Firstname
        {
            get { return _Firstname; }
            set { _Firstname = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }

        public string Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value; }
        }

        public string Mailaddress
        {
            get { return _Mailaddress; }
            set { _Mailaddress = value; }
        }

        internal List<LocalDirectoryGroup> LocalDirectoryGroupMembership1
        {
            get { return LocalDirectoryGroupMembership; }
            set { LocalDirectoryGroupMembership = value; }
        }
        #endregion

        #region constructor
        /// <summary>
        /// Setzt alle benötigten Variablen in der Klasse
        /// </summary>
        /// <param name="importline"></param>
        public LocalDirectoryUser(string importline)
        {
            string[] line = new string[7];
            line = importline.Split(';');
            Domain = line[0];
            UserID = line[1];
            SID = line[2];
            Firstname = line[3];
            LastName = line[4];
            FullName = line[5];
            Birthday = line[6];
            Mailaddress = line[7];
        }
        #endregion
    }
}
