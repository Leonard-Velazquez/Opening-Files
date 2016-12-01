using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace Open
{
    class Program
    {


        // Opens a file or you can open a exe and using a ',' open something else
        //within the exe
        void OpenWithArguments()
        {
            //Put the path name in here and add another \ to the existing \
            //So a path looking like this
            //C:\Users\You\Desktop\Folder
            //Will look like this
            //C:\\Users\\You\\Desktop\\Folder
            Process.Start("");
        }


        static void Main()
        {
            Program myProcess = new Program();

            myProcess.OpenWithArguments();
        }
    }
}
