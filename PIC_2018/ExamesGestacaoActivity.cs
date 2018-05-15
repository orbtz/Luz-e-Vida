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
    [Activity(Label = "Exames Gestação",
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    class ExamesGestacaoActivity : Activity
    {

        //BOTÕES DA TELA
        ImageButton BUTTON_T1;   //11
        ImageButton BUTTON_T2;         //12
        ImageButton BUTTON_T3;    //13

        ButtonsInfo ButtonPressed = new ButtonsInfo();

        Intent NextActivity;

        public void LayoutFindViewById() //"Escuta" os ImageButtons
        {
            BUTTON_T1 = FindViewById<ImageButton>(Resource.Id.BUT_trim1);
            BUTTON_T2 = FindViewById<ImageButton>(Resource.Id.BUT_trim2);
            BUTTON_T3 = FindViewById<ImageButton>(Resource.Id.BUT_trim3);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Promocao); //Set Main na tela
        }

        // ONSTART VAI AQUI //

        protected override void OnResume()
        {
            base.OnResume();
            LayoutFindViewById();

            // -- -- -- CHAMADA DE OUTRAS ACTIVITIES DE FUTURAS TELAS -- -- -- //
            BUTTON_T1.Click += delegate //ERRO - CHAMADA DE VAR NULA?
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                ButtonPressed.LastPressed(11);
                SetContentView(Resource.Layout.Trimestre1);

            };

            BUTTON_T2.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //Finish();
                SetContentView(Resource.Layout.Trimestre2);
                //StartActivity(NextActivity);
            };

            BUTTON_T3.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //Finish();
                SetContentView(Resource.Layout.Trimestre3);
                //StartActivity(NextActivity);

            };
            // -- -- -- CHAMADA DE OUTRAS ACTIVITIES DE FUTURAS TELAS -- -- -- //

        }

        //BOTÃO DE VOLTAR
        public override void OnBackPressed()
        {
            Finish();
            //SetContentView(Resource.Layout.Main);

        }

    }
}