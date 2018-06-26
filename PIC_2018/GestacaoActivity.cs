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
        ImageButton BUTTON_DescGrav;
        ImageButton BUTTON_EvoBebe;
        ImageButton BUTTON_MudCorpo;
        ImageButton BUTTON_Roupas;
        ImageButton BUTTON_Nomes;
        ImageButton BUTTON_Sono;
        ImageButton BUTTON_SinaParto;
        ImageButton BUTTON_PrimeiCuidados;
        ImageButton BUTTON_TiposParto;
        ImageButton BUTTON_Puerp;

        ButtonsInfo ButtonPressed = new ButtonsInfo();

        Intent NextActivity;

        public void LayoutFindViewById() //"Escuta" os ImageButtons
        {
            BUTTON_ExamesAnuais = FindViewById<ImageButton>(Resource.Id.BUT_ExaGest);
            BUTTON_DescGrav = FindViewById<ImageButton>(Resource.Id.BUT_DesGra);
            BUTTON_EvoBebe = FindViewById<ImageButton>(Resource.Id.BUT_EvoBeb);
            BUTTON_MudCorpo = FindViewById<ImageButton>(Resource.Id.BUT_MudCorp);
            BUTTON_Roupas = FindViewById<ImageButton>(Resource.Id.BUT_Roupas);
            BUTTON_Sono = FindViewById<ImageButton>(Resource.Id.BUT_Sono);
            BUTTON_Nomes = FindViewById<ImageButton>(Resource.Id.BUT_Nomes);
            BUTTON_SinaParto = FindViewById<ImageButton>(Resource.Id.BUT_SinPart);
            BUTTON_PrimeiCuidados = FindViewById<ImageButton>(Resource.Id.BUT_PrimCuid);
            BUTTON_TiposParto = FindViewById<ImageButton>(Resource.Id.BUT_TiposPart);
            BUTTON_Puerp = FindViewById<ImageButton>(Resource.Id.BUT_RisPuer);
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
                //ButtonPressed.LastPressed(11);
                //SetContentView(Resource.Layout.ExamAnua);

            };

            BUTTON_DescGrav.Click += delegate
            {
                //NextActivity = new Intent(this, typeof(ExamesGestacaoActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(11);
                //SetContentView(Resource.Layout.Gdescobrindo);
                Toast.MakeText(this, "Disponível em breve...", ToastLength.Short).Show();

            };

            BUTTON_EvoBebe.Click += delegate
            {
                //NextActivity = new Intent(this, typeof(ExamesGestacaoActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(11);
                SetContentView(Resource.Layout.Gevolucao);
            };

            BUTTON_MudCorpo.Click += delegate
            {
                //NextActivity = new Intent(this, typeof(ExamesGestacaoActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(11);
                SetContentView(Resource.Layout.Gmudancas);
            };

            BUTTON_Roupas.Click += delegate
            {
                //NextActivity = new Intent(this, typeof(ExamesGestacaoActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(11);
                //SetContentView(Resource.Layout.);
                Toast.MakeText(this, "Disponível em breve...", ToastLength.Short).Show();
            };

            BUTTON_Sono.Click += delegate
            {
                //NextActivity = new Intent(this, typeof(ExamesGestacaoActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(11);
                //SetContentView(Resource.Layout.Gsono);
                Toast.MakeText(this, "Disponível em breve...", ToastLength.Short).Show();
            };

            BUTTON_Nomes.Click += delegate
            {
                //NextActivity = new Intent(this, typeof(ExamesGestacaoActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(11);
                //SetContentView(Resource.Layout.Gdescobrindo);
                Toast.MakeText(this, "Disponível em breve...", ToastLength.Short).Show();
            };

            BUTTON_SinaParto.Click += delegate
            {
                //NextActivity = new Intent(this, typeof(ExamesGestacaoActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(11);
                //SetContentView(Resource.Layout.Gsinais);
                Toast.MakeText(this, "Disponível em breve...", ToastLength.Short).Show();
            };

            BUTTON_PrimeiCuidados.Click += delegate
            {
                //NextActivity = new Intent(this, typeof(ExamesGestacaoActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(11);
                //SetContentView(Resource.Layout.Gprimeiros);
                Toast.MakeText(this, "Disponível em breve...", ToastLength.Short).Show();
            };

            BUTTON_TiposParto.Click += delegate
            {
                //NextActivity = new Intent(this, typeof(ExamesGestacaoActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(11);
                //SetContentView(Resource.Layout.Gparto);
                Toast.MakeText(this, "Disponível em breve...", ToastLength.Short).Show();
            };

            BUTTON_Puerp.Click += delegate
            {
                //NextActivity = new Intent(this, typeof(ExamesGestacaoActivity)); //SetContentView(Resource.Layout.Promocao);
                //StartActivity(NextActivity);
                //Finish();
                //ButtonPressed.LastPressed(11);
                //SetContentView(Resource.Layout.Gpuerperio);
                Toast.MakeText(this, "Disponível em breve...", ToastLength.Short).Show();
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