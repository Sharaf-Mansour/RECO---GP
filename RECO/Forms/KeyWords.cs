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
using RECO.Forms;
namespace RECO.Forms
{
    public partial class KeyWords : Form
    {
        public KeyWords(string dirPath)
        {
            InitializeComponent();
            viewKeyWords(dirPath);
            
            
        }
        public string CheckName(string content, string path)
        {
            string compare = "default";
            DirectoryInfo di = new DirectoryInfo(path); // get all info
            // Get a reference to each directory in that directory
            DirectoryInfo[] dirArr = di.GetDirectories();
            foreach (DirectoryInfo dri in dirArr)
            {
                if (dri.Name == content)
                {
                    compare = content;

                }

            }
            return compare;
        }
        public void viewKeyWords(string dirPath)
        {

            int directoryCount = System.IO.Directory.GetDirectories(dirPath).Length;
            int Number = directoryCount;
            int firstRepo = Number + 1;
            string createdName = @"\New Repo " + firstRepo;
            string dir = dirPath + createdName;
            string[] dirs = System.IO.Directory.GetDirectories(dirPath); // add all dirs in an array to check if it empty or not
            DirectoryInfo di = new DirectoryInfo(dirPath); // get all info
                                                           // Get a reference to each directory in that directory
            DirectoryInfo[] dirArr = di.GetDirectories();
            int i = 0;
            if (!(dirs.Length == 0))
            {
                foreach (DirectoryInfo dri in dirArr)

                {
                    string allDirpath = dirPath +@"\" + dri.Name;
                    Button KeyWord = new Button();
                    Button Delete = new Button();
                    Button Rename = new Button();
                    Panel panel2 = new Panel();
                    //  panel1.Controls.Add(KeyWord);

                    /** Button KeyWord style :
                     * 
                     * 
                     * 
                     * */

                    // 
                    // panel2
                    // 
                     
                     
                     
                    
                     //panel2.Location = new Point(10, 10);
                     panel2.Name = "panel2";
                     panel2.Size = new System.Drawing.Size(400, 150);
                   //  panel2.TabIndex = i;
                    panel2.Tag = i;
                   panel2.TabIndex = i;
                    
                   // panel1.TabIndex = i;
                    // 
                    // KeyWord
                    // 
                   // KeyWord.Location = new System.Drawing.Point(11, 10);
                   //  KeyWord.Name = "KeyWord";
                   //  KeyWord.Size = new System.Drawing.Size(255, 66);
                   // // KeyWord.TabIndex = i;
                   //  KeyWord.Text = "KeyWord";
                   ////  KeyWord.Dock = DockStyle.Top;
                   //  KeyWord.UseVisualStyleBackColor = true;
                   // KeyWord.Dock = DockStyle.Top;

                   // // 
                   // // Delete
                   // // 
                   // Delete.Location = new System.Drawing.Point(272, 26);
                   //  Delete.Name = "Delete";
                   //  Delete.Size = new System.Drawing.Size(54, 35);
                   //  Delete.TabIndex = i;
                   //  Delete.Text = "Delete";
                   //  Delete.UseVisualStyleBackColor = true;
                    
                   //  Delete.Dock = DockStyle.Top;
                   // // 
                   // // Rename
                   // // 
                   // Rename.Location = new System.Drawing.Point(332, 26);
                   //  Rename.Name = "Rename";
                   //  Rename.Size = new System.Drawing.Size(57, 35);
                   //  Rename.TabIndex = i;
                   //  Rename.Text = "Rename";
                   //  Rename.UseVisualStyleBackColor = true;
                   // Rename.Dock = DockStyle.Top;
                    // Rename.Dock = DockStyle.Top;
                    //panel2.Controls.Add(KeyWord);
                    //panel2.Controls.Add(Rename);
                    //panel2.Controls.Add(Delete);
                    


                    KeyWord.Location = new System.Drawing.Point(0, 0);
                    KeyWord.Size = new System.Drawing.Size(50, 36);
                    KeyWord.UseVisualStyleBackColor = true;
                    KeyWord.Tag = i;
                    KeyWord.Dock = DockStyle.Top;
                    KeyWord.Text = dri.Name;
                    panel2.Controls.Add(KeyWord);
                    KeyWord.Margin = new Padding(20);


                    Delete.Location = new Point(306, 20);
                    Delete.Name = "Delete";
                    Delete.Size = new System.Drawing.Size(35, 32);
                    Delete.TabIndex = i;
                    Delete.Text = "X";
                    Delete.UseVisualStyleBackColor = true;
                    Delete.Dock = DockStyle.Top;
                    panel2.Controls.Add(Delete);

                    Rename.Location = new Point(306, 20);
                    Rename.Name = "Rename";
                    Rename.Size = new System.Drawing.Size(35, 32);
                    Rename.TabIndex = i;
                    Rename.Text = "I";
                    Rename.UseVisualStyleBackColor = true;
                    Rename.Dock = DockStyle.Top;
                    panel2.Controls.Add(Rename);
                    panel1.Controls.Add(panel2);
                    i++;
                    Delete.Click += delegate
                    {
                        DeleteDialogeMessage delete = new DeleteDialogeMessage();
                        Done done = new Done();

                        delete.Show();
                        delete.Yes.Click += delegate
                        {
                            
                            if (Directory.Exists(allDirpath))
                            {
                                Directory.Delete(allDirpath);
                            }

                            delete.Dispose();
                            panel2.Controls.Clear();

                            done.Show();
                        };
                        
                        
                    };

                    Rename.Click += delegate
                    {
                        MessageBox.Show("s");
                        EditDialogeMessage edit = new EditDialogeMessage();
                        edit.Show();
                        int parsedValue;
                        string content;
                        //var defualt = repoNamelable.Text;
                        edit.EditBtn.Click += delegate
                        {

                            content = edit.RenameRepoTxtBox.Text;


                            if (String.IsNullOrEmpty(content) || String.IsNullOrWhiteSpace(content)) // if the input is null, handle it
                            {
                                MessageBox.Show("Please, Enter a valid repo name", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if (int.TryParse(content, out parsedValue)) // if it number, handle it
                            {
                                Convert.ToInt64(content);
                                MessageBox.Show("Repo name Cannot be number", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                            else if (content == KeyWord.Text)
                            {

                                Done done = new Done();
                                done.Show();
                            }

                            else if (content == CheckName(content, dirPath))
                            {
                                MessageBox.Show("Repo name is already exists", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else
                            {


                               
                                Directory.Move(dri.FullName, Path.Combine(dri.Name, dirPath + @"\" + content));
                                Done done = new Done();
                                edit.Dispose();
                                done.Show();
                            }
                        };


                    };
                    

                }
            }
            else
            {
                Directory.CreateDirectory(dir);
                viewKeyWords(dirPath);
            }

            Add.Click += delegate
            {
                Directory.CreateDirectory(dir);
                viewKeyWords(dirPath);
            };


        }

        
    }
}
