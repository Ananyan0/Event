using DiscountChanged;

namespace MyShop
{
    class Shop
    {
        private string _name { get; set; }
        private int _discount { get; set; }

        public Shop(string Name, int Discount)
        {
            _name = Name;
            _discount = Discount;
        }

        public string Name => _name;
        public int Discount
        {
            get { return _discount; }
            set
            {
                if(value <= 0) throw new ArgumentException("The discount can not be negative or zero");

                if(_discount != value)
                {
                    int OldDiscount = _discount;
                    _discount = value;
                    OnDiscountChanged(OldDiscount, _discount);
                }
            }
        }
        protected virtual void OnDiscountChanged(int OldDiscount, int NewDiscount)
        {
            DiscountChanged?.Invoke(this, new DiscountChangedEventArgs(OldDiscount, NewDiscount));
        }

        public event EventHandler<DiscountChangedEventArgs> DiscountChanged;
    }
}