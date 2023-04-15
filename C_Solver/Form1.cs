namespace C_Solver
{
    public partial class Form : System.Windows.Forms.Form
    {
        string fileContent = string.Empty;
        int amountOfLayers = 4;
        Solver solver;
        public Form()
        {
            InitializeComponent();
            labelC1.Visible = false;
            labelC2.Visible = false;
            labelC3.Visible = false;
            labelC4.Visible = false;
            buttonRun.Enabled = false;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        solver = new Solver(fileContent);
                        if (solver.AmountOfLayers == 0)
                            MessageBox.Show("Матрица смежности должна содержать только 0 и 1, разделенные пробелами и переносами строки");
                        else
                            buttonRun.Enabled = true;                    
                    }
                }
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            List<List<int>> C = solver.Solve(amountOfLayers);
            labelC1.Text = makeString(C[0]);
            labelC2.Text = makeString(C[1]);
            labelC3.Text = makeString(C[2]);
            labelC4.Text = makeString(C[3]);
            labelC1.Visible = true;
            labelC2.Visible = true;
            labelC3.Visible = true;
            labelC4.Visible = true;
        }

        private string makeString(List<int> C)
        {
            string result = "";
            for (int i = 0; i < C.Count; i++)
                result += (C[i] + 1).ToString() + ", ";
            return result.Substring(0, result.Length - 2);
        }
    }
}