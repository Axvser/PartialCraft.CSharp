using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PartialCraft.CSharp;

namespace INPCGenerator;

[Generator(LanguageNames.CSharp)]
public class INPCGenerator : IncrementalCore<ClassDeclarationSyntax, INamedTypeSymbol>
{
    public INPCGenerator()
    {
        Weavers.Add(new INPCWeaver());
    }
}
