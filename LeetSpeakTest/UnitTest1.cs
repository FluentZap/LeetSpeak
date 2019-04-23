using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;
namespace LeetSpeakTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LeetSpeakTestReturnWord()
        {
            Assert.AreEqual("snap", new LeetSpeakConvert().Convert("snap"));
        }

        [TestMethod]
        public void LeetSpeakTestReturnWordReplaceEWith3()
        {
            Assert.AreEqual("3l3phan7", new LeetSpeakConvert().Convert("Elephant"));
        }

        [TestMethod]
        public void LeetSpeakTestReturnWordReplaceOWith0()
        {
            Assert.AreEqual("0p3ra70r", new LeetSpeakConvert().Convert("Operator"));
        }

        [TestMethod]
        public void LeetSpeakTestReturnWordReplaceTWith7()
        {
            Assert.AreEqual("L3773r 0p3n3r", new LeetSpeakConvert().Convert("Letter Opener"));
        }

        [TestMethod]
        public void LeetSpeakTestReturnWordReplaceSWithZ()
        {
            Assert.AreEqual("SilibuZ", new LeetSpeakConvert().Convert("Silibus"));
        }
    }
}
