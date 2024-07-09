using System.Windows.Forms;

namespace WinFormsMenuExample
{
    public static class MenuStateHelper
    {
        public static void SetInitialMenuStates(ToolStripMenuItem menuAdd, ToolStripMenuItem menuUpdate, ToolStripMenuItem menuSave, ToolStripMenuItem menuCancel)
        {
            // Initially enable Add, Update, and Exit
            EnableMenus(menuAdd, menuUpdate, menuSave, menuCancel, true, true, false, false);
        }

        public static void DisableAddAndUpdate(ToolStripMenuItem menuAdd, ToolStripMenuItem menuUpdate, ToolStripMenuItem menuSave, ToolStripMenuItem menuCancel)
        {
            // Enable Save and Cancel, disable Add and Update
            EnableMenus(menuAdd, menuUpdate, menuSave, menuCancel, false, false, true, true);
        }

        public static void EnableSaveCancel(ToolStripMenuItem menuSave, ToolStripMenuItem menuCancel)
        {
            menuSave.Enabled = true;
            menuCancel.Enabled = true;
        }

        public static void EnableMenus(ToolStripMenuItem menuAdd, ToolStripMenuItem menuUpdate, ToolStripMenuItem menuSave, ToolStripMenuItem menuCancel, bool addEnabled, bool updateEnabled, bool saveEnabled, bool cancelEnabled)
        {
            menuAdd.Enabled = addEnabled;
            menuUpdate.Enabled = updateEnabled;
            menuSave.Enabled = saveEnabled;
            menuCancel.Enabled = cancelEnabled;
        }
    }
}
