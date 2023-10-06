using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Numeracion
    {
        protected string msgError;
        protected string valor;

        private Numeracion()
        {
            msgError = "Valor Invalido";
            
        }
        protected Numeracion(string valor)
        {

            InicializaValor(valor);

        }

        public string Valor
        {
            get 
            {
                return valor;
            }
        }
        internal virtual double ValorNumerico
        {
            get
            {
                double.TryParse(Valor, out double v);
                double valorNumerico = v;
                return valorNumerico;
            }
        }
        protected bool EsNumeracionValida(string valor)
        {
            
            return !string.IsNullOrWhiteSpace(valor);
        }
        private void InicializaValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = msgError;
            }

        }
        public virtual Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            
        }
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            if (n1 == null)
            {
                return false;
            }
            if(n1.GetType() == n2.GetType())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Numeracion n1,Numeracion n2)
        {
            return !(n1 == n2);
        }
        public static explicit operator double(Numeracion numeracion)
        {
            if(double.TryParse(numeracion.Valor, out double valorDouble))
            {
                return valorDouble;
            }
            else
            {
                return double.NaN;
            }
            
        }



    }
}
