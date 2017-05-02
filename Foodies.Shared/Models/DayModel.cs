using System;
using GalaSoft.MvvmLight;

namespace Foodies.Shared.Models
{
    public sealed class DayModel : ObservableObject
    {
        private DateTime _day;
        private IssueEnum _issueScore;

        public DateTime Day
        {
            get
            {
                return this._day;
            }
            set
            {
                this.Set(() => this.Day, ref this._day, value);
            }
        }

        public IssueEnum IssueScore
        {
            get
            {
                return this._issueScore;
            }
            set
            {
                this.Set(() => this.IssueScore, ref this._issueScore, value);
            }
        }
    }
}
