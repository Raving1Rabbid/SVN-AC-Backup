using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Data
{
    public class LogCreator
    {
        StreamWriter sw = new StreamWriter("Log.txt");
       
        //erstellen der logs mit atributen 

        public void WriteLog(string name)
        {
           sw.WriteLine(DateTime.Now + " User"+ " "+ name+"  wurde angelegt");
  
        }

        public void Errorlog(string fail)
        {
            sw.WriteLine(DateTime.Now +" Fehler"+ fail );
 
           
        }

        public void DelLog(string name )
        {
            sw.WriteLine(DateTime.Now+" User"+" "+name+"entfernt");
    
   
        }
        public void Listlog(string list)
        {
            sw.WriteLine(DateTime.Now + list + "  wurde eingelesen");
  
        }
        public void Startlog()
        {
            sw.WriteLine(DateTime.Now + "Das Programm wurde gestartet");
          

        }
        public void Usereinlesen(string user)
        {
            sw.WriteLine("User "+ user +" wurde aus dem Directory eingelesen");
            
            
        }
        public void stop()
        {
            sw.Close();
        }

    }
}
