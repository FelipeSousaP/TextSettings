namespace TextSetting1_0
{
    public class TextManeger
    {
        //class estaticas nnão comportam herança
        static protected string FraseGuardada;
        static protected string novafrase;
        static protected int _delay;
        static protected int _position;

        static public void Escrita(string escrever)
        {
            FraseGuardada = escrever;
            Console.WriteLine(FraseGuardada);
        }
        public static void Escrita(string escrever, int delay)
        {
            FraseGuardada = escrever;
            _delay = delay;
            AplicadordeDelay();
        }
        public static void Escrita(string escrever, int delay, int postição)
        {
            FraseGuardada = escrever;
            _delay = delay;
            _position = postição;
            AplicadordeDelay();
        }

        private static void AplicadordeDelay()
        {
            foreach (char item in FraseGuardada)
            { 
                Thread.Sleep(_delay);
                Console.Write(item);
            }
        }
        
    }
}
