using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.CustomElements
{
    class TextBoxWithPlaceholder : TextBox
    {
        public string Placeholder { get; set; }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            if (!DesignMode)
            {
                Text = Placeholder;
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);

            if (Text.Equals(string.Empty))
            {
                Text = Placeholder;
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            if (Text.Equals(Placeholder))
            {
                Text = string.Empty;
            }
        }
    }
}