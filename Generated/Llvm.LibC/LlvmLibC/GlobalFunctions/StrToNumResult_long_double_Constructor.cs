using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_long_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIeEC2Eeli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long double>::StrToNumResult(long double, long, int)")]
	public unsafe static void Invoke(void* @this, [NativeType("long double")] double value, [NativeType("long")] long parsed_len, [NativeType("int")] int error)
	{
		unchecked
		{
			((StrToNumResult_uytq62*)@this)->value = value;
			((StrToNumResult_uytq62*)@this)->error = error;
			((StrToNumResult_uytq62*)@this)->parsed_len = parsed_len;
		}
	}
}
