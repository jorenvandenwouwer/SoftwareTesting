using NUnit.Framework;
using System;
using System.Security.Cryptography.X509Certificates;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_whenDefault_returnsinput(
            [Values(1,2,4,7,8,11,13,14,16,17,19)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }
        [Test]
        public void Buzzer_whenDiv3_returnsFizz(
            [Values(3, 6, 9,12,18)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void Buzzer_whenDiv5_returnsBuzz(
            [Values(5, 10,20)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }
        [Test]
        public void Buzzer_whenDiv3AndDiv5_returnsBuzz(
            [Values(15)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
