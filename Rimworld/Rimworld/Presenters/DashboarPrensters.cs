using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Rimworld.Models;
using Rimworld.Views;


namespace Rimworld.Presenters
{
    public class DashboarPrensters
    {
        IDashBoard dashBoardView;

        public DashboarPrensters(IDashBoard view)
        {
            dashBoardView = view;
        }

        public string[] showListFilesSave()
        {
            return Common.getFilesSave();
        }

        public string getFileStorePath(string fileName)
        {
            string storePath =  Common.getStorePath()+fileName;            
            return storePath;
        }

    }
}
