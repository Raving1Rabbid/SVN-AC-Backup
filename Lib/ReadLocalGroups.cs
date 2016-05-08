using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.DirectoryServices.AccountManagement;


namespace Lib
{
    class ReadLocalGroups
    {
        public void CreateGrouplist()
        {
            //Liste in der die Grupppen eingespriehcen werden
            List<string> LocalDirGroups = new List<string>();
            PrincipalContext ctx = new PrincipalContext(ContextType.Domain);
            GroupPrincipal qbeGroup = new GroupPrincipal(ctx);

            PrincipalSearcher srch = new PrincipalSearcher(qbeGroup);
            foreach (var found in srch.FindAll())
            {
               LocalDirGroups.Add(Convert.ToString(found));

            }

        }


    }
}
