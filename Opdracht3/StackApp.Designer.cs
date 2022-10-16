namespace Opdracht3
{
    partial class StackApp
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
            this.btn_string_add = new System.Windows.Forms.Button();
            this.btn_string_remove = new System.Windows.Forms.Button();
            this.btn_string_empty = new System.Windows.Forms.Button();
            this.label_string = new System.Windows.Forms.Label();
            this.tb_string = new System.Windows.Forms.TextBox();
            this.tb_int = new System.Windows.Forms.TextBox();
            this.label_int = new System.Windows.Forms.Label();
            this.btn_int_empty = new System.Windows.Forms.Button();
            this.btn_int_remove = new System.Windows.Forms.Button();
            this.btn_int_add = new System.Windows.Forms.Button();
            this.tb_persoon = new System.Windows.Forms.TextBox();
            this.label_persoon = new System.Windows.Forms.Label();
            this.btn_persoon_empty = new System.Windows.Forms.Button();
            this.btn_persoon_remove = new System.Windows.Forms.Button();
            this.btn_persoon_add = new System.Windows.Forms.Button();
            this.tb_display_stack = new System.Windows.Forms.TextBox();
            this.btn_string_copy = new System.Windows.Forms.Button();
            this.btn_int_copy = new System.Windows.Forms.Button();
            this.btn_persoon_copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_string_add
            // 
            this.btn_string_add.Location = new System.Drawing.Point(237, 54);
            this.btn_string_add.Name = "btn_string_add";
            this.btn_string_add.Size = new System.Drawing.Size(75, 23);
            this.btn_string_add.TabIndex = 0;
            this.btn_string_add.Text = "Voeg toe";
            this.btn_string_add.UseVisualStyleBackColor = true;
            this.btn_string_add.Click += new System.EventHandler(this.btn_string_add_Click);
            // 
            // btn_string_remove
            // 
            this.btn_string_remove.Location = new System.Drawing.Point(318, 53);
            this.btn_string_remove.Name = "btn_string_remove";
            this.btn_string_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_string_remove.TabIndex = 1;
            this.btn_string_remove.Text = "Verwijder";
            this.btn_string_remove.UseVisualStyleBackColor = true;
            this.btn_string_remove.Click += new System.EventHandler(this.btn_string_remove_Click);
            // 
            // btn_string_empty
            // 
            this.btn_string_empty.Location = new System.Drawing.Point(906, 54);
            this.btn_string_empty.Name = "btn_string_empty";
            this.btn_string_empty.Size = new System.Drawing.Size(75, 23);
            this.btn_string_empty.TabIndex = 2;
            this.btn_string_empty.Text = "Maak leeg";
            this.btn_string_empty.UseVisualStyleBackColor = true;
            this.btn_string_empty.Click += new System.EventHandler(this.btn_string_empty_Click);
            // 
            // label_string
            // 
            this.label_string.AutoSize = true;
            this.label_string.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_string.Location = new System.Drawing.Point(21, 23);
            this.label_string.Name = "label_string";
            this.label_string.Size = new System.Drawing.Size(115, 28);
            this.label_string.TabIndex = 3;
            this.label_string.Text = "String Stack";
            // 
            // tb_string
            // 
            this.tb_string.Location = new System.Drawing.Point(21, 54);
            this.tb_string.Name = "tb_string";
            this.tb_string.Size = new System.Drawing.Size(210, 23);
            this.tb_string.TabIndex = 4;
            // 
            // tb_int
            // 
            this.tb_int.Location = new System.Drawing.Point(21, 122);
            this.tb_int.Name = "tb_int";
            this.tb_int.Size = new System.Drawing.Size(210, 23);
            this.tb_int.TabIndex = 9;
            // 
            // label_int
            // 
            this.label_int.AutoSize = true;
            this.label_int.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_int.Location = new System.Drawing.Point(21, 91);
            this.label_int.Name = "label_int";
            this.label_int.Size = new System.Drawing.Size(125, 28);
            this.label_int.TabIndex = 8;
            this.label_int.Text = "Integer Stack";
            // 
            // btn_int_empty
            // 
            this.btn_int_empty.Location = new System.Drawing.Point(906, 122);
            this.btn_int_empty.Name = "btn_int_empty";
            this.btn_int_empty.Size = new System.Drawing.Size(75, 23);
            this.btn_int_empty.TabIndex = 7;
            this.btn_int_empty.Text = "Maak leeg";
            this.btn_int_empty.UseVisualStyleBackColor = true;
            this.btn_int_empty.Click += new System.EventHandler(this.btn_int_empty_Click);
            // 
            // btn_int_remove
            // 
            this.btn_int_remove.Location = new System.Drawing.Point(318, 121);
            this.btn_int_remove.Name = "btn_int_remove";
            this.btn_int_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_int_remove.TabIndex = 6;
            this.btn_int_remove.Text = "Verwijder";
            this.btn_int_remove.UseVisualStyleBackColor = true;
            this.btn_int_remove.Click += new System.EventHandler(this.btn_int_remove_Click);
            // 
            // btn_int_add
            // 
            this.btn_int_add.Location = new System.Drawing.Point(237, 122);
            this.btn_int_add.Name = "btn_int_add";
            this.btn_int_add.Size = new System.Drawing.Size(75, 23);
            this.btn_int_add.TabIndex = 5;
            this.btn_int_add.Text = "Voeg toe";
            this.btn_int_add.UseVisualStyleBackColor = true;
            this.btn_int_add.Click += new System.EventHandler(this.btn_int_add_Click);
            // 
            // tb_persoon
            // 
            this.tb_persoon.Location = new System.Drawing.Point(21, 188);
            this.tb_persoon.Name = "tb_persoon";
            this.tb_persoon.Size = new System.Drawing.Size(210, 23);
            this.tb_persoon.TabIndex = 14;
            // 
            // label_persoon
            // 
            this.label_persoon.AutoSize = true;
            this.label_persoon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_persoon.Location = new System.Drawing.Point(21, 157);
            this.label_persoon.Name = "label_persoon";
            this.label_persoon.Size = new System.Drawing.Size(208, 28);
            this.label_persoon.TabIndex = 13;
            this.label_persoon.Text = "Persoon (Klasse)  Stack";
            // 
            // btn_persoon_empty
            // 
            this.btn_persoon_empty.Location = new System.Drawing.Point(906, 188);
            this.btn_persoon_empty.Name = "btn_persoon_empty";
            this.btn_persoon_empty.Size = new System.Drawing.Size(75, 23);
            this.btn_persoon_empty.TabIndex = 12;
            this.btn_persoon_empty.Text = "Maak leeg";
            this.btn_persoon_empty.UseVisualStyleBackColor = true;
            this.btn_persoon_empty.Click += new System.EventHandler(this.btn_persoon_empty_Click);
            // 
            // btn_persoon_remove
            // 
            this.btn_persoon_remove.Location = new System.Drawing.Point(318, 187);
            this.btn_persoon_remove.Name = "btn_persoon_remove";
            this.btn_persoon_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_persoon_remove.TabIndex = 11;
            this.btn_persoon_remove.Text = "Verwijder";
            this.btn_persoon_remove.UseVisualStyleBackColor = true;
            this.btn_persoon_remove.Click += new System.EventHandler(this.btn_persoon_remove_Click);
            // 
            // btn_persoon_add
            // 
            this.btn_persoon_add.Location = new System.Drawing.Point(237, 188);
            this.btn_persoon_add.Name = "btn_persoon_add";
            this.btn_persoon_add.Size = new System.Drawing.Size(75, 23);
            this.btn_persoon_add.TabIndex = 10;
            this.btn_persoon_add.Text = "Voeg toe";
            this.btn_persoon_add.UseVisualStyleBackColor = true;
            this.btn_persoon_add.Click += new System.EventHandler(this.btn_persoon_add_Click);
            // 
            // tb_display_stack
            // 
            this.tb_display_stack.Location = new System.Drawing.Point(12, 282);
            this.tb_display_stack.Name = "tb_display_stack";
            this.tb_display_stack.ReadOnly = true;
            this.tb_display_stack.Size = new System.Drawing.Size(988, 23);
            this.tb_display_stack.TabIndex = 15;
            // 
            // btn_string_copy
            // 
            this.btn_string_copy.Location = new System.Drawing.Point(399, 53);
            this.btn_string_copy.Name = "btn_string_copy";
            this.btn_string_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_string_copy.TabIndex = 16;
            this.btn_string_copy.Text = "Kopieer";
            this.btn_string_copy.UseVisualStyleBackColor = true;
            this.btn_string_copy.Click += new System.EventHandler(this.btn_string_copy_Click);
            // 
            // btn_int_copy
            // 
            this.btn_int_copy.Location = new System.Drawing.Point(399, 122);
            this.btn_int_copy.Name = "btn_int_copy";
            this.btn_int_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_int_copy.TabIndex = 17;
            this.btn_int_copy.Text = "Kopieer";
            this.btn_int_copy.UseVisualStyleBackColor = true;
            this.btn_int_copy.Click += new System.EventHandler(this.btn_int_copy_Click);
            // 
            // btn_persoon_copy
            // 
            this.btn_persoon_copy.Location = new System.Drawing.Point(399, 187);
            this.btn_persoon_copy.Name = "btn_persoon_copy";
            this.btn_persoon_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_persoon_copy.TabIndex = 18;
            this.btn_persoon_copy.Text = "Kopieer";
            this.btn_persoon_copy.UseVisualStyleBackColor = true;
            this.btn_persoon_copy.Click += new System.EventHandler(this.btn_persoon_copy_Click);
            // 
            // StackApp
            // 
            this.ClientSize = new System.Drawing.Size(1012, 317);
            this.Controls.Add(this.btn_persoon_copy);
            this.Controls.Add(this.btn_int_copy);
            this.Controls.Add(this.btn_string_copy);
            this.Controls.Add(this.tb_display_stack);
            this.Controls.Add(this.tb_persoon);
            this.Controls.Add(this.label_persoon);
            this.Controls.Add(this.btn_persoon_empty);
            this.Controls.Add(this.btn_persoon_remove);
            this.Controls.Add(this.btn_persoon_add);
            this.Controls.Add(this.tb_int);
            this.Controls.Add(this.label_int);
            this.Controls.Add(this.btn_int_empty);
            this.Controls.Add(this.btn_int_remove);
            this.Controls.Add(this.btn_int_add);
            this.Controls.Add(this.tb_string);
            this.Controls.Add(this.label_string);
            this.Controls.Add(this.btn_string_empty);
            this.Controls.Add(this.btn_string_remove);
            this.Controls.Add(this.btn_string_add);
            this.Name = "StackApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_string_add;
        private Button btn_string_remove;
        private Button btn_string_empty;
        private Label label_string;
        private TextBox tb_string;
        private TextBox tb_int;
        private Label label_int;
        private Button btn_int_empty;
        private Button btn_int_remove;
        private Button btn_int_add;
        private TextBox tb_persoon;
        private Label label_persoon;
        private Button btn_persoon_empty;
        private Button btn_persoon_remove;
        private Button btn_persoon_add;
        private TextBox tb_display_stack;
        private Button btn_string_copy;
        private Button btn_int_copy;
        private Button btn_persoon_copy;
        private Button btn_string_show_copy;
    }
}