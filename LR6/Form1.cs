using System;
using System.IO;
using System.Windows.Forms;

namespace LR6
{
    public partial class Form1 : Form
    {
        private DataAdapter adapter;

        public Form1()
        {
            InitializeComponent();
            adapter = new DataAdapter();
        }

        private void btnSaveToBinary_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Binary Files (*.bin)|*.bin",
                Title = "Save to Binary File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                adapter.SaveToBinary(dataGridView1, saveFileDialog.FileName);
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveToText_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Save to Text File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                adapter.SaveToText(dataGridView1, saveFileDialog.FileName);
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoadFromBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Binary Files (*.bin)|*.bin",
                Title = "Load from Binary File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                adapter.LoadFromBinary(dataGridView1, openFileDialog.FileName);
                MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoadFromText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Load from Text File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                adapter.LoadFromText(dataGridView1, openFileDialog.FileName);
                MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public class DataAdapter
    {
        public void SaveToBinary(DataGridView gridView, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(gridView.Rows.Count);
                writer.Write(gridView.Columns.Count);

                foreach (DataGridViewRow row in gridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        writer.Write(cell.Value?.ToString() ?? "");
                    }
                }
            }
        }

        public void SaveToText(DataGridView gridView, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (DataGridViewRow row in gridView.Rows)
                {
                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        writer.Write(row.Cells[i].Value?.ToString() ?? "");
                        if (i < gridView.Columns.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();
                }
            }
        }

        public void LoadFromBinary(DataGridView gridView, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                int rows = reader.ReadInt32();
                int columns = reader.ReadInt32();

                gridView.Rows.Clear();
                gridView.Columns.Clear();

                for (int i = 0; i < columns; i++)
                {
                    gridView.Columns.Add($"Column{i}", $"Column{i}");
                }

                for (int i = 0; i < rows; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(gridView);

                    for (int j = 0; j < columns; j++)
                    {
                        row.Cells[j].Value = reader.ReadString();
                    }

                    gridView.Rows.Add(row);
                }
            }
        }

        public void LoadFromText(DataGridView gridView, string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                gridView.Rows.Clear();
                gridView.Columns.Clear();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');

                    if (gridView.Columns.Count == 0)
                    {
                        for (int i = 0; i < values.Length; i++)
                        {
                            gridView.Columns.Add($"Column{i}", $"Column{i}");
                        }
                    }

                    gridView.Rows.Add(values);
                }
            }
        }
    }
}

