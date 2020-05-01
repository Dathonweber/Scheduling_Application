using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BOP1_Scheduling_Application
{
    class ActivityLog
    {
        public string filename = "ActivityLog.txt";
        public string user = "Test";
        DateTime DT = DateTime.Now;

        public void RecordLogin() 
        {
            using (StreamWriter file = File.AppendText(Application.StartupPath + "\\Activity Log\\" + user + ".txt"))
            {
                file.WriteLine($"User: {user}");
                file.WriteLine($"Date & Time: {DT}");
            }
        }
    }
}
