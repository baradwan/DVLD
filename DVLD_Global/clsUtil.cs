using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Global
{
    public class clsUtil
    {
        public static string GenerateGUID() { 
        
            return Guid.NewGuid().ToString();
        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath) {

            try
            {
                if (!Directory.Exists(FolderPath))
                {
                    Directory.CreateDirectory(FolderPath);
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }


        }
          
        public static string ReplaceFileNameWithGUID(string FilePath)
        {
            if (string.IsNullOrEmpty(FilePath)) return string.Empty;
            return $"{Guid.NewGuid().ToString()}{Path.GetExtension(FilePath)}";
            
        }


        public static bool CopyImageToProjectFolderPathHandler(ref string SourceFilePath, string destinationFile)
        {
     

            if (!CreateFolderIfDoesNotExist(destinationFile))
                return false;
           // string DestinationFilePath = destinationFile+ ReplaceFileNameWithGUID(SourceFilePath);

            string DestinationFilePath = Path.Combine(destinationFile, ReplaceFileNameWithGUID(SourceFilePath));
            try
            {
              
                File.Copy(SourceFilePath, DestinationFilePath,true);
             
               
            }
            catch (IOException ioEx)
            {
                // خطأ يتعلق بالملف (مثل أنه مفتوح في برنامج آخر)
                Debug.WriteLine("IO Error: " + ioEx.Message);
                return false;
            }

            SourceFilePath = DestinationFilePath;
            return true;
        }

        public static bool  DeleteIfExists(string path)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(path))
                    return false;

                if(File.Exists(path))
                    File.Delete(path);
                //if (!string.IsNullOrWhiteSpace(path) && File.Exists(path))
                //{
                //    File.Delete(path);
                //    return true;
                //}
                //return true;
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
