using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_internal_ExpandedFloat_long_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultINS_8internal13ExpandedFloatIeEEEC2ES3_")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::StrToNumResult(__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>)")]
	public unsafe static void Invoke([MangledName("this")] StrToNumResult_ggsbhp* This, [MangledName("value")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>")] void* Value)
	{
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Value, Value, 32L, isVolatile: false);
		This->Error = 0;
		This->Parsed_len = 0L;
	}
}
