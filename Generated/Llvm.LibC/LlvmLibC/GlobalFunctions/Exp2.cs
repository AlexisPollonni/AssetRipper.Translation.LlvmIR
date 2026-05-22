using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exp2
{
	[MangledName("exp2")]
	[DemangledName("exp2")]
	public unsafe static double Invoke([MangledName("x")] double X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		long num = 0L;
		int num2 = 0;
		double num3 = 0.0;
		double x = 0.0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		double num7 = 0.0;
		double y = 0.0;
		double x2 = 0.0;
		double num8 = 0.0;
		double num9 = 0.0;
		double num10 = 0.0;
		long num11 = 0L;
		double num12 = 0.0;
		long num13 = 0L;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair4 = default(Llvm_libc_20_1_2_NumberPair);
		double num14 = 0.0;
		double num15 = 0.0;
		long num16 = 0L;
		double num17 = 0.0;
		long num18 = 0L;
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			double result;
			if (Details_expects_bool_condition_bool.Invoke((ulong)num > 13875572859742453760uL || ((ulong)num <= 13589353796997972734uL && (ulong)num >= 4652218415073722368uL) || (ulong)num <= 4370485359770567421uL, Expected: false))
			{
				result = Anonymous_namespace_set_exceptional_carush.Invoke(X);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = X + 3145728.0001220703;
				int num19 = (int)(Cpp_bit_cast_unsigned_long_double.Invoke(&num3) >>> 19);
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
				num2 = num19;
				Llvm_lifetime_start_p0.Invoke(8L, &x);
				x = num2;
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = (num2 >> 6) & 0x3F;
				Llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = num2 & 0x3F;
				Llvm_lifetime_start_p0.Invoke(4L, &num6);
				num6 = num2 >> 12;
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
				*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
				((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
				long num20 = (uint)num4;
				llvm_libc_20_1_2_NumberPair.Lo = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID1.Pointer)[num20].Mid;
				long num21 = (uint)num4;
				llvm_libc_20_1_2_NumberPair.Hi = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID1.Pointer)[num21].Hi;
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
				*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
				((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
				long num22 = (uint)num5;
				llvm_libc_20_1_2_NumberPair2.Lo = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID2.Pointer)[num22].Mid;
				long num23 = (uint)num5;
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
				Llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = Fputil_multiply_add_double.Invoke(x, -0.000244140625, X);
				Llvm_lifetime_start_p0.Invoke(8L, &y);
				y = num7 * llvm_libc_20_1_2_NumberPair3.Hi;
				Llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = Anonymous_namespace_poly_approx_d_jq287d.Invoke(num7);
				Llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = Fputil_multiply_add_double.Invoke(x2, y, llvm_libc_20_1_2_NumberPair3.Lo);
				Llvm_lifetime_start_p0.Invoke(8L, &num9);
				num9 = llvm_libc_20_1_2_NumberPair3.Hi + (num8 + 1.6263032587282567E-19);
				Llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = llvm_libc_20_1_2_NumberPair3.Hi + (num8 - 1.6263032587282567E-19);
				if (Details_expects_bool_condition_bool.Invoke(num9 == num10, Expected: true))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num11);
					num11 = (long)num6 << 52;
					Llvm_lifetime_start_p0.Invoke(8L, &num12);
					Llvm_lifetime_start_p0.Invoke(8L, &num13);
					num13 = checked(num11 + Cpp_bit_cast_long_double.Invoke(&num9));
					double num26 = Cpp_bit_cast_double_long.Invoke(&num13);
					Llvm_lifetime_end_p0.Invoke(8L, &num13);
					num12 = num26;
					result = num12;
					Llvm_lifetime_end_p0.Invoke(8L, &num12);
					Llvm_lifetime_end_p0.Invoke(8L, &num11);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
					*(double*)(&llvm_libc_20_1_2_NumberPair4) = double.NaN;
					((double*)(&llvm_libc_20_1_2_NumberPair4))[1] = double.NaN;
					Struct_4ydhja struct_4ydhja4 = Anonymous_namespace_exp2_double_double.Invoke(num7, &llvm_libc_20_1_2_NumberPair3);
					Llvm_libc_20_1_2_NumberPair* num27 = &llvm_libc_20_1_2_NumberPair4;
					Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
					*(double*)num27 = struct_4ydhja5.field_0;
					byte* num28 = (byte*)(&llvm_libc_20_1_2_NumberPair4) + 8u;
					Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
					*(double*)num28 = struct_4ydhja6.field_1;
					Llvm_lifetime_start_p0.Invoke(8L, &num14);
					num14 = llvm_libc_20_1_2_NumberPair4.Hi + (llvm_libc_20_1_2_NumberPair4.Lo + 7.888609052210118E-31);
					Llvm_lifetime_start_p0.Invoke(8L, &num15);
					num15 = llvm_libc_20_1_2_NumberPair4.Hi + (llvm_libc_20_1_2_NumberPair4.Lo - 7.888609052210118E-31);
					if (Details_expects_bool_condition_bool.Invoke(num14 == num15, Expected: true))
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num16);
						num16 = (long)num6 << 52;
						Llvm_lifetime_start_p0.Invoke(8L, &num17);
						Llvm_lifetime_start_p0.Invoke(8L, &num18);
						num18 = checked(num16 + Cpp_bit_cast_long_double.Invoke(&num14));
						double num29 = Cpp_bit_cast_double_long.Invoke(&num18);
						Llvm_lifetime_end_p0.Invoke(8L, &num18);
						num17 = num29;
						result = num17;
						Llvm_lifetime_end_p0.Invoke(8L, &num17);
						Llvm_lifetime_end_p0.Invoke(8L, &num16);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
						*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) = -86;
						sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 1;
						*ptr = -86;
						ptr[1] = -86;
						ptr[2] = -86;
						((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd))[1] = -1431655766;
						sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 8;
						*(long*)ptr2 = -6148914691236517206L;
						((long*)ptr2)[1] = -6148914691236517206L;
						Anonymous_namespace_exp2_f128.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, num7, num6, num4, num5);
						result = DyadicFloat_128ul_Double_double_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
						Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num15);
					Llvm_lifetime_end_p0.Invoke(8L, &num14);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num10);
				Llvm_lifetime_end_p0.Invoke(8L, &num9);
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
				Llvm_lifetime_end_p0.Invoke(8L, &x2);
				Llvm_lifetime_end_p0.Invoke(8L, &y);
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
				Llvm_lifetime_end_p0.Invoke(4L, &num6);
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				Llvm_lifetime_end_p0.Invoke(8L, &x);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
