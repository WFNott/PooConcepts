namespace PooConcepts.Calculadora
{
    public class Suma
    {
        public int num1 { get; set; }

        public int num2 { get; set; }

        public Suma()
        {

        }

        public Suma(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Sumar()
        {
            return num1 + num2;
        }
    }
}
