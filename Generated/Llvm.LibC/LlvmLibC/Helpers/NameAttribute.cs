using System;

namespace LlvmLibC.Helpers;

internal abstract partial class NameAttribute(string name) : Attribute
{
	public string Name { get; } = name;
}
