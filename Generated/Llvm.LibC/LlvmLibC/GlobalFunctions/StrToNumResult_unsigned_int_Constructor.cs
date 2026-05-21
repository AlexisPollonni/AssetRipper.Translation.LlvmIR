using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_unsigned_int_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIjEC2Ejli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned int>::StrToNumResult(unsigned int, long, int)")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int value, [NativeType("long")] long parsed_len, [NativeType("int")] int error)
	{
		unchecked
		{
			((StrToNumResult_imtnam*)@this)->value = value;
			((StrToNumResult_imtnam*)@this)->error = error;
			((StrToNumResult_imtnam*)@this)->parsed_len = parsed_len;
		}
	}
}
