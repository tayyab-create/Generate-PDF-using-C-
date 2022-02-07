using System;
using IronPdf;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generate_PDF_using_IronPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_generate_Click(object sender, EventArgs e)
        {
            String htmlTemp = txt_htmlstring.Text;
            
            //Chceking If Text in TextBox is empty or not
            if(htmlTemp.Trim().Length > 0)
            {
                //Initialize Save File Dialog Box
                SaveFileDialog file = new SaveFileDialog();
                file.DefaultExt = "pdf";
                file.Title = "Save Pdf File";
                file.DefaultExt = "pdf";
                file.FilterIndex = 1;
                file.Filter = "Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    string fileName = file.FileName;
                    
                    //Initalize Generating PDF
                    var Renderer = new IronPdf.ChromePdfRenderer();
                    
                    //Generate PDF from HTML string
                    Renderer.RenderHtmlAsPdf(htmlTemp).SaveAs(fileName);
                    MessageBox.Show("File Generated and saved succesfully!");

                    //Empty TextBox after generating PDF
                    txt_htmlstring.Text = String.Empty;
                }
            
            }
            //If the Text is not greater than 0, PDF will not generate.
            else
            {
                MessageBox.Show("You can't generate Empty PDF!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_htmlstring.Text = String.Empty;
        }

        private void btn_url_Click(object sender, EventArgs e)
        {
            String url = txt_url.Text;

            //Chceking If Text in TextBox is empty or not
            if (url.Trim().Length > 0)
            {
                //Initialize Save File Dialog Box
                SaveFileDialog file = new SaveFileDialog();
                file.DefaultExt = "pdf";
                file.Title = "Save Pdf File";
                file.DefaultExt = "pdf";
                file.FilterIndex = 1;
                file.Filter = "Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    string fileName = file.FileName;

                    //Initalize Generating PDF
                    var Renderer = new IronPdf.ChromePdfRenderer();

                    //Generate PDF from URL
                    Renderer.RenderUrlAsPdf(url).SaveAs(fileName);
                    MessageBox.Show("File Generated and saved succesfully!");

                    //Empty TextBox after generating PDF
                    txt_url.Text = String.Empty;
                }
            }
            //If the Text is not greater than 0, PDF will not generate.
            else
            {
                MessageBox.Show("Enter URL please!");
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "HTML files (*.html)|*.html";
            
            if(file.ShowDialog() == DialogResult.OK)
            {
                txt_file.Text = file.FileName;
            }
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            if(txt_file.Text.Trim() != "")
            {
                string selectedFilePath = txt_file.Text;
                //Initialize Save File Dialog Box
                SaveFileDialog file = new SaveFileDialog();
                file.DefaultExt = "pdf";
                file.Title = "Save Pdf File";
                file.DefaultExt = "pdf";
                file.FilterIndex = 1;
                file.Filter = "Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    string fileName = file.FileName;

                    //Initalize Generating PDF
                    var Renderer = new IronPdf.ChromePdfRenderer();

                    //Generate PDF from URL
                    Renderer.RenderHTMLFileAsPdf(selectedFilePath).SaveAs(fileName);
                    MessageBox.Show("File Generated and saved succesfully!");

                    //Empty TextBox after generating PDF
                    txt_file.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please select a HTML file!");
            }
        }
    }
}
