using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace RECO.Forms
{
    public partial class Repositories : Form
    {
        private Panel Panel;
        private Button DeleteButton;
        private Button EditButton;
        private Label NothingIn;
        public Repositories()
        {
            InitializeComponent();
            viewRepos(); // Method to show all repos and its actions
        }


        private void NoRepoLabel(object senderLbl)
        {
            NothingIn = (Label)senderLbl;
            NothingIn.FlatStyle = FlatStyle.Flat;
            //NothingIn.BackColor = Color.FromArgb(237, 168, 116);
            NothingIn.Text = "There Is Nothing To Show ";
            NothingIn.Font = new Font("arial", 12);
            NothingIn.Width = 350;
            NothingIn.ForeColor = Color.FromArgb(175, 240, 210);
            NothingIn.TextAlign = ContentAlignment.MiddleCenter;
            // NothingIn.Location = new Point(200,100);
            NothingIn.Size = new Size(300, 250);
            NothingIn.Dock = DockStyle.Bottom;
            NothingIn.Margin = new Padding(245, 30, 0, 0);
        }

        private void buttonDelete(object senderBtn)
        {
            DeleteButton = (Button)senderBtn;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.BackColor = Color.FromArgb(237, 168, 116);
            DeleteButton.ForeColor = Color.Red;
            DeleteButton.Text = "Delete";
            DeleteButton.Font = new Font("arial", 8);
            DeleteButton.TextAlign = ContentAlignment.MiddleCenter;
            DeleteButton.Location = new Point(70, 45);
            DeleteButton.Dock = DockStyle.Bottom;
        }


        private void buttonEdit(object senderBtn)
        {
            EditButton = (Button)senderBtn;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.BackColor = Color.FromArgb(237, 168, 116);
            EditButton.ForeColor = Color.Red;
            EditButton.Text = "Edit";
            EditButton.Font = new Font("arial", 8);
            EditButton.TextAlign = ContentAlignment.MiddleCenter;
            EditButton.Location = new Point(70, 45);
            EditButton.Dock = DockStyle.Bottom;
        }



        private void PanelView(object senderPnl, Label label)
        {
            Panel = (Panel)senderPnl;
            Panel.BackColor = Color.FromArgb(169, 83, 118);
            Panel.ForeColor = Color.White;
            Panel.Margin = new Padding(20);
            Panel.BorderStyle = BorderStyle.FixedSingle;
            Panel.Location = new Point(56, 90);
            Panel.Size = new Size(180, 100);
            label.BorderStyle = BorderStyle.None;
            label.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            label.ForeColor = Color.White;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Margin = new Padding(10);
            label.Location = new Point(30, 10);
            label.Dock = DockStyle.Top;
        }


        Label addReposmsg = new Label(); //this label handle empty "All repos folder"


        public void newOpenChildForm(Form childForm)
        {
            formMain formMain = new formMain();
            // open only form
            /* if (currentChildForm != null)
             {
                 currentChildForm.Close();
             }
             currentChildForm = childForm;*/
            // End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // panelDesktop.Controls.Add(childForm);
            //panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            // lblTitleChildForm.Text = childForm.Text;
        }
        public string CheckName(string content,string path)
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
        
            public void viewRepos()
        {
            /* ALGORITHM 
             
            1) get all dirs in the path
            2) Check if the path is not empty
            3) Show all folders As "labels", and each label is under "flow layout panel", each panel has 2 buttons , remove button and rename button

            */
            // Make a reference to a directory
            string path = @"D:\AllRepos\"; //path
            string[] dirs = System.IO.Directory.GetDirectories(path); // add all dirs in an array to check if it empty or not
            DirectoryInfo di = new DirectoryInfo(@"D:\AllRepos\"); // get all info

            // Get a reference to each directory in that directory
            DirectoryInfo[] dirArr = di.GetDirectories();
            int i = 0;
            // Display the names of the directories.

            if (!(dirs.Length == 0))
            {

                foreach (DirectoryInfo dri in dirArr)
                {
                   string allDirpath = @"D:\AllRepos\" + dri.Name ;
                    Button button_x = new Button(); // remove button
                    Label repoNamelable = new Label(); // """label that holds the repo name
                    Panel panel = new Panel(); // the panel holds dir name button && remove button && rename button
                    PanelView(panel, repoNamelable);
                    Button repoRename = new Button(); // the I button , next to remove button
                    panel.Tag = i;
                    panel.Text = dri.Name;
                    buttonDelete(button_x);
                    buttonEdit(repoRename);
                    repoNamelable.Text = dri.Name;
                    panel.Controls.Add(repoNamelable);

                    button_x.Click += delegate // delete button action
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

                            panel.Controls.Clear();
                            panel.Dispose();
                            done.Show();


                        };

                    };
                    
                    //panel.Click += delegate
                    //{
                    //    MessageBox.Show(dri.FullName);
                    //    //KeyWords keyWords = new KeyWords();
                    //    //keyWords.ShowDialog();
                    //};


                    repoRename.Click += delegate //rename button
                    {
                        EditDialogeMessage edit = new EditDialogeMessage();
                        edit.Show();
                        int parsedValue;
                        string content;
                        var defualt = repoNamelable.Text;
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

                            else if (content == repoNamelable.Text)
                            {

                                Done done = new Done();
                                done.Show();
                            }

                            else if (content == CheckName(content,path))
                            {
                                MessageBox.Show("Repo name is already exists", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else
                            {



                                Directory.Move(dri.FullName, Path.Combine(dri.Name, path + content));
                                allDirpath = path + content;
                                Done done = new Done();
                                done.Show();
                                repoNamelable.Text = content;
                                MessageBox.Show(allDirpath);
                                edit.Dispose();
                                done.Dispose();
                            }

                        };



                    };
                    repoNamelable.Click += delegate
                    {

                        KeyWords keyWords = new KeyWords(allDirpath);

                        this.Dispose();
                        keyWords.Show();

                    };

                    buttonDelete(button_x);
                    buttonEdit(repoRename);
                    panel.Controls.Add(button_x);
                    panel.Controls.Add(repoNamelable);
                    panel.Controls.Add(repoRename);
                    flowLayoutPanel1.Controls.Add(panel); // add the panel itself to the flow panel
                    i++;

                    



    }//end foreach



            }//end if
            else
            {

                NoRepoLabel(addReposmsg);
                flowLayoutPanel1.Controls.Add(addReposmsg);


            }//end else
        }//end viewropos msg


        private void Repositories_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            addReposmsg.Dispose(); // if user v
            string path = @"D:\AllRepos\"; //path
            int directoryCount = System.IO.Directory.GetDirectories(@"D:\AllRepos\").Length;
            int Number = directoryCount + 1;
            var createdName = "New Repo " + Number;
            string dir = @"D:\AllRepos\ " + createdName;
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {

                Directory.CreateDirectory(dir);
                DirectoryInfo d = new DirectoryInfo(dir);
                Button button_x = new Button();
                Panel panel = new Panel();
                Label repoName = new Label();
                PanelView(panel, repoName);
                Button repoRename = new Button();
                buttonDelete(button_x);
                buttonEdit(repoRename);
                repoName.Text = createdName;
                panel.Controls.Add(repoName);
                panel.Controls.Add(repoRename);
                panel.Controls.Add(button_x);
                repoRename.Click += delegate //rename button
                {
                    EditDialogeMessage edit = new EditDialogeMessage();
                    edit.Show();
                    int parsedValue;
                    string content;
                    var defualt = repoName.Text;
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

                        else if (content == repoName.Text)
                        {

                            Done done = new Done();
                            done.Show();
                        }

                        else if (content == CheckName(content,path))
                        {
                            MessageBox.Show("Repo name is already exists", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {



                            Directory.Move(d.FullName, Path.Combine(d.Name, path + content));
                            Done done = new Done();
                            done.Show();
                        }
                    };//end delegete 
                };

                button_x.Click += delegate // delete button action
                {
                    DeleteDialogeMessage delete = new DeleteDialogeMessage();
                    delete.Show();
                    Done done = new Done();
                    delete.Yes.Click += delegate
                    {
                        if (Directory.Exists(dir))
                        {
                            Directory.Delete(dir);
                        }

                        delete.Dispose();

                        panel.Controls.Clear();
                        panel.Dispose();
                        done.Show();
                    };

                };//end deleget 

                //repoName.Click += delegate
                //{
                //    KeyWords keyWords = new KeyWords();
                //    this.Dispose();
                //    keyWords.Show();
                //};


                //panel.Click += delegate
                //{
                //    KeyWords keyWords = new KeyWords();
                //    keyWords.ShowDialog();
                //};

                flowLayoutPanel1.Controls.Add(panel); // add the panel to the layout panel " The smallest panel => panel, the big one => flow layout panel

            }
        }
       
    }
}
