using _2.Printer.Concrete;
using _LeetCode_Easy.Concrete.DesignOOP;
using static _0.Tests._LeetCode_Easy._TestsCases;

namespace _0.Tests.Tests._LeetCode_Easy
{
    public class TestsOOP
    {
        private readonly DisplayTypeInstantiator _display;
        private readonly Codec _codec;
        private readonly OrderedStream _orderedStream;
        private readonly ParkingSystem _parkingSystem;

        public TestsOOP(DisplayTypeInstantiator display)
        {
            _display = display;
            _codec = new Codec();
            _orderedStream = new OrderedStream(OrderedStream_TestCase1);
            _parkingSystem = new ParkingSystem(ParkingSystem_TestCase1[0], ParkingSystem_TestCase1[1], ParkingSystem_TestCase1[2]);
        }

        public void Codec_Test()
        {
            var longUrl = "https://asfsdfgergrehergregregdfgergregwfasfagjyjye.com";
            _display.DisplayString.DisplayResult(_codec.Encode(longUrl));
            _display.DisplayString.DisplayResult(_codec.Decode("http://tinyurl.com/" + longUrl.GetHashCode()));
        }

        public void OrderedStream_Test()
        {
            _display.DisplayString.DisplayResult(_orderedStream.Insert(1, "aaa"));
        }

        public void ParkingSystem_Test()
        {
            _display.DisplayBoolean.DisplayResult(_parkingSystem.AddCar(1));
        }
    }
}