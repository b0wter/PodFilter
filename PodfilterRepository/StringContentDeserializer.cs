﻿using PodfilterCore.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodfilterRepository
{
    public class StringContentDeserializer : IContentDeserializer<string>
    {
        public string DeserializeString(string s)
        {
            return s;
        }
    }
}