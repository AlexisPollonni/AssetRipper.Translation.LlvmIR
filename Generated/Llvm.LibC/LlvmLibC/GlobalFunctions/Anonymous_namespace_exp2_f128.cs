using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_exp2_f128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_19exp2_f128Ediii")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::exp2_f128(double, int, int, int)")]
	public unsafe static void Invoke([MangledName("agg.result")] Fputil_DyadicFloat_kt2kd4* Agg_result, [MangledName("x")][NativeType("double")] double X, [MangledName("hi")][NativeType("int")] int Hi, [MangledName("idx1")][NativeType("int")] int Idx1, [MangledName("idx2")][NativeType("int")] int Idx2)
	{
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
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd, X);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd2) = -86;
			sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd2) + 1;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd2))[1] = -1431655766;
			sbyte* ptr4 = (sbyte*)(&fputil_DyadicFloat_kt2kd2) + 8;
			*(long*)ptr4 = -6148914691236517206L;
			((long*)ptr4)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd3, ((Fputil_TripleDouble*)EXP2_MID1.Pointer)[Idx1].Hi);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd5, ((Fputil_TripleDouble*)EXP2_MID1.Pointer)[Idx1].Mid);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd6, ((Fputil_TripleDouble*)EXP2_MID1.Pointer)[Idx1].Lo);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd4, &fputil_DyadicFloat_kt2kd5, &fputil_DyadicFloat_kt2kd6);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd2, &fputil_DyadicFloat_kt2kd3, &fputil_DyadicFloat_kt2kd4);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd7) = -86;
			sbyte* ptr5 = (sbyte*)(&fputil_DyadicFloat_kt2kd7) + 1;
			*ptr5 = -86;
			ptr5[1] = -86;
			ptr5[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd7))[1] = -1431655766;
			sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd7) + 8;
			*(long*)ptr6 = -6148914691236517206L;
			((long*)ptr6)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd8, ((Fputil_TripleDouble*)EXP2_MID2.Pointer)[Idx2].Hi);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd10, ((Fputil_TripleDouble*)EXP2_MID2.Pointer)[Idx2].Mid);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd11, ((Fputil_TripleDouble*)EXP2_MID2.Pointer)[Idx2].Lo);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd9, &fputil_DyadicFloat_kt2kd10, &fputil_DyadicFloat_kt2kd11);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd9);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd12) = -86;
			sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd12) + 1;
			*ptr7 = -86;
			ptr7[1] = -86;
			ptr7[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd12))[1] = -1431655766;
			sbyte* ptr8 = (sbyte*)(&fputil_DyadicFloat_kt2kd12) + 8;
			*(long*)ptr8 = -6148914691236517206L;
			((long*)ptr8)[1] = -6148914691236517206L;
			Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd2, &fputil_DyadicFloat_kt2kd7);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd13);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd13) = -86;
			sbyte* ptr9 = (sbyte*)(&fputil_DyadicFloat_kt2kd13) + 1;
			*ptr9 = -86;
			ptr9[1] = -86;
			ptr9[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd13))[1] = -1431655766;
			sbyte* ptr10 = (sbyte*)(&fputil_DyadicFloat_kt2kd13) + 8;
			*(long*)ptr10 = -6148914691236517206L;
			((long*)ptr10)[1] = -6148914691236517206L;
			Anonymous_namespace_poly_approx_f128_3v5nkh.Invoke(&fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd);
			*(sbyte*)Agg_result = -86;
			sbyte* ptr11 = (sbyte*)Agg_result + 1;
			*ptr11 = -86;
			ptr11[1] = -86;
			ptr11[2] = -86;
			((int*)Agg_result)[1] = -1431655766;
			sbyte* ptr12 = (sbyte*)Agg_result + 8;
			*(long*)ptr12 = -6148914691236517206L;
			((long*)ptr12)[1] = -6148914691236517206L;
			Fputil_quick_mul_128ul.Invoke(Agg_result, &fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd13);
		}
		Agg_result->Exponent += Hi;
		Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd13);
		Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
		Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
		Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
		Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
	}
}
