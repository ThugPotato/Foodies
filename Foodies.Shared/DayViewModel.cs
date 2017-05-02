using System.Collections.ObjectModel;
using Foodies.Shared.Models;
using GalaSoft.MvvmLight;

namespace Foodies.Shared
{
    public sealed class DayViewModel : ViewModelBase
    {
        private ObservableCollection<DayModel> _lstKnownDays;

        public ObservableCollection<DayModel> LstKnownDays
        {
            get
            {
                return this._lstKnownDays;
            }
            set
            {
                this.Set(()=> this.LstKnownDays, ref this._lstKnownDays, value);
            }
        }

        public DayViewModel()
        {
        }
    }
}
