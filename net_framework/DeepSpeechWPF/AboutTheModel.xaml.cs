using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DeepSpeech.WPF
{
    /// <summary>
    /// Interaction logic for AboutTheModel.xaml
    /// </summary>
    public partial class AboutTheModel : Window
    {
        class Metadata
        {
            string start;
            string author;
            string model_name;
            string model_version;
            string contact_info;
            string license;
            string language;
            string runtime;
            string min_ds_version;
            string max_ds_version;
            string acoustic_model_url;
            string scorer_url;
            string end;
            string footnotes;
        }

        List<string> data = new List<string>();
        string line;
        string fields;
        public AboutTheModel()
        {
            InitializeComponent();
            TextReader reader = new StreamReader("C:\\Users\\carlw\\Documents\\GitHub\\DeepSpeech-examples-0.7\\net_framework\\DeepSpeechWPF\\Model\\Numerov3.md");
            while ((line = reader.ReadLine()) != null)
            {
                data.Add(line);
            }

            string author = data.ElementAt(1).ToString();
            string model_name = data.ElementAt(2).ToString();
            string model_version = data.ElementAt(3).ToString();
            string contact_info = data.ElementAt(4).ToString();
            string license = data.ElementAt(5).ToString();
            string language = data.ElementAt(6).ToString();
            string runtime = data.ElementAt(7).ToString();
            string min_ds_version = data.ElementAt(8).ToString();
            string max_ds_version = data.ElementAt(9).ToString();
            string acoustic_model_url = data.ElementAt(10).ToString();
            string scorer_url = data.ElementAt(11).ToString();

            txtAuthor.Text = author.Substring(author.IndexOf(":") + 1);
            txtNameOfModel.Text = model_name.Substring(model_name.IndexOf(":") + 1);
            txtModelVersion.Text = model_version.Substring(model_version.IndexOf(":") + 1);
            txtContactInfo.Text = contact_info.Substring(contact_info.IndexOf(":") + 1);
            txtLicense.Text = license.Substring(license.IndexOf(":") + 1);   
            txtLanguage.Text = language.Substring(language.IndexOf(":") + 1);
            txtRuntime.Text = runtime.Substring(runtime.IndexOf(":") + 1);
            txtMinimumVersion.Text = min_ds_version.Substring(min_ds_version.IndexOf(":") + 1);
            txtMaximumVersion.Text = max_ds_version.Substring(max_ds_version.IndexOf(":") + 1);
            txtAcousticModelURL.Text = acoustic_model_url.Substring(acoustic_model_url.IndexOf(":") + 1);
            txtScorerModelURL.Text = scorer_url.Substring(scorer_url.IndexOf(":") + 1);

        }
    }
}
