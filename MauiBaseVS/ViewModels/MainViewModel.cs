using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MauiBaseVS.Models;

namespace MauiBaseVS.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<UserDetails> _DetailsList = new List<UserDetails>();

        public List<UserDetails> DetailsList
        {
            get => _DetailsList;

            set
            {
                _DetailsList = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string param = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(param));
        }

        //private UserDetails _userDetails = new UserDetails();
        //public UserDetails UserDetails
        //{
        //    get => _userDetails;
        //    set
        //    {
        //        _userDetails = value;
        //        OnPropertyChanged(nameof(UserDetails));
        //    }
        //}

        //private void OnPropertyChanged() =>
        //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs());

        public ICommand MultipleSelectionCommand => new Command<IList<object>>((obj) =>
        {
            List<UserDetails> users = new List<UserDetails>();
            
            foreach(var item in obj)
            {
                var selectedItems = item as UserDetails;
                users.Add(selectedItems);
            }
        });

        public MainViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            List<UserDetails> detailsList = new List<UserDetails>();

            detailsList.Add(new UserDetails { Name = "Rick", Location = "Colorado" });
            detailsList.Add(new UserDetails { Name = "Bill", Location = "Iowa" });
            detailsList.Add(new UserDetails { Name = "Tom", Location = "Nebraska" });
            detailsList.Add(new UserDetails { Name = "William", Location = "Arizonia" });

            DetailsList = detailsList;
        }
    }
}
