using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        public SistemaDecimal(string valor):base(valor) 
        {
            
        }
        internal override double ValorNumerico 
        {
            get
            {
                if (double.TryParse(Valor, out double valorDecimal));
                return valorDecimal;
            }
        }
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return this;
            }
            else if (sistema == ESistema.Binario)
            {
                return this.DecimalABinario();
            }
            else
            {
                throw new NotSupportedException("Sistema erroneo");
            }
            
        }

        private bool EsSistemaDecimalValido(string valor)
        {
            if (valor == null)
            {
                return false;
            }
            else if (!double.TryParse(valor,out double valorDouble)) 
            {
                return false;
            }
            return true;
        }

        private SistemaBinario DecimalABinario()
        {
            double.TryParse(Valor,out double valorDecimal);
            if (valorDecimal < 0)
            {
                return "Numero invalido";
            }
            if (valorDecimal == 0)
            {
                return "0";
            }
            string valorBinario = "";
            int resultDiv = (int)valorDecimal;
            int restoDiv;

            while (resultDiv > 0)
            {
                restoDiv = resultDiv % 2;
                resultDiv /= 2;
                valorBinario = restoDiv.ToString() + valorBinario;
            }
            return valorBinario;

        }

        internal bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && this.EsSistemaDecimalValido(valor);   
        }
        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }
        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }
    }

}