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
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.StartLayout);
        }

        public void OnStart()
        {
            base.OnStart();
            int currentLayout = 0; //0 é a layout inicial
        }
        
        protected override void OnResume()
        {
            
            base.OnResume();
            SetContentView(Resource.Layout.Main);

            //Escutando os botões
            ImageButton BUTTON_promocao     = FindViewById<ImageButton>(Resource.Id.BUT_promo);
            ImageButton BUTTON_prevencao    = FindViewById<ImageButton>(Resource.Id.BUT_preve);
            ImageButton BUTTON_protecao     = FindViewById<ImageButton>(Resource.Id.BUT_prote);
            ImageButton BUTTON_gestacao     = FindViewById<ImageButton>(Resource.Id.BUT_gesta);

            //Chamada dos botões acionados
            //BOTÃO PROMOÇÃO
            BUTTON_promocao.Click += delegate //Se o botão for acionado	
            {
                CallLayout(1);
            };

            //BOTÃO PREVENÇÃO
            BUTTON_prevencao.Click += delegate //Se o botão for acionado	
            {
                CallLayout(2);
            };

            //BOTÃO PROTEÇÃO
            BUTTON_protecao.Click += delegate //Se o botão for acionado	
            {
                CallLayout(3);
            };

            //BOTÃO GESTAÇÃO
            BUTTON_gestacao.Click += delegate //Se o botão for acionado	
            {
                CallLayout(4);
            };


            //BOTÃO DE VOLTAR

        }

        public override void OnBackPressed()
        {
            base.OnBackPressed();
            
            
        }


        //Pega e armazena a layout atual
        public void CurrentLayout(int cl)
        {
            int currentLayout = cl;
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        //Funções chamada de botões
        protected void CallLayout(int layout)
        {
            CurrentLayout(layout); //Armazena na função qual a atual layout ativa

            if (layout.Equals(1)) //Botão Promoção
                SetContentView(Resource.Layout.Promocao);

            if (layout.Equals(2)) //Botão Prevenção
                SetContentView(Resource.Layout.Prevencao);

            if (layout.Equals(3)) //Botão Proteção
                SetContentView(Resource.Layout.Protecao);

            if (layout.Equals(4)) //Botão Gestação
                SetContentView(Resource.Layout.Gestacao);
            
        }
        //Funções chamada de botões
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

    }
}