﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Debugging_Part8
{
    public class FileHelper
    {
        public bool IsValidFile(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Exists && fileInfo.Length < 1024 * 1024; // 1 MB
        }
    }
}
