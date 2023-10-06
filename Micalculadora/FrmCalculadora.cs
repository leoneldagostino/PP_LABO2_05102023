using System.Drawing.Text;

namespace Micalculadora
{
    public partial class FrmCalculadora : Form
    {

        public FrmCalculadora()
        {
            InitializeComponent();
        }


        private void btnOperar_Click(object sender, EventArgs e)
        {
            setResultado();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            setResultado();

        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            setResultado();

        }



        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void setResultado()
        {

        }
        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {

        }
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {


        }
    }
}