namespace AssetRipper.Translation.LlvmIR.Runtime.Attributes;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public sealed class MangledNameAttribute(string name) : NameAttribute(name) { }
