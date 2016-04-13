using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace FolderSync
{

    public partial class Form1 : Form
    {
        public struct Folder
        {
            public string name;
            public int parent;
            public float size;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void PrintStatus(string msg)
        {
            lblAnalyzing.Text += DateTime.Now.ToString("hh:mm:ss") + " > " + msg + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAnalyzing.Text = "";
            PrintStatus("Start analyzing...");
            PanelFolderSync.Visible = false;
            checkGreen1.Visible = false;
            checkGreen2.Visible = false;
            PanelMatchingFolders.Visible = false;
            btnNextStep.Visible = false;
            PanelWait.Visible = true;
            Refresh();
            PanelWait.Refresh();
            var listAdd = new List<ListView>();
            var lblTotal = new List<Label>();
            var dir = new List<string>();
            var folders = new List<List<Folder>>(); //target folders
            var missing = new List<string>(); //missing folders
            Folder folder;
            var f = 0;//incrm for list of target folders
            var i = 0;//incrm for list of folder paths found
            var m = 0;
            var s = 0;
            var total = 0;
            var countdown = 0;
            var missingCount = 0;
            var changedCount = 0;
            var matches = false;
            var findchanges = checkChangedFolders.Checked;
            var path = "";
            var matchpath = "";
            List<Folder> paths;
            DirectoryInfo dirInfo;
            DirectoryInfo[] dirList;
            ListViewItem lvItem;

            dir.Add(textBox1.Text);
            dir.Add(textBox2.Text);
            folders.Add(new List<Folder>());//sfolder paths
            folders.Add(new List<Folder>());//folder paths
            folders[0].Add(NewFolder(dir[0], -1));
            folders[1].Add(NewFolder(dir[1], -1));
            listAdd.Add(ListAdd1);
            listAdd.Add(ListAdd2);
            lblTotal.Add(lblTotal1);
            lblTotal.Add(lblTotal2);
            foreach(var list in listAdd)
            {
                list.Items.Clear();
            }

            //get list of folders & sub folders for both directories
            while (f < folders.Count)
            {
                //get a list of folders 
                lblCurrentTarget.Text = folders[f][0].name;
                i = 0;
                while(i < folders[f].Count)
                {
                    if(i == 0)
                    {
                        path = dir[f];
                    }
                    else
                    {
                        path = GetPath(folders[f], i);
                    }
                    if (!Directory.Exists(path))
                    {
                        MessageBox.Show("Directory '" + path + "' does not exist.");
                        return;
                    }
                    //add list of sub-folders
                    dirInfo = new DirectoryInfo(path);
                    try
                    {
                        dirList = dirInfo.GetDirectories();
                        foreach (DirectoryInfo info in dirList)
                        {
                            folder = new Folder();
                            folder.name = info.Name;
                            if (findchanges == true)
                            {
                                //only get folder size if checking filesize changes while matching
                                foreach (var file in info.EnumerateFiles())
                                {
                                    folder.size += file.Length / 1024;
                                }
                            }
                            folder.parent = i;
                            folders[f].Add(folder);
                        }
                        total += dirList.Length;
                        lblTotal[f].Text = (folders[f].Count - 1).ToString();
                        lblTargetFolders.Text = lblTotal[f].Text;
                        lblTotalFolders.Text = total.ToString();
                        PanelWait.Refresh();
                    }
                    catch (Exception ex) { }
                    i++;
                }
                PrintStatus(dir[f] + " contains " + lblTotal[f].Text + " sub-folders");
                PanelWait.Refresh();
                f++;
            }

            checkGreen1.Visible = true;
            PanelMatchingFolders.Visible = true;
            ProgressMatching.Visible = true;
            ProgressMatching.Maximum = total;
            ProgressMatching.Value = 0;
            lblMatchesLeft.Text = total.ToString();
            Refresh();

            //find missing folders
            f = 0;
            countdown = total;
            while (f < folders.Count)
            {
                //loop through each target folder
                missingCount = 0;
                changedCount = 0;
                for (i=1; i < folders[f].Count; i++)
                {
                    //loop through all subfolders in selected target folder
                    paths = FolderPath(folders[f], i);
                    for(var x = 0;x < folders.Count;x++)
                    {
                        //loop through target folders (except for selected folder)
                        if(x != f)
                        {
                            //match path with target folder
                            m = 0;
                            matches = true;
                            for(var y = 1; y < paths.Count; y++)
                            {
                                //go through folder paths to match with target
                                s = folders[x].FindIndex(c => c.parent == m && c.name == paths[y].name);
                                if(s > 0)
                                {
                                    m = s;
                                    //path matches so far
                                }
                                else
                                {
                                    //path part doesn't exist
                                    matches = false;
                                    break;
                                }
                            }
                            if(matches == false)
                            {
                                //folder doesn't exist
                                path = GetPath(folders[f], i);
                                if(missing.FindIndex(c => path.IndexOf(c)==0) < 0)
                                {
                                    lvItem = new ListViewItem();
                                    lvItem.Text = GetPath(folders[f], i);
                                    listAdd[x].Items.Add(lvItem);
                                    missing.Add(path);
                                    missingCount++;
                                }
                            }
                            else
                            {
                                //folder exists, now match filesize
                                if(findchanges == true && f == 0)
                                {
                                    if (folders[x][m].size != folders[f][i].size)
                                    {
                                        //find changed files
                                        path = GetPath(folders[f], i);
                                        matchpath = GetPath(folders[x], m);
                                        lvItem = new ListViewItem();
                                        lvItem.Text = path;
                                        ListChangedFiles.Items.Add(lvItem);
                                        changedCount++;
                                    }
                                }
                            }
                        }
                    }
                    //count down matches left
                    countdown--;
                    lblMatchesLeft.Text = countdown.ToString();
                    if (ProgressMatching.Value < ProgressMatching.Maximum)
                    {
                        ProgressMatching.Value += 1;
                    }
                    PanelWait.Refresh();
                }
                PrintStatus("Found " + missingCount.ToString() + " missing folder(s) " +
                    (findchanges == true && f == 0 ? "and " + changedCount.ToString() + " changed folder(s)" : "") + 
                    " within '" + dir[f] + "'.");
                f++;
            }
            checkGreen2.Visible = true;
            btnNextStep.Visible = true;
            PrintStatus("Done Analyzing Folders! Continue onto the next step...");
        }

        private string GetPath(List<Folder> folders, int i)
        {
            var paths = new List<string>();
            var e = int.Parse(i.ToString());
            while(e >= 0)
            {
                paths.Add(folders[e].name);
                e = folders[e].parent;
            }
            paths.Reverse();
            return (string.Join("\\", paths) + "\\").Replace("\\\\","\\");
        }

        private List<Folder> FolderPath(List<Folder> folders, int i)
        {
            var paths = new List<Folder>();
            var e = int.Parse(i.ToString());
            while (e >= 0)
            {
                paths.Add(folders[e]);
                e = folders[e].parent;
            }
            paths.Reverse();
            return paths;
        }
        
        private Folder NewFolder(string name, int parent)
        {
            var folder = new Folder();
            folder.name = name;
            folder.parent = parent;
            return folder;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProgressSync.Value = 0;
            PanelActions.Visible = false;
            PanelSync.Visible = true;
            Refresh();
            var listAdd = new List<ListView>();
            var listRemove = new List<ListView>();
            var dir = new List<string>();
            var copyFromDrive = "";
            var copyToDrive = "";
            var copyToFolder = "";
            var curr = 0;
            var total = 0;
            dir.Add(textBox1.Text);
            dir.Add(textBox2.Text);
            listAdd.Add(ListAdd1);
            listAdd.Add(ListAdd2);

            //first, get total amount of checked items
            for (var x = 0; x < listAdd.Count; x++)
            {
                foreach (ListViewItem item in listAdd[x].Items)
                {
                    if (item.Checked == true)
                    {
                        total++;
                    }
                }
            }
            ProgressSync.Maximum = total;

            //next, physically copy over missing folders
            for (var x = 0; x < listAdd.Count;x++)
            {
                copyToDrive = GetDriveLetter(dir[x]);
                foreach(ListViewItem item in listAdd[x].Items)
                {
                    if(item.Checked == true)
                    {
                        //copy folder over from one drive to the other
                        copyFromDrive = GetDriveLetter(item.Text);
                        lblSyncing.Text = "Copying " + item.Text + " to " + copyToDrive;
                        PanelSync.Refresh();
                        copyToFolder = item.Text;
                        for (var y = 0; y < dir.Count; y++)
                        {
                            //get copy to folder path
                            if(y != x)
                            {
                                if(copyToFolder.IndexOf(dir[y]) == 0)
                                {
                                    copyToFolder = copyToFolder.Replace(dir[y], dir[x]);
                                    break;
                                }
                            }
                        }
                        DirectoryCopy(item.Text, copyToFolder);
                        curr++;
                        ProgressSync.Value = curr;
                    }
                }
            }
            PanelSync.Visible = false;
            PanelActions.Visible = true;
        }

        private string GetDriveLetter(string path)
        {
            return path.Substring(0, 3);
        }

        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs = true)
        { // Get the subdirectories for the specified directory. 
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + sourceDirName);
            }
            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }
            // Get the files in the directory and copy them to the new location. 
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files) {
                string temppath = Path.Combine(destDirName, file.Name);
                lblSyncing.Text = "Copying file to '" + temppath;
                PanelSync.Refresh(); 
                file.CopyTo(temppath, true);
            }
                       // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs) {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            PanelWait.Visible = false;
            PanelFolderSync.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowser.SelectedPath = textBox1.Text;
            FolderBrowser.ShowDialog();
            textBox1.Text = FolderBrowser.SelectedPath;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowser.SelectedPath = textBox2.Text;
            FolderBrowser.ShowDialog();
            textBox2.Text = FolderBrowser.SelectedPath;
        }

        private void LinkSelectAll1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach(ListViewItem item in ListAdd1.Items)
            {
                if(item.Checked == true)
                {
                    foreach(ListViewItem itm in ListAdd1.CheckedItems)
                    {
                        itm.Checked = false;
                    }
                    return;
                }
            }
            foreach (ListViewItem item in ListAdd1.Items)
            {
                item.Checked = true;
            }
        }

        private void LinkSelectAll2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem item in ListAdd2.Items)
            {
                if (item.Checked == true)
                {
                    foreach (ListViewItem itm in ListAdd2.CheckedItems)
                    {
                        itm.Checked = false;
                    }
                    return;
                }
            }
            foreach (ListViewItem item in ListAdd2.Items)
            {
                item.Checked = true;
            }
        }

        private void LinkSelectAll3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem item in ListChangedFiles.Items)
            {
                if (item.Checked == true)
                {
                    foreach (ListViewItem itm in ListChangedFiles.CheckedItems)
                    {
                        itm.Checked = false;
                    }
                    return;
                }
            }
            foreach (ListViewItem item in ListChangedFiles.Items)
            {
                item.Checked = true;
            }
        }
    }
}
