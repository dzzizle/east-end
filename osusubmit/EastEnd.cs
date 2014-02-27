using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osusubmit
{
    public partial class EastEnd : Form
    {
        public EastEnd()
        {
            InitializeComponent();
            ckboxAutoPilot.CheckedChanged += new EventHandler(modChanged);
            ckboxDoubleTime.CheckedChanged += new EventHandler(modChanged);
            ckboxEasy.CheckedChanged += new EventHandler(modChanged);
            ckboxFlashlight.CheckedChanged += new EventHandler(modChanged);
            ckboxHalfTime.CheckedChanged += new EventHandler(modChanged);
            ckboxHardRock.CheckedChanged += new EventHandler(modChanged);
            ckboxHidden.CheckedChanged += new EventHandler(modChanged);
            ckboxNoFail.CheckedChanged += new EventHandler(modChanged);
            ckboxRelax.CheckedChanged += new EventHandler(modChanged);
            ckboxSpunOut.CheckedChanged += new EventHandler(modChanged);
            ckboxSuddenDeath.CheckedChanged += new EventHandler(modChanged);
            ckboxPerfect.CheckedChanged += new EventHandler(modChanged);
            ckboxFadeIn.CheckedChanged += new EventHandler(modChanged);
            ckboxNightcore.CheckedChanged += new EventHandler(modChanged);
            browseMapDialog = new OpenFileDialog();
            browseOsuDialog = new OpenFileDialog();

        }
        private Helper helper = new Helper();

        public Mods playMods;
        public Rankings ranking = Rankings.XH;
        public PlayModes playMode = PlayModes.Osu;

        private void Form1_Load(object sender, EventArgs e)
        {
            //where is osu located?
            if (File.Exists("C:\\Program Files (x86)\\osu!/osu!.exe"))
            {
                helper.osuPath = "C:\\Program Files (x86)\\osu!/osu!.exe";
            }
            else if (File.Exists("C:\\Program Files\\osu!/osu!.exe"))
            {
                helper.osuPath = "C:\\Program Files\\osu!/osu!.exe";
            }
            else
            {
                //other path, probably not on c drive
                txtOsuPath.Text = "osu! path";
                txtOsuPath.Enabled = true;
                btnOsuPath.Enabled = true;
            }
        }

        private void btnSendScore_Click(object sender, EventArgs e)
        {
            helper.time = DateTime.Now;
            string pass = null;
            NameValueCollection pairs = new NameValueCollection();
            pairs.Add("pl", helper.encrypt(helper.getProcesses(), ref pass));
            pairs.Add("score", helper.encrypt(helper.getScore(this), ref pass));
            pairs.Add("fs", helper.encrypt(helper.fs(), ref pass));
            pairs.Add("st", "0"); //not sure what this is, but it sends 0
            pairs.Add("c1", helper.getGUID() + "|" + helper.getDiskSig(this));
            pairs.Add("pass", helper.hash(txtPassword.Text));
            pairs.Add("s", helper.encrypt(helper.getClientID(this), ref pass));
            pairs.Add("i", string.Empty);
            //pairs.Add([REDACTED], [REDACTED]);
            pairs.Add("iv", pass); //passed string
            string message = new UTF8Encoding().GetString(helper.post("http://osu.ppy.sh/web/osu-submit-modular.php", pairs));

            MessageBox.Show(message, "Response", MessageBoxButtons.OK);
        }

        private void modChanged(object sender, EventArgs e)
        {
            playMods = Mods.None;
            if (ckboxNightcore.Checked)
                playMods |= Mods.Nightcore;
            if (ckboxRelax.Checked)
                playMods |= Mods.Relax;
            if (ckboxHalfTime.Checked)
                playMods |= Mods.HalfTime;
            if (ckboxHardRock.Checked)
                playMods |= Mods.HardRock;
            if (ckboxSuddenDeath.Checked)
                playMods |= Mods.SuddenDeath;
            if (ckboxSuddenDeath.Checked)
                playMods |= Mods.Perfect;
            if (ckboxDoubleTime.Checked)
                playMods |= Mods.DoubleTime;
            if (ckboxFlashlight.Checked)
                playMods |= Mods.Flashlight;
            if (ckboxSpunOut.Checked)
                playMods |= Mods.SpunOut;
            if (ckboxAutoPilot.Checked)
                playMods |= Mods.AutoPilot;
            if (ckboxNoFail.Checked)
                playMods |= Mods.NoFail;
            if (ckboxEasy.Checked)
                playMods |= Mods.Easy;
            if (ckboxHidden.Checked)
                playMods |= Mods.Hidden;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void nupMiss_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nup50_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl50_Click(object sender, EventArgs e)
        {

        }

        private void lblMiss_Click(object sender, EventArgs e)
        {

        }

        private void nupKatu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nup100_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl100_Click(object sender, EventArgs e)
        {

        }

        private void lblKatu_Click(object sender, EventArgs e)
        {

        }

        private void nupGeki_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nup300_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl300_Click(object sender, EventArgs e)
        {

        }

        private void lblGeki_Click(object sender, EventArgs e)
        {

        }

        private void cmboxRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmboxRank.SelectedIndex)
            {
                case 0:
                    ranking = Rankings.XH;
                    break;

                case 1:
                    ranking = Rankings.SH;
                    break;

                case 2:
                    ranking = Rankings.X;
                    break;

                case 3:
                    ranking = Rankings.S;
                    break;

                case 4:
                    ranking = Rankings.A;
                    break;

                case 5:
                    ranking = Rankings.B;
                    break;

                case 6:
                    ranking = Rankings.C;
                    break;

                case 7:
                    ranking = Rankings.D;
                    break;
            }

        }

        private OpenFileDialog browseMapDialog;

        private void btnBrowseMap_Click(object sender, EventArgs e)
        {
            if (browseMapDialog.ShowDialog() == DialogResult.OK)
            {
                txtMapPath.Text = browseMapDialog.FileName;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmboxPlayMode.SelectedIndex)
            {
                case 0:
                    playMode = PlayModes.Osu;
                    break;

                case 1:
                    playMode = PlayModes.CatchTheBeat;
                    break;

                case 2:
                    playMode = PlayModes.Taiko;
                    break;

                case 3:
                    playMode = PlayModes.OsuMania;
                    break;
            }
        }

        private OpenFileDialog browseOsuDialog;
        private void btnOsuPath_Click(object sender, EventArgs e)
        {
            if (browseOsuDialog.ShowDialog() == DialogResult.OK)
            {
                txtOsuPath.Text = browseOsuDialog.FileName;
                helper.osuPath = browseOsuDialog.FileName;
            }
        }

        private Rankings getRankFromHits(int h, int f, int k, int m)
        {
            return h > 0 || f > 0 || k > 0 || m > 0 ? Rankings.SH : Rankings.XH;
        }
    }
}
