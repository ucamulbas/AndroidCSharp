using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Content;
using EncyclopedieWakfu.Models;
using Newtonsoft.Json;
using System.Resources;

namespace EncyclopedieWakfu
{
    [Activity(Label = "Encyclopedie", MainLauncher = true)]
    public class MainActivity : Activity
    {
        MyButtonList listButton = new MyButtonList();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            Init();

        }


        private void Init()
        {
            ImageButton ClassButton;
            ImageButton BestiaryButton;
            ImageButton JobsButton;
            ClassButton = FindViewById<ImageButton>(Resource.Id.buttonClasse);
            BestiaryButton = FindViewById<ImageButton>(Resource.Id.buttonBestaire);
            JobsButton = FindViewById<ImageButton>(Resource.Id.buttonJobs);

            MyButton MClassButton = new MyButton(ClassButton);
            MyButton MBestiaryButton = new MyButton(BestiaryButton);
            MyButton MJobsButton = new MyButton(JobsButton);

            MClassButton.InitContent(InitClassContent);
            


            listButton.Add(MClassButton);
            listButton.Add(MBestiaryButton);
            listButton.Add(MJobsButton);

            listButton.Init();

            foreach (var button in listButton)
            {
                button.classButton.Click += delegate
                {
                    listButton.Active(button);
                    PrintContent(button);
                };
            }
        }

        public void PrintContent(MyButton button)
        {
            LinearLayout layout = FindViewById<LinearLayout>(Resource.Id.MainContentLayout);
            layout.RemoveAllViews();
            foreach (var content in button.contents)
            {
                layout.AddView(content);
            }
        }

        private void InitClassContent(MyButton button)
        {


            button.contents.AddRange(new List<Button>() {   InitButton(GetString(Resource.String.feca)), InitButton(GetString(Resource.String.osamodas)),
                                                            InitButton(GetString(Resource.String.enutrof)), InitButton(GetString(Resource.String.sram)),
                                                            InitButton(GetString(Resource.String.xelor)), InitButton(GetString(Resource.String.ecaflip)),
                                                            InitButton(GetString(Resource.String.eniripsa)), InitButton(GetString(Resource.String.iop)),
                                                            InitButton(GetString(Resource.String.cra)), InitButton(GetString(Resource.String.sadida)),
                                                            InitButton(GetString(Resource.String.sacrieur)), InitButton(GetString(Resource.String.pandawa)),
                                                            InitButton(GetString(Resource.String.roublard)), InitButton(GetString(Resource.String.zobal)),
                                                            InitButton(GetString(Resource.String.steamer)), InitButton(GetString(Resource.String.eliotrop)),
                                                            InitButton(GetString(Resource.String.huppermage))});
        }

        private Button InitButton(string name)
        {
            Button button = new Button(this);
            button.Text = name;
            Classe classe = new Classe(name);
            var data = JsonConvert.SerializeObject(classe);
            

            button.Click += delegate {
                var activity = new Intent(this, typeof(ClassActivity));
                activity.PutExtra("Classe", data);
                StartActivity(activity);
            };
            return button;
        }

    }
}

