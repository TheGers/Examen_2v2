namespace Examen2
{
    partial class Pedidos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.id_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Identidad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cargar_button = new System.Windows.Forms.Button();
            this.descrip_textBox = new System.Windows.Forms.TextBox();
            this.total_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cant_textBox = new System.Windows.Forms.TextBox();
            this.codigo_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lista_pedidosdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_pedidosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nombre_textBox);
            this.groupBox1.Controls.Add(this.id_maskedTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Identidad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Location = new System.Drawing.Point(141, 71);
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_textBox.TabIndex = 3;
            // 
            // id_maskedTextBox
            // 
            this.id_maskedTextBox.Location = new System.Drawing.Point(141, 12);
            this.id_maskedTextBox.Mask = "####-####-#####";
            this.id_maskedTextBox.Name = "id_maskedTextBox";
            this.id_maskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_maskedTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo";
            // 
            // Identidad
            // 
            this.Identidad.AutoSize = true;
            this.Identidad.Location = new System.Drawing.Point(23, 20);
            this.Identidad.Name = "Identidad";
            this.Identidad.Size = new System.Drawing.Size(57, 13);
            this.Identidad.TabIndex = 0;
            this.Identidad.Text = "Indentidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cargar_button);
            this.groupBox2.Controls.Add(this.descrip_textBox);
            this.groupBox2.Controls.Add(this.total_textBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cant_textBox);
            this.groupBox2.Controls.Add(this.codigo_textBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cargar_button
            // 
            this.cargar_button.Location = new System.Drawing.Point(474, 73);
            this.cargar_button.Name = "cargar_button";
            this.cargar_button.Size = new System.Drawing.Size(82, 34);
            this.cargar_button.TabIndex = 8;
            this.cargar_button.Text = "Cargar";
            this.cargar_button.UseVisualStyleBackColor = true;
            // 
            // descrip_textBox
            // 
            this.descrip_textBox.Location = new System.Drawing.Point(364, 19);
            this.descrip_textBox.Name = "descrip_textBox";
            this.descrip_textBox.Size = new System.Drawing.Size(204, 20);
            this.descrip_textBox.TabIndex = 8;
            // 
            // total_textBox
            // 
            this.total_textBox.Location = new System.Drawing.Point(321, 78);
            this.total_textBox.Name = "total_textBox";
            this.total_textBox.Size = new System.Drawing.Size(100, 20);
            this.total_textBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total";
            // 
            // cant_textBox
            // 
            this.cant_textBox.Location = new System.Drawing.Point(113, 63);
            this.cant_textBox.Name = "cant_textBox";
            this.cant_textBox.Size = new System.Drawing.Size(100, 20);
            this.cant_textBox.TabIndex = 9;
            this.cant_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cant_textBox_KeyPress);
            // 
            // codigo_textBox
            // 
            this.codigo_textBox.Location = new System.Drawing.Point(113, 23);
            this.codigo_textBox.Name = "codigo_textBox";
            this.codigo_textBox.Size = new System.Drawing.Size(100, 20);
            this.codigo_textBox.TabIndex = 10;
            this.codigo_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo";
            // 
            // lista_pedidosdataGridView
            // 
            this.lista_pedidosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_pedidosdataGridView.Location = new System.Drawing.Point(12, 288);
            this.lista_pedidosdataGridView.Name = "lista_pedidosdataGridView";
            this.lista_pedidosdataGridView.Size = new System.Drawing.Size(574, 160);
            this.lista_pedidosdataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pedidos Ingresados";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_pedidosdataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_pedidosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Identidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cargar_button;
        private System.Windows.Forms.DataGridView lista_pedidosdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre_textBox;
        private System.Windows.Forms.MaskedTextBox id_maskedTextBox;
        private System.Windows.Forms.TextBox descrip_textBox;
        private System.Windows.Forms.TextBox total_textBox;
        private System.Windows.Forms.TextBox cant_textBox;
        private System.Windows.Forms.TextBox codigo_textBox;
    }
}