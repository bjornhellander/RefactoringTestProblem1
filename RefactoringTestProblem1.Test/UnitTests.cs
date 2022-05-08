using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using static RefactoringTestProblem1.Test.CSharpCodeRefactoringVerifier<
    RefactoringTestProblem1.MyCodeRefactoringProvider>;

namespace RefactoringTestProblem1.Test
{
    [TestClass]
    public class MyUnitTest
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var test = @"[||]";

            await VerifyRefactoringAsync(test, test);
        }
    }
}
