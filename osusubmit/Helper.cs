using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Management;

namespace osusubmit
{
    class Helper
    {
        public string osuPath = string.Empty;

        public string getClientID(EastEnd form)
        {
            string hashedClient = hashFile(osuPath);
            string s = string.Empty;
            foreach (NetworkInterface interface2 in NetworkInterface.GetAllNetworkInterfaces())
            {
                s = s + interface2.GetPhysicalAddress().ToString().Replace('E', 'F').Replace('4', 'E') + ".";
            }
            string str5 = this.hash(s);
            string str6 = this.hash(this.getGUID());
            string str7 = this.hash(this.getDiskSig(form) + "A");
            return (hashedClient + ":" + s + ":" + str5 + ":" + str6 + ":" + str7);
        }

        public string getGUID()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\osu!", true);
            if (registryKey == null)
            {
                registryKey = Registry.CurrentUser.CreateSubKey("Software\\osu!");
            }
            string id = (string) registryKey.GetValue("UninstallID");
            if (id == null)
            {
                Guid guid = Guid.NewGuid();
                id = guid.ToString();
                registryKey.SetValue("UninstallID", guid);
            }
            if (registryKey != null)
            {
                registryKey.Close();
            }
            return this.hash(id);
        }

        public string hashFile(string file)
        {
            lock (md5)
            {
                if (File.Exists(file))
                {
                    try
                    {
                        using (Stream stream = File.Open(file, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            byte[] buffer = md5.ComputeHash(stream);
                            StringBuilder sb = new StringBuilder();
                            for (int i = 0; i < buffer.Length; i++)
                            {
                                sb.Append(buffer[i].ToString("x2"));
                            }
                            return sb.ToString();
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                return string.Empty;
            }
        }

        public string getDiskSig(EastEnd form)
        {
            ManagementClass management = new ManagementClass("Win32_DiskDrive");
            using (ManagementObjectCollection.ManagementObjectEnumerator iterator = management.GetInstances().GetEnumerator())
            {
                while (iterator.MoveNext())
                {
                    ManagementObject managementObject = (ManagementObject) iterator.Current;
                    try
                    {
                        string diskSig = form.ckboxFakeDisksig.Checked ? 
                                         hash("SUDIUKASD" + managementObject["Signature"].ToString() + "GARBAGE") : hash(managementObject["Signature"].ToString());
                        return diskSig;
                    }
                    catch
                    {
                        //we just let this pass
                    }
                }
            }
            return string.Empty;
        }

        public DateTime time;

        public string getScore(EastEnd form)
        {
            return string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}:{8}:{9}:{10}:{11}:{12}:{13}:{14}:{15}:{16:yyMMddHHmmss}:{17}", new object[] { 
            hashFile(form.txtMapPath.Text), form.txtUsername.Text, secondScore(form), form.nup300.Value, form.nup100.Value, form.nup50.Value, form.nupGeki.Value, form.nupKatu.Value, form.nupMiss.Value, form.nupScore.Value, form.nupCombo.Value, form.ckboxFullCombo.Checked, form.ranking, (int) form.playMods, true, (int) form.playMode, 
            time.ToUniversalTime(), "20140114"
            });
        }

        public string secondScore(EastEnd form)
        {
            return hash(string.Format("poop{0}o15{1}{2}s{3}{4}uu{5}{6}{7}{8}{9}{10}{11}" + 'Q' + "{12}{13}{15}{14:yyMMddHHmmss}{16}", new object[] { 
            form.nup100.Value + form.nup300.Value, form.nup50.Value, form.nupGeki.Value, form.nupKatu.Value, form.nupMiss.Value, hashFile(form.txtMapPath.Text), form.nupCombo.Value, form.ckboxFullCombo.Checked, form.txtUsername.Text, form.nupScore.Value, form.ranking, (int) form.playMods, true, (int) form.playMode, time.ToUniversalTime(), "20140114", 
            getClientID(form)
            }));
        }

        public byte[] post(string endpoint, NameValueCollection data)
        {
            using (WebClient webClient = new WebClient())
            {
                return webClient.UploadValues(endpoint, data);
            }
        }

        public string getProcesses()
        {
            StringBuilder sb = new StringBuilder();
            Process[] processList = Process.GetProcesses();

            foreach(Process process in processList){
                if (process.ProcessName.Equals("WDExpress") || process.ProcessName.Contains("osusubmit"))
                    continue; //we don't want peppy to see!
                sb.AppendLine(" | " + process.ProcessName + "()"); 
            }
            return sb.ToString();
        }

        public string fs()
        {
            return string.Format("{0}:{1}:{2}:{3}:{4}", new object[]
            {
                100,
                false,
                false,
                false,
                true
            });
        }

        private MD5 md5 = MD5.Create();
        public string hash(string s)
        {
            byte[] array = new UTF8Encoding().GetBytes(s);
            NumberFormatInfo numberFormat = new CultureInfo("en-US", false).NumberFormat;
            Monitor.Enter(md5);
            string result;
            try
            {
                array = md5.ComputeHash(array);
            }
            catch (Exception)
            {
                return "fail";
            }
            finally
            {
                Monitor.Exit(md5);
            }
            char[] contents = new char[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                array[i].ToString("x2", numberFormat).CopyTo(0, contents, i * 2, 2);
            }
            result = new string(contents);
            return result;
        }


        public string encrypt(string text, ref string pass)
        {
            byte[] bytes = Encoding.UTF8.GetBytes("h89f2-890h2h89b34g-h80g134n90133");
            string result = null;
            using (RijndaelManaged cipher = new RijndaelManaged())
            {
                cipher.Key = bytes;
                cipher.BlockSize = 0x100;
                cipher.Mode = CipherMode.CBC;
                if (pass != null)
                {
                    cipher.IV = Convert.FromBase64String(pass);
                }
                else
                {
                    cipher.GenerateIV();
                    pass = Convert.ToBase64String(cipher.IV);
                }
                try
                {
                    MemoryStream stream = new MemoryStream();
                    using (CryptoStream stream2 = new CryptoStream(stream, cipher.CreateEncryptor(bytes, cipher.IV), CryptoStreamMode.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(stream2))
                        {
                            writer.Write(text);
                            writer.Close();
                        }
                        stream2.Close();
                    }
                    result = Convert.ToBase64String(stream.ToArray());
                    stream.Close();
                }
                finally
                {
                    cipher.Clear();
                }
            }
            return result;
        }

    }
}
