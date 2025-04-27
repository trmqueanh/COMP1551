namespace StringProcessingApp
{
    public partial class Form1 : Form
    {
        private StringProcessing processor;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            try
            {
                processor = new StringProcessing(txtInput.Text.Trim(), int.Parse(txtShift.Text.Trim()));
                txtResult.Text = "✅ Initialization successful!";
            }
            catch (Exception ex)
            {
                txtResult.Text = "❌ Error: " + ex.Message;
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                processor.Encode();
                txtResult.Text = "🔹 Encoded: " + processor.Print();
            }
            catch
            {
                txtResult.Text = "❌ Error: Initialize first.";
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                processor.Decode(); 
                txtResult.Text = "🔑 Decoded: " + processor.Print();
            }
            catch
            {
                txtResult.Text = "❌ Error: Initialize first.";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = "📄 Output String: " + processor.Print();
            }
            catch
            {
                txtResult.Text = "❌ Error: Encode first.";
            }
        }

        private void btnInputCode_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = "🔢 Input ASCII: " + string.Join(", ", processor.InputCode());
            }
            catch
            {
                txtResult.Text = "❌ Error: Initialize first.";
            }
        }

        private void btnOutputCode_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = "🔢 Output ASCII: " + string.Join(", ", processor.OutputCode());
            }
            catch
            {
                txtResult.Text = "❌ Error: Encode first.";
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = "📌 Sorted String: " + processor.Sort();
            }
            catch
            {
                txtResult.Text = "❌ Error: Initialize first.";
            }
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = "🔒 SHA-256 Hash: " + processor.HashOutput();
            }
            catch
            {
                txtResult.Text = "❌ Error: Encode first.";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtShift.Clear();
            txtResult.Clear();
            processor = null; 
        }
    }
}
