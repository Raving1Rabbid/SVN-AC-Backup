using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    class LocalDirectoryGroupList
    {
        #region Instancevariable

        string _Config;
        List<LocalDirectoryGroup> _AllLocalDirectoryGroups;

        #endregion

        #region Properties

        public string Config
        {
            get
            {
                return _Config;
            }

            set
            {
                _Config = value;
            }
        }

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

        #endregion

        #region Constructor

        public LocalDirectoryGroupList(string config, List<LocalDirectoryGroup> alllocaldirectorygroups)
        {
            _Config = config;
            _AllLocalDirectoryGroups = alllocaldirectorygroups;
        }

        #endregion

        #region Methodes

        private void ImportAllGroupsFromLocalDirectoryUserlist(List<LocalDirectoryUserList> Groups)
        {

        }

        #endregion
    }
}
