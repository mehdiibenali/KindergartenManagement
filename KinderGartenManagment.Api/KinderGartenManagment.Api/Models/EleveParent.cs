﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinderGartenManagment.Api.Models
{
    public class EleveParent
    {
        public int EleveId { get; set; }
        public int ParentId { get; set; }
        public bool ParentTuteur { get; set; }
        public Eleve Eleve { get; set; }
        public Parent Parent { get; set; }

    }
}
