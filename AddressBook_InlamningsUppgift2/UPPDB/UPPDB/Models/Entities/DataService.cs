namespace UPPDB.Models.Entities
{
    public class DataService
    {
        private object comboBox1;

        public DataService()
        {
            object value = InitializeComponent();


            comboBox1.Items.Add("Mahmod");
            comboBox1.Items.Add("Ahmed");
            comboBox1.Items.Add("Ali");


        }

        private object InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Selected index {comboBox1.SelectedIndex} Item {comboBox1.SelectedItem}");
            label1.Text = comboBox1.SelectedItem.ToString();

        }
    }
}
   