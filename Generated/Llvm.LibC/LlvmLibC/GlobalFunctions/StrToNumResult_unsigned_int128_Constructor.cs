using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_unsigned_int128_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIoEC2Eoli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned __int128>::StrToNumResult(unsigned __int128, long, int)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value.coerce0")] long Value, [MangledName("value.coerce1")] long Parsed_len, [MangledName("parsed_len")][CleanName("Error")] long Error_hm8b8a, [MangledName("error")][CleanName("Error")] int Error_xz3rmz)
	{
		Int128 value = default(Int128);
		unchecked
		{
			*(long*)(&value) = Value;
			((long*)(&value))[1] = Parsed_len;
			((StrToNumResult_i4jxtt*)This)->Value = value;
			((StrToNumResult_i4jxtt*)This)->Error = Error_xz3rmz;
			((StrToNumResult_i4jxtt*)This)->Parsed_len = Error_hm8b8a;
		}
	}
}
