using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_19exp2_f128Ediii")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::exp2_f128(double, int, int, int)")]
internal static partial class anonymous_namespace_exp2_f128_double_int_int_int
{
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_kt2kd4* agg_result, double x, int hi, int idx1, int idx2)
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
			fputil_DyadicFloat_128ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_kt2kd5, x);
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
			fputil_DyadicFloat_128ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_kt2kd7, ((fputil_TripleDouble*)EXP2_MID1.Pointer)[idx1].hi);
			fputil_DyadicFloat_128ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_kt2kd9, ((fputil_TripleDouble*)EXP2_MID1.Pointer)[idx1].mid);
			fputil_DyadicFloat_128ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_kt2kd10, ((fputil_TripleDouble*)EXP2_MID1.Pointer)[idx1].lo);
			fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd9, &fputil_DyadicFloat_kt2kd10);
			fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd8);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd11) = -86;
			sbyte* ptr5 = (sbyte*)(&fputil_DyadicFloat_kt2kd11) + 1;
			*ptr5 = -86;
			ptr5[1] = -86;
			ptr5[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd11))[1] = -1431655766;
			sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd11) + 8;
			*(long*)ptr6 = -6148914691236517206L;
			((long*)ptr6)[1] = -6148914691236517206L;
			fputil_DyadicFloat_128ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_kt2kd12, ((fputil_TripleDouble*)EXP2_MID2.Pointer)[idx2].hi);
			fputil_DyadicFloat_128ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_kt2kd14, ((fputil_TripleDouble*)EXP2_MID2.Pointer)[idx2].mid);
			fputil_DyadicFloat_128ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_kt2kd15, ((fputil_TripleDouble*)EXP2_MID2.Pointer)[idx2].lo);
			fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd14, &fputil_DyadicFloat_kt2kd15);
			fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd13);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd16);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd16) = -86;
			sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd16) + 1;
			*ptr7 = -86;
			ptr7[1] = -86;
			ptr7[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd16))[1] = -1431655766;
			sbyte* ptr8 = (sbyte*)(&fputil_DyadicFloat_kt2kd16) + 8;
			*(long*)ptr8 = -6148914691236517206L;
			((long*)ptr8)[1] = -6148914691236517206L;
			fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(&fputil_DyadicFloat_kt2kd16, &fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd11);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd17);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd17) = -86;
			sbyte* ptr9 = (sbyte*)(&fputil_DyadicFloat_kt2kd17) + 1;
			*ptr9 = -86;
			ptr9[1] = -86;
			ptr9[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd17))[1] = -1431655766;
			sbyte* ptr10 = (sbyte*)(&fputil_DyadicFloat_kt2kd17) + 8;
			*(long*)ptr10 = -6148914691236517206L;
			((long*)ptr10)[1] = -6148914691236517206L;
			anonymous_namespace_poly_approx_f128_fputil_DyadicFloat_128ul_const_40.Invoke(&fputil_DyadicFloat_kt2kd17, &fputil_DyadicFloat_kt2kd5);
			*(sbyte*)agg_result = -86;
			sbyte* ptr11 = (sbyte*)agg_result + 1;
			*ptr11 = -86;
			ptr11[1] = -86;
			ptr11[2] = -86;
			((int*)agg_result)[1] = -1431655766;
			sbyte* ptr12 = (sbyte*)agg_result + 8;
			*(long*)ptr12 = -6148914691236517206L;
			((long*)ptr12)[1] = -6148914691236517206L;
			fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(agg_result, &fputil_DyadicFloat_kt2kd16, &fputil_DyadicFloat_kt2kd17);
		}
		agg_result->exponent += hi;
		llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd17);
		llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd16);
		llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
		llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
		llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
	}
}
