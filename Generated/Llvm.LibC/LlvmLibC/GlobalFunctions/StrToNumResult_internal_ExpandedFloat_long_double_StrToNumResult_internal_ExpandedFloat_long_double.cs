using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultINS_8internal13ExpandedFloatIeEEEC2ES3_")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::StrToNumResult(__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>)")]
internal static partial class StrToNumResult_internal_ExpandedFloat_long_double_StrToNumResult_internal_ExpandedFloat_long_double
{
	public unsafe static void Invoke(void* @this, void* value)
	{
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((StrToNumResult_ggsbhp*)@this)->value, value, 32L, isVolatile: false);
			((StrToNumResult_ggsbhp*)@this)->error = 0;
			((StrToNumResult_ggsbhp*)@this)->parsed_len = 0L;
		}
	}
}
