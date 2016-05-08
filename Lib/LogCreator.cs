using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    class LogCreator
    {
        #region instances

        string _LogName;
        string _LogContent;
        string _LogPath;

        #endregion

        #region propperties
        public string LogName
        {
            get
            {
                return _LogName;
            }

            set
            {
                _LogName = value;
            }
        }

        public string LogContent
        {
            get
            {
                return _LogContent;
            }

            set
            {
                _LogContent = SetLogConent();
            }
        }

        

        public string LogPath
        {
            get
            {
                return _LogPath;
            }

            set
            {
                _LogPath = value;
            }
        }

        #endregion
        
        #region constructors

        public LogCreator(string Name, string Content, string Path)
        {
            _LogName = Name;
            _LogContent = Content;
            _LogPath = Path;
        }

        #endregion

        #region methods
        private string SetLogConent()
        {
            //erzeugt den Inhalt, der in der Logdatei angefügt wird
            throw new NotImplementedException();
        }
        #endregion
    }
}
