using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class anonymous_namespace_exp10_f128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_110exp10_f128Eddii")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::exp10_f128(double, double, int, int)")]
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_kt2kd4* agg_result, [NativeType("double")] double x, [NativeType("double")] double kd, [NativeType("int")] int idx1, [NativeType("int")] int idx2)
	{
		double x2 = 0.0;
		double x3 = 0.0;
		double x4 = 0.0;
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
		llvm_lifetime_start_p0.Invoke(8L, &x2);
		x2 = fputil_multiply_add_double.Invoke(kd, -7.349365128561658E-05, x);
		llvm_lifetime_start_p0.Invoke(8L, &x3);
		x3 = kd * 4.649201285808973E-16;
		llvm_lifetime_start_p0.Invoke(8L, &x4);
		x4 = kd * 1.1980559920951342E-26;
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
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd6, x2);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd8, x3);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd9, x4);
			fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd9);
			fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd5, &fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd7);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd10);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd10) = -86;
			sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd10) + 1;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd10))[1] = -1431655766;
			sbyte* ptr4 = (sbyte*)(&fputil_DyadicFloat_kt2kd10) + 8;
			*(long*)ptr4 = -6148914691236517206L;
			((long*)ptr4)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd11, ((fputil_TripleDouble*)EXP2_MID1.Pointer)[idx1].hi);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd13, ((fputil_TripleDouble*)EXP2_MID1.Pointer)[idx1].mid);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd14, ((fputil_TripleDouble*)EXP2_MID1.Pointer)[idx1].lo);
			fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd14);
			fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd10, &fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd12);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd15);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd15) = -86;
			sbyte* ptr5 = (sbyte*)(&fputil_DyadicFloat_kt2kd15) + 1;
			*ptr5 = -86;
			ptr5[1] = -86;
			ptr5[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd15))[1] = -1431655766;
			sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd15) + 8;
			*(long*)ptr6 = -6148914691236517206L;
			((long*)ptr6)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd16, ((fputil_TripleDouble*)EXP2_MID2.Pointer)[idx2].hi);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd18, ((fputil_TripleDouble*)EXP2_MID2.Pointer)[idx2].mid);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd19, ((fputil_TripleDouble*)EXP2_MID2.Pointer)[idx2].lo);
			fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd17, &fputil_DyadicFloat_kt2kd18, &fputil_DyadicFloat_kt2kd19);
			fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd15, &fputil_DyadicFloat_kt2kd16, &fputil_DyadicFloat_kt2kd17);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd20);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd20) = -86;
			sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd20) + 1;
			*ptr7 = -86;
			ptr7[1] = -86;
			ptr7[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd20))[1] = -1431655766;
			sbyte* ptr8 = (sbyte*)(&fputil_DyadicFloat_kt2kd20) + 8;
			*(long*)ptr8 = -6148914691236517206L;
			((long*)ptr8)[1] = -6148914691236517206L;
			fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd20, &fputil_DyadicFloat_kt2kd10, &fputil_DyadicFloat_kt2kd15);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd21);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd21) = -86;
			sbyte* ptr9 = (sbyte*)(&fputil_DyadicFloat_kt2kd21) + 1;
			*ptr9 = -86;
			ptr9[1] = -86;
			ptr9[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd21))[1] = -1431655766;
			sbyte* ptr10 = (sbyte*)(&fputil_DyadicFloat_kt2kd21) + 8;
			*(long*)ptr10 = -6148914691236517206L;
			((long*)ptr10)[1] = -6148914691236517206L;
			anonymous_namespace_poly_approx_f128_i3da78.Invoke(&fputil_DyadicFloat_kt2kd21, &fputil_DyadicFloat_kt2kd5);
			*(sbyte*)agg_result = -86;
			sbyte* ptr11 = (sbyte*)agg_result + 1;
			*ptr11 = -86;
			ptr11[1] = -86;
			ptr11[2] = -86;
			((int*)agg_result)[1] = -1431655766;
			sbyte* ptr12 = (sbyte*)agg_result + 8;
			*(long*)ptr12 = -6148914691236517206L;
			((long*)ptr12)[1] = -6148914691236517206L;
			fputil_quick_mul_128ul.Invoke(agg_result, &fputil_DyadicFloat_kt2kd20, &fputil_DyadicFloat_kt2kd21);
		}
		agg_result->exponent += unchecked((int)kd) >> 12;
		llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd21);
		llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd20);
		llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd15);
		llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd10);
		llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		llvm_lifetime_end_p0.Invoke(8L, &x4);
		llvm_lifetime_end_p0.Invoke(8L, &x3);
		llvm_lifetime_end_p0.Invoke(8L, &x2);
	}
}
