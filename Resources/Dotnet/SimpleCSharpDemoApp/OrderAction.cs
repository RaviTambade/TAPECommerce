namespace CSFeaturesDemoApp
{
    public partial class Order
    {
        public bool Approve() { return false; }
        public bool IsApproved() { return false; }
        public bool Reject() { return true; }

        public bool Cancel() { return false; }
        public bool ChangeStatus(string status)
        {
            this.Status = status;
            return true;
        }

    }
}
