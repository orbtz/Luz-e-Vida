using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PIC_2018
{
    class AppActivity
    {
        int currentLayoutValue = 0;

        public void SaveCurrentLayout(int CL)
        {
            currentLayoutValue = CL;
        }
        
        public int ReturnLayout()
        {
            return currentLayoutValue;
        }

    }
}