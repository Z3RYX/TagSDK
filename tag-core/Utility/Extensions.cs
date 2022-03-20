using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tag_core.Utility;

internal static class Extensions
{
    internal static string TagString(this double num) => num.ToString("0.######");
}
