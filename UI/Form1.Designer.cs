namespace UI
{
    partial class frSVNACTeam40f5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frSVNACTeam40f5));
            this.lbxKlasse = new System.Windows.Forms.ListBox();
            this.lblKlasse = new System.Windows.Forms.Label();
            this.lbxSchueler = new System.Windows.Forms.ListBox();
            this.lblSchueler = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbxLocalUsers = new System.Windows.Forms.ListBox();
            this.lblLocalUsers = new System.Windows.Forms.Label();
            this.pnlDragAndDrop = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbxKlasse
            // 
            this.lbxKlasse.FormattingEnabled = true;
            this.lbxKlasse.Location = new System.Drawing.Point(15, 25);
            this.lbxKlasse.Name = "lbxKlasse";
            this.lbxKlasse.Size = new System.Drawing.Size(105, 316);
            this.lbxKlasse.TabIndex = 0;
            // 
            // lblKlasse
            // 
            this.lblKlasse.AutoSize = true;
            this.lblKlasse.Location = new System.Drawing.Point(12, 9);
            this.lblKlasse.Name = "lblKlasse";
            this.lblKlasse.Size = new System.Drawing.Size(38, 13);
            this.lblKlasse.TabIndex = 1;
            this.lblKlasse.Text = "Klasse";
            this.lblKlasse.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbxSchueler
            // 
            this.lbxSchueler.FormattingEnabled = true;
            this.lbxSchueler.Location = new System.Drawing.Point(168, 25);
            this.lbxSchueler.Name = "lbxSchueler";
            this.lbxSchueler.Size = new System.Drawing.Size(224, 316);
            this.lbxSchueler.TabIndex = 2;
            // 
            // lblSchueler
            // 
            this.lblSchueler.AutoSize = true;
            this.lblSchueler.Location = new System.Drawing.Point(165, 9);
            this.lblSchueler.Name = "lblSchueler";
            this.lblSchueler.Size = new System.Drawing.Size(49, 13);
            this.lblSchueler.TabIndex = 3;
            this.lblSchueler.Text = "Schueler";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(168, 347);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(224, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Ausgewählte Elemente entfernen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxLocalUsers
            // 
            this.lbxLocalUsers.FormattingEnabled = true;
            this.lbxLocalUsers.Location = new System.Drawing.Point(398, 25);
            this.lbxLocalUsers.Name = "lbxLocalUsers";
            this.lbxLocalUsers.Size = new System.Drawing.Size(120, 316);
            this.lbxLocalUsers.TabIndex = 5;
            // 
            // lblLocalUsers
            // 
            this.lblLocalUsers.AutoSize = true;
            this.lblLocalUsers.Location = new System.Drawing.Point(395, 9);
            this.lblLocalUsers.Name = "lblLocalUsers";
            this.lblLocalUsers.Size = new System.Drawing.Size(84, 13);
            this.lblLocalUsers.TabIndex = 6;
            this.lblLocalUsers.Text = "Lokale Benutzer";
            // 
            // pnlDragAndDrop
            // 
            this.pnlDragAndDrop.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pnlDragAndDrop.AllowDrop = true;
            this.pnlDragAndDrop.BackColor = System.Drawing.Color.Transparent;
            this.pnlDragAndDrop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDragAndDrop.BackgroundImage")));
            this.pnlDragAndDrop.ForeColor = System.Drawing.Color.Transparent;
            this.pnlDragAndDrop.Location = new System.Drawing.Point(624, 191);
            this.pnlDragAndDrop.Name = "pnlDragAndDrop";
            this.pnlDragAndDrop.Size = new System.Drawing.Size(100, 100);
            this.pnlDragAndDrop.TabIndex = 9;
            this.pnlDragAndDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDragAndDrop_DragDrop);
            this.pnlDragAndDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDragAndDrop_DragEnter);
            // 
            // frSVNACTeam40f5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 412);
            this.Controls.Add(this.pnlDragAndDrop);
            this.Controls.Add(this.lblLocalUsers);
            this.Controls.Add(this.lbxLocalUsers);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblSchueler);
            this.Controls.Add(this.lbxSchueler);
            this.Controls.Add(this.lblKlasse);
            this.Controls.Add(this.lbxKlasse);
            this.Name = "frSVNACTeam40f5";
            this.Text = "SVNACTeam4Of5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxKlasse;
        private System.Windows.Forms.Label lblKlasse;
        private System.Windows.Forms.ListBox lbxSchueler;
        private System.Windows.Forms.Label lblSchueler;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbxLocalUsers;
        private System.Windows.Forms.Label lblLocalUsers;
        private System.Windows.Forms.Panel pnlDragAndDrop;
    }
}

