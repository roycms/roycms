using System;
using System.Collections.Generic;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;

namespace ROYcms.Common
{
    public class ZIP
    {/// <summary>压缩文件</summary>
        /// <param name="filename">filename生成的文件的名称，如：C\123\123.zip</param>
        /// <param name="directory">directory要压缩的文件夹路径</param>
        /// <returns></returns>
        public static bool PackFiles(string filename, string directory)
        {
            try
            {

                directory = directory.Replace("/", "\\");

                if (!directory.EndsWith("\\"))
                    directory += "\\";
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                //FileStream ins = File.OpenRead("1.jpg");
                //FileStream outs = File.Create("test.zip");

                //ICSharpCode.SharpZipLib.Zip.ZipFile pp = new ZipFile(outs);

                //FastZip fz = new FastZip();
                //fz.CreateEmptyDirectories = true;
                //fz.CreateZip(filename, directory, true, "");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        /// <summary>解压文件</summary>
        /// <param name="file">压缩文件的名称，如：C:\123\123.zip</param>
        /// <param name="dir">dir要解压的文件夹路径</param>
        /// <returns></returns>
        public static bool UnpackFiles(string file, string dir)
        {
            //try
            //{
                if (!File.Exists(file))
                    return false;

                dir = dir.Replace("/", "\\");
                if (!dir.EndsWith("\\"))
                    dir += "\\";

                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                ZipInputStream s = new ZipInputStream(File.OpenRead(file));
                ZipEntry theEntry;
                while ((theEntry = s.GetNextEntry()) != null)
                {

                    string directoryName = Path.GetDirectoryName(theEntry.Name);
                    string fileName = Path.GetFileName(theEntry.Name);

                    if (directoryName != String.Empty)
                        Directory.CreateDirectory(dir + directoryName);

                    if (fileName != String.Empty)
                    {
                        FileStream streamWriter = File.Create(dir + theEntry.Name);

                        int size = 2048;
                        byte[] data = new byte[2048];
                        while (true)
                        {
                            size = s.Read(data, 0, data.Length);
                            if (size > 0)
                            {
                                streamWriter.Write(data, 0, size);
                            }
                            else
                            {
                                break;
                            }
                        }

                        streamWriter.Close();
                    }
                }
                s.Close();
                return true;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
        }

    }
}
