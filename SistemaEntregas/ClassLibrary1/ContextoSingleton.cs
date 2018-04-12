using System;
using modelos.dao;

namespace Controller
{
    public class ContextoSingleton
    {
        private static Contexto instancia;

        public static Contexto Instacia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Contexto();
                }
                
                    return instancia;                
            }
       }
        private ContextoSingleton()
        {

        }

    }
}
