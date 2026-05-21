using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIlEC2Elli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long>::StrToNumResult(long, long, int)")]
	public unsafe static void Invoke(void* @this, [NativeType("long")] long value, [NativeType("long")] long parsed_len, [NativeType("int")] int error)
	{
		unchecked
		{
			((StrToNumResult_gbeb3a*)@this)->value = value;
			((StrToNumResult_gbeb3a*)@this)->error = error;
			((StrToNumResult_gbeb3a*)@this)->parsed_len = parsed_len;
		}
	}
}
