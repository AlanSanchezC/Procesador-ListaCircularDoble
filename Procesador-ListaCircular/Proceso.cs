namespace Procesador_ListaCircular
{
    class Proceso
    {
        public int tiempo { get; set; }
        public Proceso siguiente { get; set; }
        public Proceso anterior { get; set; }

        public Proceso(int time)
        {
            tiempo = time;
        }
    }
}
