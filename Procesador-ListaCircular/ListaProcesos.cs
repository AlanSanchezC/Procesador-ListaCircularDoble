namespace Procesador_ListaCircular
{
    class ListaProcesos
    {
        private Proceso inicio, turno;

        private int _ciclosVacios = 0;
        public int ciclosVacios
        {
            get { return _ciclosVacios; }
        }

        private int _maxFormados = 0;
        public int maxFormados
        {
            get { return _maxFormados; }
        }

        private int _procesosAtendidos = 0;
        public int procesosAtendidos
        {
            get { return _procesosAtendidos; }
        }

        public void agregar(Proceso p)
        {
            if (inicio == null)
            {
                inicio = p;
                inicio.siguiente = inicio;
                inicio.anterior = inicio;
            }
            else
            {
                Proceso pr = inicio;
                while (pr.siguiente != inicio)
                {
                    pr = pr.siguiente;
                }
                p.siguiente = inicio;
                pr.siguiente = p;
                p.anterior = pr;
                inicio.anterior = p;
            }
             if (cuantosHay() > _maxFormados)
                _maxFormados = cuantosHay();
        }

        public Proceso sacarElemento()
        {
            return inicio;
        }

        public void avanzar()
        {
            if (turno == null)
                turno = inicio;
            else
                turno = turno.siguiente;

            if (inicio == null)
                _ciclosVacios++;
            else
            {
                try
                {
                    turno.tiempo--;
                    if (turno.tiempo == 0)
                    {
                        eliminarProceso(turno);
                        _procesosAtendidos++;
                    }
                }
                catch (System.NullReferenceException) { }
            }
        }

        private void eliminarProceso(Proceso p)
        {
            if (p == p.anterior)
            {
                inicio = null;
                turno = null;
            }
            else
            {
                turno.anterior.siguiente = turno.siguiente;
                turno.siguiente.anterior = turno.anterior;

                if (turno == inicio)
                    inicio = turno.siguiente;
            }
        }
        private int cuantosHay()
        {
            int total = 0;
            Proceso i = inicio;

            do
            {
                total++;
                i = i.siguiente;
            } while (i != inicio);

            return total;
        }
    }
}
