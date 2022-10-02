using System;
using System.Windows.Forms;

// This Source Code Form is subject to the terms of the MIT License.
// Copyright(C) Jan Luk. All Rights Reserved 2017.


namespace WinForm
{
    public partial class Form1 : Form
    {
        //The project shows how the 'delegate' mechanism works.
        //A descendant form called by a parent normally cannot call the parent's methods.
        //Thanks to the delegate mechanism, it can do so. A delegate is a reference to the parent method.
        //Form1 initializes Form2 and passes it a reference to its method 'jDelegatPrintFromForm1()'
        //Form2 presses its key and writes its text in Form1.


        #region - CONSTRUCTOR & Variable ----------------

        static string csTextFromDelegate { get; set; }

        public Form1()
        {
            InitializeComponent();
            csTextFromDelegate = "null";
        }

        #endregion ----------------

        #region - Delegated methods ---------------------

        //Subskrybowana funkcja do Form2, posiadająca 'typ' delegata, do którego będzie subskrybowana.
        //Ta funkcja będzie uruchamiana 'zdalnie' przez inne 'Form', może się nazywać dowolnie.
        //Delegate signature for the event
        public void jDelegatPrintFromForm1(string s)
        {
            textDelegat.Text = s; 
            csTextFromDelegate = s;

            //if (InvokeRequired) { //old attempts
            //    this.BeginInvoke(new Action<string>(PrintFromForm1), new object[] { s });
            //    return;
            //}
            //textDelegat.Text += value;
        }

        //Subskrybowana funkcja do FormTimes
        public void jDelegatPrintFromTimes(double xdTimeGo, double xdTimeEnd, string xsText)
        {
            labTime1.Text = xdTimeGo.ToString("### ##0.###0");
            labTime2.Text = xdTimeEnd.ToString("### ##0.###0");
            textMessage.Text = xsText;
        }


        #endregion -----------------------

        #region - Buttons -------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            jCreateNextForm2();
        }


        private void butCreateFormTimes_Click(object sender, EventArgs e)
        {
            jCreateFWinDockParam();
        }

        #endregion -----------------------------

        #region - WORK ----------------------------------

        private void jCreateNextForm2()
        {
            WinForm.Form2 f2 = new WinForm.Form2();
            f2.Text = "Form2 in Form1";

            Form2.PrintToTextBox pm1 = new Form2.PrintToTextBox(jDelegatPrintFromForm1);
            //This method [IniDelegate()] subscribes (sign in) to event notifications in Form2
            f2.IniDelegate(pm1);

            f2.Show();

        }


        private void jCreateFWinDockParam()
        {
            FormTimes fDockParam = new FormTimes();
            fDockParam.Text = "FormTimes";

            FormTimes.PrintDockParam pmd = new FormTimes.PrintDockParam(jDelegatPrintFromTimes);
            fDockParam.IniDelegate(pmd);

            fDockParam.Show();
        }

        #endregion --------------
    }
}
