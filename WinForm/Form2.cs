using System;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form2 : Form
    {
        #region - CONSTRUCTOR ------------------------
        public Form2()
        {
            InitializeComponent();
        }

        #endregion ----------------

        #region - DELEGATES --------------------------
        //Form2 is the publisher class here

        //Definition of a remote function template (szablon funkcji zdalnej/delegata)
        //Delegate signature for the event
        public delegate void PrintToTextBox(string s);

        //Pole [cDelegat] przechowuje 'delegatę' czyli referencję/wskazanie na funkcję 'zdalną'
        //uruchamianą w innym oknie (Form2 nawet nie wie gdzie ta funkcja jest, ma tylko 'link')
        PrintToTextBox cDelegat; //reference to the 'remote' function

        // The [IniDelegate()] method in the Form2 class by which external Forms subscribe
        // (sign in) to event notifications in Form2. Form2 then uses this mechanism to publish
        // its events 'out' to the external Forms that are 'hooked up' to it.
        public void IniDelegate(PrintToTextBox xDelegat)
        {
            cDelegat = xDelegat;
        }

        private void butPrintViaDelegate_Click(object sender, EventArgs e)
        {   //Publisher Form2 uruchamia subskrybowaną funkcję (metodę) delegata [PrintFromForm1()]
            //w Form1 podstawiając swój argument tekstowy [ast]
            // Publisher Form2 runs the subscribed delegate method [PrintFromForm1 ()]
            // in Form1 and writes the text argument [ast]
            string ast = textBox1.Text;
            cDelegat(ast);
        }

      #endregion ----------------------------

    }

}
