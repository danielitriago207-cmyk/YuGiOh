namespace YuGiOh
{
    partial class FormBatalla
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemi = new System.Windows.Forms.PictureBox();
            this.lblPlayerLP = new System.Windows.Forms.Label();
            this.lblEnemiLP = new System.Windows.Forms.Label();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnCambiarPos = new System.Windows.Forms.Button();
            this.btnDefender = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Location = new System.Drawing.Point(85, 53);
            this.pictureBoxPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(121, 158);
            this.pictureBoxPlayer.TabIndex = 0;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxEnemi
            // 
            this.pictureBoxEnemi.Location = new System.Drawing.Point(428, 53);
            this.pictureBoxEnemi.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEnemi.Name = "pictureBoxEnemi";
            this.pictureBoxEnemi.Size = new System.Drawing.Size(121, 158);
            this.pictureBoxEnemi.TabIndex = 1;
            this.pictureBoxEnemi.TabStop = false;
            // 
            // lblPlayerLP
            // 
            this.lblPlayerLP.AutoSize = true;
            this.lblPlayerLP.Location = new System.Drawing.Point(98, 23);
            this.lblPlayerLP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerLP.Name = "lblPlayerLP";
            this.lblPlayerLP.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerLP.TabIndex = 2;
            // 
            // lblEnemiLP
            // 
            this.lblEnemiLP.AutoSize = true;
            this.lblEnemiLP.Location = new System.Drawing.Point(388, 23);
            this.lblEnemiLP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnemiLP.Name = "lblEnemiLP";
            this.lblEnemiLP.Size = new System.Drawing.Size(0, 13);
            this.lblEnemiLP.TabIndex = 5;
            // 
            // btnAtacar
            // 
            this.btnAtacar.Location = new System.Drawing.Point(101, 282);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(86, 38);
            this.btnAtacar.TabIndex = 6;
            this.btnAtacar.Text = "button1";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // btnCambiarPos
            // 
            this.btnCambiarPos.Location = new System.Drawing.Point(272, 282);
            this.btnCambiarPos.Name = "btnCambiarPos";
            this.btnCambiarPos.Size = new System.Drawing.Size(86, 38);
            this.btnCambiarPos.TabIndex = 7;
            this.btnCambiarPos.Text = "button2";
            this.btnCambiarPos.UseVisualStyleBackColor = true;
            this.btnCambiarPos.Click += new System.EventHandler(this.btnCambiarPos_Click);
            // 
            // btnDefender
            // 
            this.btnDefender.Location = new System.Drawing.Point(444, 282);
            this.btnDefender.Name = "btnDefender";
            this.btnDefender.Size = new System.Drawing.Size(86, 38);
            this.btnDefender.TabIndex = 8;
            this.btnDefender.Text = "button3";
            this.btnDefender.UseVisualStyleBackColor = true;
            this.btnDefender.Click += new System.EventHandler(this.btnDefender_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 146);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 121);
            this.textBox1.TabIndex = 9;
            // 
            // FormBatalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 413);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDefender);
            this.Controls.Add(this.btnCambiarPos);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.lblEnemiLP);
            this.Controls.Add(this.lblPlayerLP);
            this.Controls.Add(this.pictureBoxEnemi);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBatalla";
            this.Text = "FormBatalla";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxEnemi;
        private System.Windows.Forms.Label lblPlayerLP;
        private System.Windows.Forms.Label lblEnemiLP;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnCambiarPos;
        private System.Windows.Forms.Button btnDefender;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}