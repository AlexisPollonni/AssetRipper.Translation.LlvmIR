namespace AssetRipper.Translation.LlvmIR.Runtime.Attributes;

public abstract class NameAttribute(string name) : Attribute
{
	public string Name { get; } = name;
}
