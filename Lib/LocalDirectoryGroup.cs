using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;

namespace Lib
{
    class LocalDirectoryGroup
    {
        #region Instancevariable

        private string _localDirectoryGroupName;
        private string _localDirectoryGroupSID;

        #endregion

        #region Properties

        public string LocalDirectoryGroupName
        {
            get
            {
                return _localDirectoryGroupName;
            }

            set
            {
                _localDirectoryGroupName = value;
            }
        }

        public string LocalDirectoryGroupSID
        {
            get
            {
                return _localDirectoryGroupSID;
            }

            set
            {
                _localDirectoryGroupSID = value;
            }
        }

        #endregion

        #region getthegroup



        #endregion getthegroup

        public void getthegroup()
        {
            PrincipalContext ctx = new PrincipalContext(ContextType.Domain);

            GroupPrincipal qbeGroup = new GroupPrincipal(ctx);

            PrincipalSearcher srch = new PrincipalSearcher(qbeGroup);

            foreach (var found in srch.FindAll())
            { 
                GroupPrincipal foundgroup = found as GroupPrincipal;
                  
                if(foundgroup != null)
                  {
     
                 }
            }

        }

        #region Constructors

        /// <summary>
        /// setzt alle Benoetigten Variablen der Klasse
        /// </summary>
        /// <param name="gid"></param>
        /// <param name="sid"></param>
        public LocalDirectoryGroup(string GroupName, string sid)
        {
            _localDirectoryGroupName = GroupName;
            _localDirectoryGroupSID = sid;
        }

        #endregion

        #region Methodes

        public override string ToString()
        {
            return LocalDirectoryGroupName + ";" + LocalDirectoryGroupSID;
        }

        #endregion


    }
}
