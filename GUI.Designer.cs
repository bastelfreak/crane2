namespace DemoOpenGLBasicsCS
{
   partial class GUI
   {
      /// <summary>
      /// Erforderliche Designervariable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Verwendete Ressourcen bereinigen.
      /// </summary>
      /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Vom Windows Form-Designer generierter Code

      /// <summary>
      /// Erforderliche Methode für die Designerunterstützung.
      /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
      /// </summary>
      private void InitializeComponent()
      {
            this.panel = new System.Windows.Forms.Panel();
            this.btn_links = new System.Windows.Forms.Button();
            this.btn_rechts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ausleger_zurueck = new System.Windows.Forms.Button();
            this.btn_ausleger_vor = new System.Windows.Forms.Button();
            this.btn_seil_runter = new System.Windows.Forms.Button();
            this.btn_seil_hoch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lbl_z = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(741, 480);
            this.panel.TabIndex = 0;
            // 
            // btn_links
            // 
            this.btn_links.Location = new System.Drawing.Point(760, 49);
            this.btn_links.Name = "btn_links";
            this.btn_links.Size = new System.Drawing.Size(75, 23);
            this.btn_links.TabIndex = 1;
            this.btn_links.Text = "Links";
            this.btn_links.UseVisualStyleBackColor = true;
            this.btn_links.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_links_MouseDown);
            this.btn_links.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_links_MouseUp);
            // 
            // btn_rechts
            // 
            this.btn_rechts.Location = new System.Drawing.Point(841, 49);
            this.btn_rechts.Name = "btn_rechts";
            this.btn_rechts.Size = new System.Drawing.Size(75, 23);
            this.btn_rechts.TabIndex = 2;
            this.btn_rechts.Text = "Rechts";
            this.btn_rechts.UseVisualStyleBackColor = true;
            this.btn_rechts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_rechts_MouseDown);
            this.btn_rechts.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_rechts_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(759, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drehbewegung";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(759, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ausleger";
            // 
            // btn_ausleger_zurueck
            // 
            this.btn_ausleger_zurueck.Location = new System.Drawing.Point(841, 131);
            this.btn_ausleger_zurueck.Name = "btn_ausleger_zurueck";
            this.btn_ausleger_zurueck.Size = new System.Drawing.Size(75, 23);
            this.btn_ausleger_zurueck.TabIndex = 6;
            this.btn_ausleger_zurueck.Text = "Zurück";
            this.btn_ausleger_zurueck.UseVisualStyleBackColor = true;
            this.btn_ausleger_zurueck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_ausleger_zurueck_MouseDown);
            this.btn_ausleger_zurueck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ausleger_zurueck_MouseUp);
            // 
            // btn_ausleger_vor
            // 
            this.btn_ausleger_vor.Location = new System.Drawing.Point(760, 131);
            this.btn_ausleger_vor.Name = "btn_ausleger_vor";
            this.btn_ausleger_vor.Size = new System.Drawing.Size(75, 23);
            this.btn_ausleger_vor.TabIndex = 5;
            this.btn_ausleger_vor.Text = "Vor";
            this.btn_ausleger_vor.UseVisualStyleBackColor = true;
            this.btn_ausleger_vor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_ausleger_vor_MouseDown);
            this.btn_ausleger_vor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ausleger_vor_MouseUp);
            // 
            // btn_seil_runter
            // 
            this.btn_seil_runter.Location = new System.Drawing.Point(841, 213);
            this.btn_seil_runter.Name = "btn_seil_runter";
            this.btn_seil_runter.Size = new System.Drawing.Size(75, 23);
            this.btn_seil_runter.TabIndex = 9;
            this.btn_seil_runter.Text = "Runter";
            this.btn_seil_runter.UseVisualStyleBackColor = true;
            this.btn_seil_runter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_seil_runter_MouseDown);
            this.btn_seil_runter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_seil_runter_MouseUp);
            // 
            // btn_seil_hoch
            // 
            this.btn_seil_hoch.Location = new System.Drawing.Point(760, 213);
            this.btn_seil_hoch.Name = "btn_seil_hoch";
            this.btn_seil_hoch.Size = new System.Drawing.Size(75, 23);
            this.btn_seil_hoch.TabIndex = 8;
            this.btn_seil_hoch.Text = "Hoch";
            this.btn_seil_hoch.UseVisualStyleBackColor = true;
            this.btn_seil_hoch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_seil_hoch_MouseDown);
            this.btn_seil_hoch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_seil_hoch_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(759, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(759, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Aktuelle Position";
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x.Location = new System.Drawing.Point(759, 322);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(23, 25);
            this.lbl_x.TabIndex = 11;
            this.lbl_x.Text = "x";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_y.Location = new System.Drawing.Point(759, 347);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(23, 25);
            this.lbl_y.TabIndex = 12;
            this.lbl_y.Text = "y";
            // 
            // lbl_z
            // 
            this.lbl_z.AutoSize = true;
            this.lbl_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z.Location = new System.Drawing.Point(759, 372);
            this.lbl_z.Name = "lbl_z";
            this.lbl_z.Size = new System.Drawing.Size(23, 25);
            this.lbl_z.TabIndex = 13;
            this.lbl_z.Text = "z";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 504);
            this.Controls.Add(this.lbl_z);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_seil_runter);
            this.Controls.Add(this.btn_seil_hoch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ausleger_zurueck);
            this.Controls.Add(this.btn_ausleger_vor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rechts);
            this.Controls.Add(this.btn_links);
            this.Controls.Add(this.panel);
            this.Name = "GUI";
            this.Text = "OpenGL Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_links;
        private System.Windows.Forms.Button btn_rechts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ausleger_zurueck;
        private System.Windows.Forms.Button btn_ausleger_vor;
        private System.Windows.Forms.Button btn_seil_runter;
        private System.Windows.Forms.Button btn_seil_hoch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_z;
    }
}

