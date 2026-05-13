namespace AssetRipper.Translation.LlvmIR.Runtime.Attributes;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public sealed class InlineAssemblyAttribute(string assembly, string constraints) : Attribute
{
	public string Assembly { get; } = assembly;
	public string Constraints { get; } = constraints;
}
