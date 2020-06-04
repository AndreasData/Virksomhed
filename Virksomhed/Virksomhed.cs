using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Virksomhed
{
    public class Virksomhed : INotifyPropertyChanged
    {
        private string virksomhedsBrugernavn;

        public List<Announce> List_Announce
        {
            get => list_Announce; set
            {
                list_Announce = value;
                OnPropertyChanged();
            }
        }



        public string VirksomhedsBrugernavn
        {
            get { return virksomhedsBrugernavn; }
            set
            {
                virksomhedsBrugernavn = value;
                OnPropertyChanged();
            }
        }
        private string virksomhedsPassword;

        public string VirksomhedsPassword
        {
            get { return virksomhedsPassword; }
            set
            {
                virksomhedsPassword = value;
                OnPropertyChanged();
            }
        }
        private string virksomhedsEmail;
        private List<Announce> list_Announce;

        public string VirksomhedsEmail
        {
            get { return virksomhedsEmail; }
            set
            {
                virksomhedsEmail = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Virksomhed(string navn, string password, string email)
        {
            this.VirksomhedsBrugernavn = navn;
            this.VirksomhedsPassword = password;
            this.VirksomhedsEmail = email;

            List_Announce = new List<Announce>();
        }

        public Virksomhed()
        {

        }

        /*public void AddAnnouce()
        {
            Announce OAnnounce = new Announce(Info, Profession, Kontraktlængde, Løn, Bruger);

            List_Announce.Add(OAnnounce);
        }*/



        /*public Announce() 
        {
        
        }*/

    }
}