using InterviewQuestion;
namespace TestProject1
{
    public class Tests
    {
        private Solution solution;

        [SetUp]
        public void Setup()
        {
            solution = new Solution();
        }

        [Test]
        public void Valid()
        {
            Assert.IsTrue(solution.isValid("((()))"));
            Assert.IsTrue(solution.isValid("((()[]{}))"));
            Assert.IsTrue(solution.isValid("((()))[]{}{{(())}}"));
            Assert.IsTrue(solution.isValid("((()))"));
            Assert.IsTrue(solution.isValid("()[]{}()"));

        }

        [Test]
        public void Invalid()
        {
            Assert.IsFalse(solution.isValid("(()))"));
            Assert.IsFalse(solution.isValid("((()[)(]{}))"));
            Assert.IsFalse(solution.isValid("((()[{]{}{{(())}}"));
            Assert.IsFalse(solution.isValid("((())}{)"));
        }
        [Test]
        public void InvalidImpermisable()
        {
            Assert.IsFalse(solution.isValid("("));
            Assert.IsFalse(solution.isValid(""));
            Assert.IsFalse(solution.isValid("random string"));
        }
    }
}