namespace AnimalSemRef
{

    public class Cachorro
        {
            public string especie;
            public string habitat;
            public string classe;
            public int expectativaDeVida;

            public Cachorro(string especie, string habitat, string classe, int expectativaDeVida)
            {
                this.especie = especie;
                this.habitat = habitat;
                this.classe = classe;
                this.expectativaDeVida = expectativaDeVida;
            }


            public void EmitirSom()
            {
                Console.WriteLine("AU-AU");
            }

            public void Locomover()
            {
                Console.WriteLine("Cachorros Andam!");
            }


        }
    }

