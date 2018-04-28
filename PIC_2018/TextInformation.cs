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
    class TextInformation
    {

        // CLASSE USADA APENAS PARA PUXAR OS TEXTOS INFORMATIVOS, QUE SERÃO PUXADOS DEPENDENDO DE QUAL BOTÃO ACIONADO

        string data;
        public string InfoData(int tag)
        {
            if (tag.Equals(11)) InfoObjetivos();
            else if (tag.Equals(21)) InfoDoencas();
            else return "Texto não disponível";

            return data;
        }

        // -- -- -- -- FUNÇÕES COM OS TEXTOS -- -- -- --
        protected void InfoObjetivos()
        {
            data = "TEXTO BASE OBJETIVOS QUE FOI PUXADA DE OUTRA CLASSE TESTE PARA VER SE ELE FUNCIONA!";
        }

        protected void InfoDoencas()
        {
            data = "TEXTO BASE DOENCAS QUE FOI PUXADA DE OUTRA CLASSE TESTE PARA VER SE ELE FUNCIONA!";
        }
        // -- -- -- -- FUNÇÕES COM OS TEXTOS -- -- -- --

    }
}