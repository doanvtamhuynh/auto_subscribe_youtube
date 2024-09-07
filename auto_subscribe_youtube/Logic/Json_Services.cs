using auto_subscribe_youtube.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_subscribe_youtube.Logic
{
    internal class Json_Services
    {
        public List<Youtube> ReadFile(string path)
        {
            try
            {
                string jsonString = File.ReadAllText(path);

                List<Youtube> youtubes = JsonConvert.DeserializeObject<List<Youtube>>(jsonString);

                return youtubes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK);
                return null;
            }
        }

        public bool WriteFile(List<Youtube> youtubes, string path)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(youtubes, Formatting.Indented);
                File.WriteAllText(path, jsonString);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
