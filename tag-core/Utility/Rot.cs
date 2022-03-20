using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tag_core.Utility;

/// <summary>
/// Represents a rotation using quaternions
/// </summary>
internal class Rot
{
    internal Rot(double w, double x, double y, double z)
    {
        W = w;
        X = x;
        Y = y;
        Z = z;
    }

    internal double W { get; set; }
    internal double X { get; set; }
    internal double Y { get; set; }
    internal double Z { get; set; }

    internal static Rot Default = new(1, 0, 0, 0);

    internal static Rot X90 = new(0.707107, 0.707107, 0, 0);
    internal static Rot X180 = new(0, 1, 0, 0);
    internal static Rot X270 = new(0.707107, -0.707107, 0, 0);

    internal static Rot Y90 = new(0.707107, 0, 0.707107, 0);
    internal static Rot Y180 = new(0, 0, 1, 0);
    internal static Rot Y270 = new(0.707107, 0, -0.707107, 0);

    internal static Rot Z90 = new(0.707107, 0, 0, 0.707107);
    internal static Rot Z180 = new(0, 0, 0, 1);
    internal static Rot Z270 = new(0.707107, 0, 0, -0.707107);

    internal string TagString() => $@"<Rotation><w value=""{W.TagString()}""><x value=""{X.TagString()}""><y value=""{Y.TagString()}""><z value=""{Z.TagString()}""></Rotation>";
}
