namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone()
        {

        }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...♫♪");
        }

        public void AlterarNumero()
        {
            Console.WriteLine($"Seu novo número é {Numero}");
        }
        public void ExibirDados()

        {
            Console.WriteLine($"O seu celular tem modelo {Modelo}, IMEI {IMEI}, memória de {Memoria} GB e número {Numero}");
        }
        
        public abstract void InstalarAplicativo(string nomeApp);
    }
}