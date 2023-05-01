namespace _LeetCode_Medium.Concrete.Struggle
{
    public class StruggleMedium 
    {
        private readonly RotateArray _rotateArray;
        private readonly ProductofArrayExceptSelf _productofArrayExceptSelf;
        private readonly MaximumPointsYouCanObtainFromCards _maximumPointsYouCanObtainFromCards;
        private readonly NumberOfWaysToBuyPensAndPencils _numberOfWaysToBuyPensAndPencils;
        private readonly NumberOfClosedIslands _numberOfClosedIslands;

        public StruggleMedium()
        {
            this._rotateArray = new RotateArray();
            this._productofArrayExceptSelf = new ProductofArrayExceptSelf();
            this._maximumPointsYouCanObtainFromCards = new MaximumPointsYouCanObtainFromCards();
            this._numberOfWaysToBuyPensAndPencils = new NumberOfWaysToBuyPensAndPencils();
            this._numberOfClosedIslands = new NumberOfClosedIslands();
        }

        public RotateArray RotateArray => _rotateArray;

        public ProductofArrayExceptSelf ProductofArrayExceptSelf => _productofArrayExceptSelf;

        public MaximumPointsYouCanObtainFromCards MaximumPointsYouCanObtainFromCards => _maximumPointsYouCanObtainFromCards;

        public NumberOfWaysToBuyPensAndPencils NumberOfWaysToBuyPensAndPencils => _numberOfWaysToBuyPensAndPencils;

        public NumberOfClosedIslands NumberOfClosedIslands => _numberOfClosedIslands;
    }
}