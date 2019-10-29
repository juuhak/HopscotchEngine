﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletClassLibrary
{
    public interface IImmaterialObject : IGameObject
    {
        bool Hit(ISolidObject solidObject);
        bool Hit(IImmaterialObject immaterial);
    }
}