using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonToExcel_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                arquivoOrigem.Text = openFileDialog.FileName;
            }

            saveCSVdialog.FileName = arquivoOrigem.Text.Replace("json", "csv");
            arquivoDestino.Text = saveCSVdialog.FileName;
        }

        private void btSelecionarCSV_Click(object sender, EventArgs e)
        {
            if (saveCSVdialog.ShowDialog() == DialogResult.OK) arquivoDestino.Text = saveCSVdialog.FileName;
        }

        private void btConvert_Click(object sender, EventArgs e)
        {
            var jsonText = File.ReadAllText(arquivoOrigem.Text);

            var logs = SimpleJSON.JSON.Parse(jsonText);

            string csv = "";
            List<ExpandoObject> dataList = null;
            foreach (var child in logs.Children)
            {
                var firebaseLookup = JsonConvert.DeserializeObject<Dictionary<string, ExpandoObject>>(child.ToString());
                dataList = firebaseLookup.Values.ToList(); // or FirstOrDefault();
            }

            if (dataList != null) csv += JsonToCsv(dataList, "\t");



            File.WriteAllText(arquivoDestino.Text, csv);
            System.Windows.Forms.MessageBox.Show("Conversão Completada!");
        }

        public static string JsonToCsv(List<ExpandoObject> expandos, string delimiter)
        {
            using (var writer = new StringWriter())
            {
                using (var csv = new CsvWriter(writer))
                {
                    csv.Configuration.Delimiter = delimiter;

                    csv.WriteRecords(expandos as IEnumerable<dynamic>);
                }

                return writer.ToString();
            }
        }
    }
}
