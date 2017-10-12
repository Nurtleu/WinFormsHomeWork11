using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsHW11
{
    public partial class Explorer : Form
    {
        DriveInfo driveInfo;
        TreeNode treeNodeDrives;
        public Explorer()
        {
            InitializeComponent();
            
        }
        public string path;
        private void TreeDrive(TreeNode driveNodes)
        {
            foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
            {
                treeViewExplorerFile.Nodes.Add(treeNodeDrives);
                treeNodeDrives = new TreeNode()
                {
                    Text = driveInfo.Name
                };
            }
            string[] directorios = Directory.GetDirectories(path);
            foreach (string directory in directorios)
            {
                treeNodeDrives = new TreeNode();
                TreeNode treeNodeDrive = new TreeNode();
                //TreeDrive(treeNodeDrives, driveInfo.Name);
                treeNodeDrive.Text = directory.Remove(0, directory.LastIndexOf("\\") + 1);
                driveNodes.Nodes.Add(treeNodeDrive);
            }
        }

        private void TreeViewExplorerFile_MouseClick(object sender, MouseEventArgs e)
        {
            treeNodeDrives = new TreeNode();
            listViewExplorer.Show();
        }
    }
}
