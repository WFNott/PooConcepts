namespace PooConcepts.Calculadora
{
    public class Operaciones
    {
        private Suma _suma;

        public Operaciones() {
            _suma = new Suma();
        }

        public int Sumar(int num1, int num2)
        {
            _suma.num1 = num1;
            _suma.num2 = num2;

            return _suma.Sumar();
        }
    }
}
