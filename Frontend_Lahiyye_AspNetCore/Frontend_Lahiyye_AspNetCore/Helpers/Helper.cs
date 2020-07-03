using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Lahiyye_AspNetCore.Helpers
{
    public static class Helper
    {
        public static void DeleteImage(string root, string folder, string image )
        {
            string path = Path.Combine(root, folder, image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            
        }
        public enum UserRols
        { 
            Admin,
            Member
        }

    }
}
