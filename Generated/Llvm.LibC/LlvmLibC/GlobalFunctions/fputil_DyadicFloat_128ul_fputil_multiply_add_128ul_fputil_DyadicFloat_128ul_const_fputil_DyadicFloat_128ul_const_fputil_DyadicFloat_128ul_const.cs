using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12multiply_addILm128EEENS0_11DyadicFloatIXT_EEERKS3_S5_S5_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> __llvm_libc_20_1_2_::fputil::multiply_add<128ul>(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&)")]
internal static partial class fputil_DyadicFloat_128ul_fputil_multiply_add_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const
{
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_kt2kd4* agg_result, fputil_DyadicFloat_kt2kd4* a, fputil_DyadicFloat_kt2kd4* b, fputil_DyadicFloat_kt2kd4* c)
	{
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(fputil_DyadicFloat_kt2kd4);
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd5, c, 24L, isVolatile: false);
		fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(&fputil_DyadicFloat_kt2kd6, a, b);
		fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(agg_result, &fputil_DyadicFloat_kt2kd5, &fputil_DyadicFloat_kt2kd6);
	}
}
