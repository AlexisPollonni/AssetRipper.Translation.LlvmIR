using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic11sincos_evalERKNS_6fputil11DyadicFloatILm128EEERS3_S6_")]
[DemangledName("__llvm_libc_20_1_2_::generic::sincos_eval(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>&)")]
internal static partial class generic_sincos_eval_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul
{
	public unsafe static void Invoke(void* u, void* sin_u, void* cos_u)
	{
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		InlineArray7_fputil_DyadicFloat_kt2kd4 inlineArray7_fputil_DyadicFloat_kt2kd = default(InlineArray7_fputil_DyadicFloat_kt2kd4);
		InlineArray7_fputil_DyadicFloat_kt2kd4 inlineArray7_fputil_DyadicFloat_kt2kd2 = default(InlineArray7_fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd7 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd8 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		unchecked
		{
			*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(&fputil_DyadicFloat_kt2kd5, u, u);
			llvm_lifetime_start_p0.Invoke(168L, &inlineArray7_fputil_DyadicFloat_kt2kd);
			llvm_memcpy_p0_p0_i64.Invoke(&inlineArray7_fputil_DyadicFloat_kt2kd, SIN_COEFFS.Pointer, 168L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(168L, &inlineArray7_fputil_DyadicFloat_kt2kd2);
			llvm_memcpy_p0_p0_i64.Invoke(&inlineArray7_fputil_DyadicFloat_kt2kd2, COS_COEFFS.Pointer, 168L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			cpp_enable_if_sizeof_fputil_DyadicFloat_128ul_8ul_fputil_DyadicFloat_128ul_type_fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(&fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd5, &inlineArray7_fputil_DyadicFloat_kt2kd, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd, sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd, (nint)2 * sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd, (nint)3 * sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd, (nint)4 * sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd, (nint)5 * sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd, (nint)6 * sizeof(fputil_DyadicFloat_kt2kd4))));
			fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(&fputil_DyadicFloat_kt2kd6, u, &fputil_DyadicFloat_kt2kd7);
			llvm_memcpy_p0_p0_i64.Invoke(sin_u, &fputil_DyadicFloat_kt2kd6, 24L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
			cpp_enable_if_sizeof_fputil_DyadicFloat_128ul_8ul_fputil_DyadicFloat_128ul_type_fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(&fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd5, &inlineArray7_fputil_DyadicFloat_kt2kd2, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd2, sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd2, (nint)2 * sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd2, (nint)3 * sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd2, (nint)4 * sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd2, (nint)5 * sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd2, (nint)6 * sizeof(fputil_DyadicFloat_kt2kd4))));
			llvm_memcpy_p0_p0_i64.Invoke(cos_u, &fputil_DyadicFloat_kt2kd8, 24L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
			llvm_lifetime_end_p0.Invoke(168L, &inlineArray7_fputil_DyadicFloat_kt2kd2);
			llvm_lifetime_end_p0.Invoke(168L, &inlineArray7_fputil_DyadicFloat_kt2kd);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		}
	}
}
