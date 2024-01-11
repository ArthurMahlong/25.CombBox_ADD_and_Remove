namespace _25.CombBox_ADD_and_Remove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String txtRemove = " ";
            comboBox1.Items.Add("Arthur");
            comboBox1.Items.Add("Mahlong");
            comboBox1.Items.Add("Strike");
            comboBox1.Items.Add("Selala");
            comboBox1.Items.Add("Ronny");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            label2.Text = comboBox1.SelectedItem.ToString();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string textRemoved = "";

            textRemoved = comboBox1.SelectedItem.ToString();
            comboBox1.Items.Remove(comboBox1.SelectedItem);
           // textRemoved = comboBox1.SelectedItem.ToString();
            MessageBox.Show(textRemoved + " Has been removed succesfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            MessageBox.Show(textBox1.Text + " has been added to the combobox");
        }
    }
}
