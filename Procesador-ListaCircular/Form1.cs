using System;
using System.Windows.Forms;

namespace Procesador_ListaCircular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lista = new ListaProcesos();
            aleatorio = new Random();
        }

        static Random aleatorio;
        ListaProcesos lista;

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                int num = aleatorio.Next(1, 5);
                if (num == 1)
                {
                    Proceso p1 = new Proceso(aleatorio.Next(2, 6));
                    lista.agregar(p1);
                }

                procedimiento();
                lista.avanzar();
                num = 0;
            }

            txtReporte.Text += "Máximo de procesos formados: " + lista.maxFormados + Environment.NewLine +
                                "Ciclos vacíos: " + lista.ciclosVacios + Environment.NewLine +
                                "Procesos atendidos: " + lista.procesosAtendidos + Environment.NewLine;
            reportePendientes();
        }

        private void procedimiento()
        {
            Proceso pr = lista.sacarElemento();
            Proceso inicio = lista.sacarElemento();
            if (pr != null)
                do
                {
                    string espacios = "  ";
                    if (pr.tiempo > 9) espacios = " ";

                    txtProcedimiento.Text += pr.tiempo.ToString() + espacios;
                    pr = pr.siguiente;

                } while (pr != inicio);
            else
                txtProcedimiento.Text += "NULL";
            txtProcedimiento.Text += Environment.NewLine;
        }

        private void reportePendientes()
        {
            Proceso pr = lista.sacarElemento();
            int suma = 0;
            int cont = 0;

            try
            {
                do
                {
                    suma += pr.tiempo;
                    cont++;
                    pr = pr.siguiente;
                } while (pr != lista.sacarElemento());
            }
            catch (System.NullReferenceException) { }
            txtReporte.Text += cont + " procesos restantes con un tiempo de " + suma;
        }
    }
}
