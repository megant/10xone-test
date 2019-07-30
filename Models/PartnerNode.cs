namespace TenXOne.Models
{
    public class PartnerNode
    {
        public PartnerNode() {}
        public PartnerNode(decimal left, decimal right, decimal depth, Partner partner)
        {
            this.Left = left;
            this.Right = right;
            this.Depth = depth;
            this.Partner = partner;

        }
        public decimal Left { get; set; }
        public decimal Right { get; set; }
        public decimal Depth { get; set; }
        public Partner Partner { get; set; }
    }
}