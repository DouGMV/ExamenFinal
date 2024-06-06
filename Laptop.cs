namespace ExamenFinal
{
    public class Laptop : Dispositivo
    {
        public string Ram {  get; set; }
        public string Almacenamiento { get; set; }

        public Laptop() 
        { 
            Ram = string.Empty;
            Almacenamiento = string.Empty;
        }
    }
}
