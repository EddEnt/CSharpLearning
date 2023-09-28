﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models;

    internal class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Message => "This app is a .NET MAUI app, written in XAML and C#";
    }