namespace AssetRipper.Translation.LlvmIR.Runtime.Attributes;

/// <summary>
/// Indicates that an intrinsic method might "throw" an emulated exception.
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class MightThrowAttribute : Attribute { }
