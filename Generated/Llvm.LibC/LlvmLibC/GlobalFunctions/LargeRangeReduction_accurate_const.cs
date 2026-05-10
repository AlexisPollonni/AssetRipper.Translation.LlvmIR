using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_19LargeRangeReduction8accurateEv")]
[DemangledName("__llvm_libc_20_1_2_::LargeRangeReduction::accurate() const")]
internal static partial class LargeRangeReduction_accurate_const
{
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_kt2kd4* agg_result, void* @this)
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
		llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		llvm_memset_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd5, 0, 1L, isVolatile: false);
		unchecked
		{
			((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -133;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
			*(long*)ptr = -4267615245585081135L;
			((long*)ptr)[1] = -3958705157555305932L;
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd6) = -86;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 1;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd6))[1] = -1431655766;
			sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 8;
			*(long*)ptr3 = -6148914691236517206L;
			((long*)ptr3)[1] = -6148914691236517206L;
			double x_reduced = ((LargeRangeReduction*)@this)->x_reduced;
			long num = (uint)((LargeRangeReduction*)@this)->idx;
			fputil_DyadicFloat_128ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_kt2kd6, x_reduced * ((double*)((byte*)ONE_TWENTY_EIGHT_OVER_PI.Pointer + (nint)num * sizeof(InlineArray4_Double)))[3L]);
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
			fputil_DyadicFloat_128ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_kt2kd8, ((LargeRangeReduction*)@this)->y_lo);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd9, &fputil_DyadicFloat_kt2kd6, 24L, isVolatile: false);
			fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd9);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd10);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd10) = -86;
			sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd10) + 1;
			*ptr6 = -86;
			ptr6[1] = -86;
			ptr6[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd10))[1] = -1431655766;
			sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd10) + 8;
			*(long*)ptr7 = -6148914691236517206L;
			((long*)ptr7)[1] = -6148914691236517206L;
			fputil_DyadicFloat_128ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_kt2kd11, ((LargeRangeReduction*)@this)->y_mid.lo);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd7, 24L, isVolatile: false);
			fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd10, &fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd12);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd13);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd13) = -86;
			sbyte* ptr8 = (sbyte*)(&fputil_DyadicFloat_kt2kd13) + 1;
			*ptr8 = -86;
			ptr8[1] = -86;
			ptr8[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd13))[1] = -1431655766;
			sbyte* ptr9 = (sbyte*)(&fputil_DyadicFloat_kt2kd13) + 8;
			*(long*)ptr9 = -6148914691236517206L;
			((long*)ptr9)[1] = -6148914691236517206L;
			fputil_DyadicFloat_128ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_kt2kd14, ((LargeRangeReduction*)@this)->y_hi);
			fputil_DyadicFloat_128ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_kt2kd15, ((LargeRangeReduction*)@this)->y_mid.hi);
			fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd14, &fputil_DyadicFloat_kt2kd15);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd16);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd16) = -86;
			sbyte* ptr10 = (sbyte*)(&fputil_DyadicFloat_kt2kd16) + 1;
			*ptr10 = -86;
			ptr10[1] = -86;
			ptr10[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd16))[1] = -1431655766;
			sbyte* ptr11 = (sbyte*)(&fputil_DyadicFloat_kt2kd16) + 8;
			*(long*)ptr11 = -6148914691236517206L;
			((long*)ptr11)[1] = -6148914691236517206L;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd17, &fputil_DyadicFloat_kt2kd13, 24L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd18, &fputil_DyadicFloat_kt2kd10, 24L, isVolatile: false);
			fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd16, &fputil_DyadicFloat_kt2kd17, &fputil_DyadicFloat_kt2kd18);
			fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(agg_result, &fputil_DyadicFloat_kt2kd16, &fputil_DyadicFloat_kt2kd5);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd16);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd13);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd10);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		}
	}
}
