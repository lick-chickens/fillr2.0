
namespace Fillr2
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
            this.sc_main = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb_template = new System.Windows.Forms.TextBox();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.lb_vars = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).BeginInit();
            this.sc_main.Panel1.SuspendLayout();
            this.sc_main.Panel2.SuspendLayout();
            this.sc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_main
            // 
            this.sc_main.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.sc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_main.Location = new System.Drawing.Point(0, 0);
            this.sc_main.Name = "sc_main";
            // 
            // sc_main.Panel1
            // 
            this.sc_main.Panel1.Controls.Add(this.splitContainer1);
            // 
            // sc_main.Panel2
            // 
            this.sc_main.Panel2.Controls.Add(this.btn_insert);
            this.sc_main.Panel2.Controls.Add(this.btn_copy);
            this.sc_main.Panel2.Controls.Add(this.tb_input);
            this.sc_main.Panel2.Controls.Add(this.lb_vars);
            this.sc_main.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sc_main.Size = new System.Drawing.Size(1041, 550);
            this.sc_main.SplitterDistance = 742;
            this.sc_main.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_template);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tb_output);
            this.splitContainer1.Size = new System.Drawing.Size(742, 550);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 0;
            // 
            // tb_template
            // 
            this.tb_template.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_template.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_template.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_template.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_template.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_template.Location = new System.Drawing.Point(12, 12);
            this.tb_template.Multiline = true;
            this.tb_template.Name = "tb_template";
            this.tb_template.PlaceholderText = "Template - Define variables with <<var_name>>";
            this.tb_template.Size = new System.Drawing.Size(727, 195);
            this.tb_template.TabIndex = 0;
            this.tb_template.TextChanged += new System.EventHandler(this.tb_template_TextChanged);
            // 
            // tb_output
            // 
            this.tb_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_output.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_output.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_output.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_output.Location = new System.Drawing.Point(12, 3);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.PlaceholderText = "Output";
            this.tb_output.Size = new System.Drawing.Size(727, 321);
            this.tb_output.TabIndex = 1;
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_insert.Location = new System.Drawing.Point(184, 504);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(98, 34);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "Next";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_copy.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btn_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_copy.Location = new System.Drawing.Point(3, 504);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(175, 34);
            this.btn_copy.TabIndex = 2;
            this.btn_copy.Text = "Copy output";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // tb_input
            // 
            this.tb_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_input.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_input.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_input.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_input.Location = new System.Drawing.Point(2, 471);
            this.tb_input.Name = "tb_input";
            this.tb_input.PlaceholderText = "Set variable to";
            this.tb_input.Size = new System.Drawing.Size(280, 27);
            this.tb_input.TabIndex = 1;
            this.tb_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_input_KeyDown);
            // 
            // lb_vars
            // 
            this.lb_vars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_vars.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lb_vars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_vars.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lb_vars.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_vars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_vars.FormattingEnabled = true;
            this.lb_vars.ItemHeight = 20;
            this.lb_vars.Location = new System.Drawing.Point(3, 12);
            this.lb_vars.Name = "lb_vars";
            this.lb_vars.Size = new System.Drawing.Size(280, 442);
            this.lb_vars.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1041, 550);
            this.Controls.Add(this.sc_main);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fillr 2.0";
            this.sc_main.Panel1.ResumeLayout(false);
            this.sc_main.Panel2.ResumeLayout(false);
            this.sc_main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).EndInit();
            this.sc_main.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_main;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tb_template;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.ListBox lb_vars;
    }
}

