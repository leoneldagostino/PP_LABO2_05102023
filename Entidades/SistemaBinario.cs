using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor)
        {

        }

        internal double ValorNumerico
        {
            get
            {
                return (double)this.BinarioADecimal();
            }

        }

        private SistemaDecimal BinarioADecimal()
        {
            if (!string.IsNullOrWhiteSpace(Valor) && EsSistemaBinarioValido(valor) && !valor.Contains(msgError))
            {
                double resultado = 0;
                int cantidadCaracteres = valor.Length;

                for (int i = 0; i < cantidadCaracteres; i++)
                {
                    char caracter = valor[i];
                    int bvalor = caracter - '0';
                    int potencia = cantidadCaracteres - 1;
                    resultado += bvalor * Math.Pow(2, potencia);
                }
                return new SistemaDecimal(resultado.ToString());
            }

            return new SistemaDecimal("Error: Valor binario no valido.");


        }

        public Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
               
                SistemaDecimal sistemaDecimal = BinarioADecimal();
                return sistemaDecimal;
            }
            else
            {

                return this;
            }

        }

        internal bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && this.EsSistemaBinarioValido(valor);
        }

        private bool EsSistemaBinarioValido(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                foreach (char caracter in valor)
                {
                    if (caracter > '1')
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public static implicit operator SistemaBinario(string valor)
        {
            if (new SistemaBinario(valor).EsSistemaBinarioValido(valor))
            {
                return new SistemaBinario(valor);
            }
            else
            {
                throw new Exception("Sistema no valido");
            }
        }
    }
}
