namespace ChallengeApp.Test
{
    public class TypeTests
    {

        [Test]
        public void CompareFloatType()
        {
            //attract
            float temp1 = -100F;
            float temp2 = 0.30F;


            //act


            //assert
            Assert.AreNotEqual(temp1, temp2);

        }

        [Test]
        public void WhenTwoNameAreNotEqual_ShouldCorrctResult()
        {
            //attract
            string name1 = ("Blazej");
            string name2 = ("Zosia");



            //act


            //assert
            Assert.AreNotEqual(name1, name2);
               
        }


        [Test]
        public void WhenTwoNumberAreEqual_SholudCorrectResult()
        {
            //attract
            int number1 = 1;
            int number2 = 2;



            //act


            //assert
            Assert.AreNotEqual(number1, number2);
        }


        [Test]
        public void WhenGetTwoEmployeersAreNotEqual_SholudCorrectResult()
        {
            //attract
            var emp1 = GetEmp("Marcin", "Kowalski", 28);
            var emp2 = GetEmp("Magda", "Wróbel", 20);



            //act


            //assert
            Assert.AreNotEqual(emp1, emp2);
        }
        
        private Employee GetEmp(string name, string surname, int age)
        {
            return new Employee(name);
        }

    }
     
}

