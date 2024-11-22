using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESERCIZIOFINALE
{

    public partial class frmFinale : Form
    {
        string[] modelliBiciElettrica = new string[]
           {
                "Model X",
                "E-Bike 3000",
                "Volt Runner",
                "Speedster 5000",
                "Urban Glide",
                "EcoCruise"
           };

        // Array delle marche delle biciclette elettriche
        string[] marcheBiciElettrica = new string[]
        {
                "Bianchi",
                "Trek",
                "Cannondale",
                "Giant",
                "Riese & Müller",
                "Specialized"
        };

        private listBici listaBici;
        private dictBici dizionarioBici;
        public frmFinale()
        {
            InitializeComponent();
            cmbMarca.DataSource=marcheBiciElettrica;
            cmbModello.DataSource = modelliBiciElettrica;
            listaBici=new listBici();
            dizionarioBici = dictBici.Create();
            listaBici.superiore700 += AvvisaUtente;
        }

        private void AvvisaUtente()
        {
            MessageBox.Show("Nota: Si è inserito una bici con potenza maggiore a  700");
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                clsBiciElettrica bici = new clsBiciElettrica(cmbModello.Text, txtTelaio.Text, txtCambio.Text, txtColore.Text, txtPeso.Text, cmbMarca.Text, nudPotenza.Value.ToString(), txtPrezzo.Text);
                listaBici.inserire(bici);
                dizionarioBici.InserireBici(bici);
                listaBici.visualizzare(dgvListaBici);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
