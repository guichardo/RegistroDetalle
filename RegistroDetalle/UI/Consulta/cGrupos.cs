using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDetalle.UI.Consulta
{
    public partial class cGrupos : Form
    {
        public cGrupos()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            //Inicializando el filtro en True
            Expression<Func<Grupos, bool>> filtro = p => true;

            int id;
            switch (filtrarcomboBox.SelectedIndex)
            {
                case 1://ID
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = p => p.GrupoId == id
                    && (p.Fecha >= DesdedateTimePicker.Value && p.Fecha <= HastadateTimePicker.Value);
                    break;

            }


            ConsultadataGridView.DataSource = BLL.GruposBLL.GetList(filtro);
        }
    }
}
