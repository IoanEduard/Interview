using _LeetCode_Easy.Concrete.Struggle.Arrays;

namespace _0.Tests._LeetCode_Easy.Tests.Struggle.Arrays
{
    public class TestArraysStruggleClassFactory
    {
        private RemoveDuplicatesfromSortedArray _removeDuplicatesfromSortedArray;
        public RemoveDuplicatesfromSortedArray RemoveDuplicatesfromSortedArray
        {
            get { return _removeDuplicatesfromSortedArray; }
            set { _removeDuplicatesfromSortedArray = new RemoveDuplicatesfromSortedArray(); }
        }

        public CreateTargetArrayInTheGivenOrder _createTargetArrayInTheGivenOrder;
        public CreateTargetArrayInTheGivenOrder CreateTargetArrayInTheGivenOrder
        {
            get { return _createTargetArrayInTheGivenOrder; }
            set { _createTargetArrayInTheGivenOrder = new CreateTargetArrayInTheGivenOrder(); }
        }

        public DestinationCity _destinationCity;
        public DestinationCity DestinationCity
        {
            get { return _destinationCity; }
            set { _destinationCity = new DestinationCity(); }
        }

        public SumOfAllOddLengthSubarrays _sumOfAllOddLengthSubarrays;
        public SumOfAllOddLengthSubarrays SumOfAllOddLengthSubarrays
        {
            get { return _sumOfAllOddLengthSubarrays; }
            set { _sumOfAllOddLengthSubarrays = new SumOfAllOddLengthSubarrays(); }
        }

    }
}