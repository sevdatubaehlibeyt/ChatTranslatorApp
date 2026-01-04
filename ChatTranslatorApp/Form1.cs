using System;
using System.Windows.Forms;

namespace ChatTranslatorApp
{
    public partial class Form1 : Form
    {
        TranslationService translator = new TranslationService();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFrom.Items.Add("Türkçe");
            cmbFrom.Items.Add("İngilizce");
            cmbFrom.Items.Add("Almanca");
            cmbFrom.Items.Add("İtalyanca");
            cmbFrom.Items.Add("Arapça");
            cmbFrom.Items.Add("Korece");

            cmbTo.Items.Add("Türkçe");
            cmbTo.Items.Add("İngilizce");
            cmbTo.Items.Add("Almanca");
            cmbTo.Items.Add("İtalyanca");
            cmbTo.Items.Add("Arapça");
            cmbTo.Items.Add("Korece");

            cmbFrom.SelectedIndex = 0;
            cmbTo.SelectedIndex = 1;
        }

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string from = cmbFrom.SelectedItem.ToString();
            string to = cmbTo.SelectedItem.ToString();

            txtOutput.Text = "Çevriliyor...";

            string result = await translator.TranslateAsync(input, from, to);

            txtOutput.Text = result;

            // SOHBET GEÇMİŞİNE EKLEME
            rtbHistory.AppendText($"[ {from} → {to} ]\n");
            rtbHistory.AppendText($"Orijinal: {input}\n");
            rtbHistory.AppendText($"Çeviri: {result}\n\n");

            // OTOMATİK AŞAĞI KAYDIRMA
            rtbHistory.SelectionStart = rtbHistory.Text.Length;
            rtbHistory.ScrollToCaret();
        }
        }
    }

