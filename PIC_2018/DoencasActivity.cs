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
    [Activity(Label = "Doenças")]
    class DoencasActivity : Activity
    {
        //BOTÕES DA TELA
        ImageButton BUTTON_Sifilis;   //61
        ImageButton BUTTON_HepatiteB;   //62
        ImageButton BUTTON_HepatiteC;   //62
        ImageButton BUTTON_HIV;   //61
        //ImageButton BUTTON_Aids;   //63
        ImageButton BUTTON_Gonorreia;   //64
        //ImageButton BUTTON_Clamidia;   //65
        ImageButton BUTTON_Herpes;   //66
        ImageButton BUTTON_Tricomoniase;   //67
        ImageButton BUTTON_HPV;   //67

        ButtonsInfo ButtonPressed = new ButtonsInfo();

        Intent NextActivity;

        public void LayoutFindViewById() //"Escuta" os ImageButtons
        {
            BUTTON_Sifilis      = FindViewById<ImageButton>(Resource.Id.sifi);
            BUTTON_HepatiteB    = FindViewById<ImageButton>(Resource.Id.hepa);
            BUTTON_HepatiteC    = FindViewById<ImageButton>(Resource.Id.hepa);
            BUTTON_HIV          = FindViewById<ImageButton>(Resource.Id.hiv);
            //BUTTON_Aids         = FindViewById<ImageButton>(Resource.Id.aids);
            BUTTON_Gonorreia    = FindViewById<ImageButton>(Resource.Id.gono);
            //BUTTON_Clamidia     = FindViewById<ImageButton>(Resource.Id.clam);
            BUTTON_Herpes       = FindViewById<ImageButton>(Resource.Id.herp);
            BUTTON_Tricomoniase = FindViewById<ImageButton>(Resource.Id.trico);
            BUTTON_HPV          = FindViewById<ImageButton>(Resource.Id.hpv);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Doenc); //Set a tela
        }

        // ONSTART VAI AQUI //

        protected override void OnResume()
        {
            base.OnResume();
            LayoutFindViewById();

            // -- -- -- CHAMADA DE OUTRAS ACTIVITIES DE FUTURAS TELAS -- -- -- //
            BUTTON_Sifilis.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(21);
                SetContentView(Resource.Layout.Dsifil);

            };

            BUTTON_HepatiteB.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(21);
                SetContentView(Resource.Layout.Dhepa);

            };

            BUTTON_HepatiteC.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(21);
                SetContentView(Resource.Layout.Dhepa);

            };

            BUTTON_HIV.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(21);
                SetContentView(Resource.Layout.Dhiv);

            };

           // BUTTON_Aids.Click += delegate
          //  {
          //      NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(21);
          //      SetContentView(Resource.Layout.Daids);

         //   };

            BUTTON_HPV.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(21);
                SetContentView(Resource.Layout.Dhpv);

            };

            BUTTON_Gonorreia.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(21);
                SetContentView(Resource.Layout.Dgono);

            };

      //      BUTTON_Clamidia.Click += delegate
      //      {
      //          NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
      //          //StartActivity(NextActivity);
      //          //Finish();
      //          //ButtonPressed.LastPressed(21);
      //          SetContentView(Resource.Layout.Dclam);

       //     };

            BUTTON_Herpes.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(21);
                SetContentView(Resource.Layout.Dherp);

            };

            BUTTON_Tricomoniase.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(21);
                SetContentView(Resource.Layout.Dtrico);

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