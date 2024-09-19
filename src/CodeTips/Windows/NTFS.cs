using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTips.Windows
{
    internal class NTFS
    {
        internal bool IsNTFS(string path)
        {
            var rootPath = Path.GetPathRoot(path)!;

            var driveInfo = new DriveInfo(rootPath);

            return driveInfo.DriveFormat.Equals("ntfs", StringComparison.OrdinalIgnoreCase);
        }
    }
}
