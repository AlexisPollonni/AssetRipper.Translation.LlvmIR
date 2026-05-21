using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_newton_raphson_div
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_118newton_raphson_divERKNS_6fputil11DyadicFloatILm128EEES3_d")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::newton_raphson_div(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, double)")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* Agg_result, [MangledName("a")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* A, [MangledName("b")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>")] void* B, [MangledName("q")][NativeType("double")] double Q)
	{
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
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
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, Q);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2);
			Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2, 0, 1L, isVolatile: false);
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2))[1] = -126;
			sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2) + 8;
			*(long*)ptr3 = 0L;
			((long*)ptr3)[1] = long.MinValue;
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &((Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4*)B)->Sign, 1L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(source: (!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb.Val, anon_izyfb2.Val)) ? Llvm_libc_20_1_2_Sign_POS.Pointer : Llvm_libc_20_1_2_Sign_NEG.Pointer, destination: &((Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4*)B)->Sign, length: 1L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3);
			*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3) = -86;
			sbyte* ptr4 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3) + 1;
			*ptr4 = -86;
			ptr4[1] = -86;
			ptr4[2] = -86;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3))[1] = -1431655766;
			sbyte* ptr5 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3) + 8;
			*(long*)ptr5 = -6148914691236517206L;
			((long*)ptr5)[1] = -6148914691236517206L;
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2, 24L, isVolatile: false);
			Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6, (Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4*)B, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
			Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6);
			Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7);
			*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7) = -86;
			sbyte* ptr6 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7) + 1;
			*ptr6 = -86;
			ptr6[1] = -86;
			ptr6[2] = -86;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7))[1] = -1431655766;
			sbyte* ptr7 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7) + 8;
			*(long*)ptr7 = -6148914691236517206L;
			((long*)ptr7)[1] = -6148914691236517206L;
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2, 24L, isVolatile: false);
			Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10, (Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4*)B, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3);
			Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10);
			Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8);
			Fputil_quick_mul_128ul.Invoke(Agg_result, A, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
		}
	}
}
