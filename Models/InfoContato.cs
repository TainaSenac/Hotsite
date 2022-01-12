using System.Collections.Generic;
namespace pi3.Models
{
    public class InfoContato
    {
        private static List<Contato>  lista = new List<Contato>();
        
        public static void Incluir(Contato contato)
        {
            lista.Add(contato);
        }
        
        public static List<Contato> Lista ()
        {
            return (lista) ;
        }
    }
}