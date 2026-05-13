using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultItEC2Etli")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned short>::StrToNumResult(unsigned short, long, int)")]
internal static partial class StrToNumResult_unsigned_short_StrToNumResult_unsigned_short_long_int
{
	public unsafe static void Invoke(void* @this, short value, long parsed_len, int error)
	{
		short value2 = value;
		unchecked
		{
			((StrToNumResult_wwcts2*)@this)->value = value2;
			((StrToNumResult_wwcts2*)@this)->error = error;
			((StrToNumResult_wwcts2*)@this)->parsed_len = parsed_len;
		}
	}
}
