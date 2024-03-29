﻿using ThreeDlex.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeDlex.Core.Interfaces
{
    public interface IGlobal
    {
        string CurrentToken { get; set; }

        UserLogin CurrentLogin { get; set; }

        User CurrentUser { get; set; }

        string CurrentUserImagePath { get; set; }

        string ApiUri { get; set; } 

    }
}
