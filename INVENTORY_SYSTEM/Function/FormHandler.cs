using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTORY_SYSTEM
{
    public static class FormHandler
    {
        public static bool IsFormOpen(Type formType)
        {
            return Application.OpenForms.OfType<Form>().Any(f => f.GetType() == formType);
        }
    }
}
