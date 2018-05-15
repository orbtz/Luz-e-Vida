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
    [Activity(Label = "Gestação",
                ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    class GestacaoActivity : Activity
    {

        //BOTÕES DA TELA
        ImageButton BUTTON_ExamesAnuais;   //21

        ButtonsInfo ButtonPressed = new ButtonsInfo();

        Intent NextActivity;

        public void LayoutFindViewById() //"Escuta" os ImageButtons
        {
            BUTTON_ExamesAnuais = FindViewById<ImageButton>(Resource.Id.BUT_ExaGest);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Gestacao); //Set Main na tela
        }

        // ONSTART VAI AQUI //

        protected override void OnResume()
        {
            base.OnResume();
            LayoutFindViewById();

            // -- -- -- CHAMADA DE OUTRAS ACTIVITIES DE FUTURAS TELAS -- -- -- //
            BUTTON_ExamesAnuais.Click += delegate
            {
                NextActivity = new Intent(this, typeof(ExamesGestacaoActivity)); //SetContentView(Resource.Layout.Promocao);
                StartActivity(NextActivity);
                //Finish();
                ButtonPressed.LastPressed(11);
                //SetContentView(Resource.Layout.ExamAnua);

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