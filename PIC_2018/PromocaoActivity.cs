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
    [Activity(Label = "Promoção e Proteção",
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    class PromocaoActivity : Activity
    {

        //BOTÕES DA TELA
        ImageButton BUTTON_Objetivos;   //11
        ImageButton BUTTON_SUS;         //12
        ImageButton BUTTON_Protecao;    //13
        ImageButton BUTTON_Metodos;     //14
        ImageButton BUTTON_Exames;      //15

        int V;

        ButtonsInfo ButtonPressed = new ButtonsInfo();

        Intent NextActivity;

        public void LayoutFindViewById() //"Escuta" os ImageButtons
        {
            BUTTON_Objetivos = FindViewById<ImageButton>(Resource.Id.BUT_OM);
            BUTTON_SUS = FindViewById<ImageButton>(Resource.Id.BUT_SUS);
            BUTTON_Protecao = FindViewById<ImageButton>(Resource.Id.BUT_PG);
            BUTTON_Metodos = FindViewById<ImageButton>(Resource.Id.BUT_MC);
            BUTTON_Exames = FindViewById<ImageButton>(Resource.Id.BUT_EA);
        }
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Promocao); //Set Main na tela

            V = Intent.Extras.GetInt("BUTTON_P");

        }

        // ONSTART VAI AQUI //

        protected override void OnResume()
        {

            base.OnResume();
            LayoutFindViewById();
            
            Toast.MakeText(this, "" + V, ToastLength.Short).Show(); //Aparentemente se coloar apenas int ele tenta referenciar um textID

            // -- -- -- CHAMADA DE OUTRAS ACTIVITIES DE FUTURAS TELAS -- -- -- //
            BUTTON_Objetivos.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                ButtonPressed.LastPressed(11);
                SetContentView(Resource.Layout.ObjMil);
                
            };

            BUTTON_SUS.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //Finish();
                SetContentView(Resource.Layout.SUS);
                //StartActivity(NextActivity);
            };

            BUTTON_Protecao.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //Finish();
                SetContentView(Resource.Layout.ProtecaoGestacao);
                //StartActivity(NextActivity);

            };

            BUTTON_Metodos.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //Finish();
                ButtonPressed.LastPressed(14);
                SetContentView(Resource.Layout.MetConcep);
                //StartActivity(NextActivity);

            };

            BUTTON_Exames.Click += delegate
            {
                NextActivity = new Intent(this, typeof(InformationActivity)); //SetContentView(Resource.Layout.Promocao);
                //Finish();
                ButtonPressed.LastPressed(15);
                SetContentView(Resource.Layout.ExamAnua);
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