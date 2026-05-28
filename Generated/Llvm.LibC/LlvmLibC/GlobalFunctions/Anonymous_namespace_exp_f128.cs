using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_exp_f128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_18exp_f128Eddii")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::exp_f128(double, double, int, int)")]
	public unsafe static void Invoke([MangledName("agg.result")] Fputil_DyadicFloat_kt2kd4* Agg_result, [MangledName("x")][NativeType("double")] double X, [MangledName("kd")][NativeType("double")] double Kd, [MangledName("idx1")][NativeType("int")] int Idx1, [MangledName("idx2")][NativeType("int")] int Idx2)
	{
		double x = 0.0;
		double x2 = 0.0;
		double x3 = 0.0;
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd2 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd3 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd4 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd7 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd8 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd9 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd10 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd11 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd12 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd13 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd14 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd15 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd16 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd17 = default(Fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(8L, &x);
		x = Fputil_multiply_add_double.Invoke(Kd, -0.00016922538588914904, X);
		Llvm_lifetime_start_p0.Invoke(8L, &x2);
		x2 = Kd * 1.0256140311365355E-14;
		Llvm_lifetime_start_p0.Invoke(8L, &x3);
		x3 = Kd * 2.797449396191097E-24;
		Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
		unchecked
		{
			*(sbyte*)(&fputil_DyadicFloat_kt2kd) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd))[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd2, x);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd4, x2);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd5, x3);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd3, &fputil_DyadicFloat_kt2kd4, &fputil_DyadicFloat_kt2kd5);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd, &fputil_DyadicFloat_kt2kd2, &fputil_DyadicFloat_kt2kd3);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd6) = -86;
			sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 1;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd6))[1] = -1431655766;
			sbyte* ptr4 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 8;
			*(long*)ptr4 = -6148914691236517206L;
			((long*)ptr4)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd7, ((Fputil_TripleDouble*)EXP2_MID1.Pointer)[Idx1].Hi);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd9, ((Fputil_TripleDouble*)EXP2_MID1.Pointer)[Idx1].Mid);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd10, ((Fputil_TripleDouble*)EXP2_MID1.Pointer)[Idx1].Lo);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd9, &fputil_DyadicFloat_kt2kd10);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd8);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd11) = -86;
			sbyte* ptr5 = (sbyte*)(&fputil_DyadicFloat_kt2kd11) + 1;
			*ptr5 = -86;
			ptr5[1] = -86;
			ptr5[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd11))[1] = -1431655766;
			sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd11) + 8;
			*(long*)ptr6 = -6148914691236517206L;
			((long*)ptr6)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd12, ((Fputil_TripleDouble*)EXP2_MID2.Pointer)[Idx2].Hi);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd14, ((Fputil_TripleDouble*)EXP2_MID2.Pointer)[Idx2].Mid);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd15, ((Fputil_TripleDouble*)EXP2_MID2.Pointer)[Idx2].Lo);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd14, &fputil_DyadicFloat_kt2kd15);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd13);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd16);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd16) = -86;
			sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd16) + 1;
			*ptr7 = -86;
			ptr7[1] = -86;
			ptr7[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd16))[1] = -1431655766;
			sbyte* ptr8 = (sbyte*)(&fputil_DyadicFloat_kt2kd16) + 8;
			*(long*)ptr8 = -6148914691236517206L;
			((long*)ptr8)[1] = -6148914691236517206L;
			Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd16, &fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd11);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd17);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd17) = -86;
			sbyte* ptr9 = (sbyte*)(&fputil_DyadicFloat_kt2kd17) + 1;
			*ptr9 = -86;
			ptr9[1] = -86;
			ptr9[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd17))[1] = -1431655766;
			sbyte* ptr10 = (sbyte*)(&fputil_DyadicFloat_kt2kd17) + 8;
			*(long*)ptr10 = -6148914691236517206L;
			((long*)ptr10)[1] = -6148914691236517206L;
			Anonymous_namespace_poly_approx_f128_cq56ks.Invoke(&fputil_DyadicFloat_kt2kd17, &fputil_DyadicFloat_kt2kd);
			*(sbyte*)Agg_result = -86;
			sbyte* ptr11 = (sbyte*)Agg_result + 1;
			*ptr11 = -86;
			ptr11[1] = -86;
			ptr11[2] = -86;
			((int*)Agg_result)[1] = -1431655766;
			sbyte* ptr12 = (sbyte*)Agg_result + 8;
			*(long*)ptr12 = -6148914691236517206L;
			((long*)ptr12)[1] = -6148914691236517206L;
			Fputil_quick_mul_128ul.Invoke(Agg_result, &fputil_DyadicFloat_kt2kd16, &fputil_DyadicFloat_kt2kd17);
		}
		Agg_result->Exponent += unchecked((int)Kd) >> 12;
		Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd17);
		Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd16);
		Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
		Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
		Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
		Llvm_lifetime_end_p0.Invoke(8L, &x3);
		Llvm_lifetime_end_p0.Invoke(8L, &x2);
		Llvm_lifetime_end_p0.Invoke(8L, &x);
	}
}
