using System;

namespace LlvmLibC.Helpers;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
internal sealed partial class InlineAssemblyAttribute(string assembly, string constraints) : Attribute
{
	public string Assembly { get; } = assembly;

	public string Constraints { get; } = constraints;
}
