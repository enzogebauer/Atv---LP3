namespace AnimalSemRef
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Cachorro dogão = new Cachorro("Pug", "Domestico", "Mamifero", 15);
            PeixePalhaco nemo = new PeixePalhaco("Palhaço", "Oceano", "Peixe", 5);
            Cobra cobrinha = new Cobra("Anaconda", "Selva", "Reptil", 20);

            dogão.EmitirSom();
            nemo.EmitirSom();
            cobrinha.EmitirSom();

            dogão.Locomover();
            nemo.Locomover();
            cobrinha.Locomover();

            Console.ReadLine();
        }

    }
}