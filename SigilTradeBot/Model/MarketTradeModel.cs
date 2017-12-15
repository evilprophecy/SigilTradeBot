using PropertyChanged;
using BittrexSharp.Domain;
using System.Threading.Tasks;
using System.ComponentModel;
using BittrexSharp;
using SigilTradeBot.ViewModel;
using SigilTradeBot.Model;


namespace SigilTradeBot.Model
{
    [AddINotifyPropertyChangedInterface]
   
    /// <summary>
    /// Class to Contain Market Trading infomation
    /// </summary>
    public class MarketTrade : INotifyPropertyChanged
    {
      
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };                       
              
        /// <summary>
        /// Constructor of MarketTrade Class
        /// </summary>
        public MarketTrade()
        {
            
            _SelectedMarketPair = "BTC-LTC";
            _Api = "Input Bittrex Api Here";
            _Api_Secret = "Input Bittrex Secret Api Here";

        }

        Bittrex BittrexLink = new Bittrex();
        
        /// <summary>
        /// Private Backing Fields 
        /// </summary>
              
        private MarketSummary _LinkMS;
        private string _Api;
        private string _Api_Secret;
        private string _SelectedMarketPair;
        private decimal _TradeUnits;
        private decimal _TradePrice;
       
                

        /// <summary>
        /// Properties 
        /// </summary>
        public MarketSummary LinkMS
        {

            get
            {
                return _LinkMS;
            }
            set
            {
                _LinkMS = value;
            }
        }
        public string Api
        {
            get
            {
                return _Api;
            }
            set
            {
                _Api = value;

            }
        }
        public string Api_Secret
        {
            get
            {
                return _Api_Secret;
            }
            set
            {
                _Api_Secret = value;

            }
        }
        public string SelectedMarketPair
        {
            get
            {
                return _SelectedMarketPair;
            }

            set
            {
                _SelectedMarketPair = value;

            }
        }
        public decimal TradeUnits
        {
            get { return _TradeUnits; }
            set { _TradeUnits = value; } 
        }
        public decimal TradePrice
        {
            get { return _TradePrice; }
            set { _TradePrice = value; }
        }
        public decimal TradeTotal
        {
            get { return TradeUnits*TradePrice; }
            
        }




        /// <summary>
        /// Methods
        /// </summary>
        
        /// Sets the Api varibles of the Bittrex Object
        public void AuthenticateApi()
        {
            BittrexLink.SetApiKeys(Api, Api_Secret);
        }
        public async Task UpdateMarketSummary()
        {
                        
         LinkMS = await BittrexLink.GetMarketSummary(SelectedMarketPair);

            
        }
        public async Task PlaceBuyOrder()
        {
            await BittrexLink.BuyLimit(SelectedMarketPair, TradeUnits, TradePrice);
        }
        public async Task PlaceBuyOrder(string SelectedMarketPair, decimal TradeUnits, decimal TradePrice)
        {
            await BittrexLink.BuyLimit(SelectedMarketPair, TradeUnits, TradePrice);
        }
        public async Task PlaceSellOrder()
        {
            await BittrexLink.SellLimit(SelectedMarketPair, TradeUnits, TradePrice);
        }
        public async Task PlaceSellOrder(string SelectedMarketPair, decimal TradeUnits, decimal TradePrice)
        {
            await BittrexLink.SellLimit(SelectedMarketPair, TradeUnits, TradePrice);
        }


    }

}
