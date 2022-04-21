namespace Unity_AssetLoader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.madeby = new System.Windows.Forms.Label();
            this.btn_ga = new System.Windows.Forms.Button();
            this.btn_mga = new System.Windows.Forms.Button();
            this.ga_selectedga = new System.Windows.Forms.Label();
            this.mga_selectedmga = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_rmga = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.selectasset = new System.Windows.Forms.OpenFileDialog();
            this.selectmodasset = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 24F);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(143, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(270, 36);
            this.title.TabIndex = 0;
            this.title.Text = "Unity AssetLoader";
            // 
            // madeby
            // 
            this.madeby.AutoSize = true;
            this.madeby.Font = new System.Drawing.Font("Arial", 8.25F);
            this.madeby.ForeColor = System.Drawing.Color.White;
            this.madeby.Location = new System.Drawing.Point(285, 47);
            this.madeby.Name = "madeby";
            this.madeby.Size = new System.Drawing.Size(128, 14);
            this.madeby.TabIndex = 1;
            this.madeby.Text = "made by Junior Schueller";
            // 
            // btn_ga
            // 
            this.btn_ga.BackColor = System.Drawing.Color.DarkGray;
            this.btn_ga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ga.Font = new System.Drawing.Font("Arial", 16F);
            this.btn_ga.ForeColor = System.Drawing.Color.White;
            this.btn_ga.Location = new System.Drawing.Point(18, 74);
            this.btn_ga.Name = "btn_ga";
            this.btn_ga.Size = new System.Drawing.Size(264, 78);
            this.btn_ga.TabIndex = 2;
            this.btn_ga.Text = "Game Asset";
            this.tooltip.SetToolTip(this.btn_ga, "Select the asset file to be modified.");
            this.btn_ga.UseVisualStyleBackColor = false;
            this.btn_ga.Click += new System.EventHandler(this.btn_ga_Click);
            // 
            // btn_mga
            // 
            this.btn_mga.BackColor = System.Drawing.Color.DarkGray;
            this.btn_mga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mga.Font = new System.Drawing.Font("Arial", 16F);
            this.btn_mga.ForeColor = System.Drawing.Color.White;
            this.btn_mga.Location = new System.Drawing.Point(18, 176);
            this.btn_mga.Name = "btn_mga";
            this.btn_mga.Size = new System.Drawing.Size(264, 78);
            this.btn_mga.TabIndex = 3;
            this.btn_mga.Text = "Modified Game Asset";
            this.tooltip.SetToolTip(this.btn_mga, "Select the modified asset file.");
            this.btn_mga.UseVisualStyleBackColor = false;
            this.btn_mga.Click += new System.EventHandler(this.btn_mga_Click);
            // 
            // ga_selectedga
            // 
            this.ga_selectedga.AutoSize = true;
            this.ga_selectedga.Font = new System.Drawing.Font("Arial", 12F);
            this.ga_selectedga.ForeColor = System.Drawing.Color.White;
            this.ga_selectedga.Location = new System.Drawing.Point(15, 155);
            this.ga_selectedga.Name = "ga_selectedga";
            this.ga_selectedga.Size = new System.Drawing.Size(165, 18);
            this.ga_selectedga.TabIndex = 4;
            this.ga_selectedga.Text = "No files were selected.";
            // 
            // mga_selectedmga
            // 
            this.mga_selectedmga.AutoSize = true;
            this.mga_selectedmga.Font = new System.Drawing.Font("Arial", 12F);
            this.mga_selectedmga.ForeColor = System.Drawing.Color.White;
            this.mga_selectedmga.Location = new System.Drawing.Point(15, 257);
            this.mga_selectedmga.Name = "mga_selectedmga";
            this.mga_selectedmga.Size = new System.Drawing.Size(165, 18);
            this.mga_selectedmga.TabIndex = 5;
            this.mga_selectedmga.Text = "No files were selected.";
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.DarkGray;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("Arial", 16F);
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Location = new System.Drawing.Point(288, 74);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(264, 78);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "Load";
            this.tooltip.SetToolTip(this.btn_load, "Load the asset file for the modified asset.");
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_rmga
            // 
            this.btn_rmga.BackColor = System.Drawing.Color.DarkGray;
            this.btn_rmga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rmga.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_rmga.ForeColor = System.Drawing.Color.White;
            this.btn_rmga.Location = new System.Drawing.Point(288, 176);
            this.btn_rmga.Name = "btn_rmga";
            this.btn_rmga.Size = new System.Drawing.Size(264, 78);
            this.btn_rmga.TabIndex = 8;
            this.btn_rmga.Text = "Replace Modified Game Asset";
            this.tooltip.SetToolTip(this.btn_rmga, "Replaces the modified asset by the original asset.");
            this.btn_rmga.UseVisualStyleBackColor = false;
            this.btn_rmga.Click += new System.EventHandler(this.btn_rmga_Click);
            // 
            // selectasset
            // 
            this.selectasset.Filter = "Unity Assets File | *.assets";
            this.selectasset.RestoreDirectory = true;
            this.selectasset.Title = "Unity AssetLoader | Open";
            this.selectasset.FileOk += new System.ComponentModel.CancelEventHandler(this.selectasset_FileOk);
            // 
            // selectmodasset
            // 
            this.selectmodasset.Filter = "Unity Assets File | *.assets";
            this.selectmodasset.Title = "Unity AssetLoader | Open";
            this.selectmodasset.FileOk += new System.ComponentModel.CancelEventHandler(this.selectmodasset_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(567, 282);
            this.Controls.Add(this.btn_rmga);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.mga_selectedmga);
            this.Controls.Add(this.ga_selectedga);
            this.Controls.Add(this.btn_mga);
            this.Controls.Add(this.btn_ga);
            this.Controls.Add(this.madeby);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unity AssetLoader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label madeby;
        private System.Windows.Forms.Button btn_ga;
        private System.Windows.Forms.Button btn_mga;
        private System.Windows.Forms.Label ga_selectedga;
        private System.Windows.Forms.Label mga_selectedmga;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_rmga;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.OpenFileDialog selectasset;
        private System.Windows.Forms.OpenFileDialog selectmodasset;
    }
}

