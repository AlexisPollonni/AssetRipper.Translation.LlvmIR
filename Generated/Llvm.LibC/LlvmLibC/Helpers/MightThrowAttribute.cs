using System;

namespace LlvmLibC.Helpers;

[AttributeUsage(AttributeTargets.Method)]
internal sealed partial class MightThrowAttribute : Attribute
{
}
