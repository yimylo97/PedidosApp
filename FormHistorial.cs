using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosApp
{
    public partial class FormHistorial : Form
    {
        public FormHistorial()
        {
            InitializeComponent();
            CargarHistorial();

            cmbFiltroEntrega.Items.Add("Todos");
            cmbFiltroEntrega.Items.Add("Dron");
            cmbFiltroEntrega.Items.Add("Motocicleta");
            cmbFiltroEntrega.Items.Add("Camión");
            cmbFiltroEntrega.Items.Add("Bicicleta");
            cmbFiltroEntrega.SelectedIndex = 0;

            cmbFiltroEntrega.SelectedIndexChanged += (s, e) => CargarHistorial();
        }

        private void CargarHistorial()
        {
            var pedidos = RegistroPedidos.Instancia.Pedidos;

            string filtro = cmbFiltroEntrega.SelectedItem?.ToString();

            if (filtro != "Todos")
            {
                pedidos = pedidos
                    .Where(p => p.MetodoEntrega.TipoEntrega() == filtro).ToList();
            }

            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = pedidos
                .Select(p => new
                {
                    p.Cliente,
                    p.Producto,
                    p.Urgente,
                    p.Peso,
                    p.Distancia,
                    TipoEntrega = p.MetodoEntrega.TipoEntrega(),
                    Costo = p.ObtenerCosto()
                }).ToList();
        }
    }
}
