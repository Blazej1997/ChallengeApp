namespace ChallengeApp.tests
{
    public class Tests
    {
        
        [Test]
        public void WhenAddScore_SholudHaveResult()
        {
            //arrange
            var employee = new Employee("Marcin", "Kowalski", 28);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(0);
            employee.AddScore(10);
            // act
            var result = employee.Result;
            //assert
            Assert.AreEqual(21, result);

        }
        [Test]
        public void WhenEmployeeCollectMixedRatings()
        {
            var employee = new Employee("Magda", "Wróbel", 20);
            employee.AddScore(10);
            employee.AddScore(10);
            employee.AddScore(9);
            employee.AddScore(-20);

            var result = employee.Result;

            Assert.AreEqual(9, result);
        }


        [Test]
        public void CheckUserAddScoreMethodWithMinusPoint()
        {
            var employee = new Employee("Dawid", "Kowalski", 40);
            employee.AddScore(-20);
            employee.AddScore(-20);
           
            

            var result = employee.Result;

            Assert.AreEqual(-40, result);


        }

            
    }
}