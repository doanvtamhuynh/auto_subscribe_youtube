using auto_subscribe_youtube.Logic;
using auto_subscribe_youtube.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_subscribe_youtube
{
    public partial class Main : Form
    {
        private string _channelsPath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\Resources\\";
        private List<Youtube> _youtubes;
        private Json_Services _JsonServices = new Json_Services();
        private string _email;
        private string _password;
        private CancellationTokenSource _cts;
        public Main()
        {
            InitializeComponent();
            LoadForm();
        }

        public void LoadForm()
        {
            try
            {
                dataGridView1.Columns["cl_Channel"].Width = 100;
                dataGridView1.Columns["cl_Link"].Width = 300;
                _youtubes = _JsonServices.ReadFile(_channelsPath + "channels.json");
                dataGridView1.DataSource = _youtubes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAddChannel_Click(object sender, EventArgs e)
        {
            try
            {
                btnAddChannel.Enabled = false;
                string channel = txtChannel.Text;
                string link = txtLink.Text;

                if(channel != "" && link != "")
                {
                    _youtubes.Add(new Youtube(channel, link));
                    bool result = _JsonServices.WriteFile(_youtubes, _channelsPath + "channels.json");
                    if (result)
                    {
                        txtChannel.Text = "";
                        txtLink.Text = "";
                        LoadForm();
                    }
                }
                else
                {
                    MessageBox.Show("Channel Or Link Is Empty!!!", "Empty!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            finally
            {
                btnAddChannel.Enabled = true;
            }
        }

        private void btnDeleteChannel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the selected columns?"
                                        , "Confirm Delete"
                                        , MessageBoxButtons.YesNo
                                        , MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    btnDeleteChannel.Enabled = false;
                    List<int> rowsToRemove = new List<int>();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Selected)
                        {
                            rowsToRemove.Add(row.Index);
                        }
                    }

                    rowsToRemove.Reverse();
                    foreach (int item in rowsToRemove)
                    {
                        _youtubes.RemoveAt(item);
                    }

                    _JsonServices.WriteFile(_youtubes, _channelsPath + "channels.json");
                    LoadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    btnDeleteChannel.Enabled = true;
                }
            }
        }

        private async void btnAuto_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            CancellationToken token = _cts.Token;

            try
            {
                btnAuto.Enabled = false;
                _email = txtEmail.Text;
                _password = txtPass.Text;
                if(_email != "" && _password != "")
                {
                    Google_Services.OpenGoogle();
                    var result = Google_Services.LoginGoogle(new EmailAccount(_email, _password));
                    Thread.Sleep(5000);
                    if (result)
                    {
                        await Task.Run(() => Google_Services.Subscribe(_youtubes, token), token);
                    }
                }
                else
                {
                    MessageBox.Show("Email, Password or Recovery Is Empty!!!", "Empty", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            { 
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                btnAuto.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure you want to stop?"
                                        , "Confirm Stop"
                                        , MessageBoxButtons.YesNo
                                        , MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    btnStop.Enabled = false;
                    if (_cts != null)
                    {
                        _cts.Cancel();
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                btnStop.Enabled = true;
            }

        }
    }
}
