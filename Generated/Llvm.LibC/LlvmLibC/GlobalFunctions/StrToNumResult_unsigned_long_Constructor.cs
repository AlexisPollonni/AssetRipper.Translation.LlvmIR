using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultImEC2Emli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned long>::StrToNumResult(unsigned long, long, int)")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned long")] long value, [NativeType("long")] long parsed_len, [NativeType("int")] int error)
	{
		unchecked
		{
			((StrToNumResult_gbeb3a*)@this)->value = value;
			((StrToNumResult_gbeb3a*)@this)->error = error;
			((StrToNumResult_gbeb3a*)@this)->parsed_len = parsed_len;
		}
	}
}
