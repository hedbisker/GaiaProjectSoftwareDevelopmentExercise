using Newtonsoft.Json;

namespace GaiaProjectClientSide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadOperations();
        }
        private const string apiUrl = "http://localhost:5207/Operators/";
        private async void LoadOperations()
        {
            // טען את ההיסטוריה מהשרת והצג אותה ב-RichTextBox
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"{apiUrl}GetListOfOperators");
                    comboBox1.DataSource = JsonConvert.DeserializeObject<List<string>>(response.Content.ReadAsStringAsync().Result);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string _operator = comboBox1.SelectedValue.ToString();
                    HttpResponseMessage response = client.GetAsync($"{apiUrl}{_operator}?first={textBox1.Text}&second={textBox2.Text}").Result;
                    textBox3.Text = JsonConvert.DeserializeObject<string>(response.Content.ReadAsStringAsync().Result);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error calculation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
