namespace DiscountChanged
{
    class DiscountChangedEventArgs : EventArgs
    {
        private int oldDiscount { get; set; }
        private int newDiscount { get; set; }

        public DiscountChangedEventArgs(int OldDiscount, int NewDiscount)
        {
            oldDiscount = OldDiscount;
            newDiscount = NewDiscount;
        }

        public int OldDiscount => oldDiscount;
        public int NewDiscount => newDiscount;

    }
}