namespace DemoTest
{
    public class Tests
    {
        UserService.AuthenticationResult Response { get; set; }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Starting Auth Testing ..");
            //using (var client = new UserService.SessionManagerClient())
            //{
            //    this.Response = client.AuthByIdNumber(Guid.Parse(""), "", "", "");
            //}
        }

        [Test]
        public void UserDataReturned()
        {
            Assert.Greater(this.Response.UserID, 0);
            Assert.Pass();
        }

        [Test]
        public void PersonalNoReturned()
        {
            Assert.IsNotEmpty(this.Response.PersonalNo);
            Assert.Pass();
        }

        [Test]
        public void IsPersonalNumberValid()
        {
            Int64 number = 0;
            Assert.IsTrue(Int64.TryParse(this.Response.PersonalNo, out number));
            Assert.Pass();
        }

        [Test]
        public void IsPersonFromTbilisi()
        {
            Assert.IsTrue(this.Response.PersonalNo.Substring(0, 1) == "0");
        }
    }
}