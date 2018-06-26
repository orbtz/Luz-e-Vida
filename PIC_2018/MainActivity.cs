using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace PIC_2018
{
    //Theme = "@style/MyTheme.Splash"
    [Activity(  Label = "Luz e Vida",
                MainLauncher = true,
                ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : Activity
    {
        ButtonsInfo ButtonsInfo = new ButtonsInfo();

        //BOTÕES DA TELA
        ImageButton BUTTON_promocao;
        ImageButton BUTTON_prevencao;
        ImageButton BUTTON_gestacao;

        //

        Intent NextActivity;

        public void LayoutFindViewById() //"Escuta" os ImageButtons
        {
            BUTTON_gestacao = FindViewById<ImageButton>(Resource.Id.BUT_gesta);
            BUTTON_prevencao = FindViewById<ImageButton>(Resource.Id.BUT_preve);
            BUTTON_promocao = FindViewById<ImageButton>(Resource.Id.BUT_promo);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main); //Set Main na tela
        }
        
        // ONSTART VAI AQUI //

        protected override void OnResume()
        {
            base.OnResume();
            LayoutFindViewById();

            // -- -- -- CHAMADA DE OUTRAS ACTIVITIES DE FUTURAS TELAS -- -- -- //
            BUTTON_promocao.Click += delegate
            {
                ButtonsInfo.LastPressed(1);
                NextActivity = new Intent(this, typeof(PromocaoActivity)); //Aqui cria uma var Intent que vai dizer a próxima activity -- //SetContentView(Resource.Layout.Promocao);
                //Finish();
                StartActivity(NextActivity);
                
            };

            BUTTON_prevencao.Click += delegate
            {
                ButtonsInfo.LastPressed(2);
                NextActivity = new Intent(this, typeof(DoencasActivity)); //SetContentView(Resource.Layout.Promocao);
                //Finish();
                StartActivity(NextActivity);
            };

            BUTTON_gestacao.Click += delegate
            {
                ButtonsInfo.LastPressed(3);
                NextActivity = new Intent(this, typeof(GestacaoActivity)); //SetContentView(Resource.Layout.Promocao);
                //Finish();
                StartActivity(NextActivity);
                
            };
            // -- -- -- CHAMADA DE OUTRAS ACTIVITIES DE FUTURAS TELAS -- -- -- //

        }

        //BOTÃO DE VOLTAR
        public override void OnBackPressed()
        {
            base.OnBackPressed();
            AppActivity ObjectAA = new AppActivity();
            int CL = ObjectAA.ReturnLayout();

            Toast.MakeText(this, "Aperte novamente para fechar o aplicativo", ToastLength.Short).Show();

            SetContentView(Resource.Layout.Main);
            
        }
        

    }
}