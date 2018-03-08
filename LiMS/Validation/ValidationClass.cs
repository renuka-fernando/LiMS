using DevComponents.DotNetBar.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiMS.Validation
{
    class ValidationClass
    {
        public static bool ValidateEmptyText(Highlighter highlighter, Control[] controls, string[] captions)
        {
            int length = controls.Length;

            //Test for Required Fields
            for(int i = 0; i < length; i++)
            {
                if(controls[i].Text.Equals(""))
                {
                    ShowInvalidError(
                        highlighter,
                        controls[i],
                        string.Format("The {0} is required!", captions[i]),
                        captions[i]
                    );
                    return false;
                }
            }
            return true;
        }

        public static void ShowInvalidError(Highlighter highlighter, Control control, string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            highlighter.SetHighlightColor(control, eHighlightColor.Red);
            control.Select();
        }

        public static void setControlsTextEmpty(List<Control> controls)
        {
            int length = controls.Count;
            for(int i = 0; i < length; i++)
            {
                controls[i].Text = "";
            }
        }
    }
}
