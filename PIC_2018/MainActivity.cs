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
            // Set our view from the "StartLayout" layout resource
            //SetContentView(Resource.Layout.StartLayout);

            base.OnCreate(savedInstanceState);
            

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //BOTÕES
            ImageButton b_Objetivos = FindViewById<ImageButton>(Resource.Id.buttonMainObjetivos);
            ImageButton b_01 = FindViewById<ImageButton>(Resource.Id.button01);
            ImageButton b_02 = FindViewById<ImageButton>(Resource.Id.button02);
            ImageButton b_03 = FindViewById<ImageButton>(Resource.Id.button03);
            ImageButton b_04 = FindViewById<ImageButton>(Resource.Id.button04);

            //Checa os botões se serão apertados

            //BOTÃO OBJETIVOS
            b_Objetivos.Click += delegate //Se o botão for acionado
            {
                CallLayoutObjetivos();
            };

            //BOTÃO 01
            b_01.Click += delegate //Se o botão for acionado
            {
                CallLayoutObjetivos();
            };

            //BOTÃO 02
            b_02.Click += delegate //Se o botão for acionado
            {
                CallLayoutObjetivos();
            };

            //BOTÃO 03
            b_03.Click += delegate //Se o botão for acionado
            {
                CallLayoutObjetivos();
            };

            //BOTÃO 04
            b_04.Click += delegate //Se o botão for acionado
            {
                CallLayoutObjetivos();
            };

        }

        void CallLayoutObjetivos()
        {
            SetContentView(Resource.Layout.Objetivos);
        }


    }
}

