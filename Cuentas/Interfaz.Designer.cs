namespace Cuentas
{
    partial class Interfaz
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbCuentas = new System.Windows.Forms.ComboBox();
            this.butAbrirCuenta = new System.Windows.Forms.Button();
            this.butCrearCuenta = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txCuenta = new System.Windows.Forms.TextBox();
            this.txTitular = new System.Windows.Forms.TextBox();
            this.txTipo = new System.Windows.Forms.TextBox();
            this.txSaldo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.butDepositar = new System.Windows.Forms.Button();
            this.butRetirar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(249, 240);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.butAbrirCuenta, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.butCrearCuenta, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbCuentas, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(243, 87);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cbCuentas
            // 
            this.cbCuentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuentas.FormattingEnabled = true;
            this.cbCuentas.Location = new System.Drawing.Point(3, 3);
            this.cbCuentas.Name = "cbCuentas";
            this.cbCuentas.Size = new System.Drawing.Size(237, 21);
            this.cbCuentas.TabIndex = 2;
            // 
            // butAbrirCuenta
            // 
            this.butAbrirCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.butAbrirCuenta.Location = new System.Drawing.Point(3, 31);
            this.butAbrirCuenta.Name = "butAbrirCuenta";
            this.butAbrirCuenta.Size = new System.Drawing.Size(237, 22);
            this.butAbrirCuenta.TabIndex = 2;
            this.butAbrirCuenta.Text = "Abrir Cuenta";
            this.butAbrirCuenta.UseVisualStyleBackColor = true;
            this.butAbrirCuenta.Click += new System.EventHandler(this.butAbrirCuenta_Click);
            // 
            // butCrearCuenta
            // 
            this.butCrearCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.butCrearCuenta.Location = new System.Drawing.Point(3, 59);
            this.butCrearCuenta.Name = "butCrearCuenta";
            this.butCrearCuenta.Size = new System.Drawing.Size(237, 23);
            this.butCrearCuenta.TabIndex = 3;
            this.butCrearCuenta.Text = "Crear Cuenta";
            this.butCrearCuenta.UseVisualStyleBackColor = true;
            this.butCrearCuenta.Click += new System.EventHandler(this.butCrearCuenta_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txTitular, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txTipo, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txSaldo, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txCuenta, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 96);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(243, 104);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuenta #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Saldo";
            // 
            // txCuenta
            // 
            this.txCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.txCuenta.Location = new System.Drawing.Point(124, 3);
            this.txCuenta.Name = "txCuenta";
            this.txCuenta.ReadOnly = true;
            this.txCuenta.Size = new System.Drawing.Size(116, 20);
            this.txCuenta.TabIndex = 2;
            // 
            // txTitular
            // 
            this.txTitular.Dock = System.Windows.Forms.DockStyle.Top;
            this.txTitular.Location = new System.Drawing.Point(124, 29);
            this.txTitular.Name = "txTitular";
            this.txTitular.ReadOnly = true;
            this.txTitular.Size = new System.Drawing.Size(116, 20);
            this.txTitular.TabIndex = 3;
            // 
            // txTipo
            // 
            this.txTipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txTipo.Location = new System.Drawing.Point(124, 55);
            this.txTipo.Name = "txTipo";
            this.txTipo.ReadOnly = true;
            this.txTipo.Size = new System.Drawing.Size(116, 20);
            this.txTipo.TabIndex = 4;
            // 
            // txSaldo
            // 
            this.txSaldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txSaldo.Location = new System.Drawing.Point(124, 81);
            this.txSaldo.Name = "txSaldo";
            this.txSaldo.ReadOnly = true;
            this.txSaldo.Size = new System.Drawing.Size(116, 20);
            this.txSaldo.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.butRetirar, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.butDepositar, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 206);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(243, 29);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // butDepositar
            // 
            this.butDepositar.Dock = System.Windows.Forms.DockStyle.Top;
            this.butDepositar.Location = new System.Drawing.Point(3, 3);
            this.butDepositar.Name = "butDepositar";
            this.butDepositar.Size = new System.Drawing.Size(115, 23);
            this.butDepositar.TabIndex = 2;
            this.butDepositar.Text = "Depositar";
            this.butDepositar.UseVisualStyleBackColor = true;
            this.butDepositar.Click += new System.EventHandler(this.butDepositar_Click);
            // 
            // butRetirar
            // 
            this.butRetirar.Dock = System.Windows.Forms.DockStyle.Top;
            this.butRetirar.Location = new System.Drawing.Point(124, 3);
            this.butRetirar.Name = "butRetirar";
            this.butRetirar.Size = new System.Drawing.Size(116, 23);
            this.butRetirar.TabIndex = 3;
            this.butRetirar.Text = "Retirar";
            this.butRetirar.UseVisualStyleBackColor = true;
            this.butRetirar.Click += new System.EventHandler(this.butRetirar_Click);
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(249, 240);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Interfaz";
            this.Text = "Sistema de Administracion de Cuentas";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button butRetirar;
        private System.Windows.Forms.Button butDepositar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txTitular;
        private System.Windows.Forms.TextBox txTipo;
        private System.Windows.Forms.TextBox txSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button butAbrirCuenta;
        private System.Windows.Forms.Button butCrearCuenta;
        private System.Windows.Forms.ComboBox cbCuentas;
    }
}