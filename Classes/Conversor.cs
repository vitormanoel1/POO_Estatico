namespace POO_Estatico.Classes
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.10f;
        public static float valorUsuario1;
        public static float ConverterDolarParaReal()
        {
            return valorUsuario1 * cotacaoDolar;
        }
        public static float ConverterRealParaDolar()
        {
            return valorUsuario1 / cotacaoDolar;
        }
        private static float cotacaoEuro = 6.22f;
        public static float valorUsuario2;
        public static float ConverterEuroParaReal()
        {
            return valorUsuario2 * cotacaoEuro;
        }
        public static float ConverterRealParaEuro()
        {
            return valorUsuario2 / cotacaoEuro;
        }
    }
}