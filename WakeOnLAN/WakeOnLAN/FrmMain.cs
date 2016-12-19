using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WakeOnLAN
{
    public partial class FrmMain : Form
    {
        private readonly string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"WakeOnLAN\config.xml");
        private Config config;


        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            config = LoadConfig(configPath);
            AddAllTargetsToList(config.targets);
        }

        private void btnNewTarget_Click(object sender, EventArgs e)
        {
            Target target = new Target();
            target.name = tbTargetName.Text;
            target.MAC = mtbMACAddress.Text;
            target.hostname = tbBroadcastAddress.Text;

            config.targets.Add(target);
            clbTargets.Items.Add(target);

            SaveConfig(config, configPath);
        }

        private void btnUpdateTarget_Click(object sender, EventArgs e)
        {
            Target target = (Target) clbTargets.SelectedItem;
            if (target != null)
            {
                target.name = tbTargetName.Text;
                target.MAC = mtbMACAddress.Text;
                target.hostname = tbBroadcastAddress.Text;

                clbTargets.Refresh();
            }

            SaveConfig(config, configPath);
        }

        private void btnDeleteTarget_Click(object sender, EventArgs e)
        {
            int index = clbTargets.SelectedIndex;
            if (index != -1)
            {
                clbTargets.Items.RemoveAt(index);
                config.targets.RemoveAt(index);
                clbTargets.Refresh();

                SaveConfig(config, configPath);
            }
        }

        private void btnWakeTarget_Click(object sender, EventArgs e)
        {
            Target target = (Target)clbTargets.SelectedItem;
            if (target != null)
            {
                int iterations = Convert.ToInt32(nudPacketsToSend.Value);
                target.WakeTarget(iterations);
            }
        }

        private void clbTargets_SelectedIndexChanged(object sender, EventArgs e)
        {
            Target target = (Target) clbTargets.SelectedItem;
            if (target != null)
            {
                tbTargetName.Text = target.name;
                mtbMACAddress.Text = target.MAC;
                tbBroadcastAddress.Text = target.hostname;
            }
        }

        private void AddAllTargetsToList(List<Target> targets)
        {
            foreach(Target target in targets)
            {
                clbTargets.Items.Add(target);
            }
        }

        private Config LoadConfig(string path)
        {
            Config config = Utility.XMLDeserialize<Config>(path);
            if(config == null)
            {
                config = new Config();
            }

            return config;
        }

        private void SaveConfig(Config config, string path)
        {
            Utility.XMLSerialize<Config>(config, path);
        }
    }
}
