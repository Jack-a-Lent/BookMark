using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookmark
{
    class Variables
    {
        public String strIniFilePath;
        public Int32 i32NumOfBookmark;
        public Int32 i32NumOfFolders;
        

        public void VariablesInitSub()
        {

            i32NumOfBookmark = 0;
            i32NumOfFolders = 0;
          
            
        }
    }

    class StaticVariables
    {
        public static bool bIsAddForm;
        public static String StrSectionName;
        public static String StrKey;
        public static String StrValue;
    }
}
