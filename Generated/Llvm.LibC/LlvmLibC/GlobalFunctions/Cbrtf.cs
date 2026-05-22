using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cbrtf
{
	[MangledName("cbrtf")]
	[DemangledName("cbrtf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		double x = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		long num6 = 0L;
		int num7 = 0;
		double num8 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double num9 = 0.0;
		double num10 = 0.0;
		double z = 0.0;
		double y = 0.0;
		double z2 = 0.0;
		double y2 = 0.0;
		double x2 = 0.0;
		double z3 = 0.0;
		double y3 = 0.0;
		double x3 = 0.0;
		long num11 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		long x4 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm4 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) & 0x7FFFFFFF;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) >>> 31 << 11;
			float result;
			if (Details_expects_bool_condition_bool.Invoke(X == 0f || (uint)num >= 2139095040u, Expected: false))
			{
				result = X + X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &x);
				x = X;
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, x);
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = (int)((uint)num3 / 3u + 682) | num2;
				Llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = (int)((uint)num3 % 3u);
				Llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
				Llvm_lifetime_start_p0.Invoke(4L, &num7);
				num7 = (int)(num6 >>> 48);
				num6 |= 0x3FF0000000000000L;
				Llvm_lifetime_start_p0.Invoke(8L, &num8);
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, num6);
				double num12 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				num8 = num12;
				Llvm_lifetime_start_p0.Invoke(8L, &num9);
				num9 = num8 - 1.0;
				Llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = num9 * num9;
				Llvm_lifetime_start_p0.Invoke(8L, &z);
				double x5 = num9;
				long num13 = (uint)num7;
				z = Fputil_multiply_add_double.Invoke(x5, *(double*)((byte*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS.Pointer + (nint)num13 * sizeof(InlineArray7_Double)), 1.0);
				Llvm_lifetime_start_p0.Invoke(8L, &y);
				double x6 = num9;
				long num14 = (uint)num7;
				double y4 = ((double*)((byte*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS.Pointer + (nint)num14 * sizeof(InlineArray7_Double)))[2L];
				long num15 = (uint)num7;
				y = Fputil_multiply_add_double.Invoke(x6, y4, ((double*)((byte*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS.Pointer + (nint)num15 * sizeof(InlineArray7_Double)))[1]);
				Llvm_lifetime_start_p0.Invoke(8L, &z2);
				double x7 = num9;
				long num16 = (uint)num7;
				double y5 = ((double*)((byte*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS.Pointer + (nint)num16 * sizeof(InlineArray7_Double)))[4L];
				long num17 = (uint)num7;
				z2 = Fputil_multiply_add_double.Invoke(x7, y5, ((double*)((byte*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS.Pointer + (nint)num17 * sizeof(InlineArray7_Double)))[3L]);
				Llvm_lifetime_start_p0.Invoke(8L, &y2);
				double x8 = num9;
				long num18 = (uint)num7;
				double y6 = ((double*)((byte*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS.Pointer + (nint)num18 * sizeof(InlineArray7_Double)))[6L];
				long num19 = (uint)num7;
				y2 = Fputil_multiply_add_double.Invoke(x8, y6, ((double*)((byte*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS.Pointer + (nint)num19 * sizeof(InlineArray7_Double)))[5L]);
				Llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = num10 * num10;
				Llvm_lifetime_start_p0.Invoke(8L, &z3);
				z3 = Fputil_multiply_add_double.Invoke(num10, y, z);
				Llvm_lifetime_start_p0.Invoke(8L, &y3);
				y3 = Fputil_multiply_add_double.Invoke(num10, y2, z2);
				Llvm_lifetime_start_p0.Invoke(8L, &x3);
				double num20 = Fputil_multiply_add_double.Invoke(x2, y3, z3);
				long num21 = (uint)num5;
				x3 = num20 * ((double*)Llvm_libc_20_1_2_anonymous_namespace_CBRT2.Pointer)[num21];
				Llvm_lifetime_start_p0.Invoke(8L, &num11);
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3, x3);
				long num22 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3));
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
				num11 = num22;
				if (Details_expects_bool_condition_bool.Invoke((ulong)((num11 + 8L) & 0xFFFFFFFFFFFL) <= 16uL, Expected: false))
				{
					num11 = (((ulong)(num11 & 0xFFFFFFFFFFFL) > 8uL) ? ((num11 & -32L) + 32L) : (num11 & -32L));
					Fputil_clear_except_if_required.Invoke(32);
				}
				Llvm_lifetime_start_p0.Invoke(8L, &x4);
				x4 = num11 | (long)((ulong)(uint)num4 << 52);
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
				FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4, x4);
				result = (float)FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
				Llvm_lifetime_end_p0.Invoke(8L, &x4);
				Llvm_lifetime_end_p0.Invoke(8L, &num11);
				Llvm_lifetime_end_p0.Invoke(8L, &x3);
				Llvm_lifetime_end_p0.Invoke(8L, &y3);
				Llvm_lifetime_end_p0.Invoke(8L, &z3);
				Llvm_lifetime_end_p0.Invoke(8L, &x2);
				Llvm_lifetime_end_p0.Invoke(8L, &y2);
				Llvm_lifetime_end_p0.Invoke(8L, &z2);
				Llvm_lifetime_end_p0.Invoke(8L, &y);
				Llvm_lifetime_end_p0.Invoke(8L, &z);
				Llvm_lifetime_end_p0.Invoke(8L, &num10);
				Llvm_lifetime_end_p0.Invoke(8L, &num9);
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
				Llvm_lifetime_end_p0.Invoke(4L, &num7);
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				Llvm_lifetime_end_p0.Invoke(8L, &x);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
