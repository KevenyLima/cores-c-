namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_esquerda = new System.Windows.Forms.Button();
            this.cmd_pulo = new System.Windows.Forms.Button();
            this.cmd_cima = new System.Windows.Forms.Button();
            this.cmd_baixo = new System.Windows.Forms.Button();
            this.cmd_direita = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_esquerda
            // 
            this.cmd_esquerda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmd_esquerda.Location = new System.Drawing.Point(425, 257);
            this.cmd_esquerda.Name = "cmd_esquerda";
            this.cmd_esquerda.Size = new System.Drawing.Size(41, 23);
            this.cmd_esquerda.TabIndex = 0;
            this.cmd_esquerda.Text = "a";
            this.cmd_esquerda.UseVisualStyleBackColor = true;
            this.cmd_esquerda.Click += new System.EventHandler(this.cmd_esquerda_Click);
            // 
            // cmd_pulo
            // 
            this.cmd_pulo.Location = new System.Drawing.Point(472, 257);
            this.cmd_pulo.Name = "cmd_pulo";
            this.cmd_pulo.Size = new System.Drawing.Size(41, 23);
            this.cmd_pulo.TabIndex = 1;
            this.cmd_pulo.UseVisualStyleBackColor = true;
            this.cmd_pulo.Click += new System.EventHandler(this.cmd_pulo_Click);
            // 
            // cmd_cima
            // 
            this.cmd_cima.Location = new System.Drawing.Point(472, 228);
            this.cmd_cima.Name = "cmd_cima";
            this.cmd_cima.Size = new System.Drawing.Size(41, 23);
            this.cmd_cima.TabIndex = 2;
            this.cmd_cima.Text = "w";
            this.cmd_cima.UseVisualStyleBackColor = true;
            this.cmd_cima.Click += new System.EventHandler(this.cmd_cima_Click);
            // 
            // cmd_baixo
            // 
            this.cmd_baixo.Location = new System.Drawing.Point(472, 286);
            this.cmd_baixo.Name = "cmd_baixo";
            this.cmd_baixo.Size = new System.Drawing.Size(41, 23);
            this.cmd_baixo.TabIndex = 3;
            this.cmd_baixo.Text = "s";
            this.cmd_baixo.UseVisualStyleBackColor = true;
            // 
            // cmd_direita
            // 
            this.cmd_direita.Location = new System.Drawing.Point(519, 257);
            this.cmd_direita.Name = "cmd_direita";
            this.cmd_direita.Size = new System.Drawing.Size(41, 23);
            this.cmd_direita.TabIndex = 4;
            this.cmd_direita.Text = "d";
            this.cmd_direita.UseVisualStyleBackColor = true;
            this.cmd_direita.Click += new System.EventHandler(this.cmd_direita_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(139, 12);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(197, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(139, 64);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(197, 45);
            this.trackBar2.TabIndex = 9;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(139, 115);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(197, 45);
            this.trackBar3.TabIndex = 10;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 324);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.cmd_direita);
            this.Controls.Add(this.cmd_baixo);
            this.Controls.Add(this.cmd_cima);
            this.Controls.Add(this.cmd_pulo);
            this.Controls.Add(this.cmd_esquerda);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_esquerda;
        private System.Windows.Forms.Button cmd_pulo;
        private System.Windows.Forms.Button cmd_cima;
        private System.Windows.Forms.Button cmd_baixo;
        private System.Windows.Forms.Button cmd_direita;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

