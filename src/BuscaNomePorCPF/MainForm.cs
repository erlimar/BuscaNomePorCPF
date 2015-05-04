using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaNomePorCPF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ClearResultScreen()
        {
            lblNomeResultado.Text = "...";
            txtResultado.Text = string.Empty;

            lblSituacaoCPFEncontrado.Text = "...";
        }

        private void EnableDisableScreen(bool enabled)
        {
            lblCPF.Enabled = enabled;
            txtCPF.Enabled = enabled;
            btnBuscar.Enabled = enabled;
            lblNome.Enabled = enabled;
            lblNomeResultado.Enabled = enabled;
            lblSituacaoCPF.Enabled = enabled;
            lblSituacaoCPFEncontrado.Enabled = enabled;
            txtResultado.Enabled = enabled;

            if (enabled)
                txtCPF.Focus();
        }

        private void DisableScreen()
        {
            EnableDisableScreen(false);
        }

        private void EnableScreen()
        {
            EnableDisableScreen(true);
        }

        private string FormatCPF(string cpf)
        {
            if(cpf != null && cpf.Length == 11)
            {
                cpf = ""
                    + cpf.Substring(0, 3) + "."
                    + cpf.Substring(3, 3) + "."
                    + cpf.Substring(6, 3) + "-"
                    + cpf.Substring(9, 2);
            }
            return cpf;
        }

        private string PrepareCPF(string cpf)
        {
            if (Regex.IsMatch(cpf, @"^[0-9-.]*$"))
            {
                cpf = cpf
                    .Replace(".", string.Empty)
                    .Replace("-", string.Empty);
            }

            return cpf;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClearResultScreen();
            DisableScreen();
            try
            {
                var url = string.Format(
                    "http://www.nomesbrasil.com/n/s?s=1&kw=\"{0}\"",
                    PrepareCPF(txtCPF.Text));

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");

                    using (var response = client.GetAsync(url))
                    using (var content = response.Result.Content)
                    {
                        var resultado = JsonConvert.DeserializeObject<Resultado>(content.ReadAsStringAsync().Result);

                        txtResultado.Text = resultado.search_info;

                        if(resultado.found && resultado.items.Count == 1){
                            var item = resultado.items[0];

                            lblNomeResultado.Text = item.name;
                            lblSituacaoCPFEncontrado.Text = string.Format("{0}/{1}", FormatCPF(item.rf_cpf), item.rf_status);
                        }
                        else if (resultado.found && resultado.items.Count > 0)
                        {
                            txtResultado.Text = txtResultado.Text +
                                string.Format("\r\n\r\n--- --- ---\r\n{0}",
                                "Somente resultados com 1 (um) único item são considerados.");
                        }
                    }
                }
            }catch(Exception error)
            {
                txtResultado.Text = string.Format( "Erro: \n {0}", error.Message);
            }
            finally
            {
                EnableScreen();
            }
        }

        private void txtCPF_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }
    }
}
