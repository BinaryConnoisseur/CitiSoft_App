using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiSoft_App
{
    internal class DBConnection
    {
        private DBConnection instance;

        private string CitisoftDBConnection;

        private DBConnection() 
        {
            //Leaving a comment here to test
            CitisoftDBConnection = Properties.Settings.Default.CitisoftDBConnection;
        }
    }
}
