using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_ErikMartinez
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public string SurfaceMaterial { get; set; }

        // Constraints for Width and Depth

        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MINDRAWER = 0;
        public const int MAXDRAWER = 7;
    }
}
