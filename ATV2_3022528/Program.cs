namespace ATV2_3022528
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atividade 1 - Lista


            Console.WriteLine("Digite o seu valor em metros: ");
            double quantidade = double.Parse(Console.ReadLine());
            double centimetros = quantidade / 100;
            double milimetros = quantidade / 1000;

            Console.WriteLine("O seu valor em centímetros é: " + centimetros.ToString("0.00"));
            Console.WriteLine("O seu valor em milímetros é: " + milimetros.ToString("0.00"));
            Console.ReadKey();

            //Atividade 2 - Lista
            Console.WriteLine("Digite o valor em Fahrenheit: ");
            float f_graus = float.Parse(Console.ReadLine());
            float c_graus;

            Console.WriteLine("Digite o valor novamente: ");
            int f_graus1 = int.Parse(Console.ReadLine());
            int c_graus1;

            c_graus = (f_graus - 32.0f) * (5.0f / 9.0f);
            c_graus1 = (f_graus1 - 32) * (5 / 9);
            Console.WriteLine("O resultado em celsius com float é: {0} \n O resultado em celsius com inteiro é: {1}", c_graus, c_graus1);


            //Atividade 3 - Lista
            Console.WriteLine("Digite sua altura em metros: ");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso em kilos: ");
            float peso = float.Parse(Console.ReadLine());
            float imc;
            imc = peso / (altura * altura);
            Console.WriteLine("O seu IMC é: " + imc.ToString());
        }
    }
}
