using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class LargeRangeReduction_accurate
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_19LargeRangeReduction8accurateEv")]
	[DemangledName("__llvm_libc_20_1_2_::LargeRangeReduction::accurate() const")]
	public unsafe static void Invoke([MangledName("agg.result")] Fputil_DyadicFloat_kt2kd4* Agg_result, [MangledName("this")] LargeRangeReduction* This)
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
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd14 = default(Fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
		Llvm_memset_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd, 0, 1L, isVolatile: false);
		unchecked
		{
			((int*)(&fputil_DyadicFloat_kt2kd))[1] = -133;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 8;
			*(long*)ptr = -4267615245585081135L;
			((long*)ptr)[1] = -3958705157555305932L;
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd2) = -86;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd2) + 1;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd2))[1] = -1431655766;
			sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd2) + 8;
			*(long*)ptr3 = -6148914691236517206L;
			((long*)ptr3)[1] = -6148914691236517206L;
			double x_reduced = This->X_reduced;
			long num = (uint)This->Idx;
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd2, x_reduced * ((double*)((byte*)ONE_TWENTY_EIGHT_OVER_PI.Pointer + (nint)num * sizeof(InlineArray4_Double)))[3L]);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd3);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd3) = -86;
			sbyte* ptr4 = (sbyte*)(&fputil_DyadicFloat_kt2kd3) + 1;
			*ptr4 = -86;
			ptr4[1] = -86;
			ptr4[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd3))[1] = -1431655766;
			sbyte* ptr5 = (sbyte*)(&fputil_DyadicFloat_kt2kd3) + 8;
			*(long*)ptr5 = -6148914691236517206L;
			((long*)ptr5)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd4, This->Y_lo);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd5, &fputil_DyadicFloat_kt2kd2, 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd3, &fputil_DyadicFloat_kt2kd4, &fputil_DyadicFloat_kt2kd5);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd6) = -86;
			sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 1;
			*ptr6 = -86;
			ptr6[1] = -86;
			ptr6[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd6))[1] = -1431655766;
			sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 8;
			*(long*)ptr7 = -6148914691236517206L;
			((long*)ptr7)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd7, This->Y_mid.Lo);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd3, 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd8);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd9);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd9) = -86;
			sbyte* ptr8 = (sbyte*)(&fputil_DyadicFloat_kt2kd9) + 1;
			*ptr8 = -86;
			ptr8[1] = -86;
			ptr8[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd9))[1] = -1431655766;
			sbyte* ptr9 = (sbyte*)(&fputil_DyadicFloat_kt2kd9) + 8;
			*(long*)ptr9 = -6148914691236517206L;
			((long*)ptr9)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd10, This->Y_hi);
			DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd11, This->Y_mid.Hi);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd9, &fputil_DyadicFloat_kt2kd10, &fputil_DyadicFloat_kt2kd11);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd12) = -86;
			sbyte* ptr10 = (sbyte*)(&fputil_DyadicFloat_kt2kd12) + 1;
			*ptr10 = -86;
			ptr10[1] = -86;
			ptr10[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd12))[1] = -1431655766;
			sbyte* ptr11 = (sbyte*)(&fputil_DyadicFloat_kt2kd12) + 8;
			*(long*)ptr11 = -6148914691236517206L;
			((long*)ptr11)[1] = -6148914691236517206L;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd9, 24L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd14, &fputil_DyadicFloat_kt2kd6, 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd14);
			Fputil_quick_mul_128ul.Invoke(Agg_result, &fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd9);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd3);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
		}
	}
}
