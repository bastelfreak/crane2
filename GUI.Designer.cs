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
            this.tbx_x = new System.Windows.Forms.TextBox();
            this.tbx_y = new System.Windows.Forms.TextBox();
            this.tbx_z = new System.Windows.Forms.TextBox();
            this.tbx_xz_movement = new System.Windows.Forms.TextBox();
            this.tbx_y_movement = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_tri_z = new System.Windows.Forms.TextBox();
            this.tbx_tri_y = new System.Windows.Forms.TextBox();
            this.tbx_tri_x = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbx_rad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbx_alpha = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbx_towerheight = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbx_boomlength = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbx_ropelength = new System.Windows.Forms.TextBox();
            this.tbx_ropeposition = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbx_mark_z = new System.Windows.Forms.TextBox();
            this.tbx_mark_y = new System.Windows.Forms.TextBox();
            this.tbx_mark_x = new System.Windows.Forms.TextBox();
            this.btn_mark_position = new System.Windows.Forms.Button();
            this.btn_goto_position = new System.Windows.Forms.Button();
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
            this.label4.Location = new System.Drawing.Point(759, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vektor";
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x.Location = new System.Drawing.Point(759, 293);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(23, 25);
            this.lbl_x.TabIndex = 11;
            this.lbl_x.Text = "x";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_y.Location = new System.Drawing.Point(759, 318);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(23, 25);
            this.lbl_y.TabIndex = 12;
            this.lbl_y.Text = "y";
            // 
            // lbl_z
            // 
            this.lbl_z.AutoSize = true;
            this.lbl_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z.Location = new System.Drawing.Point(759, 343);
            this.lbl_z.Name = "lbl_z";
            this.lbl_z.Size = new System.Drawing.Size(23, 25);
            this.lbl_z.TabIndex = 13;
            this.lbl_z.Text = "z";
            // 
            // tbx_x
            // 
            this.tbx_x.Location = new System.Drawing.Point(799, 298);
            this.tbx_x.Name = "tbx_x";
            this.tbx_x.Size = new System.Drawing.Size(100, 20);
            this.tbx_x.TabIndex = 14;
            // 
            // tbx_y
            // 
            this.tbx_y.Location = new System.Drawing.Point(799, 324);
            this.tbx_y.Name = "tbx_y";
            this.tbx_y.Size = new System.Drawing.Size(100, 20);
            this.tbx_y.TabIndex = 15;
            // 
            // tbx_z
            // 
            this.tbx_z.Location = new System.Drawing.Point(799, 350);
            this.tbx_z.Name = "tbx_z";
            this.tbx_z.Size = new System.Drawing.Size(100, 20);
            this.tbx_z.TabIndex = 16;
            // 
            // tbx_xz_movement
            // 
            this.tbx_xz_movement.Location = new System.Drawing.Point(1179, 298);
            this.tbx_xz_movement.Name = "tbx_xz_movement";
            this.tbx_xz_movement.Size = new System.Drawing.Size(100, 20);
            this.tbx_xz_movement.TabIndex = 17;
            // 
            // tbx_y_movement
            // 
            this.tbx_y_movement.Location = new System.Drawing.Point(1179, 324);
            this.tbx_y_movement.Name = "tbx_y_movement";
            this.tbx_y_movement.Size = new System.Drawing.Size(100, 20);
            this.tbx_y_movement.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1100, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Skalierungsfaktor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1134, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "XZ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1146, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(759, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Trigonometrie";
            // 
            // tbx_tri_z
            // 
            this.tbx_tri_z.Location = new System.Drawing.Point(799, 472);
            this.tbx_tri_z.Name = "tbx_tri_z";
            this.tbx_tri_z.Size = new System.Drawing.Size(100, 20);
            this.tbx_tri_z.TabIndex = 28;
            // 
            // tbx_tri_y
            // 
            this.tbx_tri_y.Location = new System.Drawing.Point(799, 446);
            this.tbx_tri_y.Name = "tbx_tri_y";
            this.tbx_tri_y.Size = new System.Drawing.Size(100, 20);
            this.tbx_tri_y.TabIndex = 27;
            // 
            // tbx_tri_x
            // 
            this.tbx_tri_x.Location = new System.Drawing.Point(799, 420);
            this.tbx_tri_x.Name = "tbx_tri_x";
            this.tbx_tri_x.Size = new System.Drawing.Size(100, 20);
            this.tbx_tri_x.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(759, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(759, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(759, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "x";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1122, 420);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Rad";
            // 
            // tbx_rad
            // 
            this.tbx_rad.Location = new System.Drawing.Point(1179, 420);
            this.tbx_rad.Name = "tbx_rad";
            this.tbx_rad.Size = new System.Drawing.Size(100, 20);
            this.tbx_rad.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1134, 445);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "α";
            // 
            // tbx_alpha
            // 
            this.tbx_alpha.Location = new System.Drawing.Point(1179, 451);
            this.tbx_alpha.Name = "tbx_alpha";
            this.tbx_alpha.Size = new System.Drawing.Size(100, 20);
            this.tbx_alpha.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1148, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "Infos";
            // 
            // tbx_towerheight
            // 
            this.tbx_towerheight.Location = new System.Drawing.Point(1179, 52);
            this.tbx_towerheight.Name = "tbx_towerheight";
            this.tbx_towerheight.Size = new System.Drawing.Size(100, 20);
            this.tbx_towerheight.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1054, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 25);
            this.label15.TabIndex = 35;
            this.label15.Text = "Towerhöhe";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1023, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 25);
            this.label16.TabIndex = 36;
            this.label16.Text = "Auslegerlänge";
            // 
            // tbx_boomlength
            // 
            this.tbx_boomlength.Location = new System.Drawing.Point(1179, 78);
            this.tbx_boomlength.Name = "tbx_boomlength";
            this.tbx_boomlength.Size = new System.Drawing.Size(100, 20);
            this.tbx_boomlength.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1072, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 25);
            this.label17.TabIndex = 38;
            this.label17.Text = "Seillänge";
            // 
            // tbx_ropelength
            // 
            this.tbx_ropelength.Location = new System.Drawing.Point(1179, 104);
            this.tbx_ropelength.Name = "tbx_ropelength";
            this.tbx_ropelength.Size = new System.Drawing.Size(100, 20);
            this.tbx_ropelength.TabIndex = 39;
            // 
            // tbx_ropeposition
            // 
            this.tbx_ropeposition.Location = new System.Drawing.Point(1179, 130);
            this.tbx_ropeposition.Name = "tbx_ropeposition";
            this.tbx_ropeposition.Size = new System.Drawing.Size(100, 20);
            this.tbx_ropeposition.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1050, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 25);
            this.label18.TabIndex = 41;
            this.label18.Text = "Seilposition";
            // 
            // tbx_mark_z
            // 
            this.tbx_mark_z.Location = new System.Drawing.Point(913, 472);
            this.tbx_mark_z.Name = "tbx_mark_z";
            this.tbx_mark_z.Size = new System.Drawing.Size(100, 20);
            this.tbx_mark_z.TabIndex = 47;
            // 
            // tbx_mark_y
            // 
            this.tbx_mark_y.Location = new System.Drawing.Point(913, 446);
            this.tbx_mark_y.Name = "tbx_mark_y";
            this.tbx_mark_y.Size = new System.Drawing.Size(100, 20);
            this.tbx_mark_y.TabIndex = 46;
            // 
            // tbx_mark_x
            // 
            this.tbx_mark_x.Location = new System.Drawing.Point(913, 420);
            this.tbx_mark_x.Name = "tbx_mark_x";
            this.tbx_mark_x.Size = new System.Drawing.Size(100, 20);
            this.tbx_mark_x.TabIndex = 45;
            // 
            // btn_mark_position
            // 
            this.btn_mark_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mark_position.Location = new System.Drawing.Point(1026, 431);
            this.btn_mark_position.Name = "btn_mark_position";
            this.btn_mark_position.Size = new System.Drawing.Size(75, 23);
            this.btn_mark_position.TabIndex = 48;
            this.btn_mark_position.Text = "Markieren";
            this.btn_mark_position.UseVisualStyleBackColor = true;
            this.btn_mark_position.Click += new System.EventHandler(this.btn_mark_position_Click);
            // 
            // btn_goto_position
            // 
            this.btn_goto_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goto_position.Location = new System.Drawing.Point(1026, 458);
            this.btn_goto_position.Name = "btn_goto_position";
            this.btn_goto_position.Size = new System.Drawing.Size(75, 23);
            this.btn_goto_position.TabIndex = 49;
            this.btn_goto_position.Text = "Fahren";
            this.btn_goto_position.UseVisualStyleBackColor = true;
            this.btn_goto_position.Click += new System.EventHandler(this.btn_goto_position_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 504);
            this.Controls.Add(this.btn_goto_position);
            this.Controls.Add(this.btn_mark_position);
            this.Controls.Add(this.tbx_mark_z);
            this.Controls.Add(this.tbx_mark_y);
            this.Controls.Add(this.tbx_mark_x);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbx_ropeposition);
            this.Controls.Add(this.tbx_ropelength);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbx_boomlength);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbx_towerheight);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbx_alpha);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbx_rad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbx_tri_z);
            this.Controls.Add(this.tbx_tri_y);
            this.Controls.Add(this.tbx_tri_x);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_y_movement);
            this.Controls.Add(this.tbx_xz_movement);
            this.Controls.Add(this.tbx_z);
            this.Controls.Add(this.tbx_y);
            this.Controls.Add(this.tbx_x);
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
        private System.Windows.Forms.TextBox tbx_x;
        private System.Windows.Forms.TextBox tbx_y;
        private System.Windows.Forms.TextBox tbx_z;
        private System.Windows.Forms.TextBox tbx_xz_movement;
        private System.Windows.Forms.TextBox tbx_y_movement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_tri_z;
        private System.Windows.Forms.TextBox tbx_tri_y;
        private System.Windows.Forms.TextBox tbx_tri_x;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbx_rad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbx_alpha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbx_towerheight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbx_boomlength;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbx_ropelength;
        private System.Windows.Forms.TextBox tbx_ropeposition;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbx_mark_z;
        private System.Windows.Forms.TextBox tbx_mark_y;
        private System.Windows.Forms.TextBox tbx_mark_x;
        private System.Windows.Forms.Button btn_mark_position;
        private System.Windows.Forms.Button btn_goto_position;
    }
}

