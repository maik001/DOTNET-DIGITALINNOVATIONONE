namespace DOTNET_DIGITALINNOVATIONONE.Herança
{
    public class Ponto
    {
        
        public int x, y;




        public Ponto(int x, int y){
            this.x = x;
            this.y = y;
        }


        protected void CalcularDistancia(){
            //Faz alguma coisa...
            CalcularDistancia2();
        }

        private void CalcularDistancia2(){
            //Faz alguma coisa
        }

        public virtual void CalcularDistancia3(){
            //Faz alguma coisa
        }


    }
}