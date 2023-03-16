// See https://aka.ms/new-console-template for more information

namespace Animal
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Cachorro dogao = new Cachorro("C.Lupus", 17, "casa de seu dono", "mamiferos");
            dogao.EmitirSom();
            dogao.Locomover();
            Cobra Cascavel = new Cobra("Crotalus durissus", 20, "selva", "réptil");
            Cascavel.EmitirSom();
            Cascavel.Locomover();
            PeixePalhaco nemo = new PeixePalhaco("Amphiprioninae", 10, "oceano", "peixe");
            nemo.EmitirSom();
            nemo.Locomover();
        }
    }
}

