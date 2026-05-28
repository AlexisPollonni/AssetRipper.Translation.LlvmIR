using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_internal_ExpandedFloat_float_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultINS_8internal13ExpandedFloatIfEEEC2ES3_")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::StrToNumResult(__llvm_libc_20_1_2_::internal::ExpandedFloat<float>)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value.coerce")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<float>")] long Value)
	{
		Internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up = default(Internal_ExpandedFloat_i7t5up);
		unchecked
		{
			*(long*)(&internal_ExpandedFloat_i7t5up) = Value;
			Llvm_memcpy_p0_p0_i64.Invoke(&((StrToNumResult_kkgahp*)This)->Value, &internal_ExpandedFloat_i7t5up, 8L, isVolatile: false);
			((StrToNumResult_kkgahp*)This)->Error = 0;
			((StrToNumResult_kkgahp*)This)->Parsed_len = 0L;
		}
	}
}
