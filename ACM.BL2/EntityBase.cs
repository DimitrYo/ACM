using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL {
    public abstract class EntityBase {

        public string EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool isNew { get; private set; }
        public bool isValid { get { return Validate(); } }

        public abstract bool Validate();
    }
}

