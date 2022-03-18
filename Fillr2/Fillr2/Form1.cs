using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace Fillr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Regex r_var = new Regex("(?<=<<).*?(?=>>)");
        private ArrayList vars = new ArrayList();  // Stores current variables (highly volatile)

        private void tb_template_TextChanged(object sender, EventArgs e)
        {
            // Setup environment
            lb_vars.Items.Clear();
            vars.Clear();

            // Recompute vars
            foreach (Match var in r_var.Matches(tb_template.Text))
            {
                if (!vars.Contains(var.Value) && var.Value.Trim().Length != 0)
                {
                    vars.Add(var.Value);
                } else
                {
                    MessageBox.Show("Please use a variable name that you have not used before and is not blank.");
                }
            }

            // Update new vars & UI
            foreach (string var in vars)
            {
                lb_vars.Items.Add(var);
            }
            if (lb_vars.Items.Count > 0) lb_vars.SelectedIndex = 0;
        }

        private void tb_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && lb_vars.SelectedIndex >= 0)
            {
                insert_variable();
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            insert_variable();
        }

        private void insert_variable()
        {
            // Pull working values
            string template = tb_template.Text;
            int insertFrom = vars.IndexOf(lb_vars.SelectedItem.ToString()) == 0 ? 0 : template.IndexOf("<<" + (string)vars[vars.IndexOf(lb_vars.SelectedItem.ToString()) - 1] + ">>") + ((string)vars[vars.IndexOf(lb_vars.SelectedItem.ToString()) - 1]).Length + 4;  // Index of where to insert template code starting at
            int insertTo = template.IndexOf("<<" + lb_vars.SelectedItem.ToString() + ">>");
            string value = tb_input.Text;

            // Process value insert
            tb_output.AppendText(template.Substring(insertFrom, insertTo - insertFrom) + value);

            // Last var in iteration
            if (lb_vars.SelectedIndex == lb_vars.Items.Count - 1) tb_output.AppendText(template.Substring(insertTo + lb_vars.SelectedItem.ToString().Length + 4));

            lb_vars.SelectedIndex = lb_vars.SelectedIndex != lb_vars.Items.Count - 1 ? lb_vars.SelectedIndex + 1 : 0;  // Tick selected variable
            tb_input.Clear();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_output.Text);
        }
    }
}
