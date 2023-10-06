using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private ESistema sistema;

        private Calculadora()
        {
            throw new System.NotImplementedException();
        }

        public Calculadora()
        {
           operacion = new List<string>();  
        }

        public Calculadora(string nombreAlumno)
        {
            this.NombreAlumno = nombreAlumno;
            operacion = new List<string>();
        }

        public string NombreAlumno
        {
            get
            {
                return nombreAlumno;
            }
            set
            {
                nombreAlumno = value;
            }
        }

        public List<string> Operaciones
        {
            get 
            { 
                return Operaciones; 
            }
            
            
            
        }

        public Numeracion PrimerOperando
        {
            get
            {
                return primerOperando;
            }

            set
            {
                primerOperando = value;
            }
            
        }

        public Numeracion Resultado
        {
            get
            {
                return resultado;
            }
        }

        public Numeracion SegundoOperando
        {
            get 
            { 
                return segundoOperando; 
            }
            set 
            { 
                segundoOperando = value;
            }
        }

        public ESistema Sistema
        {
            get 
            { 
                return sistema; 
            }
            set 
            { 
                sistema = value; 
            }
        }

        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Sistema: ");
            sb.Append(sistema);
            sb.Append(", Primer Operando: ");
            sb.Append(primerOperando.Valor);
            sb.Append(", Segundo Operando: ");
            sb.Append(segundoOperando.Valor);
            sb.Append(", Operador: ");
            sb.Append(operador);
            operaciones.Add(sb.ToString());
        }

        public void Calcular()
        {
            Calcular('+'); ;
        }

        public void Calcular(char operador)
        {
            if (primerOperando != null && segundoOperando != null && primerOperando.GetType() == segundoOperando.GetType())
            {
                double valor1 = primerOperando.ValorNumerico;
                double valor2 = segundoOperando.ValorNumerico;
                double resultadoCalculado = 0;

                switch (operador)
                {
                    case '+':
                        resultadoCalculado = valor1 + valor2;
                        break;
                    case '-':
                        resultadoCalculado = valor1 - valor2;
                        break;
                    case '*':
                        resultadoCalculado = valor1 * valor2;
                        break;
                    case '/':
                        if (valor2 != 0)
                        {
                            resultadoCalculado = valor1 / valor2;
                        }
                        else
                        {
                            resultadoCalculado = double.MinValue;
                        }
                        break;
                    default:
                        break;
                }

                resultado = new SistemaDecimal(resultadoCalculado.ToString());
                ActualizaHistorialDeOperaciones(operador);
            }
            else
            {
                resultado = new SistemaDecimal(double.MinValue.ToString());
            }
        }

    }

    public void EliminarHistorialDeOperaciones()
        {
            operaciones.Clear();
        }

        private void MapeaResultado(double valor)
    {
        switch (sistema)
        {
            case ESistema.Decimal:
                return new SistemaDecimal(resultado.Valor);
            case ESistema.Binario:
                return new SistemaBinario(resultado.Valor);
            default:
                return new SistemaDecimal(Resultado.Valor);
        }
    }

}

