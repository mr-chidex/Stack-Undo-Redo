namespace UndoRedoSample
{
    partial class Form1
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.UndoBotton = new System.Windows.Forms.Button();
            this.RedoBotton = new System.Windows.Forms.Button();
            this.SaveBotton = new System.Windows.Forms.Button();
            this.LoadSaved = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(37, 33);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(193, 20);
            this.textBox.TabIndex = 0;
            // 
            // UndoBotton
            // 
            this.UndoBotton.Location = new System.Drawing.Point(37, 108);
            this.UndoBotton.Name = "UndoBotton";
            this.UndoBotton.Size = new System.Drawing.Size(75, 32);
            this.UndoBotton.TabIndex = 1;
            this.UndoBotton.Text = "Undo";
            this.UndoBotton.UseVisualStyleBackColor = true;
            this.UndoBotton.Click += new System.EventHandler(this.UndoBotton_Click);
            // 
            // RedoBotton
            // 
            this.RedoBotton.Location = new System.Drawing.Point(155, 108);
            this.RedoBotton.Name = "RedoBotton";
            this.RedoBotton.Size = new System.Drawing.Size(75, 32);
            this.RedoBotton.TabIndex = 2;
            this.RedoBotton.Text = "Redo";
            this.RedoBotton.UseVisualStyleBackColor = true;
            this.RedoBotton.Click += new System.EventHandler(this.RedoBotton_Click);
            // 
            // SaveBotton
            // 
            this.SaveBotton.Location = new System.Drawing.Point(99, 163);
            this.SaveBotton.Name = "SaveBotton";
            this.SaveBotton.Size = new System.Drawing.Size(75, 32);
            this.SaveBotton.TabIndex = 4;
            this.SaveBotton.Text = "Save";
            this.SaveBotton.UseVisualStyleBackColor = true;
            this.SaveBotton.Click += new System.EventHandler(this.SaveBotton_Click);
            // 
            // LoadSaved
            // 
            this.LoadSaved.Location = new System.Drawing.Point(99, 217);
            this.LoadSaved.Name = "LoadSaved";
            this.LoadSaved.Size = new System.Drawing.Size(75, 32);
            this.LoadSaved.TabIndex = 5;
            this.LoadSaved.Text = "Load Saved";
            this.LoadSaved.UseVisualStyleBackColor = true;
            this.LoadSaved.Click += new System.EventHandler(this.LoadSaved_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(255, 305);
            this.Controls.Add(this.LoadSaved);
            this.Controls.Add(this.SaveBotton);
            this.Controls.Add(this.RedoBotton);
            this.Controls.Add(this.UndoBotton);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button UndoBotton;
        private System.Windows.Forms.Button RedoBotton;
        private System.Windows.Forms.Button SaveBotton;
        private System.Windows.Forms.Button LoadSaved;
    }
}

