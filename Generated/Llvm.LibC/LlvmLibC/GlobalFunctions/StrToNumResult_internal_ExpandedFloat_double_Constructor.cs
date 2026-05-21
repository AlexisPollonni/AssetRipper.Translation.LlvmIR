using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_internal_ExpandedFloat_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultINS_8internal13ExpandedFloatIdEEEC2ES3_")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::StrToNumResult(__llvm_libc_20_1_2_::internal::ExpandedFloat<double>)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value.coerce0")] long Value, [MangledName("value.coerce1")] int Value_coerce1)
	{
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv) = Value;
			((int*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv))[2] = Value_coerce1;
			Llvm_memcpy_p0_p0_i64.Invoke(&((Llvm_libc_20_1_2_StrToNumResult_wpp2wp*)This)->Value, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv, 16L, isVolatile: false);
			((Llvm_libc_20_1_2_StrToNumResult_wpp2wp*)This)->Error = 0;
			((Llvm_libc_20_1_2_StrToNumResult_wpp2wp*)This)->Parsed_len = 0L;
		}
	}
}
