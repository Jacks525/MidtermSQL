/*
 * Porject Name: MidtermSQA
 * 
 * Purpose: To Test a Calculator c# file
 * 
 * Created Feb 11, 2025
 * 
 * 
 */

using MidtermSQA; //Why it can't find it I don't know

namespace TestProjectSQA
{
    public class Tests
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new SimpleCalculator();
        }

        [TestCase(40, 40, 80)]
        [TestCase(-5, -1, -6)]
        public void Check_if_Addition_is_valid( double Value1, double Value2, double CorrectTotal)
        {
            var Total = _calculator.Add(Value1, Value2); //Adds both values together

            Assert.AreEqual(CorrectTotal, Total); //Checks if Valid

        }

        [TestCase(40, 40, 0)]
        [TestCase(-5, -1, -4)]
        public void Check_if_Subtraction_is_valid(double Value1, double Value2, double CorrectTotal)
        {
            var Total = _calculator.Subtract(Value1, Value2); //Subtracts values 

            Assert.AreEqual(CorrectTotal, Total);//Checks if Valid

        }

        [TestCase(0, 5, 0)]
        [TestCase(3, 4, 12)]
        [TestCase(3, -4, -12)] //Checks if Negative carries over
        [TestCase(-5, -4, 20)] //Checks if Negative is made null
        public void Check_if_Mult_is_valid(double Value1, double Value2, double CorrectTotal)
        {
            var Total = _calculator.Multiply(Value1, Value2); //Multiplies values 

            Assert.AreEqual(CorrectTotal, Total);//Checks if Valid

        }


        [TestCase(12, 3, 4)]
        [TestCase(-20, 5, -4)] //Checks if Negative carries over
        [TestCase(-20, -5, 4)] //Checks if Negative is made null
        public void Check_if_divid_is_valid(double Value1, double Value2, double CorrectTotal)
        {
            var Total = _calculator.Divide(Value1, Value2); //Divides values 

            Assert.AreEqual(CorrectTotal, Total);//Checks if Valid

        }


        [TestCase(5, 0)]
        [TestCase(0, 5)] // Will Return fail as only second value is checked
        public void Divid_zero_check(double Value1, double Value2)
        {
            var Total = _calculator.Divide(Value1, Value2); //Divides values 

            Assert.AreEqual("Division by zero is not allowed", Total); //Checks if Zero Error is caught
            
        } 


    }
}