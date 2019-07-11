namespace ValidaLco.App
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.lblIntegrador = new System.Windows.Forms.Label();
            this.txtIntegrador = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtRfcEmisor = new System.Windows.Forms.TextBox();
            this.txtRfcConsulta = new System.Windows.Forms.TextBox();
            this.lblRfcEmisor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultaRfc = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.txtBxResultado = new System.Windows.Forms.TextBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.Label20);
            this.Panel1.Controls.Add(this.Label19);
            this.Panel1.Controls.Add(this.PictureBoxLogo);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(708, 76);
            this.Panel1.TabIndex = 4;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label20.Location = new System.Drawing.Point(173, 28);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(486, 16);
            this.Label20.TabIndex = 5;
            this.Label20.Text = "En este demo se muestra como hacer uso del WebService ValidaLco";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label19.Location = new System.Drawing.Point(173, 45);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(519, 16);
            this.Label19.TabIndex = 4;
            this.Label19.Text = "para facilitar la integración entre tu sistema y nuestro servicio de timbrado";
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = global::ValidaLco.App.Resources.timbradoLogo_50;
            this.PictureBoxLogo.InitialImage = global::ValidaLco.App.Resources.timbradoLogo_50;
            this.PictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(155, 50);
            this.PictureBoxLogo.TabIndex = 2;
            this.PictureBoxLogo.TabStop = false;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 76);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(708, 371);
            this.TabControl1.TabIndex = 5;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabPage1.Controls.Add(this.GroupBox3);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(700, 345);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Consulta RFC";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.TableLayoutPanel);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox3.Location = new System.Drawing.Point(3, 3);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(694, 339);
            this.GroupBox3.TabIndex = 5;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Ejemplo de consulta de RFC.";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 5;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.Controls.Add(this.btnReestablecer, 4, 0);
            this.TableLayoutPanel.Controls.Add(this.lblIntegrador, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.txtIntegrador, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.txtContraseña, 3, 0);
            this.TableLayoutPanel.Controls.Add(this.lblContraseña, 2, 0);
            this.TableLayoutPanel.Controls.Add(this.txtRfcEmisor, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.txtRfcConsulta, 3, 1);
            this.TableLayoutPanel.Controls.Add(this.lblRfcEmisor, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.label2, 2, 1);
            this.TableLayoutPanel.Controls.Add(this.btnConsultaRfc, 4, 1);
            this.TableLayoutPanel.Controls.Add(this.txtBxResultado, 0, 2);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanel.Location = new System.Drawing.Point(3, 81);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 3;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(688, 255);
            this.TableLayoutPanel.TabIndex = 8;
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Location = new System.Drawing.Point(551, 3);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(134, 23);
            this.btnReestablecer.TabIndex = 0;
            this.btnReestablecer.Text = "Restablecer parametros.";
            this.btnReestablecer.UseVisualStyleBackColor = true;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // lblIntegrador
            // 
            this.lblIntegrador.AutoSize = true;
            this.lblIntegrador.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblIntegrador.Location = new System.Drawing.Point(37, 0);
            this.lblIntegrador.Name = "lblIntegrador";
            this.lblIntegrador.Size = new System.Drawing.Size(97, 30);
            this.lblIntegrador.TabIndex = 1;
            this.lblIntegrador.Text = "Usuario Integrador:";
            this.lblIntegrador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIntegrador
            // 
            this.txtIntegrador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtIntegrador.Location = new System.Drawing.Point(140, 7);
            this.txtIntegrador.Name = "txtIntegrador";
            this.txtIntegrador.Size = new System.Drawing.Size(131, 20);
            this.txtIntegrador.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtContraseña.Location = new System.Drawing.Point(414, 7);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(131, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblContraseña.Location = new System.Drawing.Point(293, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(115, 30);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña Integrador:";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRfcEmisor
            // 
            this.txtRfcEmisor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtRfcEmisor.Location = new System.Drawing.Point(140, 37);
            this.txtRfcEmisor.Name = "txtRfcEmisor";
            this.txtRfcEmisor.Size = new System.Drawing.Size(131, 20);
            this.txtRfcEmisor.TabIndex = 5;
            // 
            // txtRfcConsulta
            // 
            this.txtRfcConsulta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtRfcConsulta.Location = new System.Drawing.Point(414, 37);
            this.txtRfcConsulta.Name = "txtRfcConsulta";
            this.txtRfcConsulta.Size = new System.Drawing.Size(131, 20);
            this.txtRfcConsulta.TabIndex = 6;
            // 
            // lblRfcEmisor
            // 
            this.lblRfcEmisor.AutoSize = true;
            this.lblRfcEmisor.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRfcEmisor.Location = new System.Drawing.Point(69, 30);
            this.lblRfcEmisor.Name = "lblRfcEmisor";
            this.lblRfcEmisor.Size = new System.Drawing.Size(65, 30);
            this.lblRfcEmisor.TabIndex = 7;
            this.lblRfcEmisor.Text = "RFC Emisor:";
            this.lblRfcEmisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(333, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "RFC Consulta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConsultaRfc
            // 
            this.btnConsultaRfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaRfc.Location = new System.Drawing.Point(551, 33);
            this.btnConsultaRfc.Name = "btnConsultaRfc";
            this.btnConsultaRfc.Size = new System.Drawing.Size(134, 23);
            this.btnConsultaRfc.TabIndex = 9;
            this.btnConsultaRfc.Text = "Consulta RFC";
            this.btnConsultaRfc.UseVisualStyleBackColor = true;
            this.btnConsultaRfc.Click += new System.EventHandler(this.btnConsultaRfc_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label9.Location = new System.Drawing.Point(5, 49);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(517, 16);
            this.Label9.TabIndex = 7;
            this.Label9.Text = "Nota: El registro de emisores se puede hacer por medio del web service de timbrad" +
    "o.";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label6.Location = new System.Drawing.Point(6, 24);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(677, 16);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Para poder usar el servicio de consulta de RFCs es necesario tener un usuario int" +
    "egrador y un emisor registrado.";
            // 
            // TabPage5
            // 
            this.TabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabPage5.Controls.Add(this.TextBox1);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(700, 345);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Ventajas del Servicio TimbraCFDI";
            // 
            // TextBox1
            // 
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Location = new System.Drawing.Point(0, 0);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox1.Size = new System.Drawing.Size(700, 345);
            this.TextBox1.TabIndex = 11;
            this.TextBox1.Text = resources.GetString("TextBox1.Text");
            // 
            // txtBxResultado
            // 
            this.TableLayoutPanel.SetColumnSpan(this.txtBxResultado, 5);
            this.txtBxResultado.Location = new System.Drawing.Point(3, 63);
            this.txtBxResultado.Multiline = true;
            this.txtBxResultado.Name = "txtBxResultado";
            this.txtBxResultado.ReadOnly = true;
            this.txtBxResultado.Size = new System.Drawing.Size(679, 189);
            this.txtBxResultado.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 447);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(724, 486);
            this.MinimumSize = new System.Drawing.Size(724, 486);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo - ValidaLco";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.PictureBox PictureBoxLogo;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TabPage TabPage5;
        internal System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.Label lblIntegrador;
        private System.Windows.Forms.TextBox txtIntegrador;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtRfcEmisor;
        private System.Windows.Forms.TextBox txtRfcConsulta;
        private System.Windows.Forms.Label lblRfcEmisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultaRfc;
        private System.Windows.Forms.TextBox txtBxResultado;
    }
}

