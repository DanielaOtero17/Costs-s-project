namespace Costos_por_órdenes_de_producción.Forms
{
    partial class RecepcionPeriodos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mesBOX = new System.Windows.Forms.ComboBox();
            this.anioBOX = new System.Windows.Forms.ComboBox();
            this.estadoBOX = new System.Windows.Forms.ComboBox();
            this.elementosBOX = new System.Windows.Forms.ComboBox();
            this.cargarBTN = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // mesBOX
            // 
            this.mesBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.mesBOX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mesBOX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesBOX.ForeColor = System.Drawing.Color.White;
            this.mesBOX.FormattingEnabled = true;
            this.mesBOX.Location = new System.Drawing.Point(6, 56);
            this.mesBOX.Name = "mesBOX";
            this.mesBOX.Size = new System.Drawing.Size(116, 29);
            this.mesBOX.TabIndex = 20;
            this.mesBOX.Text = "Mes";
            this.mesBOX.SelectedIndexChanged += new System.EventHandler(this.MesBOX_SelectedIndexChanged);
            // 
            // anioBOX
            // 
            this.anioBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.anioBOX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.anioBOX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioBOX.ForeColor = System.Drawing.Color.White;
            this.anioBOX.FormattingEnabled = true;
            this.anioBOX.Location = new System.Drawing.Point(127, 56);
            this.anioBOX.Name = "anioBOX";
            this.anioBOX.Size = new System.Drawing.Size(112, 29);
            this.anioBOX.TabIndex = 21;
            this.anioBOX.Text = "Año";
            // 
            // estadoBOX
            // 
            this.estadoBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.estadoBOX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.estadoBOX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoBOX.ForeColor = System.Drawing.Color.White;
            this.estadoBOX.FormattingEnabled = true;
            this.estadoBOX.Location = new System.Drawing.Point(245, 56);
            this.estadoBOX.Name = "estadoBOX";
            this.estadoBOX.Size = new System.Drawing.Size(138, 29);
            this.estadoBOX.TabIndex = 22;
            this.estadoBOX.Text = "Estado";
            // 
            // elementosBOX
            // 
            this.elementosBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.elementosBOX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.elementosBOX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementosBOX.ForeColor = System.Drawing.Color.White;
            this.elementosBOX.FormattingEnabled = true;
            this.elementosBOX.Location = new System.Drawing.Point(389, 56);
            this.elementosBOX.Name = "elementosBOX";
            this.elementosBOX.Size = new System.Drawing.Size(177, 29);
            this.elementosBOX.TabIndex = 23;
            this.elementosBOX.Text = "Elemento de Costo";
            // 
            // cargarBTN
            // 
            this.cargarBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cargarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargarBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargarBTN.Location = new System.Drawing.Point(573, 56);
            this.cargarBTN.Name = "cargarBTN";
            this.cargarBTN.Size = new System.Drawing.Size(115, 29);
            this.cargarBTN.TabIndex = 24;
            this.cargarBTN.Text = "VER DATOS";
            this.cargarBTN.UseVisualStyleBackColor = false;
            this.cargarBTN.Click += new System.EventHandler(this.CargarBTN_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Costos_por_órdenes_de_producción.Properties.Resources.BACK_BTN;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 44);
            this.button5.TabIndex = 25;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // tablaDatos
            // 
            this.tablaDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.tablaDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCantidad,
            this.ColumnaValorUnitario,
            this.columnaValorTotal});
            this.tablaDatos.Location = new System.Drawing.Point(6, 93);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaDatos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDatos.Size = new System.Drawing.Size(682, 243);
            this.tablaDatos.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(274, 342);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(209, 30);
            this.textBox2.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(204, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "TOTAL";
            // 
            // columnaCantidad
            // 
            this.columnaCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnaCantidad.HeaderText = "NO. PEDIDO";
            this.columnaCantidad.Name = "columnaCantidad";
            this.columnaCantidad.ReadOnly = true;
            this.columnaCantidad.Width = 95;
            // 
            // ColumnaValorUnitario
            // 
            this.ColumnaValorUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaValorUnitario.HeaderText = "CLIENTE";
            this.ColumnaValorUnitario.Name = "ColumnaValorUnitario";
            this.ColumnaValorUnitario.ReadOnly = true;
            // 
            // columnaValorTotal
            // 
            this.columnaValorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnaValorTotal.HeaderText = "VALOR TOTAL";
            this.columnaValorTotal.Name = "columnaValorTotal";
            this.columnaValorTotal.ReadOnly = true;
            // 
            // RecepcionPeriodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(700, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cargarBTN);
            this.Controls.Add(this.elementosBOX);
            this.Controls.Add(this.estadoBOX);
            this.Controls.Add(this.anioBOX);
            this.Controls.Add(this.mesBOX);
            this.Name = "RecepcionPeriodos";
            this.Text = "INFORMACIÓN";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mesBOX;
        private System.Windows.Forms.ComboBox anioBOX;
        private System.Windows.Forms.ComboBox estadoBOX;
        private System.Windows.Forms.ComboBox elementosBOX;
        private System.Windows.Forms.Button cargarBTN;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaValorTotal;
    }
}