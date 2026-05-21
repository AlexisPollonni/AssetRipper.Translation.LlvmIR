using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_log10_accurate
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114log10_accurateEiid")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::log10_accurate(int, int, double)")]
	public unsafe static double Invoke([MangledName("e_x")][NativeType("int")] int E_x, [MangledName("index")][NativeType("int")] int Index, [MangledName("m_x")][NativeType("double")] double M_x)
	{
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd11 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd12 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd13 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd14 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd15 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd16 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd18 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd19 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd21 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd22 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
		unchecked
		{
			*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) = -86;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd))[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_float_0.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, E_x);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2);
			*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2) = -86;
			sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2) + 1;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2))[1] = -1431655766;
			sbyte* ptr4 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2) + 8;
			*(long*)ptr4 = -6148914691236517206L;
			((long*)ptr4)[1] = -6148914691236517206L;
			Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2, Llvm_libc_20_1_2_anonymous_namespace_LOG10_2.Pointer, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2, 24L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5, (byte*)Llvm_libc_20_1_2_anonymous_namespace_LOG10_TABLE.Pointer + (nint)Index * (nint)sizeof(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3, 24L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6);
			*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6) = -86;
			sbyte* ptr5 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6) + 1;
			*ptr5 = -86;
			ptr5[1] = -86;
			ptr5[2] = -86;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6))[1] = -1431655766;
			sbyte* ptr6 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6) + 8;
			*(long*)ptr6 = -6148914691236517206L;
			((long*)ptr6)[1] = -6148914691236517206L;
			Llvm_libc_20_1_2_log_range_reduction.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6, M_x, Llvm_libc_20_1_2_anonymous_namespace_LOG10_TABLE.Pointer, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7);
			*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7) = -86;
			sbyte* ptr7 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7) + 1;
			*ptr7 = -86;
			ptr7[1] = -86;
			ptr7[2] = -86;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7))[1] = -1431655766;
			sbyte* ptr8 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7) + 8;
			*(long*)ptr8 = -6148914691236517206L;
			((long*)ptr8)[1] = -6148914691236517206L;
			Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6, (Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4*)Llvm_libc_20_1_2_anonymous_namespace_BIG_COEFFS_33.Pointer);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, 24L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd11, (byte*)Llvm_libc_20_1_2_anonymous_namespace_BIG_COEFFS_33.Pointer + sizeof(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd11);
			Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8, 24L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd12);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd13);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd14, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, 24L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd15, (byte*)Llvm_libc_20_1_2_anonymous_namespace_BIG_COEFFS_33.Pointer + (nint)2 * sizeof(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd13, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd14, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd15);
			Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd12, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd13);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd12, 24L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd13);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd12);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd16);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd18, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, 24L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd19, (byte*)Llvm_libc_20_1_2_anonymous_namespace_BIG_COEFFS_33.Pointer + (nint)3 * sizeof(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd18, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd19);
			Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd16, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd16, 24L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd17);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd16);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20);
			*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20) = -86;
			sbyte* ptr9 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20) + 1;
			*ptr9 = -86;
			ptr9[1] = -86;
			ptr9[2] = -86;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20))[1] = -1431655766;
			sbyte* ptr10 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20) + 8;
			*(long*)ptr10 = -6148914691236517206L;
			((long*)ptr10)[1] = -6148914691236517206L;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd21, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2, 24L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd22, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd21, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd22);
			double result = DyadicFloat_128ul_Double_double_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd20);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
			return result;
		}
	}
}
