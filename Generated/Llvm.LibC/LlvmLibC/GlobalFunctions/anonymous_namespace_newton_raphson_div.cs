using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class anonymous_namespace_newton_raphson_div
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_118newton_raphson_divERKNS_6fputil11DyadicFloatILm128EEES3_d")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::newton_raphson_div(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, double)")]
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_kt2kd4* agg_result, [NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] fputil_DyadicFloat_kt2kd4* a, [NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>")] void* b, [NativeType("double")] double q)
	{
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(fputil_DyadicFloat_kt2kd4);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd7 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd8 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd9 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd10 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd11 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd12 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd13 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd14 = default(fputil_DyadicFloat_kt2kd4);
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
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd5, q);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			llvm_memset_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd6, 0, 1L, isVolatile: false);
			((int*)(&fputil_DyadicFloat_kt2kd6))[1] = -126;
			sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 8;
			*(long*)ptr3 = 0L;
			((long*)ptr3)[1] = long.MinValue;
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &((fputil_DyadicFloat_kt2kd4*)b)->sign, 1L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(source: (!Equals_fy8fvt.Invoke(anon_izyfb8.val, anon_izyfb9.val)) ? Sign_POS.Pointer : Sign_NEG.Pointer, destination: &((fputil_DyadicFloat_kt2kd4*)b)->sign, length: 1L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd7) = -86;
			sbyte* ptr4 = (sbyte*)(&fputil_DyadicFloat_kt2kd7) + 1;
			*ptr4 = -86;
			ptr4[1] = -86;
			ptr4[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd7))[1] = -1431655766;
			sbyte* ptr5 = (sbyte*)(&fputil_DyadicFloat_kt2kd7) + 8;
			*(long*)ptr5 = -6148914691236517206L;
			((long*)ptr5)[1] = -6148914691236517206L;
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd9, &fputil_DyadicFloat_kt2kd6, 24L, isVolatile: false);
			fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd10, (fputil_DyadicFloat_kt2kd4*)b, &fputil_DyadicFloat_kt2kd5);
			fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd9, &fputil_DyadicFloat_kt2kd10);
			fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd5, &fputil_DyadicFloat_kt2kd8);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd11) = -86;
			sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd11) + 1;
			*ptr6 = -86;
			ptr6[1] = -86;
			ptr6[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd11))[1] = -1431655766;
			sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd11) + 8;
			*(long*)ptr7 = -6148914691236517206L;
			((long*)ptr7)[1] = -6148914691236517206L;
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd6, 24L, isVolatile: false);
			fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd14, (fputil_DyadicFloat_kt2kd4*)b, &fputil_DyadicFloat_kt2kd7);
			fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd14);
			fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd12);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
			fputil_quick_mul_128ul.Invoke(agg_result, a, &fputil_DyadicFloat_kt2kd11);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		}
	}
}
