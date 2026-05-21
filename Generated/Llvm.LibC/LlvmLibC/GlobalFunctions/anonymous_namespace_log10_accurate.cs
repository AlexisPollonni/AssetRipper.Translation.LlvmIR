using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class anonymous_namespace_log10_accurate
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114log10_accurateEiid")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::log10_accurate(int, int, double)")]
	public unsafe static double Invoke([NativeType("int")] int e_x, [NativeType("int")] int index, [NativeType("double")] double m_x)
	{
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd7 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd8 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd9 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd10 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd11 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd12 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd13 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd14 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd15 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd16 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd17 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd18 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd19 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd20 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd21 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd22 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd23 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd24 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd25 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd26 = default(fputil_DyadicFloat_kt2kd4);
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
			DyadicFloat_128ul_DyadicFloat_float_0.Invoke(&fputil_DyadicFloat_kt2kd5, e_x);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd6) = -86;
			sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 1;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd6))[1] = -1431655766;
			sbyte* ptr4 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 8;
			*(long*)ptr4 = -6148914691236517206L;
			((long*)ptr4)[1] = -6148914691236517206L;
			fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd6, anonymous_namespace_LOG10_2.Pointer, &fputil_DyadicFloat_kt2kd5);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd6, 24L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd9, (byte*)anonymous_namespace_LOG10_TABLE.Pointer + (nint)index * (nint)sizeof(fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd9);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd7, 24L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd10);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd10) = -86;
			sbyte* ptr5 = (sbyte*)(&fputil_DyadicFloat_kt2kd10) + 1;
			*ptr5 = -86;
			ptr5[1] = -86;
			ptr5[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd10))[1] = -1431655766;
			sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd10) + 8;
			*(long*)ptr6 = -6148914691236517206L;
			((long*)ptr6)[1] = -6148914691236517206L;
			log_range_reduction.Invoke(&fputil_DyadicFloat_kt2kd10, m_x, anonymous_namespace_LOG10_TABLE.Pointer, &fputil_DyadicFloat_kt2kd6);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd11) = -86;
			sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd11) + 1;
			*ptr7 = -86;
			ptr7[1] = -86;
			ptr7[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd11))[1] = -1431655766;
			sbyte* ptr8 = (sbyte*)(&fputil_DyadicFloat_kt2kd11) + 8;
			*(long*)ptr8 = -6148914691236517206L;
			((long*)ptr8)[1] = -6148914691236517206L;
			fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd10, (fputil_DyadicFloat_kt2kd4*)anonymous_namespace_BIG_COEFFS_33.Pointer);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd13);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd14, &fputil_DyadicFloat_kt2kd11, 24L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd15, (byte*)anonymous_namespace_BIG_COEFFS_33.Pointer + sizeof(fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd14, &fputil_DyadicFloat_kt2kd15);
			fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd10, &fputil_DyadicFloat_kt2kd13);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd12, 24L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd13);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd16);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd17);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd18, &fputil_DyadicFloat_kt2kd11, 24L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd19, (byte*)anonymous_namespace_BIG_COEFFS_33.Pointer + (nint)2 * sizeof(fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd17, &fputil_DyadicFloat_kt2kd18, &fputil_DyadicFloat_kt2kd19);
			fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd16, &fputil_DyadicFloat_kt2kd10, &fputil_DyadicFloat_kt2kd17);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd16, 24L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd17);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd16);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd20);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd21);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd22, &fputil_DyadicFloat_kt2kd11, 24L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd23, (byte*)anonymous_namespace_BIG_COEFFS_33.Pointer + (nint)3 * sizeof(fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd21, &fputil_DyadicFloat_kt2kd22, &fputil_DyadicFloat_kt2kd23);
			fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd20, &fputil_DyadicFloat_kt2kd10, &fputil_DyadicFloat_kt2kd21);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd20, 24L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd21);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd20);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd24);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd24) = -86;
			sbyte* ptr9 = (sbyte*)(&fputil_DyadicFloat_kt2kd24) + 1;
			*ptr9 = -86;
			ptr9[1] = -86;
			ptr9[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd24))[1] = -1431655766;
			sbyte* ptr10 = (sbyte*)(&fputil_DyadicFloat_kt2kd24) + 8;
			*(long*)ptr10 = -6148914691236517206L;
			((long*)ptr10)[1] = -6148914691236517206L;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd25, &fputil_DyadicFloat_kt2kd6, 24L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd26, &fputil_DyadicFloat_kt2kd11, 24L, isVolatile: false);
			fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd24, &fputil_DyadicFloat_kt2kd25, &fputil_DyadicFloat_kt2kd26);
			double result = DyadicFloat_128ul_double_double_void.Invoke(&fputil_DyadicFloat_kt2kd24);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd24);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd10);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			return result;
		}
	}
}
