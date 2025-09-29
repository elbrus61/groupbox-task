namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (male.Checked) Gender = " Male ";
            if (female.Checked) Gender = " Female ";
            if (other.Checked) Gender = " Other ";


            string City = "";
            if(listcity.SelectedItem != null) 
                City = listcity.SelectedItem.ToString();


            string Uni = "";
            if (listuni.SelectedItem != null)
                Uni = listcity.SelectedItem.ToString();

            string Country = "";
            if(comboCountry.SelectedItem  != null)
                Country = comboCountry.SelectedItem.ToString();

            string languages = "";
            if (checkeng.Checked) languages += "English";
            if (checkturk.Checked) languages += " Turkish";
            if (checkrus.Checked) languages += " Russian";

            string programming = "";
            if (checkc.Checked) programming += "C#";
            if (checkpython.Checked) programming += " Python";
            if (checkjava.Checked) programming += " Java";

            string message = $"Gender : {Gender}\n" 
                + $"City : {City}\n"
                + $"Country: {Country}\n"
                + $"Programming Languages: {programming}\n"
                + $"University: {Uni}\n"
                + $"Languages: {languages}";

            MessageBox.Show(message);
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
