using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osusubmit
{
    public partial class Form1 : Form
    {
        public Form1()
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
            openFileDialog = new OpenFileDialog();

        }
        private Helper helper = new Helper();

        private Mods playMods;
        private Rankings ranking = Rankings.XH;
        private PlayModes playMode = PlayModes.Osu;

        private void Form1_Load(object sender, EventArgs e)
        {
            //where is osu located?
            helper.osuPath = File.Exists("C:\\Program Files\\osu!/osu!.exe") ? "C:\\Program Files\\osu!/osu!.exe" : "C:\\Program Files (x86)\\osu!/osu!.exe";
        }

        private void btnSendScore_Click(object sender, EventArgs e)
        {
                time = DateTime.Now;
                string pass = null;
                NameValueCollection pairs = new NameValueCollection();
                Console.WriteLine(helper.hash(txtPassword.Text));
                pairs.Add("pl", helper.encrypt(helper.getProcesses(), ref pass));
                pairs.Add("score", helper.encrypt(getScore(), ref pass));
                pairs.Add("fs", helper.encrypt(helper.fs(), ref pass));
                pairs.Add("st", "0"); //not sure what this is, but it sends 0
                pairs.Add("c1", helper.getGUID() + "|" + helper.getDiskSig());
                pairs.Add("pass", helper.hash(txtPassword.Text));
                pairs.Add("s", helper.encrypt(helper.clientid(), ref pass));
                pairs.Add("i", string.Empty);
                pairs.Add("iv", pass); //passed string
                string message = new UTF8Encoding().GetString(helper.post("http://osu.ppy.sh/web/osu-submit-modular.php", pairs));

                MessageBox.Show(message, "Response", MessageBoxButtons.OK);
        }

        public DateTime time;

        private string getScore()
        {
            return string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}:{8}:{9}:{10}:{11}:{12}:{13}:{14}:{15}:{16:yyMMddHHmmss}:{17}", new object[] { 
            helper.hashFile(txtMapPath.Text), txtUsername.Text, secondScore(), nup300.Value, nup100.Value, nup50.Value, nupGeki.Value, nupKatu.Value, nupMiss.Value, nupScore.Value, nupCombo.Value, ckboxFullCombo.Checked, ranking, (int) playMods, true, (int) playMode, 
            time.ToUniversalTime(), "20140114"
            });
        }

        private string secondScore()
        {
            return helper.hash(string.Format("poop{0}o15{1}{2}s{3}{4}uu{5}{6}{7}{8}{9}{10}{11}" + 'Q' + "{12}{13}{15}{14:yyMMddHHmmss}{16}", new object[] { 
            nup100.Value + nup300.Value, nup50.Value, nupGeki.Value, nupKatu.Value, nupMiss.Value, helper.hashFile(txtMapPath.Text), nupCombo.Value, ckboxFullCombo.Checked, txtUsername.Text, nupScore.Value, ranking, (int) playMods, true, (int) playMode, time.ToUniversalTime(), "20140114", 
            helper.clientid()
            }));
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
                playMods |= Mods.Relax2;
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

        private OpenFileDialog openFileDialog;

        private void btnBrowseMap_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtMapPath.Text = openFileDialog.FileName;
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
                    playMode = PlayModes.OsuMania
                    break;
            }
        }
    }
}
