namespace grafo
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
			listBox1 = new ListBox();
			nodo = new TextBox();
			primo = new TextBox();
			secondo = new TextBox();
			aggiugival = new Button();
			aggiugiarco = new Button();
			toglinodo = new Button();
			togliarco = new Button();
			ampiezza = new Button();
			profondita = new Button();
			textBox1 = new TextBox();
			mod1 = new TextBox();
			mod2 = new TextBox();
			mod = new Button();
			strpiul = new Button();
			divisibilita = new Button();
			importa = new Button();
			button2 = new Button();
			textBox2 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			SuspendLayout();
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(527, 12);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(250, 424);
			listBox1.TabIndex = 0;
			// 
			// nodo
			// 
			nodo.Location = new Point(12, 46);
			nodo.Name = "nodo";
			nodo.Size = new Size(100, 23);
			nodo.TabIndex = 1;
			// 
			// primo
			// 
			primo.Location = new Point(12, 127);
			primo.Name = "primo";
			primo.Size = new Size(100, 23);
			primo.TabIndex = 2;
			// 
			// secondo
			// 
			secondo.Location = new Point(128, 127);
			secondo.Name = "secondo";
			secondo.Size = new Size(100, 23);
			secondo.TabIndex = 3;
			// 
			// aggiugival
			// 
			aggiugival.BackColor = Color.Green;
			aggiugival.Font = new Font("Maiandra GD", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
			aggiugival.Location = new Point(153, 45);
			aggiugival.Name = "aggiugival";
			aggiugival.Size = new Size(75, 23);
			aggiugival.TabIndex = 4;
			aggiugival.Text = "nodo";
			aggiugival.UseVisualStyleBackColor = false;
			aggiugival.Click += aggiugival_Click;
			// 
			// aggiugiarco
			// 
			aggiugiarco.BackColor = Color.Green;
			aggiugiarco.Font = new Font("Maiandra GD", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
			aggiugiarco.Location = new Point(265, 126);
			aggiugiarco.Name = "aggiugiarco";
			aggiugiarco.Size = new Size(75, 23);
			aggiugiarco.TabIndex = 5;
			aggiugiarco.Text = "arco";
			aggiugiarco.UseVisualStyleBackColor = false;
			aggiugiarco.Click += aggiugiarco_Click;
			// 
			// toglinodo
			// 
			toglinodo.BackColor = Color.Red;
			toglinodo.Font = new Font("Maiandra GD", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			toglinodo.Location = new Point(265, 46);
			toglinodo.Name = "toglinodo";
			toglinodo.Size = new Size(75, 23);
			toglinodo.TabIndex = 6;
			toglinodo.Text = "toglinodo";
			toglinodo.UseVisualStyleBackColor = false;
			toglinodo.Click += toglinodo_Click;
			// 
			// togliarco
			// 
			togliarco.BackColor = Color.Red;
			togliarco.Font = new Font("Maiandra GD", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			togliarco.Location = new Point(346, 126);
			togliarco.Name = "togliarco";
			togliarco.Size = new Size(75, 23);
			togliarco.TabIndex = 7;
			togliarco.Text = "togliarco";
			togliarco.UseVisualStyleBackColor = false;
			togliarco.Click += togliarco_Click;
			// 
			// ampiezza
			// 
			ampiezza.BackColor = Color.Yellow;
			ampiezza.Font = new Font("Maiandra GD", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
			ampiezza.Location = new Point(12, 232);
			ampiezza.Name = "ampiezza";
			ampiezza.Size = new Size(75, 23);
			ampiezza.TabIndex = 8;
			ampiezza.Text = "ampiezza";
			ampiezza.UseVisualStyleBackColor = false;
			ampiezza.Click += ampiezza_Click;
			// 
			// profondita
			// 
			profondita.BackColor = Color.Blue;
			profondita.Font = new Font("Maiandra GD", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
			profondita.ForeColor = Color.White;
			profondita.Location = new Point(102, 233);
			profondita.Name = "profondita";
			profondita.Size = new Size(75, 23);
			profondita.TabIndex = 9;
			profondita.Text = "profondita ";
			profondita.UseVisualStyleBackColor = false;
			profondita.Click += profondita_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(202, 242);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(85, 23);
			textBox1.TabIndex = 10;
			// 
			// mod1
			// 
			mod1.Location = new Point(12, 171);
			mod1.Name = "mod1";
			mod1.Size = new Size(100, 23);
			mod1.TabIndex = 11;
			// 
			// mod2
			// 
			mod2.Location = new Point(128, 171);
			mod2.Name = "mod2";
			mod2.Size = new Size(100, 23);
			mod2.TabIndex = 12;
			// 
			// mod
			// 
			mod.BackColor = Color.GreenYellow;
			mod.Font = new Font("Maiandra GD", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
			mod.Location = new Point(265, 171);
			mod.Name = "mod";
			mod.Size = new Size(75, 23);
			mod.TabIndex = 13;
			mod.Text = "modifica";
			mod.UseVisualStyleBackColor = false;
			mod.Click += mod_Click;
			// 
			// strpiul
			// 
			strpiul.BackColor = Color.Magenta;
			strpiul.Font = new Font("Maiandra GD", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			strpiul.Location = new Point(12, 261);
			strpiul.Name = "strpiul";
			strpiul.Size = new Size(75, 23);
			strpiul.TabIndex = 16;
			strpiul.Text = "strpiul";
			strpiul.UseVisualStyleBackColor = false;
			strpiul.Click += strpiul_Click;
			// 
			// divisibilita
			// 
			divisibilita.BackColor = Color.Magenta;
			divisibilita.Font = new Font("Maiandra GD", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			divisibilita.Location = new Point(102, 262);
			divisibilita.Name = "divisibilita";
			divisibilita.Size = new Size(75, 23);
			divisibilita.TabIndex = 17;
			divisibilita.Text = "divisibilita";
			divisibilita.UseVisualStyleBackColor = false;
			divisibilita.Click += divisibilita_Click_1;
			// 
			// importa
			// 
			importa.BackColor = Color.SpringGreen;
			importa.Font = new Font("Maiandra GD", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			importa.Location = new Point(12, 354);
			importa.Name = "importa";
			importa.Size = new Size(75, 23);
			importa.TabIndex = 18;
			importa.Text = "importa";
			importa.UseVisualStyleBackColor = false;
			importa.Click += importa_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.SpringGreen;
			button2.Font = new Font("Maiandra GD", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			button2.Location = new Point(102, 354);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 19;
			button2.Text = "esporta";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(211, 355);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(101, 23);
			textBox2.TabIndex = 20;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 28);
			label1.Name = "label1";
			label1.Size = new Size(80, 15);
			label1.TabIndex = 21;
			label1.Text = "inserisci nodo";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 109);
			label2.Name = "label2";
			label2.Size = new Size(44, 15);
			label2.TabIndex = 22;
			label2.Text = "nodo1 ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(128, 109);
			label3.Name = "label3";
			label3.Size = new Size(41, 15);
			label3.TabIndex = 23;
			label3.Text = "nodo2";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(5, 153);
			label4.Name = "label4";
			label4.Size = new Size(117, 15);
			label4.TabIndex = 24;
			label4.Text = "nodo1 da modificare";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(128, 153);
			label5.Name = "label5";
			label5.Size = new Size(117, 15);
			label5.TabIndex = 25;
			label5.Text = "nodo2 da modificare";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(202, 213);
			label6.Name = "label6";
			label6.Size = new Size(229, 26);
			label6.TabIndex = 26;
			label6.Text = "se si vuole usare il pulsante ampiezza \r\ne profondita inserire da quale nodo partire";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(184, 381);
			label7.Name = "label7";
			label7.Size = new Size(320, 15);
			label7.TabIndex = 27;
			label7.Text = "scrivere il nome del file che si vuole o esportare o importare";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(202, 268);
			label8.Name = "label8";
			label8.Size = new Size(306, 60);
			label8.TabIndex = 28;
			label8.Text = "se si vuole usare la ricerca della stringa piu lunga inserire \r\nda quale nodo si vuole \r\npartire se invece si usa il pulsante divisibilitá \r\nscrivere il numero divisore\r\n";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.CornflowerBlue;
			ClientSize = new Size(800, 450);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox2);
			Controls.Add(button2);
			Controls.Add(importa);
			Controls.Add(divisibilita);
			Controls.Add(strpiul);
			Controls.Add(mod);
			Controls.Add(mod2);
			Controls.Add(mod1);
			Controls.Add(textBox1);
			Controls.Add(profondita);
			Controls.Add(ampiezza);
			Controls.Add(togliarco);
			Controls.Add(toglinodo);
			Controls.Add(aggiugiarco);
			Controls.Add(aggiugival);
			Controls.Add(secondo);
			Controls.Add(primo);
			Controls.Add(nodo);
			Controls.Add(listBox1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox listBox1;
		private TextBox nodo;
		private TextBox primo;
		private TextBox secondo;
		private Button aggiugival;
		private Button aggiugiarco;
		private Button toglinodo;
		private Button togliarco;
		private Button ampiezza;
		private Button profondita;
		private TextBox textBox1;
		private TextBox mod1;
		private TextBox mod2;
		private Button mod;
		private Button strpiul;
		private Button divisibilita;
		private Button importa;
		private Button button2;
		private TextBox textBox2;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
	}
}