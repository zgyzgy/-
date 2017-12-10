using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVM.SnailTools.lib;
using z.CMD;
using z.Extensions;
using z.Extensiont;

namespace 小怪物文件搬运
{
    public partial class 文件搬运 : Form
    {
        public 文件搬运()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tb_s.Text = dialog.SelectedPath;
            }
        }

        private void btn_t_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tb_t.Text = dialog.SelectedPath;
            }
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    setEnable(false);
                    _setlog("源文件夹:" + tb_s.Text);
                    _setlog("目标文件夹:" + tb_t.Text);
                    var allfile = IOExtension.GetAllFiles(tb_s.Text);
                    if (allfile == null || allfile.Count == 0)
                    {
                        _setlog("源文件夹为空....,请重新选择");
                        setEnable(true);
                        return;
                    }
                    var allfilet = IOExtension.GetAllFiles(tb_t.Text);
                    if (allfilet != null && allfilet.Count != 0)
                    {
                        _setlog("目标文件夹必须为空....,请重新选择");
                        setEnable(true);
                        return;
                    }
                    _setlog($"获取到文件{allfile.Count}个,共计大小{ IOExtension.CountSize(allfile.Sum(a => a.Length)) }");
                    _setlog("清除目标路径");
                    IOExtension.DeleteFile(tb_t.Text);
                    _setlog("开始复制文件");
                    int i = copy(tb_s.Text.Trim(), tb_t.Text.Trim());
                    if (i != 0)
                    {
                        if (i == 1223)
                        {
                            IOExtension.DeleteFile(tb_t.Text);
                            _setlog("用户取消,删除目标文件夹文件");
                        }
                        else
                        {
                            _setlog(ShellFileOperation.GetErrorString(i));
                        }
                        setEnable(true);
                        return;
                    }
                    _setlog("复制完成,删除原始文件");
                    IOExtension.DeleteFile(tb_s.Text);
                    _setlog("开始设置目录");
                    RunCmd cmd = new RunCmd();
                    cmd.Output += (str) =>
                    {
                        if (str == "c:\\>")
                        {
                            _setlog($"完成,请通过\"{tb_s.Text}\"检查文件是否存在");
                            setEnable(true);
                        }
                    };
                    cmd.Run($"mklink /j \"{tb_s.Text}\" \"{tb_t.Text}\"");
                }
                catch (Exception ex)
                {
                    _setlog(ex.Message);
                    setEnable(true);
                }
            }).Start();
        }


        void setEnable(bool b)
        {
            btn_run.Enabled = b;
            btn_s.Enabled = b;
            btn_t.Enabled = b;
            tb_s.Enabled = b;
            tb_t.Enabled = b;
        }
        void _setlog(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                tb_log.AppendText(DateTime.Now.ToString("hh:mm:ss") + ":");
                tb_log.AppendText(str);
                tb_log.AppendText("\r\n");
                tb_log.SelectionStart = tb_log.Text.Length;
                tb_log.SelectionLength = 0;
                tb_log.ScrollToCaret();
            }
        }
        private void 文件搬运_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btn_run.Enabled)
            {
                e.Cancel = true;
                MessageBox.Show("运行中,不能关闭程序");
            }
        }

        int copy(string path_s, string path_t)
        {
            List<DirectoryInfo> dics = IOExtension.GetAllDirectorys(IOExtension.MakeDir(path_s));
            dics.ForEach((inx, dic) =>
            {
                IOExtension.MakeDir(true, dic.FullName.Replace(path_s, path_t));
            });
            _setlog($"创建完成{dics.Count}个文件夹");
            List<FileInfo> allfile = IOExtension.GetAllFiles(IOExtension.MakeDir(path_s));
            return ShellFileOperation.Copy(
                             allfile.Select(a => a.FullName),
                             allfile.Select(a => a.FullName.Replace(path_s, path_t))
                             );
        }
    }
}
