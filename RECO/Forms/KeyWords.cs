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
            viewKeywords(dirPath);
        }

        public void viewKeywords(string dirPath)
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
            if(!(dirs.Length == 0))
            {
                foreach (DirectoryInfo dri in dirArr)

                {
                    
                    Button keyWord = new Button();
                    //  panel1.Controls.Add(keyWord);

                    /** Button keyword style :
                     * 
                     * 
                     * 
                     * */

                    keyWord.Location = new System.Drawing.Point(10, 9);
                    keyWord.Size = new System.Drawing.Size(237, 36);
                    keyWord.UseVisualStyleBackColor = true;
                    keyWord.Tag = i;
                    keyWord.Dock = DockStyle.Top;
                    keyWord.Text = dri.Name;
                    panel1.Controls.Add(keyWord);
                    keyWord.Margin = new Padding(20);
                    i++;

                }
            }
            else
            {
                Directory.CreateDirectory(dir);
                viewKeywords(dirPath);
            }
        

            // 
            // addButton
            // 
           
           





        }

        public void addKeywords()
        {
            // 
            // addButton
            // 
            Button addButton = new Button();
            addButton.Location = new System.Drawing.Point(254, 9);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(47, 36);
            addButton.TabIndex = 1;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;

            panel1.Controls.Add(addButton);
        }

      
    }
}
