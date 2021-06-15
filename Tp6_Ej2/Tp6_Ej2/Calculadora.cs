

using System;

namespace Tp7
{
    public class Calculadora
    {
        private float numero1;
        private float numero2;
        private string operacion;
        private DateTime fechaYhora;

        public Calculadora()
        {
           
        }

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public DateTime FechaYHora { get => fechaYhora; set => fechaYhora = value; }

        public float Suma()
        {
            return numero1 + numero2;
        }

        public float Resta()
        {
            return numero1 - numero2;
        }

        public float Multiplicacion()
        {
            return numero1 * numero2;
        }

        public float Division()
        {
            return (float)Math.Round(numero1 / numero2, 2);
        }

    }


}
