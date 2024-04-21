namespace Tango.PublicarPedidoDeEnvio
{
    partial class PublicarPedidoDeEnvio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipoDeCarga = new System.Windows.Forms.Label();
            this.lblSeleccione = new System.Windows.Forms.Label();
            this.cmbTipoDeCarga = new System.Windows.Forms.ComboBox();
            this.lblDomicilioDeRetiro = new System.Windows.Forms.Label();
            this.lblCalleRetiro = new System.Windows.Forms.Label();
            this.txtCalleRetiro = new System.Windows.Forms.TextBox();
            this.lblNumeroRetiro = new System.Windows.Forms.Label();
            this.txtNumeroRetiro = new System.Windows.Forms.TextBox();
            this.lblProvinciaRetiro = new System.Windows.Forms.Label();
            this.cmbProvinciaRetiro = new System.Windows.Forms.ComboBox();
            this.lblLocalidadRetiro = new System.Windows.Forms.Label();
            this.txtLocalidadRetiro = new System.Windows.Forms.TextBox();
            this.lblReferenciaRetiro = new System.Windows.Forms.Label();
            this.txtReferenciaRetiro = new System.Windows.Forms.TextBox();
            this.lblFechaDeRetiro = new System.Windows.Forms.Label();
            this.lblIngreseRetiro = new System.Windows.Forms.Label();
            this.mtbRetiro = new System.Windows.Forms.MaskedTextBox();
            this.mtbEnvio = new System.Windows.Forms.MaskedTextBox();
            this.lblIngreseEnvio = new System.Windows.Forms.Label();
            this.lblFechaDeEnvio = new System.Windows.Forms.Label();
            this.txtReferenciaEnvio = new System.Windows.Forms.TextBox();
            this.lblReferenciaEnvio = new System.Windows.Forms.Label();
            this.txtLocalidadEnvio = new System.Windows.Forms.TextBox();
            this.lblLocalidadEnvio = new System.Windows.Forms.Label();
            this.lblProvinciaEnvio = new System.Windows.Forms.Label();
            this.txtNumeroEnvio = new System.Windows.Forms.TextBox();
            this.lblNumeroEnvio = new System.Windows.Forms.Label();
            this.txtCalleEnvio = new System.Windows.Forms.TextBox();
            this.lblCalleEnvio = new System.Windows.Forms.Label();
            this.lblDomicilioDeEnvio = new System.Windows.Forms.Label();
            this.lblAdjuntarFotos = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbProvinciaEnvio = new System.Windows.Forms.ComboBox();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grdFotos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(205)))), ((int)(((byte)(79)))));
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1000, 90);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(205)))), ((int)(((byte)(79)))));
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 28F);
            this.lblTitulo.Location = new System.Drawing.Point(37, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(433, 46);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Publicar pedido de envío";
            // 
            // lblTipoDeCarga
            // 
            this.lblTipoDeCarga.AutoSize = true;
            this.lblTipoDeCarga.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.lblTipoDeCarga.Location = new System.Drawing.Point(70, 115);
            this.lblTipoDeCarga.Name = "lblTipoDeCarga";
            this.lblTipoDeCarga.Size = new System.Drawing.Size(146, 23);
            this.lblTipoDeCarga.TabIndex = 2;
            this.lblTipoDeCarga.Text = "Tipo de carga (*)";
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.AutoSize = true;
            this.lblSeleccione.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccione.Location = new System.Drawing.Point(70, 155);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(93, 19);
            this.lblSeleccione.TabIndex = 3;
            this.lblSeleccione.Text = "Seleccione:";
            // 
            // cmbTipoDeCarga
            // 
            this.cmbTipoDeCarga.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTipoDeCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeCarga.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cmbTipoDeCarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.cmbTipoDeCarga.FormattingEnabled = true;
            this.cmbTipoDeCarga.Items.AddRange(new object[] {
            "Documentación",
            "Paquete",
            "Granos",
            "Hacienda"});
            this.cmbTipoDeCarga.Location = new System.Drawing.Point(177, 155);
            this.cmbTipoDeCarga.Name = "cmbTipoDeCarga";
            this.cmbTipoDeCarga.Size = new System.Drawing.Size(200, 26);
            this.cmbTipoDeCarga.TabIndex = 4;
            // 
            // lblDomicilioDeRetiro
            // 
            this.lblDomicilioDeRetiro.AutoSize = true;
            this.lblDomicilioDeRetiro.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.lblDomicilioDeRetiro.Location = new System.Drawing.Point(70, 205);
            this.lblDomicilioDeRetiro.Name = "lblDomicilioDeRetiro";
            this.lblDomicilioDeRetiro.Size = new System.Drawing.Size(190, 23);
            this.lblDomicilioDeRetiro.TabIndex = 5;
            this.lblDomicilioDeRetiro.Text = "Domicilio de retiro (*)";
            // 
            // lblCalleRetiro
            // 
            this.lblCalleRetiro.AutoSize = true;
            this.lblCalleRetiro.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalleRetiro.Location = new System.Drawing.Point(70, 245);
            this.lblCalleRetiro.Name = "lblCalleRetiro";
            this.lblCalleRetiro.Size = new System.Drawing.Size(51, 19);
            this.lblCalleRetiro.TabIndex = 6;
            this.lblCalleRetiro.Text = "Calle:";
            // 
            // txtCalleRetiro
            // 
            this.txtCalleRetiro.BackColor = System.Drawing.SystemColors.Window;
            this.txtCalleRetiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalleRetiro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalleRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtCalleRetiro.Location = new System.Drawing.Point(127, 245);
            this.txtCalleRetiro.Name = "txtCalleRetiro";
            this.txtCalleRetiro.Size = new System.Drawing.Size(250, 20);
            this.txtCalleRetiro.TabIndex = 7;
            // 
            // lblNumeroRetiro
            // 
            this.lblNumeroRetiro.AutoSize = true;
            this.lblNumeroRetiro.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRetiro.Location = new System.Drawing.Point(70, 285);
            this.lblNumeroRetiro.Name = "lblNumeroRetiro";
            this.lblNumeroRetiro.Size = new System.Drawing.Size(72, 19);
            this.lblNumeroRetiro.TabIndex = 8;
            this.lblNumeroRetiro.Text = "Número:";
            // 
            // txtNumeroRetiro
            // 
            this.txtNumeroRetiro.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumeroRetiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroRetiro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtNumeroRetiro.Location = new System.Drawing.Point(151, 285);
            this.txtNumeroRetiro.Name = "txtNumeroRetiro";
            this.txtNumeroRetiro.Size = new System.Drawing.Size(50, 20);
            this.txtNumeroRetiro.TabIndex = 9;
            // 
            // lblProvinciaRetiro
            // 
            this.lblProvinciaRetiro.AutoSize = true;
            this.lblProvinciaRetiro.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinciaRetiro.Location = new System.Drawing.Point(70, 325);
            this.lblProvinciaRetiro.Name = "lblProvinciaRetiro";
            this.lblProvinciaRetiro.Size = new System.Drawing.Size(81, 19);
            this.lblProvinciaRetiro.TabIndex = 10;
            this.lblProvinciaRetiro.Text = "Provincia:";
            // 
            // cmbProvinciaRetiro
            // 
            this.cmbProvinciaRetiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvinciaRetiro.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cmbProvinciaRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.cmbProvinciaRetiro.FormattingEnabled = true;
            this.cmbProvinciaRetiro.Items.AddRange(new object[] {
            "Buenos Aires",
            "CABA",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santiago del Estero",
            "Tierra del Fuego",
            "Tucumán"});
            this.cmbProvinciaRetiro.Location = new System.Drawing.Point(177, 324);
            this.cmbProvinciaRetiro.MaxDropDownItems = 12;
            this.cmbProvinciaRetiro.Name = "cmbProvinciaRetiro";
            this.cmbProvinciaRetiro.Size = new System.Drawing.Size(200, 26);
            this.cmbProvinciaRetiro.TabIndex = 11;
            // 
            // lblLocalidadRetiro
            // 
            this.lblLocalidadRetiro.AutoSize = true;
            this.lblLocalidadRetiro.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidadRetiro.Location = new System.Drawing.Point(70, 365);
            this.lblLocalidadRetiro.Name = "lblLocalidadRetiro";
            this.lblLocalidadRetiro.Size = new System.Drawing.Size(84, 19);
            this.lblLocalidadRetiro.TabIndex = 12;
            this.lblLocalidadRetiro.Text = "Localidad:";
            // 
            // txtLocalidadRetiro
            // 
            this.txtLocalidadRetiro.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocalidadRetiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocalidadRetiro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidadRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtLocalidadRetiro.Location = new System.Drawing.Point(177, 365);
            this.txtLocalidadRetiro.Name = "txtLocalidadRetiro";
            this.txtLocalidadRetiro.Size = new System.Drawing.Size(200, 20);
            this.txtLocalidadRetiro.TabIndex = 13;
            // 
            // lblReferenciaRetiro
            // 
            this.lblReferenciaRetiro.AutoSize = true;
            this.lblReferenciaRetiro.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferenciaRetiro.Location = new System.Drawing.Point(70, 405);
            this.lblReferenciaRetiro.Name = "lblReferenciaRetiro";
            this.lblReferenciaRetiro.Size = new System.Drawing.Size(168, 19);
            this.lblReferenciaRetiro.TabIndex = 14;
            this.lblReferenciaRetiro.Text = "Referencia (opcional):";
            // 
            // txtReferenciaRetiro
            // 
            this.txtReferenciaRetiro.BackColor = System.Drawing.SystemColors.Window;
            this.txtReferenciaRetiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReferenciaRetiro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferenciaRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtReferenciaRetiro.Location = new System.Drawing.Point(70, 435);
            this.txtReferenciaRetiro.Name = "txtReferenciaRetiro";
            this.txtReferenciaRetiro.Size = new System.Drawing.Size(307, 20);
            this.txtReferenciaRetiro.TabIndex = 15;
            // 
            // lblFechaDeRetiro
            // 
            this.lblFechaDeRetiro.AutoSize = true;
            this.lblFechaDeRetiro.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.lblFechaDeRetiro.Location = new System.Drawing.Point(70, 485);
            this.lblFechaDeRetiro.Name = "lblFechaDeRetiro";
            this.lblFechaDeRetiro.Size = new System.Drawing.Size(163, 23);
            this.lblFechaDeRetiro.TabIndex = 16;
            this.lblFechaDeRetiro.Text = "Fecha de retiro (*)";
            // 
            // lblIngreseRetiro
            // 
            this.lblIngreseRetiro.AutoSize = true;
            this.lblIngreseRetiro.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseRetiro.Location = new System.Drawing.Point(70, 525);
            this.lblIngreseRetiro.Name = "lblIngreseRetiro";
            this.lblIngreseRetiro.Size = new System.Drawing.Size(176, 19);
            this.lblIngreseRetiro.TabIndex = 17;
            this.lblIngreseRetiro.Text = "Ingrese (dd/mm/aaaa):";
            // 
            // mtbRetiro
            // 
            this.mtbRetiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbRetiro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.mtbRetiro.Location = new System.Drawing.Point(277, 525);
            this.mtbRetiro.Mask = "00/00/0000";
            this.mtbRetiro.Name = "mtbRetiro";
            this.mtbRetiro.Size = new System.Drawing.Size(100, 20);
            this.mtbRetiro.TabIndex = 18;
            this.mtbRetiro.ValidatingType = typeof(System.DateTime);
            // 
            // mtbEnvio
            // 
            this.mtbEnvio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbEnvio.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbEnvio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.mtbEnvio.Location = new System.Drawing.Point(667, 525);
            this.mtbEnvio.Mask = "00/00/0000";
            this.mtbEnvio.Name = "mtbEnvio";
            this.mtbEnvio.Size = new System.Drawing.Size(100, 20);
            this.mtbEnvio.TabIndex = 32;
            this.mtbEnvio.ValidatingType = typeof(System.DateTime);
            // 
            // lblIngreseEnvio
            // 
            this.lblIngreseEnvio.AutoSize = true;
            this.lblIngreseEnvio.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseEnvio.Location = new System.Drawing.Point(460, 525);
            this.lblIngreseEnvio.Name = "lblIngreseEnvio";
            this.lblIngreseEnvio.Size = new System.Drawing.Size(176, 19);
            this.lblIngreseEnvio.TabIndex = 31;
            this.lblIngreseEnvio.Text = "Ingrese (dd/mm/aaaa):";
            // 
            // lblFechaDeEnvio
            // 
            this.lblFechaDeEnvio.AutoSize = true;
            this.lblFechaDeEnvio.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.lblFechaDeEnvio.Location = new System.Drawing.Point(460, 485);
            this.lblFechaDeEnvio.Name = "lblFechaDeEnvio";
            this.lblFechaDeEnvio.Size = new System.Drawing.Size(162, 23);
            this.lblFechaDeEnvio.TabIndex = 30;
            this.lblFechaDeEnvio.Text = "Fecha de envío (*)";
            // 
            // txtReferenciaEnvio
            // 
            this.txtReferenciaEnvio.BackColor = System.Drawing.SystemColors.Window;
            this.txtReferenciaEnvio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReferenciaEnvio.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferenciaEnvio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtReferenciaEnvio.Location = new System.Drawing.Point(460, 435);
            this.txtReferenciaEnvio.Name = "txtReferenciaEnvio";
            this.txtReferenciaEnvio.Size = new System.Drawing.Size(307, 20);
            this.txtReferenciaEnvio.TabIndex = 29;
            // 
            // lblReferenciaEnvio
            // 
            this.lblReferenciaEnvio.AutoSize = true;
            this.lblReferenciaEnvio.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferenciaEnvio.Location = new System.Drawing.Point(460, 405);
            this.lblReferenciaEnvio.Name = "lblReferenciaEnvio";
            this.lblReferenciaEnvio.Size = new System.Drawing.Size(168, 19);
            this.lblReferenciaEnvio.TabIndex = 28;
            this.lblReferenciaEnvio.Text = "Referencia (opcional):";
            // 
            // txtLocalidadEnvio
            // 
            this.txtLocalidadEnvio.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocalidadEnvio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocalidadEnvio.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidadEnvio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtLocalidadEnvio.Location = new System.Drawing.Point(567, 365);
            this.txtLocalidadEnvio.Name = "txtLocalidadEnvio";
            this.txtLocalidadEnvio.Size = new System.Drawing.Size(200, 20);
            this.txtLocalidadEnvio.TabIndex = 27;
            // 
            // lblLocalidadEnvio
            // 
            this.lblLocalidadEnvio.AutoSize = true;
            this.lblLocalidadEnvio.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidadEnvio.Location = new System.Drawing.Point(460, 365);
            this.lblLocalidadEnvio.Name = "lblLocalidadEnvio";
            this.lblLocalidadEnvio.Size = new System.Drawing.Size(84, 19);
            this.lblLocalidadEnvio.TabIndex = 26;
            this.lblLocalidadEnvio.Text = "Localidad:";
            // 
            // lblProvinciaEnvio
            // 
            this.lblProvinciaEnvio.AutoSize = true;
            this.lblProvinciaEnvio.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinciaEnvio.Location = new System.Drawing.Point(460, 325);
            this.lblProvinciaEnvio.Name = "lblProvinciaEnvio";
            this.lblProvinciaEnvio.Size = new System.Drawing.Size(81, 19);
            this.lblProvinciaEnvio.TabIndex = 24;
            this.lblProvinciaEnvio.Text = "Provincia:";
            // 
            // txtNumeroEnvio
            // 
            this.txtNumeroEnvio.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumeroEnvio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroEnvio.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroEnvio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtNumeroEnvio.Location = new System.Drawing.Point(541, 285);
            this.txtNumeroEnvio.Name = "txtNumeroEnvio";
            this.txtNumeroEnvio.Size = new System.Drawing.Size(50, 20);
            this.txtNumeroEnvio.TabIndex = 23;
            // 
            // lblNumeroEnvio
            // 
            this.lblNumeroEnvio.AutoSize = true;
            this.lblNumeroEnvio.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEnvio.Location = new System.Drawing.Point(460, 285);
            this.lblNumeroEnvio.Name = "lblNumeroEnvio";
            this.lblNumeroEnvio.Size = new System.Drawing.Size(72, 19);
            this.lblNumeroEnvio.TabIndex = 22;
            this.lblNumeroEnvio.Text = "Número:";
            // 
            // txtCalleEnvio
            // 
            this.txtCalleEnvio.BackColor = System.Drawing.SystemColors.Window;
            this.txtCalleEnvio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalleEnvio.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalleEnvio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtCalleEnvio.Location = new System.Drawing.Point(517, 245);
            this.txtCalleEnvio.Name = "txtCalleEnvio";
            this.txtCalleEnvio.Size = new System.Drawing.Size(250, 20);
            this.txtCalleEnvio.TabIndex = 21;
            // 
            // lblCalleEnvio
            // 
            this.lblCalleEnvio.AutoSize = true;
            this.lblCalleEnvio.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalleEnvio.Location = new System.Drawing.Point(460, 245);
            this.lblCalleEnvio.Name = "lblCalleEnvio";
            this.lblCalleEnvio.Size = new System.Drawing.Size(51, 19);
            this.lblCalleEnvio.TabIndex = 20;
            this.lblCalleEnvio.Text = "Calle:";
            // 
            // lblDomicilioDeEnvio
            // 
            this.lblDomicilioDeEnvio.AutoSize = true;
            this.lblDomicilioDeEnvio.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.lblDomicilioDeEnvio.Location = new System.Drawing.Point(460, 205);
            this.lblDomicilioDeEnvio.Name = "lblDomicilioDeEnvio";
            this.lblDomicilioDeEnvio.Size = new System.Drawing.Size(189, 23);
            this.lblDomicilioDeEnvio.TabIndex = 19;
            this.lblDomicilioDeEnvio.Text = "Domicilio de envío (*)";
            // 
            // lblAdjuntarFotos
            // 
            this.lblAdjuntarFotos.AutoSize = true;
            this.lblAdjuntarFotos.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.lblAdjuntarFotos.Location = new System.Drawing.Point(460, 115);
            this.lblAdjuntarFotos.Name = "lblAdjuntarFotos";
            this.lblAdjuntarFotos.Size = new System.Drawing.Size(218, 23);
            this.lblAdjuntarFotos.TabIndex = 33;
            this.lblAdjuntarFotos.Text = "Adjuntar fotos (opcional)";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(205)))), ((int)(((byte)(79)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(460, 155);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(218, 25);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // cmbProvinciaEnvio
            // 
            this.cmbProvinciaEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvinciaEnvio.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cmbProvinciaEnvio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.cmbProvinciaEnvio.FormattingEnabled = true;
            this.cmbProvinciaEnvio.Items.AddRange(new object[] {
            "Buenos Aires",
            "CABA",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santiago del Estero",
            "Tierra del Fuego",
            "Tucumán"});
            this.cmbProvinciaEnvio.Location = new System.Drawing.Point(567, 324);
            this.cmbProvinciaEnvio.MaxDropDownItems = 12;
            this.cmbProvinciaEnvio.Name = "cmbProvinciaEnvio";
            this.cmbProvinciaEnvio.Size = new System.Drawing.Size(200, 26);
            this.cmbProvinciaEnvio.TabIndex = 35;
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.btnPublicar.FlatAppearance.BorderSize = 0;
            this.btnPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicar.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.Location = new System.Drawing.Point(811, 435);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(150, 50);
            this.btnPublicar.TabIndex = 36;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = false;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(811, 494);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 50);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grdFotos
            // 
            this.grdFotos.AllowUserToDeleteRows = false;
            this.grdFotos.AllowUserToResizeColumns = false;
            this.grdFotos.AllowUserToResizeRows = false;
            this.grdFotos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.grdFotos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFotos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdFotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdFotos.ColumnHeadersVisible = false;
            this.grdFotos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.eliminar});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdFotos.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdFotos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.grdFotos.Location = new System.Drawing.Point(773, 154);
            this.grdFotos.Name = "grdFotos";
            this.grdFotos.ReadOnly = true;
            this.grdFotos.RowHeadersWidth = 15;
            this.grdFotos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdFotos.Size = new System.Drawing.Size(215, 231);
            this.grdFotos.TabIndex = 38;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.DefaultCellStyle = dataGridViewCellStyle6;
            this.nombre.FillWeight = 90F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // eliminar
            // 
            this.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.eliminar.DefaultCellStyle = dataGridViewCellStyle7;
            this.eliminar.FillWeight = 10F;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminar.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "* obligatorio";
            // 
            // PublicarPedidoDeEnvio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdFotos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.cmbProvinciaEnvio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblAdjuntarFotos);
            this.Controls.Add(this.mtbEnvio);
            this.Controls.Add(this.lblIngreseEnvio);
            this.Controls.Add(this.lblFechaDeEnvio);
            this.Controls.Add(this.txtReferenciaEnvio);
            this.Controls.Add(this.lblReferenciaEnvio);
            this.Controls.Add(this.txtLocalidadEnvio);
            this.Controls.Add(this.lblLocalidadEnvio);
            this.Controls.Add(this.lblProvinciaEnvio);
            this.Controls.Add(this.txtNumeroEnvio);
            this.Controls.Add(this.lblNumeroEnvio);
            this.Controls.Add(this.txtCalleEnvio);
            this.Controls.Add(this.lblCalleEnvio);
            this.Controls.Add(this.lblDomicilioDeEnvio);
            this.Controls.Add(this.mtbRetiro);
            this.Controls.Add(this.lblIngreseRetiro);
            this.Controls.Add(this.lblFechaDeRetiro);
            this.Controls.Add(this.txtReferenciaRetiro);
            this.Controls.Add(this.lblReferenciaRetiro);
            this.Controls.Add(this.txtLocalidadRetiro);
            this.Controls.Add(this.lblLocalidadRetiro);
            this.Controls.Add(this.cmbProvinciaRetiro);
            this.Controls.Add(this.lblProvinciaRetiro);
            this.Controls.Add(this.txtNumeroRetiro);
            this.Controls.Add(this.lblNumeroRetiro);
            this.Controls.Add(this.txtCalleRetiro);
            this.Controls.Add(this.lblCalleRetiro);
            this.Controls.Add(this.lblDomicilioDeRetiro);
            this.Controls.Add(this.cmbTipoDeCarga);
            this.Controls.Add(this.lblSeleccione);
            this.Controls.Add(this.lblTipoDeCarga);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "PublicarPedidoDeEnvio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publicar pedido de envío";
            ((System.ComponentModel.ISupportInitialize)(this.grdFotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipoDeCarga;
        private System.Windows.Forms.Label lblSeleccione;
        private System.Windows.Forms.ComboBox cmbTipoDeCarga;
        private System.Windows.Forms.Label lblDomicilioDeRetiro;
        private System.Windows.Forms.Label lblCalleRetiro;
        private System.Windows.Forms.TextBox txtCalleRetiro;
        private System.Windows.Forms.Label lblNumeroRetiro;
        private System.Windows.Forms.TextBox txtNumeroRetiro;
        private System.Windows.Forms.Label lblProvinciaRetiro;
        private System.Windows.Forms.ComboBox cmbProvinciaRetiro;
        private System.Windows.Forms.Label lblLocalidadRetiro;
        private System.Windows.Forms.TextBox txtLocalidadRetiro;
        private System.Windows.Forms.Label lblReferenciaRetiro;
        private System.Windows.Forms.TextBox txtReferenciaRetiro;
        private System.Windows.Forms.Label lblFechaDeRetiro;
        private System.Windows.Forms.Label lblIngreseRetiro;
        private System.Windows.Forms.MaskedTextBox mtbRetiro;
        private System.Windows.Forms.MaskedTextBox mtbEnvio;
        private System.Windows.Forms.Label lblIngreseEnvio;
        private System.Windows.Forms.Label lblFechaDeEnvio;
        private System.Windows.Forms.TextBox txtReferenciaEnvio;
        private System.Windows.Forms.Label lblReferenciaEnvio;
        private System.Windows.Forms.TextBox txtLocalidadEnvio;
        private System.Windows.Forms.Label lblLocalidadEnvio;
        private System.Windows.Forms.Label lblProvinciaEnvio;
        private System.Windows.Forms.TextBox txtNumeroEnvio;
        private System.Windows.Forms.Label lblNumeroEnvio;
        private System.Windows.Forms.TextBox txtCalleEnvio;
        private System.Windows.Forms.Label lblCalleEnvio;
        private System.Windows.Forms.Label lblDomicilioDeEnvio;
        private System.Windows.Forms.Label lblAdjuntarFotos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbProvinciaEnvio;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView grdFotos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.Label label1;
    }
}

