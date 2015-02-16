namespace StudentClass
{
    ﻿using System;

    public class PropertyChangedEventArgs
    {
        public string NewName { get; set; }

        public string OldName { get; set; }
        
        public int NewAge { get; set; }
        
        public int OldAge { get; set; }
        
        public string ChangedProperty { get; set; }
    }
}