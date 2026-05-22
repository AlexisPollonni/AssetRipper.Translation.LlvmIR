using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exp
{
	[MangledName("exp")]
	[DemangledName("exp")]
	public unsafe static double Invoke([MangledName("x")] double X)
	{
		double result = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		long num = 0L;
		double num2 = 0.0;
		int num3 = 0;
		double num4 = 0.0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		sbyte b = 0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		double z = 0.0;
		double num8 = 0.0;
		double y = 0.0;
		double x = 0.0;
		double num9 = 0.0;
		Llvm_libc_20_1_2_cpp_optional_vhbvq7 llvm_libc_20_1_2_cpp_optional_vhbvq = default(Llvm_libc_20_1_2_cpp_optional_vhbvq7);
		double num10 = 0.0;
		double num11 = 0.0;
		long num12 = 0L;
		double num13 = 0.0;
		long num14 = 0L;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair4 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_cpp_optional_vhbvq7 llvm_libc_20_1_2_cpp_optional_vhbvq2 = default(Llvm_libc_20_1_2_cpp_optional_vhbvq7);
		double num15 = 0.0;
		double num16 = 0.0;
		long num17 = 0L;
		double num18 = 0.0;
		long num19 = 0L;
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			if (Details_expects_bool_condition_bool.Invoke((ulong)num >= 13873137513782915154uL || ((ulong)num < 13591863675404156928uL && (ulong)num >= 4649454530587146736uL) || (ulong)num < 4368491638549381120uL, Expected: false))
			{
				result = Anonymous_namespace_set_exceptional_gmsn85.Invoke(X);
				goto IL_0aa7;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = Fputil_multiply_add_double.Invoke(X, 1.4426950408889634, 3145728.0001220703);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (int)(Cpp_bit_cast_unsigned_long_double.Invoke(&num2) >>> 19);
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = num3;
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = (num3 >> 6) & 0x3F;
			Llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = num3 & 0x3F;
			Llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = num3 >> 12;
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = ((num7 <= -1022) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			long num20 = (uint)num5;
			llvm_libc_20_1_2_NumberPair.Lo = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID1.Pointer)[num20].Mid;
			long num21 = (uint)num5;
			llvm_libc_20_1_2_NumberPair.Hi = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID1.Pointer)[num21].Hi;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
			long num22 = (uint)num6;
			llvm_libc_20_1_2_NumberPair2.Lo = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID2.Pointer)[num22].Mid;
			long num23 = (uint)num6;
			llvm_libc_20_1_2_NumberPair2.Hi = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID2.Pointer)[num23].Hi;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			*(double*)(&llvm_libc_20_1_2_NumberPair3) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_quick_mult_27ul.Invoke(&llvm_libc_20_1_2_NumberPair, &llvm_libc_20_1_2_NumberPair2);
			Llvm_libc_20_1_2_NumberPair* num24 = &llvm_libc_20_1_2_NumberPair3;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num24 = struct_4ydhja2.field_0;
			byte* num25 = (byte*)(&llvm_libc_20_1_2_NumberPair3) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num25 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			z = Fputil_multiply_add_double.Invoke(num4, -0.00016922538588914904, X);
			Llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = Fputil_multiply_add_double.Invoke(num4, 1.0256140314162804E-14, z);
			Llvm_lifetime_start_p0.Invoke(8L, &y);
			y = num8 * llvm_libc_20_1_2_NumberPair3.Hi;
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = Anonymous_namespace_poly_approx_d_2fncbp.Invoke(num8);
			Llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = Fputil_multiply_add_double.Invoke(x, y, llvm_libc_20_1_2_NumberPair3.Lo);
			if (Details_expects_bool_condition_bool.Invoke((b & 1) == 1, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_vhbvq);
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_vhbvq);
				*(double*)ptr = double.NaN;
				ptr[8] = -86;
				sbyte* ptr2 = ptr + 9;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				ptr2[4] = -86;
				ptr2[5] = -86;
				ptr2[6] = -86;
				Struct_8myw6y struct_8myw6y = Llvm_libc_20_1_2_ziv_test_denorm.Invoke(num7, llvm_libc_20_1_2_NumberPair3.Hi, num9, 1.6263032587282567E-19);
				Llvm_libc_20_1_2_cpp_optional_double_OptionalStorage* ptr3 = &llvm_libc_20_1_2_cpp_optional_vhbvq.Storage;
				Struct_8myw6y struct_8myw6y2 = struct_8myw6y;
				((Struct_8myw6y*)ptr3)->field_0 = struct_8myw6y2.field_0;
				Struct_8myw6y struct_8myw6y3 = struct_8myw6y;
				((Struct_8myw6y*)ptr3)->field_1 = struct_8myw6y3.field_1;
				int num26;
				if (Details_expects_bool_condition_bool.Invoke(Optional_double_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq), Expected: true))
				{
					result = *(double*)Optional_double_value.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq);
					num26 = 1;
				}
				else
				{
					num26 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_vhbvq);
				switch (num26)
				{
				case 0:
					break;
				default:
					goto IL_09b5;
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = llvm_libc_20_1_2_NumberPair3.Hi + (num9 + 1.6263032587282567E-19);
				Llvm_lifetime_start_p0.Invoke(8L, &num11);
				num11 = llvm_libc_20_1_2_NumberPair3.Hi + (num9 - 1.6263032587282567E-19);
				int num26;
				if (Details_expects_bool_condition_bool.Invoke(num10 == num11, Expected: true))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num12);
					num12 = (long)num7 << 52;
					Llvm_lifetime_start_p0.Invoke(8L, &num13);
					Llvm_lifetime_start_p0.Invoke(8L, &num14);
					num14 = checked(num12 + Cpp_bit_cast_long_double.Invoke(&num10));
					double num27 = Cpp_bit_cast_double_long.Invoke(&num14);
					Llvm_lifetime_end_p0.Invoke(8L, &num14);
					num13 = num27;
					result = num13;
					num26 = 1;
					Llvm_lifetime_end_p0.Invoke(8L, &num13);
					Llvm_lifetime_end_p0.Invoke(8L, &num12);
				}
				else
				{
					num26 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num11);
				Llvm_lifetime_end_p0.Invoke(8L, &num10);
				switch (num26)
				{
				case 0:
					break;
				default:
					goto IL_09b5;
				}
			}
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			*(double*)(&llvm_libc_20_1_2_NumberPair4) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair4))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Anonymous_namespace_exp_double_double.Invoke(X, num4, &llvm_libc_20_1_2_NumberPair3);
			Llvm_libc_20_1_2_NumberPair* num28 = &llvm_libc_20_1_2_NumberPair4;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num28 = struct_4ydhja5.field_0;
			byte* num29 = (byte*)(&llvm_libc_20_1_2_NumberPair4) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num29 = struct_4ydhja6.field_1;
			if (Details_expects_bool_condition_bool.Invoke((b & 1) == 1, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_vhbvq2);
				sbyte* ptr4 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_vhbvq2);
				*(double*)ptr4 = double.NaN;
				ptr4[8] = -86;
				sbyte* ptr5 = ptr4 + 9;
				*ptr5 = -86;
				ptr5[1] = -86;
				ptr5[2] = -86;
				ptr5[3] = -86;
				ptr5[4] = -86;
				ptr5[5] = -86;
				ptr5[6] = -86;
				Struct_8myw6y struct_8myw6y4 = Llvm_libc_20_1_2_ziv_test_denorm.Invoke(num7, llvm_libc_20_1_2_NumberPair4.Hi, llvm_libc_20_1_2_NumberPair4.Lo, 1.5777218104420236E-30);
				Llvm_libc_20_1_2_cpp_optional_double_OptionalStorage* ptr6 = &llvm_libc_20_1_2_cpp_optional_vhbvq2.Storage;
				Struct_8myw6y struct_8myw6y5 = struct_8myw6y4;
				((Struct_8myw6y*)ptr6)->field_0 = struct_8myw6y5.field_0;
				Struct_8myw6y struct_8myw6y6 = struct_8myw6y4;
				((Struct_8myw6y*)ptr6)->field_1 = struct_8myw6y6.field_1;
				int num26;
				if (Details_expects_bool_condition_bool.Invoke(Optional_double_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq2), Expected: true))
				{
					result = *(double*)Optional_double_value.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq2);
					num26 = 1;
				}
				else
				{
					num26 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_vhbvq2);
				switch (num26)
				{
				case 0:
					break;
				default:
					goto IL_09a3;
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num15);
				num15 = llvm_libc_20_1_2_NumberPair4.Hi + (llvm_libc_20_1_2_NumberPair4.Lo + 1.5777218104420236E-30);
				Llvm_lifetime_start_p0.Invoke(8L, &num16);
				num16 = llvm_libc_20_1_2_NumberPair4.Hi + (llvm_libc_20_1_2_NumberPair4.Lo - 1.5777218104420236E-30);
				int num26;
				if (Details_expects_bool_condition_bool.Invoke(num15 == num16, Expected: true))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num17);
					num17 = (long)num7 << 52;
					Llvm_lifetime_start_p0.Invoke(8L, &num18);
					Llvm_lifetime_start_p0.Invoke(8L, &num19);
					num19 = checked(num17 + Cpp_bit_cast_long_double.Invoke(&num15));
					double num30 = Cpp_bit_cast_double_long.Invoke(&num19);
					Llvm_lifetime_end_p0.Invoke(8L, &num19);
					num18 = num30;
					result = num18;
					num26 = 1;
					Llvm_lifetime_end_p0.Invoke(8L, &num18);
					Llvm_lifetime_end_p0.Invoke(8L, &num17);
				}
				else
				{
					num26 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num16);
				Llvm_lifetime_end_p0.Invoke(8L, &num15);
				switch (num26)
				{
				case 0:
					break;
				default:
					goto IL_09a3;
				}
			}
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
			*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) = -86;
			sbyte* ptr7 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 1;
			*ptr7 = -86;
			ptr7[1] = -86;
			ptr7[2] = -86;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd))[1] = -1431655766;
			sbyte* ptr8 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 8;
			*(long*)ptr8 = -6148914691236517206L;
			((long*)ptr8)[1] = -6148914691236517206L;
			Anonymous_namespace_exp_f128.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, X, num4, num5, num6);
			result = DyadicFloat_128ul_Double_double_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
			goto IL_09a3;
		}
		IL_0aa7:
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		return result;
		IL_09b5:
		Llvm_lifetime_end_p0.Invoke(8L, &num9);
		Llvm_lifetime_end_p0.Invoke(8L, &x);
		Llvm_lifetime_end_p0.Invoke(8L, &y);
		Llvm_lifetime_end_p0.Invoke(8L, &num8);
		Llvm_lifetime_end_p0.Invoke(8L, &z);
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		Llvm_lifetime_end_p0.Invoke(4L, &num7);
		Llvm_lifetime_end_p0.Invoke(4L, &num6);
		Llvm_lifetime_end_p0.Invoke(4L, &num5);
		Llvm_lifetime_end_p0.Invoke(8L, &num4);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(8L, &num2);
		goto IL_0aa7;
		IL_09a3:
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
		goto IL_09b5;
	}
}
