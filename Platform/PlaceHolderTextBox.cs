using System;
using System.Drawing;
using System.Windows.Forms;

namespace HomePlatform
{
    public class PlaceHolderTextBox : TextBox
    {
        private string placeHolderText;
        private bool isPlaceHolder;
        
        public PlaceHolderTextBox()
        {
            //this.placeHolderText = this.Text;
            this.setPlaceholder();
            GotFocus += removePlaceHolder;
            LostFocus += setPlaceholder;
        }

        //when the control is focused, the placeholder is removed
        private void removePlaceHolder()
        {
            if (isPlaceHolder)
            {
                this.Text = "";
                this.ForeColor = System.Drawing.SystemColors.WindowText;
                this.Font = new Font(this.Font, FontStyle.Regular);
                isPlaceHolder = false;
            }
        }

        protected override void OnCreateControl()
        {
            if (this.placeHolderText == null)
            {
                this.placeHolderText = this.Text;
            }
            base.OnCreateControl();
        }

        private void removePlaceHolder(object sender, EventArgs e)
        {
            removePlaceHolder();
        }

        //when the control loses focus, the placeholder is shown
        private void setPlaceholder()
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                this.Text = placeHolderText;
                this.ForeColor = Color.Gray;
                this.Font = new Font(this.Font, FontStyle.Italic);
                isPlaceHolder = true;
            }
        }

        private void setPlaceholder(object sender, EventArgs e)
        {
            setPlaceholder();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }

        public string PlaceHolderText
        {
            get { return this.placeHolderText; }
        }
    }
}
