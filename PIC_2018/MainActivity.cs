using Android.App;
using Android.Widget;
using Android.OS;

namespace PIC_2018
{
    [Activity(Label = "Luz e Vida", MainLauncher = false,
              Theme = "@style / MyTheme.Splash")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.StartLayout);
        }

        protected override void OnResume()
        {
            base.OnResume();
            SetContentView(Resource.Layout.Main);
        }
    }
}