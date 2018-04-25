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
    class Buttons : Activity
    {
        ImageButton BUTTON_promocao;
        ImageButton BUTTON_prevencao;
        ImageButton BUTTON_gestacao;

        ImageButton BUTTON_ObjetivosMilenio;
        ImageButton BUTTON_PrincipiosSUS;
        ImageButton BUTTON_ProtecaoGestacao;
        ImageButton BUTTON_MetodosContraceptivos;

        //Função usada para acinar os listeners dos botões, precisa ser separada por telas?  
        public void ImageButtons()
        {
            //Escutando os botões baseado em qual tela o user está
            AppActivity AA = new AppActivity();
            int CL = AA.ReturnLayout();

            if (CL.Equals(0)) //Se for a Main
            {
                BUTTON_promocao = FindViewById<ImageButton>(Resource.Id.BUT_promo);
                BUTTON_prevencao = FindViewById<ImageButton>(Resource.Id.BUT_preve);
                BUTTON_gestacao = FindViewById<ImageButton>(Resource.Id.BUT_gesta);
            }
            if (CL.Equals(1)) //Se for a tela de promoção
            {
                BUTTON_ObjetivosMilenio = FindViewById<ImageButton>(Resource.Id.BUT_OM);
                BUTTON_PrincipiosSUS = FindViewById<ImageButton>(Resource.Id.BUT_SUS);
                BUTTON_ProtecaoGestacao = FindViewById<ImageButton>(Resource.Id.BUT_PG);
                BUTTON_MetodosContraceptivos = FindViewById<ImageButton>(Resource.Id.BUT_MC);
            }
        }

        //Função usada para pegar um botão em específico
        public ImageButton CallImageButtons(int BV)
        {
            ImageButton Final = null;

            if (BV.Equals(1))
                Final = BUTTON_promocao;

            if (BV.Equals(2))
                Final = BUTTON_prevencao;

            if (BV.Equals(3))
                Final = BUTTON_gestacao;

            if (BV.Equals(11))
                Final = BUTTON_ObjetivosMilenio;

            if (BV.Equals(12))
                Final = BUTTON_PrincipiosSUS;

            if (BV.Equals(13))
                Final = BUTTON_ProtecaoGestacao;

            if (BV.Equals(14))
                Final = BUTTON_MetodosContraceptivos;

            return Final;
        }
        
    }
}