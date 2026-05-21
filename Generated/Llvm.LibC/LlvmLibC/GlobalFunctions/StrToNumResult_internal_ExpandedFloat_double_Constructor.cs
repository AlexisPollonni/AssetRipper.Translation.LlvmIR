using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_internal_ExpandedFloat_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultINS_8internal13ExpandedFloatIdEEEC2ES3_")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::StrToNumResult(__llvm_libc_20_1_2_::internal::ExpandedFloat<double>)")]
	public unsafe static void Invoke(void* @this, [MangledName("value.coerce0")] long value, [MangledName("value.coerce1")] int value_coerce1)
	{
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv2 = default(internal_ExpandedFloat_k68bhv);
		unchecked
		{
			*(long*)(&internal_ExpandedFloat_k68bhv2) = value;
			((int*)(&internal_ExpandedFloat_k68bhv2))[2] = value_coerce1;
			llvm_memcpy_p0_p0_i64.Invoke(&((StrToNumResult_wpp2wp*)@this)->value, &internal_ExpandedFloat_k68bhv2, 16L, isVolatile: false);
			((StrToNumResult_wpp2wp*)@this)->error = 0;
			((StrToNumResult_wpp2wp*)@this)->parsed_len = 0L;
		}
	}
}
