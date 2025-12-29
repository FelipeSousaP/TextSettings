namespace TextSetting1_0
{
    public class TextSetting
    {
        private static string _Frase = "";
        private static int _delay;
        private static int _top;
        private static ConsoleColor _Color;
        private static string[] strings;
        private static string _PalavraCentralizada = "";

        static public void Sentence(string escrever)
        {
            _Frase = escrever;
            ExceptionWith1Attritubes(_Frase);
        }
        public static void Sentence(string escrever, int delay)
        {
            _Frase = escrever;
            _delay = delay;
            ExceptionWith2Attributes(_Frase,_delay);
        }
        public static void Sentence(string escrever, int delay, int Descer)
        {
            _Frase = escrever;
            _delay = delay;
            _top = Descer;
            ExceptionWith3Attributes(_Frase, _delay, _top);
        }
        public static void Sentence(string escrever, int delay, int Descer, ConsoleColor color)
        {
            _Frase = escrever;
            _delay = delay;
            _top = Descer;
            _Color = color;
            ColorText(_Color, _Frase, _delay, _top);
        }
        public static void Sentence(string escrever, int delay, int Descer, ConsoleColor color, bool Centralizar) 
        {
            _Frase = escrever;
            _delay = delay;
            _top = Descer;
            _Color = color;
            OtherException(Centralizar,_Frase,_delay,_top,_Color);
        }

        static void ExceptionWith1Attritubes(string msg) 
        {
            try
            {
                FinalSentence(msg);
            }
            catch (ArgumentNullException e){
                Console.WriteLine("Infelizmmente a mensagem não é um string" + e.Message);            
            }
        }
        static void ExceptionWith2Attributes(string _frase, int delay)
        {
            try
            {
                FinalSentence(DelayApply(_frase,delay));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ExceptionWith3Attributes(string _frase, int delay, int Descer)
        {
            try
            {
                ToDescendText(_frase, Descer,delay);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("O numero colocado representa a quantidadde de linhas descidas no programa, não coloque um numero muito alto e nem abaixo de zero" + ex.Message);
            }
        }
        static void OtherException(bool centro, string frase,int delay, int descer, ConsoleColor color)
        {
            if (centro)
            {
                strings = frase.Split("\n");
                for(int i = 0; i < strings.Length; i++)
                {
                    string d = strings[i];
                    _PalavraCentralizada = Espaço(d) + d;
                    ColorText(color, _PalavraCentralizada,delay,descer + i);
                }
            }
            else
            {
                throw new ArgumentException("Para centralizar, a variavel deve ser verdadeira");
            }        
        }

        static private void FinalSentence(string sentence) => Console.WriteLine(sentence);
        private static string DelayApply(string fraase, int delay)
        {
            foreach (char item in fraase)
            {
                Thread.Sleep(delay);
                Console.Write(item);
            }
            return ""; 
        }
        private static void ToDescendText(string frase, int _descend, int delay)
        {
             Console.SetCursorPosition(0, _descend);
             FinalSentence(DelayApply(frase,delay));
        }
        private static void ColorText(ConsoleColor color, string frase, int delay, int Descer)
        {
            Console.ForegroundColor = color;
            ExceptionWith3Attributes(frase, delay, Descer);
        }
        private static string Espaço(string frase) 
        {
            int janela = Console.WindowWidth;
            int Space = (janela - frase.Length) / 2;
            return new string(' ', Space);
        }
    }
}
