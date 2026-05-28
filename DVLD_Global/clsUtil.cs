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
       private static string file = @"..\..\..\data.txt";
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

        private static string _DataRow(string UserName,string Password,string Seperator="#//#") {
            List<string> data = new List<string>();
            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
                return string.Empty;
            data.Add(UserName);
            data.Add(Password);
           
               return string.Join(Seperator, data);
           
           
        
        }
        public static void RememberMe(string username,string password) {

           
            
            string LoginInfoDataRow = _DataRow(username, password);
            if (string.IsNullOrWhiteSpace(LoginInfoDataRow))
                return;
            File.WriteAllText(file, LoginInfoDataRow);
          

        }
        public static void ClearRememberMe()
        {
            DeleteIfExists(file);
        }

        public static bool rememberMeWithInfo(ref string username, ref string password, string Seperator = "#//#") {

            if (!File.Exists(file))
                return false;


            string[] RowsContent = File.ReadAllLines(file);

            if (RowsContent.Length <= 0)
                return false;

            if (string.IsNullOrWhiteSpace(RowsContent[0]))
                return false;


            string[] parts = RowsContent[0].Split(new string[] { Seperator }, StringSplitOptions.None);

            if (string.IsNullOrWhiteSpace(parts[0]) || string.IsNullOrWhiteSpace(parts[1]))
                return false;

                if (parts.Length >= 2)
                {
                    username = parts[0];
                    password = parts[1];

            return true;
                }

            return false;
        }
    }
}
