using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project
{
    internal class Flag
    {
        bool isChanged;
        static Flag state;

        public static Flag State
        {
            get
            {
                if (state == null)
                {
                    state = new Flag();
                }
                return state;
            }
        }

        public bool IsChanged { get => isChanged; set => isChanged = value; }
    }
}
