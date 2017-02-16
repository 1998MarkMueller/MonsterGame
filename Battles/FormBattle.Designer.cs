namespace Battles
{
    partial class BattleWindow
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
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.picEnemyPokemon = new System.Windows.Forms.PictureBox();
            this.picYourPokemon = new System.Windows.Forms.PictureBox();
            this.lblYourPokemonName = new System.Windows.Forms.Label();
            this.lblYourPokemonLvl = new System.Windows.Forms.Label();
            this.lblYourPokemonExp = new System.Windows.Forms.Label();
            this.lblYourPokemonHP = new System.Windows.Forms.Label();
            this.lblEnemyPokemonName = new System.Windows.Forms.Label();
            this.lblEnemyPokemonLvl = new System.Windows.Forms.Label();
            this.lblEnemyPokemonHP = new System.Windows.Forms.Label();
            this.lstDialog = new System.Windows.Forms.ListBox();
            this.proYourHealth = new System.Windows.Forms.ProgressBar();
            this.proEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYourPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOption1
            // 
            this.btnOption1.Location = new System.Drawing.Point(218, 221);
            this.btnOption1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(123, 25);
            this.btnOption1.TabIndex = 0;
            this.btnOption1.Text = "Fight";
            this.btnOption1.UseVisualStyleBackColor = true;
            this.btnOption1.Click += new System.EventHandler(this.btnOption1_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.Location = new System.Drawing.Point(359, 221);
            this.btnOption2.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(123, 25);
            this.btnOption2.TabIndex = 1;
            this.btnOption2.Text = "Bag";
            this.btnOption2.UseVisualStyleBackColor = true;
            this.btnOption2.Click += new System.EventHandler(this.btnOption2_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.Location = new System.Drawing.Point(218, 252);
            this.btnOption3.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(123, 25);
            this.btnOption3.TabIndex = 2;
            this.btnOption3.Text = "Pokemon";
            this.btnOption3.UseVisualStyleBackColor = true;
            this.btnOption3.Click += new System.EventHandler(this.btnOption3_Click);
            // 
            // btnOption4
            // 
            this.btnOption4.Location = new System.Drawing.Point(359, 252);
            this.btnOption4.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(123, 25);
            this.btnOption4.TabIndex = 3;
            this.btnOption4.Text = "Run";
            this.btnOption4.UseVisualStyleBackColor = true;
            this.btnOption4.Click += new System.EventHandler(this.btnOption4_Click);
            // 
            // picEnemyPokemon
            // 
            this.picEnemyPokemon.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPokemon.Location = new System.Drawing.Point(323, 54);
            this.picEnemyPokemon.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.picEnemyPokemon.Name = "picEnemyPokemon";
            this.picEnemyPokemon.Size = new System.Drawing.Size(75, 75);
            this.picEnemyPokemon.TabIndex = 4;
            this.picEnemyPokemon.TabStop = false;
            // 
            // picYourPokemon
            // 
            this.picYourPokemon.BackColor = System.Drawing.Color.Transparent;
            this.picYourPokemon.Location = new System.Drawing.Point(93, 142);
            this.picYourPokemon.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.picYourPokemon.Name = "picYourPokemon";
            this.picYourPokemon.Size = new System.Drawing.Size(75, 75);
            this.picYourPokemon.TabIndex = 5;
            this.picYourPokemon.TabStop = false;
            // 
            // lblYourPokemonName
            // 
            this.lblYourPokemonName.AutoSize = true;
            this.lblYourPokemonName.BackColor = System.Drawing.Color.Transparent;
            this.lblYourPokemonName.Location = new System.Drawing.Point(286, 142);
            this.lblYourPokemonName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYourPokemonName.Name = "lblYourPokemonName";
            this.lblYourPokemonName.Size = new System.Drawing.Size(41, 15);
            this.lblYourPokemonName.TabIndex = 6;
            this.lblYourPokemonName.Text = "Name";
            // 
            // lblYourPokemonLvl
            // 
            this.lblYourPokemonLvl.AutoSize = true;
            this.lblYourPokemonLvl.BackColor = System.Drawing.Color.Transparent;
            this.lblYourPokemonLvl.Location = new System.Drawing.Point(409, 142);
            this.lblYourPokemonLvl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYourPokemonLvl.Name = "lblYourPokemonLvl";
            this.lblYourPokemonLvl.Size = new System.Drawing.Size(25, 15);
            this.lblYourPokemonLvl.TabIndex = 7;
            this.lblYourPokemonLvl.Text = "Lvl:";
            // 
            // lblYourPokemonExp
            // 
            this.lblYourPokemonExp.AutoSize = true;
            this.lblYourPokemonExp.BackColor = System.Drawing.Color.Transparent;
            this.lblYourPokemonExp.Location = new System.Drawing.Point(424, 187);
            this.lblYourPokemonExp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYourPokemonExp.Name = "lblYourPokemonExp";
            this.lblYourPokemonExp.Size = new System.Drawing.Size(24, 15);
            this.lblYourPokemonExp.TabIndex = 8;
            this.lblYourPokemonExp.Text = "0/0";
            // 
            // lblYourPokemonHP
            // 
            this.lblYourPokemonHP.AutoSize = true;
            this.lblYourPokemonHP.BackColor = System.Drawing.Color.Transparent;
            this.lblYourPokemonHP.Location = new System.Drawing.Point(274, 187);
            this.lblYourPokemonHP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYourPokemonHP.Name = "lblYourPokemonHP";
            this.lblYourPokemonHP.Size = new System.Drawing.Size(27, 15);
            this.lblYourPokemonHP.TabIndex = 9;
            this.lblYourPokemonHP.Text = "HP:";
            // 
            // lblEnemyPokemonName
            // 
            this.lblEnemyPokemonName.AutoSize = true;
            this.lblEnemyPokemonName.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyPokemonName.Location = new System.Drawing.Point(24, 9);
            this.lblEnemyPokemonName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEnemyPokemonName.Name = "lblEnemyPokemonName";
            this.lblEnemyPokemonName.Size = new System.Drawing.Size(41, 15);
            this.lblEnemyPokemonName.TabIndex = 10;
            this.lblEnemyPokemonName.Text = "Name";
            // 
            // lblEnemyPokemonLvl
            // 
            this.lblEnemyPokemonLvl.AutoSize = true;
            this.lblEnemyPokemonLvl.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyPokemonLvl.Location = new System.Drawing.Point(154, 9);
            this.lblEnemyPokemonLvl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEnemyPokemonLvl.Name = "lblEnemyPokemonLvl";
            this.lblEnemyPokemonLvl.Size = new System.Drawing.Size(25, 15);
            this.lblEnemyPokemonLvl.TabIndex = 11;
            this.lblEnemyPokemonLvl.Text = "Lvl:";
            // 
            // lblEnemyPokemonHP
            // 
            this.lblEnemyPokemonHP.AutoSize = true;
            this.lblEnemyPokemonHP.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyPokemonHP.Location = new System.Drawing.Point(24, 38);
            this.lblEnemyPokemonHP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEnemyPokemonHP.Name = "lblEnemyPokemonHP";
            this.lblEnemyPokemonHP.Size = new System.Drawing.Size(27, 15);
            this.lblEnemyPokemonHP.TabIndex = 12;
            this.lblEnemyPokemonHP.Text = "HP:";
            // 
            // lstDialog
            // 
            this.lstDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDialog.FormattingEnabled = true;
            this.lstDialog.ItemHeight = 12;
            this.lstDialog.Location = new System.Drawing.Point(15, 224);
            this.lstDialog.Name = "lstDialog";
            this.lstDialog.Size = new System.Drawing.Size(194, 52);
            this.lstDialog.TabIndex = 13;
            // 
            // proYourHealth
            // 
            this.proYourHealth.Location = new System.Drawing.Point(382, 171);
            this.proYourHealth.Name = "proYourHealth";
            this.proYourHealth.Size = new System.Drawing.Size(89, 10);
            this.proYourHealth.TabIndex = 14;
            // 
            // proEnemyHealth
            // 
            this.proEnemyHealth.Location = new System.Drawing.Point(118, 38);
            this.proEnemyHealth.Name = "proEnemyHealth";
            this.proEnemyHealth.Size = new System.Drawing.Size(96, 10);
            this.proEnemyHealth.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Change Pokemon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BattleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Battles.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(494, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.proEnemyHealth);
            this.Controls.Add(this.proYourHealth);
            this.Controls.Add(this.lstDialog);
            this.Controls.Add(this.picYourPokemon);
            this.Controls.Add(this.picEnemyPokemon);
            this.Controls.Add(this.lblEnemyPokemonHP);
            this.Controls.Add(this.lblEnemyPokemonLvl);
            this.Controls.Add(this.lblEnemyPokemonName);
            this.Controls.Add(this.lblYourPokemonHP);
            this.Controls.Add(this.lblYourPokemonExp);
            this.Controls.Add(this.lblYourPokemonLvl);
            this.Controls.Add(this.lblYourPokemonName);
            this.Controls.Add(this.btnOption4);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "BattleWindow";
            this.Text = "Pokemon - Cool Edition";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BattleWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYourPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.PictureBox picEnemyPokemon;
        private System.Windows.Forms.PictureBox picYourPokemon;
        private System.Windows.Forms.Label lblYourPokemonName;
        private System.Windows.Forms.Label lblYourPokemonLvl;
        private System.Windows.Forms.Label lblYourPokemonExp;
        private System.Windows.Forms.Label lblYourPokemonHP;
        private System.Windows.Forms.Label lblEnemyPokemonName;
        private System.Windows.Forms.Label lblEnemyPokemonLvl;
        private System.Windows.Forms.Label lblEnemyPokemonHP;
        private System.Windows.Forms.ListBox lstDialog;
        private System.Windows.Forms.ProgressBar proYourHealth;
        private System.Windows.Forms.ProgressBar proEnemyHealth;
        private System.Windows.Forms.Button button1;
    }
}

