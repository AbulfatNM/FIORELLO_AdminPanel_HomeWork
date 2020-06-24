using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Lahiyye_AspNetCore.Extensions
{
    public static class Extensions
    {
        public static bool IsValidImg(this IFormFile file)
        {
            return file.ContentType.Contains("images/");

        }
        public static bool MaxLenght(this IFormFile file,int kb)
        {
            return file.Length / 1020 >= kb;
        }
        public   static async Task <string> CopyImage(this IFormFile file,string root,string folder)
        {
            string path = Path.Combine(root, folder);
            string sliderName = Guid.NewGuid() + file.FileName;
            string resultPath = Path.Combine(path, sliderName);
            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return sliderName;
        }
    }
}
