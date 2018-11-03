using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConvertirGrados
{
    class LogicaOperadores
    {
        public string Operar(string operandoA, string Operador)
        {
            string ResultadoConvertido;
            double operando1 = Convert.ToDouble(operandoA);
            Enumerado OperadorEnumerado = ConvertirStringEnumeradoOperadores(Operador);
            double? Resultado = Operar(operando1, OperadorEnumerado);
            if (Resultado != null || operandoA != null)
            {
                ResultadoConvertido = Resultado.ToString();
            }
            else
            {
                ResultadoConvertido = "Error";
                System.Windows.Forms.MessageBox.Show(
                        "No se han introducido datos");
            }
            return ResultadoConvertido;
        }

        private Enumerado ConvertirStringEnumeradoOperadores(string Operador)
        {
            Enumerado Resultado;
            switch (Operador)
            {
                case "Convertir a Fahrenheit":
                case "Convert to Fahrenheit":
                    Resultado = Enumerado.CelciusEnFahrenheit;
                    break;
                case "Convertir a Celcius":
                case "Convert to Celcius":
                    Resultado = Enumerado.FahrenheitEnCelcius;
                    break;
                default:
                    Resultado = Enumerado.Desconocido;
                    break;
            }
            return Resultado;
        }
        private double? Operar(double? operandoA,
                              Enumerado Operador)
        {
            if (operandoA != null)
            {
                double? Resultado = 0.0;
                switch (Operador)
                {
                    case Enumerado.CelciusEnFahrenheit:
                        Resultado = (operandoA*9/5)+32;
                        break;
                    case Enumerado.FahrenheitEnCelcius:
                        Resultado = (operandoA-32)*5/9;
                        break;
                    default:
                        System.Windows.Forms.MessageBox.Show(
                            "No se ha seleccionado ningún operador");
                        break;
                }
                return Resultado;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                        "No se han introducido datos");
                return 0;
            }
        }
    }
}
