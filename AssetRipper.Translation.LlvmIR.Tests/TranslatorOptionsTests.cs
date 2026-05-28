namespace AssetRipper.Translation.LlvmIR.Tests;

public class TranslatorOptionsTests
{
	[Test]
	public async Task StripNamePrefix_MatchesCapitalizedLeadingPrefix()
	{
		TranslatorOptions options = new()
		{
			StripNamePrefixes = ["llvm_libc_20_1_2_"],
		};

		string result = options.StripNamePrefix("Llvm_libc_20_1_2_NumberPair");

		await Assert.That(result).IsEqualTo("NumberPair");
	}

	[Test]
	public async Task StripNamePrefix_CapitalizesLowercaseTailAfterStrip()
	{
		TranslatorOptions options = new()
		{
			StripNamePrefixes = ["llvm_libc_20_1_2_"],
		};

		string result = options.StripNamePrefix("Llvm_libc_20_1_2_app");

		await Assert.That(result).IsEqualTo("App");
	}

	[Test]
	public async Task StripNamePrefix_StillStripsMidNameOccurrences()
	{
		TranslatorOptions options = new()
		{
			StripNamePrefixes = ["llvm_libc_20_1_2_"],
		};

		string result = options.StripNamePrefix("Type_llvm_libc_20_1_2_NumberPair");

		await Assert.That(result).IsEqualTo("Type_NumberPair");
	}
}


