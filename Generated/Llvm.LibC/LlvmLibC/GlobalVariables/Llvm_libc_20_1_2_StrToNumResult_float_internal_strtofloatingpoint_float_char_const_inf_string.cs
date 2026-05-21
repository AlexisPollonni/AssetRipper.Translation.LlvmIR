using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZZN19__llvm_libc_20_1_2_8internal18strtofloatingpointIfEENS_14StrToNumResultIT_EEPKcE10inf_string")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<float> __llvm_libc_20_1_2_::internal::strtofloatingpoint<float>(char const*)::inf_string")]
internal static partial class Llvm_libc_20_1_2_StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string
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

	unsafe static Llvm_libc_20_1_2_StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string()
	{
		Value = Str_124.Pointer;
	}
}
