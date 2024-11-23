namespace WinFormsTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ver_Click(object sender, EventArgs e)
        {
            this.mostrarTabla();

        }


        private void mostrarTabla()
        {
            int n = Convert.ToInt32(this.textboxNumero.Text);

            string tabla = "";
            for (int i = 1; i <= 10; i++)
            {
                tabla = tabla + n + "x" + i + "=" + (n * i) + "\n";
            }
            this.richTextBoxResultados.AppendText(tabla);


        }

        private void richTextBoxResultados_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
