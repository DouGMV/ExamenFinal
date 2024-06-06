namespace ExamenFinal
{
    public class Smartphone : Dispositivo
    {
        public string pantalla {  get; set; }
        public string stylus { get; set; }

        public Smartphone()
        {
            pantalla = string.Empty;
            stylus = string.Empty;
        }

    }
}
