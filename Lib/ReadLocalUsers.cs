using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;


namespace Lib
{
    class ReadLocalUsers
    {
        /// <summary>
        /// liest alle Lokalen Benutzer ein, und liefert sie zurueck
        /// </summary>
        /// <returns></returns>
        public List<SVNUser> GetLocalUsers()
        {
            
           
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_UserAccount");
            List<SVNUser> Users = new List<SVNUser>();
            Data.LogCreator logobj = new Data.LogCreator();
            foreach (ManagementObject queryObj in searcher.Get())
            {

                Users.Add(new SVNUser(queryObj["Name"].ToString(),  queryObj["FullName"].ToString(),queryObj["SID"].ToString()));              
                logobj.Usereinlesen(queryObj["Name"].ToString());
                
            }
            logobj.stop();
            return Users;
        }
    }
}
