namespace customerForm
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			groupBox1 = new GroupBox();
			pictureBox1 = new PictureBox();
			radioFemenino = new RadioButton();
			radioMasculino = new RadioButton();
			label4 = new Label();
			textCedula = new TextBox();
			label3 = new Label();
			textApellido = new TextBox();
			label2 = new Label();
			textNombre = new TextBox();
			groupBox2 = new GroupBox();
			textNoCasa = new TextBox();
			textCalle = new TextBox();
			comboMunicipio = new ComboBox();
			comboProvincia = new ComboBox();
			comboPais = new ComboBox();
			label10 = new Label();
			label9 = new Label();
			textSector = new TextBox();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			button1 = new Button();
			button2 = new Button();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(18, 29);
			label1.Name = "label1";
			label1.Size = new Size(54, 15);
			label1.TabIndex = 0;
			label1.Text = "Nombre:";
			label1.Click += label1_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(pictureBox1);
			groupBox1.Controls.Add(radioFemenino);
			groupBox1.Controls.Add(radioMasculino);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(textCedula);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(textApellido);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(textNombre);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(12, 36);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(578, 185);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Informacion personal";
			groupBox1.Enter += groupBox1_Enter;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.InitialImage = null;
			pictureBox1.Location = new Point(367, 22);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(144, 112);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 9;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// radioFemenino
			// 
			radioFemenino.AutoSize = true;
			radioFemenino.Location = new Point(465, 147);
			radioFemenino.Name = "radioFemenino";
			radioFemenino.Size = new Size(77, 19);
			radioFemenino.TabIndex = 8;
			radioFemenino.TabStop = true;
			radioFemenino.Text = "Femenina";
			radioFemenino.UseVisualStyleBackColor = true;
			// 
			// radioMasculino
			// 
			radioMasculino.AutoSize = true;
			radioMasculino.Location = new Point(379, 147);
			radioMasculino.Name = "radioMasculino";
			radioMasculino.Size = new Size(80, 19);
			radioMasculino.TabIndex = 7;
			radioMasculino.TabStop = true;
			radioMasculino.Text = "Masculino";
			radioMasculino.UseVisualStyleBackColor = true;
			radioMasculino.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(338, 149);
			label4.Name = "label4";
			label4.Size = new Size(35, 15);
			label4.TabIndex = 6;
			label4.Text = "Sexo:";
			label4.Click += label4_Click_1;
			// 
			// textCedula
			// 
			textCedula.Location = new Point(83, 121);
			textCedula.Name = "textCedula";
			textCedula.Size = new Size(221, 23);
			textCedula.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(14, 129);
			label3.Name = "label3";
			label3.Size = new Size(47, 15);
			label3.TabIndex = 4;
			label3.Text = "Cedula:";
			// 
			// textApellido
			// 
			textApellido.Location = new Point(83, 78);
			textApellido.Name = "textApellido";
			textApellido.Size = new Size(221, 23);
			textApellido.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(18, 81);
			label2.Name = "label2";
			label2.Size = new Size(54, 15);
			label2.TabIndex = 2;
			label2.Text = "Apellido:";
			label2.Click += label2_Click;
			// 
			// textNombre
			// 
			textNombre.Location = new Point(83, 26);
			textNombre.Name = "textNombre";
			textNombre.Size = new Size(221, 23);
			textNombre.TabIndex = 1;
			textNombre.TextChanged += textNombre_TextChanged;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(textNoCasa);
			groupBox2.Controls.Add(textCalle);
			groupBox2.Controls.Add(comboMunicipio);
			groupBox2.Controls.Add(comboProvincia);
			groupBox2.Controls.Add(comboPais);
			groupBox2.Controls.Add(label10);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(textSector);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(label6);
			groupBox2.Controls.Add(label5);
			groupBox2.Location = new Point(12, 227);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(578, 187);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "Ubicacion";
			groupBox2.Enter += groupBox2_Enter;
			// 
			// textNoCasa
			// 
			textNoCasa.Location = new Point(318, 115);
			textNoCasa.Name = "textNoCasa";
			textNoCasa.Size = new Size(147, 23);
			textNoCasa.TabIndex = 23;
			// 
			// textCalle
			// 
			textCalle.Location = new Point(318, 75);
			textCalle.Name = "textCalle";
			textCalle.Size = new Size(147, 23);
			textCalle.TabIndex = 22;
			// 
			// comboMunicipio
			// 
			comboMunicipio.FormattingEnabled = true;
			comboMunicipio.Items.AddRange(new object[] { "San Fancisco de Macoris", "Cien Fuegos" });
			comboMunicipio.Location = new Point(83, 115);
			comboMunicipio.Name = "comboMunicipio";
			comboMunicipio.Size = new Size(127, 23);
			comboMunicipio.TabIndex = 21;
			// 
			// comboProvincia
			// 
			comboProvincia.FormattingEnabled = true;
			comboProvincia.Items.AddRange(new object[] { "Duarte", "Santiago" });
			comboProvincia.Location = new Point(83, 69);
			comboProvincia.Name = "comboProvincia";
			comboProvincia.Size = new Size(127, 23);
			comboProvincia.TabIndex = 20;
			// 
			// comboPais
			// 
			comboPais.FormattingEnabled = true;
			comboPais.Items.AddRange(new object[] { "Republica Dominicana", "Puerto Rico", "Cuba" });
			comboPais.Location = new Point(83, 31);
			comboPais.Name = "comboPais";
			comboPais.Size = new Size(127, 23);
			comboPais.TabIndex = 19;
			comboPais.SelectedIndexChanged += comboPais_SelectedIndexChanged;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(246, 120);
			label10.Name = "label10";
			label10.Size = new Size(57, 15);
			label10.TabIndex = 18;
			label10.Text = "No. Casa:";
			label10.Click += label10_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(253, 75);
			label9.Name = "label9";
			label9.Size = new Size(36, 15);
			label9.TabIndex = 17;
			label9.Text = "Calle:";
			label9.Click += label9_Click;
			// 
			// textSector
			// 
			textSector.Location = new Point(318, 27);
			textSector.Name = "textSector";
			textSector.Size = new Size(147, 23);
			textSector.TabIndex = 16;
			textSector.TextChanged += textSector_TextChanged;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(253, 31);
			label8.Name = "label8";
			label8.Size = new Size(43, 15);
			label8.TabIndex = 12;
			label8.Text = "Sector:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(18, 115);
			label7.Name = "label7";
			label7.Size = new Size(64, 15);
			label7.TabIndex = 11;
			label7.Text = "Municipio:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(18, 72);
			label6.Name = "label6";
			label6.Size = new Size(59, 15);
			label6.TabIndex = 10;
			label6.Text = "Provincia:";
			label6.Click += label6_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(18, 30);
			label5.Name = "label5";
			label5.Size = new Size(31, 15);
			label5.TabIndex = 9;
			label5.Text = "Pais:";
			label5.Click += label5_Click;
			// 
			// button1
			// 
			button1.Location = new Point(423, 455);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 3;
			button1.Text = "Enviar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(504, 455);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 4;
			button2.Text = "Cancelar";
			button2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AccessibleName = "MainForm";
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(608, 490);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "Form1";
			Text = "Registrar Clientes";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private GroupBox groupBox1;
		private Label label2;
		private TextBox textNombre;
		private TextBox textCedula;
		private Label label3;
		private TextBox textApellido;
		private RadioButton radioMasculino;
		private Label label4;
		private RadioButton radioFemenino;
		private GroupBox groupBox2;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private TextBox textSector;
		private Label label9;
		private Label label10;
		private TextBox textNoCasa;
		private TextBox textCalle;
		private ComboBox comboMunicipio;
		private ComboBox comboProvincia;
		private ComboBox comboPais;
		private PictureBox pictureBox1;
		private Button button1;
		private Button button2;
	}
}
