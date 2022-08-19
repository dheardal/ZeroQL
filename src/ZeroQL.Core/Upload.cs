﻿using System.IO;

namespace ZeroQL.Core;

public class Upload
{
    public Upload(string fileName, Stream stream)
    {
        FileName = fileName;
        Stream = stream;
    }

    public string FileName { get; set; }
    public Stream Stream { get; set; }
}