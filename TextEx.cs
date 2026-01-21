using Microsoft.CodeAnalysis;
using System;
using System.Text;

namespace PartialCraft.CSharp;

public static class TextEx
{
    public static void AppendIndentedLine(this StringBuilder builder, int depth, string text) => builder.AppendLine(new string(' ', depth * 4) + text);

    public static string GetDefaultValue(this Tuple<string,bool> context)
    {
        if (context.Item2)
        {
            return "null";
        }
        var baseTypeName = context.Item1.TrimEnd('?');
        return baseTypeName switch
        {
            "bool" => "false",
            "int" or "long" or "float" or "double" or "decimal" => "0",
            "string" => "string.Empty",
            _ => $"default({baseTypeName})"
        };
    }
}
