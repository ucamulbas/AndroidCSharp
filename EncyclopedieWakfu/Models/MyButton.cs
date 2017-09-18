using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Widget;

namespace EncyclopedieWakfu.Models
{
    public class MyButton
    {
        public ImageButton classButton;
        public List<Button> contents = new List<Button>();
        public delegate void Init(MyButton button);

        public MyButton(ImageButton classButton)
        {
            this.classButton = classButton;
        }

        public void Enable()
        {
            classButton.SetBackgroundColor(Android.Graphics.Color.Red);
        }
        public void Disable()
        {
            classButton.SetBackgroundColor(Android.Graphics.Color.DarkSlateGray);
        }
        public int GetId()
        {
            return classButton.Id;
        }
        public void InitContent(Init init)
        {
            init(this);
        }
        

    }
}