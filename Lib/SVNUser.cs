using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class SVNUser
    {
        #region Instanzvariable
        string _Name;
        string _FullName;
        string _SID;
        string _LoginName;
        #endregion

        #region Properties
        public string Name
        {
            get { return _Name; }
        }

        public string FullName
        {
            get { return _FullName; }
        }


        public string SID
        {
            get { return _SID; }
        }

        public string LoginName
        {
            get { return _LoginName; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// setzt alle Benoetigten Variablen der Klasse bei erstellen eines Nutzers
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fullName"></param>
        /// <param name="sID"></param>
        public SVNUser(string name, string fullName, string sID)
        {
            _SID = sID;
            _Name = name;
            _FullName = FullName;
        }
        #endregion

        #region methodes
        /// <summary>
        /// Setzt den Login Namen des Nutzers bei hinzufuegen des Nutzers
        /// </summary>
        private void SetUserLoginName()
        {
            _LoginName = (FullName[0] + Name).ToLower();
        }
        #endregion
    }
}
