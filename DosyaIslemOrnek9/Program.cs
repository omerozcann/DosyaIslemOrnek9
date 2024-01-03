using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaIslemOrnek9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Belirtilen klasördeki tüm dosyaları sil
            
            //String[] liste = Directory.GetFiles("c:\\users\\omer\\desktop\\deneme");
            String masaustu= Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            String[] liste = Directory.GetFiles(masaustu + "\\deneme");
            //belirtilen dizideki dosyaların listesini ver
            for (int i = 0; i < liste.Length; i++)
            {
                File.Delete(liste[i]);
            }
        }
    }
}
