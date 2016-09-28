using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitFeatures.LifeCycles
{
    static class Out
    {
        public static void Show(this string text)
        {
            Debug.WriteLine(text);
        }
    }
}
