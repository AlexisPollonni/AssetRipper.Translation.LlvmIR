using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_multiply_add_128ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12multiply_addILm128EEENS0_11DyadicFloatIXT_EEERKS3_S5_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> __llvm_libc_20_1_2_::fputil::multiply_add<128ul>(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>")]
	public unsafe static void Invoke([MangledName("agg.result")] Fputil_DyadicFloat_kt2kd4* Agg_result, [MangledName("a")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Fputil_DyadicFloat_kt2kd4* A, [MangledName("b")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Fputil_DyadicFloat_kt2kd4* B, [MangledName("c")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Fputil_DyadicFloat_kt2kd4* C)
	{
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd2 = default(Fputil_DyadicFloat_kt2kd4);
		Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd, C, 24L, isVolatile: false);
		Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd2, A, B);
		Fputil_quick_add_128ul.Invoke(Agg_result, &fputil_DyadicFloat_kt2kd, &fputil_DyadicFloat_kt2kd2);
	}
}
