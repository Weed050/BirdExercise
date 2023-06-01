namespace FloushingCards2_Win_forms_
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
            reset2 = new Button();
            shuffle2 = new Button();
            reset1 = new Button();
            shuffle1 = new Button();
            moveTo1Set = new Button();
            moveTo2Set = new Button();
            zestaw1Box = new ListBox();
            zestaw2Box = new ListBox();
            SuspendLayout();
            // 
            // reset2
            // 
            reset2.Location = new Point(360, 377);
            reset2.Name = "reset2";
            reset2.Size = new Size(204, 29);
            reset2.TabIndex = 0;
            reset2.Text = "Przywróć zestaw 2";
            reset2.UseVisualStyleBackColor = true;
            reset2.Click += reset2_Click;
            // 
            // shuffle2
            // 
            shuffle2.Location = new Point(360, 412);
            shuffle2.Name = "shuffle2";
            shuffle2.Size = new Size(204, 29);
            shuffle2.TabIndex = 1;
            shuffle2.Text = "Wymieszaj zestaw 2";
            shuffle2.UseVisualStyleBackColor = true;
            shuffle2.Click += shuffle2_Click;
            // 
            // reset1
            // 
            reset1.Location = new Point(12, 377);
            reset1.Name = "reset1";
            reset1.Size = new Size(204, 29);
            reset1.TabIndex = 2;
            reset1.Text = "Przywróć zestaw 1";
            reset1.UseVisualStyleBackColor = true;
            reset1.Click += reset1_Click;
            // 
            // shuffle1
            // 
            shuffle1.Location = new Point(12, 412);
            shuffle1.Name = "shuffle1";
            shuffle1.Size = new Size(204, 29);
            shuffle1.TabIndex = 3;
            shuffle1.Text = "Wymieszaj zestaw 1";
            shuffle1.UseVisualStyleBackColor = true;
            shuffle1.Click += shuffle1_Click;
            // 
            // moveTo1Set
            // 
            moveTo1Set.Location = new Point(241, 89);
            moveTo1Set.Name = "moveTo1Set";
            moveTo1Set.Size = new Size(94, 29);
            moveTo1Set.TabIndex = 6;
            moveTo1Set.Text = "<<";
            moveTo1Set.UseMnemonic = false;
            moveTo1Set.UseVisualStyleBackColor = true;
            moveTo1Set.Click += moveTo1Set_Click;
            // 
            // moveTo2Set
            // 
            moveTo2Set.Location = new Point(241, 124);
            moveTo2Set.Name = "moveTo2Set";
            moveTo2Set.Size = new Size(94, 29);
            moveTo2Set.TabIndex = 7;
            moveTo2Set.Text = ">>";
            moveTo2Set.UseVisualStyleBackColor = true;
            moveTo2Set.Click += moveTo2Set_Click;
            // 
            // zestaw1Box
            // 
            zestaw1Box.FormattingEnabled = true;
            zestaw1Box.ItemHeight = 20;
            zestaw1Box.Location = new Point(12, 27);
            zestaw1Box.Name = "zestaw1Box";
            zestaw1Box.Size = new Size(204, 344);
            zestaw1Box.TabIndex = 8;
            // 
            // zestaw2Box
            // 
            zestaw2Box.FormattingEnabled = true;
            zestaw2Box.ItemHeight = 20;
            zestaw2Box.Location = new Point(360, 27);
            zestaw2Box.Name = "zestaw2Box";
            zestaw2Box.Size = new Size(204, 344);
            zestaw2Box.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 450);
            Controls.Add(zestaw2Box);
            Controls.Add(zestaw1Box);
            Controls.Add(moveTo2Set);
            Controls.Add(moveTo1Set);
            Controls.Add(shuffle1);
            Controls.Add(reset1);
            Controls.Add(shuffle2);
            Controls.Add(reset2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button reset2;
        private Button shuffle2;
        private Button reset1;
        private Button shuffle1;
        private Button moveTo1Set;
        private Button moveTo2Set;
        private ListBox zestaw1Box;
        private ListBox zestaw2Box;
    }
}