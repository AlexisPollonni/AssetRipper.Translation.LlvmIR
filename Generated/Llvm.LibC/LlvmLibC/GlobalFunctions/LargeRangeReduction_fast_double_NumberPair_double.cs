using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_19LargeRangeReduction4fastEdRNS_10NumberPairIdEE")]
[DemangledName("__llvm_libc_20_1_2_::LargeRangeReduction::fast(double, __llvm_libc_20_1_2_::NumberPair<double>&)")]
internal static partial class LargeRangeReduction_fast_double_NumberPair_double
{
	public unsafe static int Invoke(LargeRangeReduction* @this, double x, NumberPair* u)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		int num = 0;
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double x2 = 0.0;
		double num2 = 0.0;
		NumberPair numberPair4 = default(NumberPair);
		double num3 = 0.0;
		NumberPair numberPair5 = default(NumberPair);
		NumberPair numberPair6 = default(NumberPair);
		NumberPair numberPair7 = default(NumberPair);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		*unchecked((long*)(&fputil_FPBits_wjhbrm2)) = -6148914691236517206L;
		fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2))) - 1085;
		@this->idx = (num >> 4) + 3;
		fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent_unsigned_long.Invoke(unchecked((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)), (num & 0xF) + 1023 + 62);
		@this->x_reduced = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
		llvm_lifetime_start_p0.Invoke(16L, &numberPair);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			double x_reduced = @this->x_reduced;
			long num4 = (uint)@this->idx;
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_exact_mult_27ul_double_double.Invoke(x_reduced, *(double*)((byte*)ONE_TWENTY_EIGHT_OVER_PI.Pointer + (nint)num4 * sizeof(InlineArray4_Double)));
			NumberPair* num5 = &numberPair;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num5 = struct_4ydhja2.field_0;
			byte* num6 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num6 = struct_4ydhja3.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			double x_reduced2 = @this->x_reduced;
			long num7 = (uint)@this->idx;
			Struct_4ydhja struct_4ydhja4 = NumberPair_double_fputil_exact_mult_27ul_double_double.Invoke(x_reduced2, ((double*)((byte*)ONE_TWENTY_EIGHT_OVER_PI.Pointer + (nint)num7 * sizeof(InlineArray4_Double)))[1]);
			NumberPair* num8 = &numberPair2;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num8 = struct_4ydhja5.field_0;
			byte* num9 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num9 = struct_4ydhja6.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			double x_reduced3 = @this->x_reduced;
			long num10 = (uint)@this->idx;
			Struct_4ydhja struct_4ydhja7 = NumberPair_double_fputil_exact_mult_27ul_double_double.Invoke(x_reduced3, ((double*)((byte*)ONE_TWENTY_EIGHT_OVER_PI.Pointer + (nint)num10 * sizeof(InlineArray4_Double)))[2L]);
			NumberPair* num11 = &numberPair3;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num11 = struct_4ydhja8.field_0;
			byte* num12 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num12 = struct_4ydhja9.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = numberPair.lo + numberPair2.hi;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = fputil_nearest_integer_double.Invoke(x2);
			@this->y_hi = numberPair.lo - num2 + numberPair2.hi;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			Struct_4ydhja struct_4ydhja10 = NumberPair_double_fputil_exact_add_true_double_double.Invoke(numberPair2.lo, numberPair3.hi);
			NumberPair* num13 = &numberPair4;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num13 = struct_4ydhja11.field_0;
			byte* num14 = (byte*)(&numberPair4) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num14 = struct_4ydhja12.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(&@this->y_mid, &numberPair4, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			@this->y_lo = numberPair3.lo;
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			double x_reduced4 = @this->x_reduced;
			long num15 = (uint)@this->idx;
			num3 = fputil_multiply_add_double_double_double.Invoke(x_reduced4, ((double*)((byte*)ONE_TWENTY_EIGHT_OVER_PI.Pointer + (nint)num15 * sizeof(InlineArray4_Double)))[3L], @this->y_lo);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			*(double*)(&numberPair5) = double.NaN;
			((double*)(&numberPair5))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja13 = NumberPair_double_fputil_exact_add_true_double_double.Invoke(@this->y_hi, @this->y_mid.hi);
			NumberPair* num16 = &numberPair5;
			Struct_4ydhja struct_4ydhja14 = struct_4ydhja13;
			*(double*)num16 = struct_4ydhja14.field_0;
			byte* num17 = (byte*)(&numberPair5) + 8u;
			Struct_4ydhja struct_4ydhja15 = struct_4ydhja13;
			*(double*)num17 = struct_4ydhja15.field_1;
			double num18 = @this->y_mid.lo + num3;
			numberPair5.lo += num18;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair6);
			*(double*)(&numberPair6) = 9.567553118338697E-19;
			((double*)(&numberPair6))[1] = Math.PI / 128.0;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair7);
			Struct_4ydhja struct_4ydhja16 = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair5, &numberPair6);
			NumberPair* num19 = &numberPair7;
			Struct_4ydhja struct_4ydhja17 = struct_4ydhja16;
			*(double*)num19 = struct_4ydhja17.field_0;
			byte* num20 = (byte*)(&numberPair7) + 8u;
			Struct_4ydhja struct_4ydhja18 = struct_4ydhja16;
			*(double*)num20 = struct_4ydhja18.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(u, &numberPair7, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair7);
			int result = (int)(long)num2;
			llvm_lifetime_end_p0.Invoke(16L, &numberPair6);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
