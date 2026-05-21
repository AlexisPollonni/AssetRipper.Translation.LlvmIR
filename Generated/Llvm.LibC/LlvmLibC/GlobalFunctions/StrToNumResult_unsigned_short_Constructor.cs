using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_unsigned_short_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultItEC2Etli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned short>::StrToNumResult(unsigned short, long, int)")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned short")] short value, [NativeType("long")] long parsed_len, [NativeType("int")] int error)
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
