using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void SimpleInterest_float()
        {

            var expected1 = 9.2;
            var principle = 200;
            var time = 2; ;
            var rate = 2.3;

            var actual1 = SimpleInterest(principle,time,rate);
            Assert.Equal(expected1, actual1);
        }
        
        double SimpleInterest(float principle, float time,double interest)
        {
            return (principle * time * interest / 100);
        }    

        public void CompoundInterest_float()
        {
            var expected1 = 10.2;
            var principle =200;
            var time = 2;
            var rate= 2.3;
            var actual1 = CompoundInterest(principle,time,rate);
            Assert.Equal(expected1, actual1);

        }
        
        double CompoundInterest(float principle, float time,double interest)
        {
            return ((1+(principle * time * interest / 100));
        }  

    }
}