using Android.App;
using Android.Widget;
using Android.OS;

namespace PIC_2018
{
    [Activity(Label = "Luz e Vida", MainLauncher = true)]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            //Set our view from the "StartLayout" layout resource
            //SetContentView(Resource.Layout.StartLayout);

            base.OnCreate(savedInstanceState);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
        }

        protected override void OnStart()
        {
            //BOTÕES
            ImageButton B01 = FindViewById<ImageButton>(Resource.Id.mainB01);
            ImageButton B02 = FindViewById<ImageButton>(Resource.Id.mainB02);
            ImageButton B03 = FindViewById<ImageButton>(Resource.Id.mainB03);
            ImageButton B04 = FindViewById<ImageButton>(Resource.Id.mainB04);
            
        }

        //Funções de chamadas de telas nível 01
        
    }
}