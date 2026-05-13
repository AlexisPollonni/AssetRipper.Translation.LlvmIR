namespace AssetRipper.Translation.LlvmIR.Runtime;

public sealed class FatalException : Exception
{
	public FatalException() { }

	public FatalException(string? message)
		: base(message) { }
}
