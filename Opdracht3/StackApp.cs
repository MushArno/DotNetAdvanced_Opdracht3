using static System.Windows.Forms.AxHost;

namespace Opdracht3
{
    public partial class StackApp : Form
    {
        Stapel<string> stapelString = new Stapel<string>();
        Stapel<int> stapelInt = new Stapel<int>();
        Stapel<Persoon> stapelPersoon = new Stapel<Persoon>();

        public StackApp()
        {

            InitializeComponent();

        }
    

        private void StackApp_Load(object sender, EventArgs e)
        {
            
        }

        // Stapel String
        private void btn_string_add_Click(object sender, EventArgs e)
        {
            string input = tb_string.Text;
            stapelString.Toevoegen(input);
            tb_string.Text = "";
            tb_display_stack.Text = stapelString.ToString();
        }

        private void btn_string_remove_Click(object sender, EventArgs e)
        {
            stapelString.Verwijderen();
            tb_display_stack.Text = stapelString.ToString();
        }

        private void btn_string_empty_Click(object sender, EventArgs e)
        {
            stapelString.MaakLeeg();
            tb_display_stack.Text = "";
        }
        // Kopie aanmaken en tonen;
        private void btn_string_copy_Click(object sender, EventArgs e)
        {

            stapelString.Copy();
            

        }


        // Stapel Int
        private void btn_int_add_Click(object sender, EventArgs e)
        {
            int input = int.Parse(tb_int.Text);
            stapelInt.Toevoegen(input);
            tb_int.Text = "";
            tb_display_stack.Text = stapelInt.ToString();
        }

        private void btn_int_remove_Click(object sender, EventArgs e)
        {
            stapelInt.Verwijderen();
            tb_display_stack.Text = stapelInt.ToString();
        }

        private void btn_int_empty_Click(object sender, EventArgs e)
        {
            stapelInt.MaakLeeg();
            tb_display_stack.Text = "";
        }

        private void btn_int_copy_Click(object sender, EventArgs e)
        {
            stapelInt.Copy();
        }
        // Stapel Persoon
        private void btn_persoon_add_Click(object sender, EventArgs e)
        {
            string input = tb_persoon.Text;
            stapelPersoon.Toevoegen(new Persoon(input));
            tb_persoon.Text = "";
            tb_display_stack.Text = stapelPersoon.ToString();
        }

        private void btn_persoon_remove_Click(object sender, EventArgs e)
        {
            stapelPersoon.Verwijderen();
            tb_display_stack.Text = stapelPersoon.ToString();
        }

        private void btn_persoon_empty_Click(object sender, EventArgs e)
        {
            stapelPersoon.MaakLeeg();
            tb_display_stack.Text = "";
        }

        private void btn_persoon_copy_Click(object sender, EventArgs e)
        {
            stapelPersoon.Copy();
        }
    }
}