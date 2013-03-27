﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirStructureCopy
{
    class CopyProgressChangedEventArgs : EventArgs
    {
        public string CurrentDirectory
        {
            get;
            private set;
        }

        public CopyProgressChangedEventArgs(string currentDirectory)
        {
            this.CurrentDirectory = currentDirectory;
        }
    }

    class CopyStoppedEventArgs : EventArgs
    {
        public StructureCopier.ResultType Result
        {
            get;
            private set;
        }

        public CopyStoppedEventArgs(StructureCopier.ResultType result)
        {
            this.Result = result;
        }
    }
}
