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
    class ButtonsInfo
    {
        public int lastButtonPressed;
        public void LastPressed(int BP)
        {
            lastButtonPressed = BP;
        }

        public int ReturnLastPressed()
        {
            return lastButtonPressed;
        }
        
    }
}