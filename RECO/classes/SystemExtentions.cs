using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IO
{
    public static class DirectoryInfoExtensions
    {
        public static void Rename(this DirectoryInfo directoryInfo, string newName)
        {
            directoryInfo.MoveTo(Path.Combine(directoryInfo.FullName, newName));
        }
    }
}

//namespace System.Windows.Forms
//{
//    public partial class Control
//    {
//         internal  virtual partial  void Clear()
//        {

//        }

         

//    }
//}