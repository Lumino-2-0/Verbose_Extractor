namespace Verbose_Extractor
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerlogBspToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Bouton_Export = new System.Windows.Forms.Button();
            this.Importation_fichier = new System.Windows.Forms.OpenFileDialog();
            this.Exporter = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fichier_importe = new System.Windows.Forms.Label();
            this.Box_Importation = new System.Windows.Forms.TextBox();
            this.CheckBox_Date_heure = new System.Windows.Forms.CheckBox();
            this.Check_TimeCompileInclude = new System.Windows.Forms.CheckBox();
            this.HelperDateHeure = new System.Windows.Forms.ToolTip(this.components);
            this.HelperTempsCompile = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importerlogBspToolStripMenuItem,
            this.exporterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // importerlogBspToolStripMenuItem
            // 
            this.importerlogBspToolStripMenuItem.Name = "importerlogBspToolStripMenuItem";
            this.importerlogBspToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.importerlogBspToolStripMenuItem.Text = "Importer (log bsp)";
            // 
            // exporterToolStripMenuItem
            // 
            this.exporterToolStripMenuItem.Enabled = false;
            this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            this.exporterToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exporterToolStripMenuItem.Text = "Exporter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "POUR QUE LE SYSTÈME SOIT ACTIF, VEUILLEZ ACTIVEZ L\'OPTION\r\n\"-verbose\" LORS DE LA " +
    "COMPILATION VRAD/$light DANS HAMMER (++) !\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Importer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bouton_Export
            // 
            this.Bouton_Export.Enabled = false;
            this.Bouton_Export.Location = new System.Drawing.Point(16, 256);
            this.Bouton_Export.Name = "Bouton_Export";
            this.Bouton_Export.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bouton_Export.Size = new System.Drawing.Size(140, 44);
            this.Bouton_Export.TabIndex = 5;
            this.Bouton_Export.Text = "Exporter";
            this.Bouton_Export.UseVisualStyleBackColor = true;
            this.Bouton_Export.Click += new System.EventHandler(this.button2_Click);
            // 
            // Importation_fichier
            // 
            this.Importation_fichier.FileName = "*.log";
            this.Importation_fichier.Filter = "Fichier log compilation BSP|*.log|Fichier texte de log BSP|*.txt|Tous le fichier " +
    "custom log BSP|*.*";
            this.Importation_fichier.RestoreDirectory = true;
            this.Importation_fichier.Title = "Importation de fichier log BSP";
            this.Importation_fichier.FileOk += new System.ComponentModel.CancelEventHandler(this.Importation_fichier_FileOk);
            // 
            // Exporter
            // 
            this.Exporter.Title = "Exportation log custom";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(411, 112);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(377, 328);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preview";
            // 
            // Fichier_importe
            // 
            this.Fichier_importe.AutoSize = true;
            this.Fichier_importe.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fichier_importe.ForeColor = System.Drawing.Color.Red;
            this.Fichier_importe.Location = new System.Drawing.Point(171, 127);
            this.Fichier_importe.Name = "Fichier_importe";
            this.Fichier_importe.Size = new System.Drawing.Size(129, 19);
            this.Fichier_importe.TabIndex = 8;
            this.Fichier_importe.Text = "fichier importé !";
            this.Fichier_importe.Visible = false;
            // 
            // Box_Importation
            // 
            this.Box_Importation.Location = new System.Drawing.Point(16, 149);
            this.Box_Importation.Name = "Box_Importation";
            this.Box_Importation.Size = new System.Drawing.Size(389, 20);
            this.Box_Importation.TabIndex = 9;
            this.Box_Importation.TextChanged += new System.EventHandler(this.Box_Importation_TextChanged);
            // 
            // CheckBox_Date_heure
            // 
            this.CheckBox_Date_heure.AutoSize = true;
            this.CheckBox_Date_heure.Enabled = false;
            this.CheckBox_Date_heure.Location = new System.Drawing.Point(16, 186);
            this.CheckBox_Date_heure.Name = "CheckBox_Date_heure";
            this.CheckBox_Date_heure.Size = new System.Drawing.Size(90, 17);
            this.CheckBox_Date_heure.TabIndex = 10;
            this.CheckBox_Date_heure.Text = "Date + Heure";
            this.HelperDateHeure.SetToolTip(this.CheckBox_Date_heure, "Retranscrit la date et l\'heure actuelle dans le fichier (à la fin) et dans le tit" +
        "re du fichier.");
            this.CheckBox_Date_heure.UseVisualStyleBackColor = true;
            this.CheckBox_Date_heure.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Check_TimeCompileInclude
            // 
            this.Check_TimeCompileInclude.AutoSize = true;
            this.Check_TimeCompileInclude.Enabled = false;
            this.Check_TimeCompileInclude.Location = new System.Drawing.Point(16, 223);
            this.Check_TimeCompileInclude.Name = "Check_TimeCompileInclude";
            this.Check_TimeCompileInclude.Size = new System.Drawing.Size(159, 17);
            this.Check_TimeCompileInclude.TabIndex = 11;
            this.Check_TimeCompileInclude.Text = "Temps de compilation inclus";
            this.HelperTempsCompile.SetToolTip(this.Check_TimeCompileInclude, "Affiche le temps de compilation (actif de base) à la fin du fichier.");
            this.Check_TimeCompileInclude.UseVisualStyleBackColor = true;
            this.Check_TimeCompileInclude.CheckedChanged += new System.EventHandler(this.Check_TimeCompileInclude_CheckedChanged);
            // 
            // HelperDateHeure
            // 
            this.HelperDateHeure.AutomaticDelay = 20;
            this.HelperDateHeure.AutoPopDelay = 10000;
            this.HelperDateHeure.InitialDelay = 20;
            this.HelperDateHeure.ReshowDelay = 4;
            this.HelperDateHeure.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.HelperDateHeure.ToolTipTitle = "Helper option Date + Heure";
            // 
            // HelperTempsCompile
            // 
            this.HelperTempsCompile.AutomaticDelay = 20;
            this.HelperTempsCompile.AutoPopDelay = 10000;
            this.HelperTempsCompile.InitialDelay = 20;
            this.HelperTempsCompile.ReshowDelay = 4;
            this.HelperTempsCompile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.HelperTempsCompile.ToolTipTitle = "Helper option du temps de compilation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 446);
            this.Controls.Add(this.Check_TimeCompileInclude);
            this.Controls.Add(this.CheckBox_Date_heure);
            this.Controls.Add(this.Box_Importation);
            this.Controls.Add(this.Fichier_importe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Bouton_Export);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerlogBspToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Bouton_Export;
        private System.Windows.Forms.OpenFileDialog Importation_fichier;
        private System.Windows.Forms.SaveFileDialog Exporter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Fichier_importe;
        private System.Windows.Forms.TextBox Box_Importation;
        private System.Windows.Forms.CheckBox CheckBox_Date_heure;
        private System.Windows.Forms.CheckBox Check_TimeCompileInclude;
        private System.Windows.Forms.ToolTip HelperDateHeure;
        private System.Windows.Forms.ToolTip HelperTempsCompile;
    }
}

