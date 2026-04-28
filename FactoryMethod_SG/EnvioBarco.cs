using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodN
{
        public class EnvioBarco : IEnvio
        {
            public void EnviarPaquete()
            {
                Console.WriteLine("Enviando paquete por barco...");
            }
        }
    
}
