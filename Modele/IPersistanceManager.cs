﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public  interface IPersistanceManager
    {
        IEnumerable<Recette> LoadRecettes();
    }
}
