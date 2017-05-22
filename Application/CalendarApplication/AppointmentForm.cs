using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calendar
{
    public partial class AppointmentForm : Form
    {
        private bool _recurs;
        private int _dateIndex;
        private DateTime _date;
        private IAppointment appoint;
        private string _freq;
        private int _occ;

        const int day = 1440;

        public AppointmentForm(DateTime date, int dateIndex, bool recurs)
        {   // generates that values for a new appointment to be handled by the form
            InitializeComponent();
            _recurs = recurs;
            _date = date;
            _dateIndex = dateIndex;
        }

        public AppointmentForm(bool recurs, IAppointment app, int occ)
        {   // this constructor is for when you are 
            // editing the values of an appointment a bit crude but it works
            InitializeComponent();
            _recurs = recurs;
            _date = app.Start;
            appoint = app;

            if(recurs)
            {
                string[] val = app.DisplayableDescription.Split('-');

                _freq = val[2];
                _occ = occ;
            }
        }

        public string GetDesc
        {
            get;
            private set;
        }
        public bool GetRecurs
        {
            get;
            private set;
        }

        public DateTime GetStart
        {
            get;
            private set;
        }

        public int GetLen
        {
            get;
            private set;
        }

        public int GetOcc
        {
            get;
            private set;
        }

        private void PopulateTime()
        {
            //populates the time slots available with up to 24 hours 
            //and selects the first item
            var Day = DateTime.Today;
            var vals = from offset in Enumerable.Range(0, 48) 
                          select Day.AddMinutes(30 * offset);
            foreach (var t in vals)
            {
                cmbbxStartTime.Items.Add(t.ToString("HH:mm"));
            }
        }
        public void PopulateLength()
        {   // populates the length values
            for (int val = 30; val <= day; val += 30)
            {
                cmbbxLength.Items.Add(val);
            }

            if (appoint != null)
            {
                cmbbxLength.SelectedText = Convert.ToString(appoint.Length);
            }
            else
            {
                cmbbxLength.SelectedIndex = 0;
            }
        }

        private void IsRecurring()
        {   //changes the forms information depending on if 
            //it's recurring or not
            if (_recurs)
            {
                this.Text = "Recurring Appointment";
                numOccurances.Enabled = true;
                cmbbxFrequency.Enabled = true;
                chkbxRecurring.Checked = true;
            }
            else
            {
                this.Text = "Appointment";
                numOccurances.Enabled = false;
                cmbbxFrequency.Enabled = false;
            }

        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {   // upon load, the lists get populated and the recursion is varified
            PopulateTime();
            PopulateLength();
            IsRecurring();

            if (appoint != null && _recurs)
            {
                cmbbxFrequency.SelectedText = _freq;
                numOccurances.Value = _occ;
            }
            else
            {
                cmbbxFrequency.SelectedIndex = 0;
            }

            lblDateSet.Text = _date.Date.ToLongDateString();

            // here it is checking that at the very least there is an appointment 
            // added to the form for editing
            if (appoint != null)
            {
                this.Text = "Edit Appointent: " + appoint.DisplayableDescription;
                string[] sectioned = appoint.DisplayableDescription.Split('-');
                txtbxSubject.Text = sectioned[0];
                txtbxLocation.Text = sectioned[1];

                cmbbxStartTime.SelectedText = _date.ToString("HH:mm");
            }
            else
            {
                cmbbxStartTime.SelectedIndex = _dateIndex;
            }
        }
        
        private void chkbxRecurring_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxRecurring.Checked)
            {
                _recurs = true;
            }
            else
            {
                _recurs = false;

            }

            IsRecurring();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {   // fills the new appointment values with the set values in the form before closing
            string valDate = _date.ToLongDateString() + " " + cmbbxStartTime.Text;
            GetStart = Convert.ToDateTime(valDate);
            GetLen = Convert.ToInt32(cmbbxLength.Text);
            GetDesc = txtbxSubject.Text + "-" + txtbxLocation.Text;
            GetOcc = Convert.ToInt32(numOccurances.Value);
            GetRecurs = chkbxRecurring.Checked;

            if (_recurs)
            {
                GetDesc = GetDesc + "-" + cmbbxFrequency.Text;
            }
        }
    }
}
