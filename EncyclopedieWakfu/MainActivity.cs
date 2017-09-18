using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Content;
using EncyclopedieWakfu.Models;
using Newtonsoft.Json;

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
            button.contents.AddRange(new List<Button>() {InitButton("Iop"), InitButton("sacrieur"), InitButton("enutrof"), InitButton("osamodas"), InitButton("sram"), InitButton("sadida"), InitButton("pandawa"), InitButton("roublard")
            , InitButton("steamer"), InitButton("zobal"), InitButton("eniripsa"), InitButton("eliotrope"), InitButton("huppermage"), InitButton("ecaflip"), InitButton("cra"), InitButton("xelor"), InitButton("feca")});
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

