namespace DOTNET_DIGITALINNOVATIONONE.Herança
{
    public class Ponto3D : Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x,y){
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular(){
            //Faz Alguma Coisa
        }
        public override void CalcularDistancia3()
        {
            //Faz Outra Coisa
            base.CalcularDistancia3();
        }
    }
}