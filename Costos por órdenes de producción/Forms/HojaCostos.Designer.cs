namespace Costos_por_órdenes_de_producción.Forms
{
    partial class HojaCostos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tablaMateriales = new System.Windows.Forms.DataGridView();
            this.columnaConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalMD = new System.Windows.Forms.TextBox();
            this.tablaManoObra = new System.Windows.Forms.DataGridView();
            this.columnaOperario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.totalMO = new System.Windows.Forms.TextBox();
            this.tablaCIF = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasTrabajadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.totalCIF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.costoTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMateriales)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaManoObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCIF)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Costos_por_órdenes_de_producción.Properties.Resources.BACK_BTN;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 44);
            this.button5.TabIndex = 21;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(252, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(200, 12, 3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "# ORDEN ";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(40, 685);
            this.textBox3.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(720, 23);
            this.textBox3.TabIndex = 35;
            this.textBox3.Text = "COSTOS INDIRECTOS DE FABRICACIÓN";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(40, 369);
            this.textBox1.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(718, 23);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "MANO DE OBRA";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tablaMateriales
            // 
            this.tablaMateriales.BackgroundColor = System.Drawing.Color.OldLace;
            this.tablaMateriales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaMateriales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tablaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaConcepto,
            this.columnaCantidad,
            this.ColumnaValorUnitario,
            this.columnaValorTotal});
            this.tablaMateriales.Location = new System.Drawing.Point(40, 82);
            this.tablaMateriales.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.tablaMateriales.Name = "tablaMateriales";
            this.tablaMateriales.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaMateriales.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaMateriales.Size = new System.Drawing.Size(718, 239);
            this.tablaMateriales.TabIndex = 39;
            this.tablaMateriales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaMateriales_CellContentClick);
            // 
            // columnaConcepto
            // 
            this.columnaConcepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnaConcepto.DefaultCellStyle = dataGridViewCellStyle1;
            this.columnaConcepto.HeaderText = "CONCEPTO";
            this.columnaConcepto.Name = "columnaConcepto";
            this.columnaConcepto.ReadOnly = true;
            // 
            // columnaCantidad
            // 
            this.columnaCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnaCantidad.HeaderText = "CANTIDAD";
            this.columnaCantidad.Name = "columnaCantidad";
            this.columnaCantidad.ReadOnly = true;
            this.columnaCantidad.Width = 87;
            // 
            // ColumnaValorUnitario
            // 
            this.ColumnaValorUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnaValorUnitario.HeaderText = "VALOR UNITARIO";
            this.ColumnaValorUnitario.Name = "ColumnaValorUnitario";
            this.ColumnaValorUnitario.ReadOnly = true;
            this.ColumnaValorUnitario.Width = 113;
            // 
            // columnaValorTotal
            // 
            this.columnaValorTotal.HeaderText = "VALOR TOTAL";
            this.columnaValorTotal.Name = "columnaValorTotal";
            this.columnaValorTotal.ReadOnly = true;
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(40, 53);
            this.textBox4.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(718, 23);
            this.textBox4.TabIndex = 33;
            this.textBox4.Text = "MATERIA PRIMA";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Controls.Add(this.textBox4);
            this.flowLayoutPanel1.Controls.Add(this.tablaMateriales);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.totalMD);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.tablaManoObra);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.totalMO);
            this.flowLayoutPanel1.Controls.Add(this.textBox3);
            this.flowLayoutPanel1.Controls.Add(this.tablaCIF);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.totalCIF);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.costoTotal);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(814, 444);
            this.flowLayoutPanel1.TabIndex = 40;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel1_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(379, 12);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(127, 31);
            this.textBox2.TabIndex = 40;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(280, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(280, 12, 3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "Total Materiales";
            // 
            // totalMD
            // 
            this.totalMD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalMD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMD.Location = new System.Drawing.Point(420, 336);
            this.totalMD.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.totalMD.Name = "totalMD";
            this.totalMD.ReadOnly = true;
            this.totalMD.Size = new System.Drawing.Size(127, 27);
            this.totalMD.TabIndex = 43;
            this.totalMD.Text = "0";
            this.totalMD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalMD.TextChanged += new System.EventHandler(this.TotalMD_TextChanged);
            // 
            // tablaManoObra
            // 
            this.tablaManoObra.BackgroundColor = System.Drawing.Color.OldLace;
            this.tablaManoObra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaManoObra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tablaManoObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaManoObra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaOperario,
            this.dataGridViewTextBoxColumn1,
            this.ColumnaPrecioUnitario,
            this.dataGridViewTextBoxColumn2});
            this.tablaManoObra.Location = new System.Drawing.Point(40, 398);
            this.tablaManoObra.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.tablaManoObra.Name = "tablaManoObra";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaManoObra.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaManoObra.Size = new System.Drawing.Size(718, 239);
            this.tablaManoObra.TabIndex = 41;
            this.tablaManoObra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaManoObra_CellContentClick);
            // 
            // columnaOperario
            // 
            this.columnaOperario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnaOperario.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnaOperario.HeaderText = "OPERARIO";
            this.columnaOperario.Name = "columnaOperario";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "HORAS TRABAJADAS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 131;
            // 
            // ColumnaPrecioUnitario
            // 
            this.ColumnaPrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnaPrecioUnitario.HeaderText = "PRECIO UNITARIO";
            this.ColumnaPrecioUnitario.Name = "ColumnaPrecioUnitario";
            this.ColumnaPrecioUnitario.ReadOnly = true;
            this.ColumnaPrecioUnitario.Width = 116;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "VALOR TOTAL";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(260, 652);
            this.label3.Margin = new System.Windows.Forms.Padding(260, 12, 3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Total Mano de Obra";
            // 
            // totalMO
            // 
            this.totalMO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalMO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMO.Location = new System.Drawing.Point(435, 652);
            this.totalMO.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.totalMO.Name = "totalMO";
            this.totalMO.ReadOnly = true;
            this.totalMO.Size = new System.Drawing.Size(127, 27);
            this.totalMO.TabIndex = 45;
            this.totalMO.Text = "0";
            this.totalMO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalMO.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // tablaCIF
            // 
            this.tablaCIF.BackgroundColor = System.Drawing.Color.OldLace;
            this.tablaCIF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaCIF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tablaCIF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCIF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.HorasTrabajadas});
            this.tablaCIF.Location = new System.Drawing.Point(40, 714);
            this.tablaCIF.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.tablaCIF.Name = "tablaCIF";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaCIF.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaCIF.Size = new System.Drawing.Size(720, 70);
            this.tablaCIF.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn3.HeaderText = "PRESUPUESTO CIF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "HORAS PRESUPUESTADAS MOD";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "TASA CIF";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // HorasTrabajadas
            // 
            this.HorasTrabajadas.HeaderText = "HORAS TRABAJADAS";
            this.HorasTrabajadas.Name = "HorasTrabajadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(180, 799);
            this.label4.Margin = new System.Windows.Forms.Padding(180, 12, 3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Total Costos Indirectos de Fabricación";
            // 
            // totalCIF
            // 
            this.totalCIF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalCIF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCIF.Location = new System.Drawing.Point(493, 799);
            this.totalCIF.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.totalCIF.Name = "totalCIF";
            this.totalCIF.ReadOnly = true;
            this.totalCIF.Size = new System.Drawing.Size(127, 27);
            this.totalCIF.TabIndex = 48;
            this.totalCIF.Text = "0";
            this.totalCIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(40, 841);
            this.label5.Margin = new System.Windows.Forms.Padding(40, 12, 3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 28);
            this.label5.TabIndex = 49;
            this.label5.Text = "COSTO TOTAL DE LA ORDEN";
            // 
            // costoTotal
            // 
            this.costoTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.costoTotal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costoTotal.Location = new System.Drawing.Point(375, 841);
            this.costoTotal.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.costoTotal.Name = "costoTotal";
            this.costoTotal.ReadOnly = true;
            this.costoTotal.Size = new System.Drawing.Size(178, 37);
            this.costoTotal.TabIndex = 50;
            this.costoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.costoTotal.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // HojaCostos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(814, 444);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "HojaCostos";
            this.Text = "HojaCostos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaMateriales)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaManoObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCIF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView tablaMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaValorTotal;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.DataGridView tablaManoObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaOperario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalMO;
        public System.Windows.Forms.DataGridView tablaCIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasTrabajadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalCIF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox costoTotal;
        public System.Windows.Forms.TextBox totalMD;
    }
}