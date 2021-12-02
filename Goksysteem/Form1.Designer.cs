
using System.Diagnostics.Eventing.Reader;

namespace Goksysteem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected void OnAuthenticate(EventArgs e)
        {
            AuthenticationEventHandler authHandler = Authenticate;
            if (authHandler != null)
            {
                foreach (AuthenticationEventHandler handler in authHandler.GetInvocationList())
                {
                    handler.BeginInvoke(this, e, new AsyncCallback(Callback), handler);
                }
            }
        }
        
        void Callback(IAsyncResult ar)
        {
            AuthenticationEventHandler d = (AuthenticationEventHandler)ar.AsyncState;
            if (d.EndInvoke(ar))
            {
                OnLoggedIn(new EventArgs());
            }
            else
            {
                OnLoggedError(new EventArgs());
            }
        }
        
        public event AuthenticationEventHandler Authenticate;
        public event EventHandler LoggedIn;
        public event EventHandler LoggedError:
        public delegate bool AuthenticationEventHandler(object sender, EventArgs e);
        public string Username 
        {
            get { return UserName.Text; }
        }
        public string Passwordtext
        {
            get { return Password.Text; }
        }
        
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}

