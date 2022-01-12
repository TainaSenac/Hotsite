namespace pi3.Models
{
    public static class Dados
    {
        public static Contato contatoAtual {get; set;}
        static Dados()
        {
            contatoAtual = new Contato();
        }
    }
}