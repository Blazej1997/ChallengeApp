namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenAddScore_ShouldHaveResult()
        {
            //attract
            var employee = new Employee("Marcin", "Kowalski", 28);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(0);
            employee.AddScore(10);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(21, result);
        }



        [Test]
        public void WhenEmployeeCollectMixedRating()
        {
            //attract
            var employee = new Employee("Magda", "Wrobel", 20);
            employee.AddScore(10);
            employee.AddScore(10);
            employee.AddScore(9);
            employee.AddScore(-20);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(9, result);
        }




        [Test]
        public void CheckUserAddScoreMethofWithMinusPoint()
        {
            //attract
            var employee = new Employee("Dawid", "Kowalski", 40);
            employee.AddScore(-20);
            employee.AddScore(-20);
            
            

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-40, result);
        }
    }
}