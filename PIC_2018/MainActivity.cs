using Android.App;
using Android.Widget;
using Android.OS;

namespace PIC_2018
{
    //Theme = "@style/MyTheme.Splash"
    [Activity(Label = "Luz e Vida", MainLauncher = true)]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
        
        // ONSTART VAI AQUI //

        protected override void OnResume()
        {
            base.OnResume();

            //Escutando os botões
            Buttons ObjectB = new Buttons();
            ObjectB.ImageButtons();
            
            AppActivity ObjectAA = new AppActivity();
            int CL = ObjectAA.ReturnLayout();
            //Abre a tela aberta por último
            //Main por padrão
            CallLayout(CL);
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

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        //Funções para os botões
        protected void ButtonAction()
        {
            Buttons ObjectB = new Buttons();

            //BOTÃO PROMOÇÃO
            ObjectB.CallImageButtons(1).Click += delegate
            {
                CallLayout(1);
            };

            //BOTÃO PREVENÇÃO
            ObjectB.CallImageButtons(2).Click += delegate
            {
                CallLayout(2);
            };

            //BOTÃO GESTAÇÃO
            ObjectB.CallImageButtons(3).Click += delegate
            {
                CallLayout(3);
            };

            //BOTÃO PROMOÇÃO
            ObjectB.CallImageButtons(11).Click += delegate
            {
                CallLayout(11);
            };
        }
        //Funções para os botões
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        //Funções chamada de telas
        protected void CallLayout(int layout)
        {
            AppActivity ObjectAA = new AppActivity();
            ObjectAA.SaveCurrentLayout(layout);

            if (layout.Equals(0)) //Botão Promoção
                SetContentView(Resource.Layout.Main);

            if (layout.Equals(1)) //Botão Promoção
                SetContentView(Resource.Layout.Promocao);

            if (layout.Equals(2)) //Botão Prevenção
                SetContentView(Resource.Layout.Prevencao);

            if (layout.Equals(3)) //Botão Proteção
                SetContentView(Resource.Layout.Gestacao);

            if (layout.Equals(11)) //Botão Objetivos Milenio
                SetContentView(Resource.Layout.ObjetivosMilenio);

            if (layout.Equals(12)) //Botão Principios SUS
                SetContentView(Resource.Layout.ObjetivosMilenio);

            if (layout.Equals(13)) //Botão Proteção Gestação
                SetContentView(Resource.Layout.ObjetivosMilenio);

            if (layout.Equals(14)) //Botão Metodos COntraceptivos
                SetContentView(Resource.Layout.ObjetivosMilenio);

        }
        //Funções chamada de telas
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

    }
}