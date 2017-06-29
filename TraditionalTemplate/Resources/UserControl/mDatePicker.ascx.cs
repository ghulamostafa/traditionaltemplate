using System;

namespace MGas.Resources.UserControl
{
    public partial class mDatePicker : System.Web.UI.UserControl
    {
        #region Properties
        
        public int dpDay()
        {
            return int.Parse(mDay.SelectedValue);
        }

        public string dpMonth()
        {
            return mMonth.SelectedValue;
        }

        public string dpYear()
        {
            return mYear.Text;
        }

        public bool Enabled
        {
            get
            {
                if (mDay.Enabled & mMonth.Enabled & !mYear.ReadOnly)
                {
                    return false;
                }
                return true;
            }
            set
            {
                mDay.Enabled = value;
                mMonth.Enabled = value;
                mYear.ReadOnly = !value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Pass in a date with Day, Month and Year separated.
        /// </summary>
        /// <param name="dpDay">Day: int</param>
        /// <param name="dpMonth">Month: string</param>
        /// <param name="dpYear">Year: int</param>
        public void SetDate(int dpDay, string dpMonth, int dpYear)
        {
            mDay.SelectedValue = dpDay.ToString();
            mMonth.SelectedValue = dpMonth;
            mYear.Text = dpYear.ToString();
        }

        /// <summary>
        /// Pass in a date in string format
        /// </summary>
        /// <param name="strDate">Date: String ddMMMyyyy</param>
        public void SetDate(string strDate)
        {
            System.DateTime theDate = default(System.DateTime);

            try
            {
                theDate = Convert.ToDateTime(strDate);
            }
            catch (Exception ex)
            {
                theDate = System.DateTime.UtcNow;
            }

            mDay.SelectedValue = theDate.Day.ToString();
            mMonth.SelectedValue = MonthName(theDate.Month, true);
            mYear.Text = theDate.Year.ToString();
        }

        /// <summary>
        /// Fetch the date specified in the controller.
        /// </summary>
        /// <returns>Gets the Date as of format 3-Feb-1991</returns>
        /// <remarks></remarks>
        public string GetDate()
        {
            return mDay.SelectedValue.ToString() + "-" + mMonth.SelectedValue.ToString() + "-" + mYear.Text.ToString();
        }

        /// <summary>
        /// Get the month name by passing integer value and the check for abbreviate or not
        /// </summary>
        /// <param name="month">Month: int</param>
        /// <param name="abbreviate">Should return short form or long</param>
        /// <returns></returns>
        private string MonthName(int month, bool abbreviate)
        {
            string _monthName = "";
            switch (month)
            {
                case 1:
                    _monthName = abbreviate ? "Jan" : "January";
                    break;
                case 2:
                    _monthName = abbreviate ? "Feb" : "February";
                    break;
                case 3:
                    _monthName = abbreviate ? "Mar" : "March";
                    break;
                case 4:
                    _monthName = abbreviate ? "Apr" : "April";
                    break;
                case 5:
                    _monthName = abbreviate ? "May" : "May";
                    break;
                case 6:
                    _monthName = abbreviate ? "Jun" : "June";
                    break;
                case 7:
                    _monthName = abbreviate ? "Jul" : "July";
                    break;
                case 8:
                    _monthName = abbreviate ? "Aug" : "August";
                    break;
                case 9:
                    _monthName = abbreviate ? "Sep" : "September";
                    break;
                case 10:
                    _monthName = abbreviate ? "Oct" : "October";
                    break;
                case 11:
                    _monthName = abbreviate ? "Nov" : "November";
                    break;
                case 12:
                    _monthName = abbreviate ? "Dec" : "December";
                    break;
                default:
                    break;
            }

            return _monthName;
        }
        
        #endregion
    }
}