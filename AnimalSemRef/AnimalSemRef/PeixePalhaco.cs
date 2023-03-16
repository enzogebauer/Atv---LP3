namespace AnimalSemRef;

public class PeixePalhaco
{ 
    
        public string especie;
        public string habitat;
        public string classe;
        public int expectativaDeVida;

        public PeixePalhaco(string especie, string habitat, string classe, int expectativaDeVida)
        {
            this.especie = especie;
            this.habitat = habitat;
            this.classe = classe;
            this.expectativaDeVida = expectativaDeVida;
        }


        public void EmitirSom()
        {
            Console.WriteLine("blub-blub");
        }

        public void Locomover()
        {
            Console.WriteLine("Peixes nadam!");
        }
}
