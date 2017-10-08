using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using EncyclopedieWakfu.Models;
using Newtonsoft.Json;

namespace EncyclopedieWakfu
{
    [Activity(Label = "Classe")]
    public class ClassActivity : Activity
    {
        Classe classe;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            classe = JsonConvert.DeserializeObject<Classe>(Intent.GetStringExtra("Classe"));

            // Create your application here
            SetContentView(Resource.Layout.ClassView);
            var className = FindViewById<TextView>(Resource.Id.classname);
            className.Text = classe.name;
            Init();
        }

        private void Init()
        {
            var description = FindViewById<TextView>(Resource.Id.classdescription);
            classe.description = GetString(Resources.GetIdentifier(string.Concat(classe.name.ToLower(), "description"), "string", PackageName));
            description.Text = classe.description;
        }
    }
}