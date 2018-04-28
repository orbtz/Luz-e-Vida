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
    [Activity(MainLauncher = false)]
    class InformationActivity : Activity
    {
        ButtonsInfo lastPressed = new ButtonsInfo();
        TextInformation Text = new TextInformation();

        TextView infoText;

        int valButtonPressed;
        string info;

        //FUNÇÃO PARA VOLTAR O TEXTO
        protected void Information()
        {
            //valButtonPressed = lastPressed.lastButtonPressed;
            valButtonPressed = lastPressed.ReturnLastPressed(); //armazena qual foi o último botão acionado - NÃO FUNCIONANDO
            info = Text.InfoData(valButtonPressed); //Val INFO vai armazenar o texto com informações. Dados dependo do último botão acionado
        }
        //FUNÇÃO PARA VOLTAR O TEXTO

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Information);
        }

        protected override void OnResume()
        {
            base.OnResume();
            Information();

            //O textView vai ser reconhecido aqui, e logo após reposto com o texto customizado
            infoText = FindViewById<TextView>(Resource.Id.infoData);
            infoText.Text = info;

        }

        public override void OnBackPressed()
        {
            base.OnBackPressed();
            Finish();

        }

    }
}