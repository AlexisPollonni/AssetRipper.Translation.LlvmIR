using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIoEC2Eoli")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned __int128>::StrToNumResult(unsigned __int128, long, int)")]
internal static partial class StrToNumResult_unsigned_int128_StrToNumResult_unsigned_int128_long_int
{
	public unsafe static void Invoke(void* @this, [MangledName("value.coerce0")] long value, [MangledName("value.coerce1")] long parsed_len, [MangledName("parsed_len")][CleanName("error")] long error_hm8b8a, [MangledName("error")][CleanName("error")] int error_xz3rmz)
	{
		Int128 value2 = default(Int128);
		unchecked
		{
			*(long*)(&value2) = value;
			((long*)(&value2))[1] = parsed_len;
			((StrToNumResult_i4jxtt*)@this)->value = value2;
			((StrToNumResult_i4jxtt*)@this)->error = error_xz3rmz;
			((StrToNumResult_i4jxtt*)@this)->parsed_len = error_hm8b8a;
		}
	}
}
