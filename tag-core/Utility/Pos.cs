using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tag_core.Utility;

/// <summary>
/// Represents a position in 3D space
/// </summary>
internal class Pos
{
    internal Pos(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    /// <summary>
    /// X position on the horizontal axis
    /// </summary>
    internal double X { get; set; }

    /// <summary>
    /// Y position on the vertical axis
    /// </summary>
    internal double Y { get; set; }

    /// <summary>
    /// Z position on the horizontal axis
    /// </summary>
    internal double Z { get; set; }

    internal string TagString(string name = "Position") => $@"<{name}><x value=""{X.TagString()}""><y value=""{Y.TagString()}""><z value=""{Z.TagString()}""></{name}>";
}
