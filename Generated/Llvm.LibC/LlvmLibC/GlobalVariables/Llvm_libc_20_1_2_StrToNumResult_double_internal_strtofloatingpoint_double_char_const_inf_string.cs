using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZZN19__llvm_libc_20_1_2_8internal18strtofloatingpointIdEENS_14StrToNumResultIT_EEPKcE10inf_string")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<double> __llvm_libc_20_1_2_::internal::strtofloatingpoint<double>(char const*)::inf_string")]
internal static partial class Llvm_libc_20_1_2_StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string
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

	unsafe static Llvm_libc_20_1_2_StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string()
	{
		Value = Str_124.Pointer;
	}
}
