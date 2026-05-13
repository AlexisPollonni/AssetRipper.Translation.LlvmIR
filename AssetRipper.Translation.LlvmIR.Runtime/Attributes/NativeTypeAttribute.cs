namespace AssetRipper.Translation.LlvmIR.Runtime.Attributes;

/// <summary>
/// The source code type name of the attributed entity.
/// </summary>
[AttributeUsage(AttributeTargets.All)]
public sealed class NativeTypeAttribute(string name) : NameAttribute(name) { }
