using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormTimes : Form
    {
      #region - CONSTRUCTOR & INI ---------------------
        public FormTimes()
        {
            InitializeComponent();
            IniTimes();
        }

        //double xi = aDtim.ToOADate();  //xi=1 to 1 dzień = 24h

        private void IniTimes()
        {
            dateTimPicStart.Format = DateTimePickerFormat.Custom;
            dateTimPicStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            dateTimPicStop.Format = DateTimePickerFormat.Custom;
            dateTimPicStop.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            jSetDataTimes();
        }

        public void jSetDataTimes() //ustawia czasy na podstawie TxtBars i comboPeriod w DataPicker
        {
            DateTime adDate1, adDate2;
            double adMin = 60;

            adDate2 = DateTime.Now;
            adDate1 = adDate2.AddMinutes(-adMin); //Odejmujemy czas

            dateTimPicStart.Value = adDate1;
            dateTimPicStop.Value = adDate2;
        }

        #endregion ----------------------------


        #region - DELEGATES --------------------------
        //FormTimes is the publisher class here

        //Deklaracja typu funkcji delegata w Form1
        //Funkcja w Form1 musi zwracać [void] i mieć argumenty: (double, double)
        public delegate void PrintDockParam(double xdTimeGo, double xdTimeEnd, string xtext);

        PrintDockParam cDelegat;
        public void IniDelegate(PrintDockParam xDelegat)
        {
            cDelegat = xDelegat;
        }

        private void RunDelegate()
        {   //Uruchomienie funkcji delegata w Form1
            //To odpali funkcję [PrintFromForm1()] w Form1

            DateTime adDate1 = dateTimPicStart.Value;
            DateTime adDate2 = dateTimPicStop.Value;
            string asText = textMessage.Text;

            //double xi = aDtim.ToOADate();  //xi=1 to 1 dzień = 24h
            double adTimeGo = adDate1.ToOADate();  //to czas w dniach od chyba 1970-01-01
            double adTimeEnd = adDate2.ToOADate();

            cDelegat(adTimeGo, adTimeEnd, asText); //Wywołanie funkcji w Form1, wcześniej podpiętej
                                           //(zlinkowanej) przez [IniDelegate(PrintToTextBox xDelegat)]
        }

      #endregion - DELEGATY ----------------------------

        private void butPrintViaDelegate_Click(object sender, EventArgs e)
        {
            RunDelegate();
        }
    }
}
