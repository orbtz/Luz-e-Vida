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
    [Activity(Label = "Gestação")]
    class GestacaoActivity : Activity
    {

        //BOTÕES DA TELA
        //ImageButton BUTTON_Doencas;   //21

        ButtonsInfo ButtonPressed = new ButtonsInfo();

        Intent NextActivity;

        public void LayoutFindViewById() //"Escuta" os ImageButtons
        {
            //BUTTON_Doencas = FindViewById<ImageButton>(Resource.Id.BUT_);
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