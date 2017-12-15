using System.ComponentModel;
using SigilTradeBot.Commands;
using SigilTradeBot.Model;
using System.Windows.Input;
using PropertyChanged;


namespace SigilTradeBot.ViewModel
{
    /// Fody.weavers interface allows for automatic programming of  
    /// property changed events  it detects when a property of 
    /// the class (BaseViewModel) is "set" through DataBinding
    [AddINotifyPropertyChangedInterface]

    /// <summary>
    /// A Base View Model that fires Property Changed Events as needed
    /// </summary>
    public class UserViewModel : INotifyPropertyChanged
    {

        /// <summary>
        /// Event Handler to notify the client when a property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Constructor for UserViewModel
        /// </summary>
            public UserViewModel()
            {
               _DefaultUser = new User();
               _DefaultMarket = new MarketTrade();
               UpdateCommand = new UserUpdateCommand(this);
               AuthenticateCommand = new AuthenticateCommand(this);
               LimitBuyCommand = new LimitBuyCommand(this);
               LimitSellCommand = new LimitSellCommand(this);
            }
        
        
        ///<summary>
        /// Private Backing Field for Properties 
        /// </summary>
        private User _DefaultUser;
        private MarketTrade _DefaultMarket;
        

        ///<summary>
        ///Properties
        /// </summary> 
        public User DefaultUser
        {
            get
            {
                return _DefaultUser;
            }
            set { _DefaultUser = value; }
        }
        public MarketTrade DefaultMarket
        {
            get
            {
                return _DefaultMarket;
            }
            set
            {
                _DefaultMarket= value;
            }
        }
        public bool CanUpdate
        {
            get;
            set;
        }
        public ICommand UpdateCommand
        {
            get;
            private set;

        }
        public ICommand AuthenticateCommand
        {
            get;
            private set;
        }
        public ICommand LimitBuyCommand
        {
            get;
            private set;
        }
        public ICommand LimitSellCommand
        {
            get;
            private set;
        }

        ///<summary>
        ///Methods
        ///</summary>




    }
}                                
        
        
        
                          

      

   





