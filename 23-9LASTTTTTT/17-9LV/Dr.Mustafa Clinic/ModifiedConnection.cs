using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dr.Mustafa_Clinic
{
    public static class ModifiedConnection
    {
            /// <summary>
            /// Global variable that is constant.
            /// </summary>
            public const string GlobalString = "Important Text";

            /// <summary>
            /// Static value protected by access routine.
            /// </summary>
            static string _constring;

            /// <summary>
            /// Access routine for global variable.
            /// </summary>
            public static string GlobalValue
            {
                get
                {
                    return _constring;
                }
                set
                {
                    _constring = value;
                }
            }

            /// <summary>
            /// Global static field.
            /// </summary>
            public static bool GlobalBoolean;
        }
    
}
