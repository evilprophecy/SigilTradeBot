using System.ComponentModel;
using PropertyChanged;
using SigilTradeBot.ViewModel;
using BittrexSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SigilTradeBot.Model
{
    /// <summary>
    /// Enables FodyWeavers Inotify package to detect when varibles are changed for us
    /// </summary>


    [AddINotifyPropertyChangedInterface]

    ///<summary>
    /// Class to Handle User information and Authentication Actions
    /// </summary>
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
        /// <summary>
        /// Constructor for then User Class
        /// </summary> 
        public User()
        {
           
           
            _Username = "Awaiting Bittrex Authentication";
        }

        /// <summary>
        /// Private Backing Field for Properties
        /// </summary>

        
        
        private string _Username;                   

        /// <summary>
        /// Properties that gets or sets private Varibles
        /// </summary>
      
      
        public string Username
        {
            get
            {
                return _Username;
            }

            set
            {
                _Username = value;
            }
        }
        ///<summary>
        ///Methods
        /// </summary>


    }
              

    
}
