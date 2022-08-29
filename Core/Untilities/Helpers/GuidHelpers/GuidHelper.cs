using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Untilities.Helpers.GuidHelpers
{
    public class GuidHelper
    {
        public static string CreateGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
