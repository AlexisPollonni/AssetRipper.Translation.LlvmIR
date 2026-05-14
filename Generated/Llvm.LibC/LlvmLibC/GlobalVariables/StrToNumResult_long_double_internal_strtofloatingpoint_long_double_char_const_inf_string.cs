using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZZN19__llvm_libc_20_1_2_8internal18strtofloatingpointIeEENS_14StrToNumResultIT_EEPKcE10inf_string")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long double> __llvm_libc_20_1_2_::internal::strtofloatingpoint<long double>(char const*)::inf_string")]
internal static partial class StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string
{
	private unsafe static void* __value;

	public unsafe static void* Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string()
	{
		Value = str_124.Pointer;
	}
}
