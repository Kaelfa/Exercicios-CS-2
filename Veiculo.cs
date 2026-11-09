using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios
{
    public class Veiculo
    {
        public float Velocidade { get; private set; }

        public Veiculo(float Velocidade)
        {

            if (Velocidade > 200)
            {
                Console.WriteLine("Velocidade excede o limite, será considerado 200");
                this.Velocidade = 200;
            }
            else if (Velocidade < 0)
            {
                Console.WriteLine("Velocidade inferior  ao limite, será considerado 0");
                this.Velocidade = 0;
            }
            else
            {
                this.Velocidade = Velocidade;
            }
        }
    }
}

