using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MauiBaseVS.Models;

namespace MauiBaseVS.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<UserDetails> _userDetailsList = new List<UserDetails>();

        public List<UserDetails> UserDetailsList
        {
            get => _userDetailsList;

            set
            {
                _userDetailsList = value;
                OnPropertyChanged();
            }
            
        }

        private void OnPropertyChanged()
        {
            throw new NotImplementedException();
        }

        public ICommand SelectionChangedCommand => new Command<object>((obj) =>
        {
            var selectedItem = obj as UserDetails;
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

            UserDetailsList = detailsList;
        }
    }
}
