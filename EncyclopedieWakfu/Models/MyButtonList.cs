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

namespace EncyclopedieWakfu.Models
{
    public class MyButtonList  : List<MyButton>
    {
        public MyButton EnabledButton;

        public void Active(MyButton buttonActived)
        {
            foreach(var button in this)
            {
                if(button == buttonActived)
                {
                    button.Enable();
                    EnabledButton = button;
                } else
                {
                    button.Disable();
                }
            }
        }

        public void Init()
        {
            foreach(var button in this)
            {
                button.Disable();
            }
        }
    }
}