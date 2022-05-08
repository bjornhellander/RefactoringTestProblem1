using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeRefactorings;
using System.Composition;
using System.Threading.Tasks;

namespace RefactoringTestProblem1
{
    [ExportCodeRefactoringProvider(LanguageNames.CSharp, Name = nameof(MyCodeRefactoringProvider)), Shared]
    public class MyCodeRefactoringProvider : CodeRefactoringProvider
    {
        public sealed override Task ComputeRefactoringsAsync(CodeRefactoringContext context)
        {
            return Task.CompletedTask;
        }
    }
}
