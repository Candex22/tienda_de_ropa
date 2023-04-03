
namespace WindowsFormsApp3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCamisa = new System.Windows.Forms.RadioButton();
            this.radioButtonPantalon = new System.Windows.Forms.RadioButton();
            this.radioButtonStandar = new System.Windows.Forms.RadioButton();
            this.radioButtonPremium = new System.Windows.Forms.RadioButton();
            this.checkBoxMangaCorta = new System.Windows.Forms.CheckBox();
            this.checkBoxCuelloMao = new System.Windows.Forms.CheckBox();
            this.checkBoxChupin = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCotizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelPrecioTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(318, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizador express";
            // 
            // radioButtonCamisa
            // 
            this.radioButtonCamisa.AutoSize = true;
            this.radioButtonCamisa.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCamisa.Location = new System.Drawing.Point(6, 34);
            this.radioButtonCamisa.Name = "radioButtonCamisa";
            this.radioButtonCamisa.Size = new System.Drawing.Size(84, 23);
            this.radioButtonCamisa.TabIndex = 1;
            this.radioButtonCamisa.TabStop = true;
            this.radioButtonCamisa.Text = "Camisas";
            this.radioButtonCamisa.UseVisualStyleBackColor = true;
            this.radioButtonCamisa.CheckedChanged += new System.EventHandler(this.radioButtonCamisa_CheckedChanged);
            // 
            // radioButtonPantalon
            // 
            this.radioButtonPantalon.AutoSize = true;
            this.radioButtonPantalon.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPantalon.Location = new System.Drawing.Point(1, 81);
            this.radioButtonPantalon.Name = "radioButtonPantalon";
            this.radioButtonPantalon.Size = new System.Drawing.Size(89, 23);
            this.radioButtonPantalon.TabIndex = 2;
            this.radioButtonPantalon.TabStop = true;
            this.radioButtonPantalon.Text = "Pantalon";
            this.radioButtonPantalon.UseVisualStyleBackColor = true;
            this.radioButtonPantalon.CheckedChanged += new System.EventHandler(this.radioButtonPantalon_CheckedChanged);
            // 
            // radioButtonStandar
            // 
            this.radioButtonStandar.AutoSize = true;
            this.radioButtonStandar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStandar.Location = new System.Drawing.Point(13, 34);
            this.radioButtonStandar.Name = "radioButtonStandar";
            this.radioButtonStandar.Size = new System.Drawing.Size(81, 23);
            this.radioButtonStandar.TabIndex = 3;
            this.radioButtonStandar.TabStop = true;
            this.radioButtonStandar.Text = "Standar";
            this.radioButtonStandar.UseVisualStyleBackColor = true;
            this.radioButtonStandar.CheckedChanged += new System.EventHandler(this.radioButtonStandar_CheckedChanged);
            // 
            // radioButtonPremium
            // 
            this.radioButtonPremium.AutoSize = true;
            this.radioButtonPremium.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPremium.Location = new System.Drawing.Point(13, 81);
            this.radioButtonPremium.Name = "radioButtonPremium";
            this.radioButtonPremium.Size = new System.Drawing.Size(91, 23);
            this.radioButtonPremium.TabIndex = 4;
            this.radioButtonPremium.TabStop = true;
            this.radioButtonPremium.Text = "Premium";
            this.radioButtonPremium.UseVisualStyleBackColor = true;
            // 
            // checkBoxMangaCorta
            // 
            this.checkBoxMangaCorta.AutoSize = true;
            this.checkBoxMangaCorta.Location = new System.Drawing.Point(54, 56);
            this.checkBoxMangaCorta.Name = "checkBoxMangaCorta";
            this.checkBoxMangaCorta.Size = new System.Drawing.Size(95, 19);
            this.checkBoxMangaCorta.TabIndex = 5;
            this.checkBoxMangaCorta.Text = "Manga corta";
            this.checkBoxMangaCorta.UseVisualStyleBackColor = true;
            this.checkBoxMangaCorta.CheckedChanged += new System.EventHandler(this.checkBoxMangaCorta_CheckedChanged);
            // 
            // checkBoxCuelloMao
            // 
            this.checkBoxCuelloMao.AutoSize = true;
            this.checkBoxCuelloMao.Location = new System.Drawing.Point(166, 56);
            this.checkBoxCuelloMao.Name = "checkBoxCuelloMao";
            this.checkBoxCuelloMao.Size = new System.Drawing.Size(89, 19);
            this.checkBoxCuelloMao.TabIndex = 6;
            this.checkBoxCuelloMao.Text = "Cuello mao";
            this.checkBoxCuelloMao.UseVisualStyleBackColor = true;
            // 
            // checkBoxChupin
            // 
            this.checkBoxChupin.AutoSize = true;
            this.checkBoxChupin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChupin.Location = new System.Drawing.Point(54, 110);
            this.checkBoxChupin.Name = "checkBoxChupin";
            this.checkBoxChupin.Size = new System.Drawing.Size(68, 20);
            this.checkBoxChupin.TabIndex = 7;
            this.checkBoxChupin.Text = "Chupin";
            this.checkBoxChupin.UseVisualStyleBackColor = true;
            this.checkBoxChupin.CheckedChanged += new System.EventHandler(this.checkBoxChupin_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCamisa);
            this.groupBox1.Controls.Add(this.checkBoxCuelloMao);
            this.groupBox1.Controls.Add(this.checkBoxChupin);
            this.groupBox1.Controls.Add(this.checkBoxMangaCorta);
            this.groupBox1.Controls.Add(this.radioButtonPantalon);
            this.groupBox1.Location = new System.Drawing.Point(44, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 151);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prendas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonStandar);
            this.groupBox2.Controls.Add(this.radioButtonPremium);
            this.groupBox2.Location = new System.Drawing.Point(365, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 151);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad";
            // 
            // buttonCotizar
            // 
            this.buttonCotizar.Location = new System.Drawing.Point(44, 389);
            this.buttonCotizar.Name = "buttonCotizar";
            this.buttonCotizar.Size = new System.Drawing.Size(132, 45);
            this.buttonCotizar.TabIndex = 10;
            this.buttonCotizar.Text = "Cotizar";
            this.buttonCotizar.UseVisualStyleBackColor = true;
            this.buttonCotizar.Click += new System.EventHandler(this.buttonCotizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Unidades en stock:";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(189, 317);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(0, 15);
            this.labelStock.TabIndex = 12;
            this.labelStock.Click += new System.EventHandler(this.labelStock_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio unitario:  $";
            // 
            // textBoxPrecioUnitario
            // 
            this.textBoxPrecioUnitario.Location = new System.Drawing.Point(672, 296);
            this.textBoxPrecioUnitario.Name = "textBoxPrecioUnitario";
            this.textBoxPrecioUnitario.Size = new System.Drawing.Size(100, 21);
            this.textBoxPrecioUnitario.TabIndex = 14;
            this.textBoxPrecioUnitario.TextChanged += new System.EventHandler(this.textBoxPrecioUnitario_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cantidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(614, 327);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 21);
            this.textBoxCantidad.TabIndex = 16;
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.textBoxCantidad_TextChanged);
            // 
            // labelPrecioTotal
            // 
            this.labelPrecioTotal.AutoSize = true;
            this.labelPrecioTotal.Location = new System.Drawing.Point(207, 404);
            this.labelPrecioTotal.Name = "labelPrecioTotal";
            this.labelPrecioTotal.Size = new System.Drawing.Size(0, 15);
            this.labelPrecioTotal.TabIndex = 17;
            this.labelPrecioTotal.Click += new System.EventHandler(this.labelPrecioTotal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Vendedor: Yamato Kozuki";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tienda: Wano Kuni";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 476);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPrecioTotal);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrecioUnitario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCotizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "$";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonCamisa;
        private System.Windows.Forms.RadioButton radioButtonPantalon;
        private System.Windows.Forms.RadioButton radioButtonStandar;
        private System.Windows.Forms.RadioButton radioButtonPremium;
        private System.Windows.Forms.CheckBox checkBoxMangaCorta;
        private System.Windows.Forms.CheckBox checkBoxCuelloMao;
        private System.Windows.Forms.CheckBox checkBoxChupin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCotizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrecioUnitario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelPrecioTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

