using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ValidaLco.Negocios;
using ValidaLco.Negocios.Config;
using ValidaLco.Negocios.Connected_Services.Cliente;
using ValidaLco.Negocios.Entidades.Emisores;
using ValidaLco.Negocios.Entidades.Integradores;
using ValidaLco.Negocios.Excepciones;

namespace ValidaLco.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            AsignaDatosPorDefecto();
        }

        private void AsignaDatosPorDefecto()
        {
            var configuracion = ObtenConfiguracion();
            var integrador = configuracion.IntegradorPorDefecto;
            txtContraseña.Text = integrador.UsuarioIntegrador.Contraseña;
            txtIntegrador.Text = integrador.UsuarioIntegrador.Usuario;
            txtRfcConsulta.Text = RFC.Profact.Valor;
            txtRfcEmisor.Text = integrador.Emisor.Valor;
        }

        private IConfiguracionKit ObtenConfiguracion()
        {
            return UtilsConfigSections.ObtenConfiguracionKit();
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            AsignaDatosPorDefecto();
        }

        private void btnConsultaRfc_Click(object sender, EventArgs e)
        {
            PreparaFormularioParaConsulta();

            ManejaExcepciones(() =>
            {
                var cliente = new ValidaLCOSoapClient();
                var integrador = ProcesaUsuarioIntegrador();
                var emisor = txtRfcEmisor.Text;
                var consulta = txtRfcConsulta.Text;

                Logger.Log("Inicia consulta de rfc.");

                UtilsServicePointManager.AceptaErroresSsl();
                var resultado = cliente.ConsultaRfc(integrador.Valor, emisor, consulta);

                Logger.Log("Finaliza consulta de rfc");

                MuestraResultado(resultado);
                PreparaFormularioParaFinDeConsulta();
            });

        }

        private void PreparaFormularioParaFinDeConsulta()
        {
            TableLayoutPanel.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void MuestraResultado(ResultadoConsultaRfc resultado)
        {
            if (resultado == null)
            {
                throw new ArgumentNullException(nameof(resultado));
            }

            var serializer = new XmlSerializer(typeof(ResultadoConsultaRfc));
            var memoryStream = new MemoryStream();
            var settings = new XmlWriterSettings {Indent = true};
            var xmlWriter = XmlWriter.Create(memoryStream, settings);
            serializer.Serialize(xmlWriter, resultado);
            var streamReader = new StreamReader(memoryStream);

            memoryStream.Position = 0;

           txtBxResultado.Text = streamReader.ReadToEnd();
        }

        private TokenIntegrador ProcesaUsuarioIntegrador()
        {
            return new TokenIntegrador()
            {
                Usuario = txtIntegrador.Text.Trim(),
                Contraseña = txtContraseña.Text.Trim()
            };
        }

        private void PreparaFormularioParaConsulta()
        {
            Cursor = Cursors.WaitCursor;
            TableLayoutPanel.Enabled = false;
            txtBxResultado.Text = string.Empty;
        }

        private void ManejaExcepciones(Action action)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                Logger.Log("Error al realizar la consulta.", ex);
                MessageBox.Show("Error al ejecutar consulta. Consulte el log para ver los detalles.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

      
    }
}
