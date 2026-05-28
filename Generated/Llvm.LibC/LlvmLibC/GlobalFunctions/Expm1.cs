using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Expm1
{
	[MangledName("expm1")]
	[DemangledName("expm1")]
	public unsafe static double Invoke([MangledName("x")] double X)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		sbyte b = 0;
		long num = 0L;
		double num2 = 0.0;
		int num3 = 0;
		double num4 = 0.0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double num8 = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		NumberPair numberPair4 = default(NumberPair);
		double z = 0.0;
		double num9 = 0.0;
		double y = 0.0;
		double x = 0.0;
		double num10 = 0.0;
		long num11 = 0L;
		double num12 = 0.0;
		long num13 = 0L;
		double num14 = 0.0;
		double num15 = 0.0;
		long num16 = 0L;
		double num17 = 0.0;
		long num18 = 0L;
		NumberPair numberPair5 = default(NumberPair);
		double num19 = 0.0;
		long num20 = 0L;
		double num21 = 0.0;
		double num22 = 0.0;
		long num23 = 0L;
		double num24 = 0.0;
		long num25 = 0L;
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
			double result;
			if (Details_expects_bool_condition_bool.Invoke((ulong)num >= 13853836650999914722uL || ((ulong)num <= 13591863675404156928uL && (ulong)num >= 4649454530587146736uL) || (ulong)num <= 4368491638549381120uL, Expected: false))
			{
				result = Anonymous_namespace_set_exceptional_icmnd6.Invoke(X);
			}
			else
			{
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
				Llvm_lifetime_start_p0.Invoke(16L, &numberPair);
				*(double*)(&numberPair) = double.NaN;
				((double*)(&numberPair))[1] = double.NaN;
				long num26 = (uint)num5;
				numberPair.Lo = ((Fputil_TripleDouble*)EXP2_MID1.Pointer)[num26].Mid;
				long num27 = (uint)num5;
				numberPair.Hi = ((Fputil_TripleDouble*)EXP2_MID1.Pointer)[num27].Hi;
				Llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
				*(double*)(&numberPair2) = double.NaN;
				((double*)(&numberPair2))[1] = double.NaN;
				long num28 = (uint)num6;
				numberPair2.Lo = ((Fputil_TripleDouble*)EXP2_MID2.Pointer)[num28].Mid;
				long num29 = (uint)num6;
				numberPair2.Hi = ((Fputil_TripleDouble*)EXP2_MID2.Pointer)[num29].Hi;
				Llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
				*(double*)(&numberPair3) = double.NaN;
				((double*)(&numberPair3))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja = Fputil_quick_mult_27ul.Invoke(&numberPair, &numberPair2);
				NumberPair* num30 = &numberPair3;
				Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
				*(double*)num30 = struct_4ydhja2.field_0;
				byte* num31 = (byte*)(&numberPair3) + 8u;
				Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
				*(double*)num31 = struct_4ydhja3.field_1;
				Llvm_lifetime_start_p0.Invoke(8L, &num8);
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_NEG.Pointer, 1L, isVolatile: false);
				long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(Biased_exp: checked(1023 - num7), Sign: anon_izyfb.Val, Mantissa: 0L);
				fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
				double num32 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				num8 = num32;
				Llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
				*(double*)(&numberPair4) = double.NaN;
				((double*)(&numberPair4))[1] = double.NaN;
				if ((b & 1) == 1)
				{
					Struct_4ydhja struct_4ydhja4 = Fputil_exact_add_true.Invoke(num8, numberPair3.Hi);
					NumberPair* num33 = &numberPair4;
					Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
					*(double*)num33 = struct_4ydhja5.field_0;
					byte* num34 = (byte*)(&numberPair4) + 8u;
					Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
					*(double*)num34 = struct_4ydhja6.field_1;
				}
				else
				{
					Struct_4ydhja struct_4ydhja7 = Fputil_exact_add_true.Invoke(numberPair3.Hi, num8);
					NumberPair* num35 = &numberPair4;
					Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
					*(double*)num35 = struct_4ydhja8.field_0;
					byte* num36 = (byte*)(&numberPair4) + 8u;
					Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
					*(double*)num36 = struct_4ydhja9.field_1;
				}
				double lo = numberPair3.Lo;
				numberPair4.Lo += lo;
				Llvm_lifetime_start_p0.Invoke(8L, &z);
				z = Fputil_multiply_add_double.Invoke(num4, -0.00016922538588914904, X);
				Llvm_lifetime_start_p0.Invoke(8L, &num9);
				num9 = Fputil_multiply_add_double.Invoke(num4, 1.0256140314162804E-14, z);
				Llvm_lifetime_start_p0.Invoke(8L, &y);
				y = num9 * numberPair3.Hi;
				Llvm_lifetime_start_p0.Invoke(8L, &x);
				x = Anonymous_namespace_poly_approx_d_ymtez3.Invoke(num9);
				Llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = Fputil_multiply_add_double.Invoke(x, y, numberPair4.Lo);
				Llvm_lifetime_start_p0.Invoke(8L, &num11);
				num11 = (((b & 1) != 1) ? 0L : ((long)checked(-num7) << 52));
				Llvm_lifetime_start_p0.Invoke(8L, &num12);
				Llvm_lifetime_start_p0.Invoke(8L, &num13);
				num13 = 4325707442089361408L + num11;
				double num37 = Cpp_bit_cast_double_unsigned_long.Invoke(&num13);
				Llvm_lifetime_end_p0.Invoke(8L, &num13);
				num12 = num37;
				Llvm_lifetime_start_p0.Invoke(8L, &num14);
				num14 = numberPair4.Hi + (num10 + num12);
				Llvm_lifetime_start_p0.Invoke(8L, &num15);
				num15 = numberPair4.Hi + (num10 - num12);
				if (Details_expects_bool_condition_bool.Invoke(num14 == num15, Expected: true))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num16);
					num16 = (long)num7 << 52;
					Llvm_lifetime_start_p0.Invoke(8L, &num17);
					Llvm_lifetime_start_p0.Invoke(8L, &num18);
					num18 = checked(num16 + Cpp_bit_cast_long_double.Invoke(&num14));
					double num38 = Cpp_bit_cast_double_long.Invoke(&num18);
					Llvm_lifetime_end_p0.Invoke(8L, &num18);
					num17 = num38;
					result = num17;
					Llvm_lifetime_end_p0.Invoke(8L, &num17);
					Llvm_lifetime_end_p0.Invoke(8L, &num16);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
					*(double*)(&numberPair5) = double.NaN;
					((double*)(&numberPair5))[1] = double.NaN;
					Struct_4ydhja struct_4ydhja10 = Anonymous_namespace_exp_double_double.Invoke(X, num4, &numberPair3, &numberPair4);
					NumberPair* num39 = &numberPair5;
					Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
					*(double*)num39 = struct_4ydhja11.field_0;
					byte* num40 = (byte*)(&numberPair5) + 8u;
					Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
					*(double*)num40 = struct_4ydhja12.field_1;
					Llvm_lifetime_start_p0.Invoke(8L, &num19);
					Llvm_lifetime_start_p0.Invoke(8L, &num20);
					num20 = 4161326055690338304L + num11;
					double num41 = Cpp_bit_cast_double_unsigned_long.Invoke(&num20);
					Llvm_lifetime_end_p0.Invoke(8L, &num20);
					num19 = num41;
					Llvm_lifetime_start_p0.Invoke(8L, &num21);
					num21 = numberPair5.Hi + (numberPair5.Lo + num19);
					Llvm_lifetime_start_p0.Invoke(8L, &num22);
					num22 = numberPair5.Hi + (numberPair5.Lo - num19);
					if (Details_expects_bool_condition_bool.Invoke(num21 == num22, Expected: true))
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num23);
						num23 = (long)num7 << 52;
						Llvm_lifetime_start_p0.Invoke(8L, &num24);
						Llvm_lifetime_start_p0.Invoke(8L, &num25);
						num25 = checked(num23 + Cpp_bit_cast_long_double.Invoke(&num21));
						double num42 = Cpp_bit_cast_double_long.Invoke(&num25);
						Llvm_lifetime_end_p0.Invoke(8L, &num25);
						num24 = num42;
						result = num24;
						Llvm_lifetime_end_p0.Invoke(8L, &num24);
						Llvm_lifetime_end_p0.Invoke(8L, &num23);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
						*(sbyte*)(&fputil_DyadicFloat_kt2kd) = -86;
						sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 1;
						*ptr = -86;
						ptr[1] = -86;
						ptr[2] = -86;
						((int*)(&fputil_DyadicFloat_kt2kd))[1] = -1431655766;
						sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 8;
						*(long*)ptr2 = -6148914691236517206L;
						((long*)ptr2)[1] = -6148914691236517206L;
						Anonymous_namespace_expm1_f128.Invoke(&fputil_DyadicFloat_kt2kd, X, num4, num5, num6);
						result = DyadicFloat_128ul_Double_double_void.Invoke(&fputil_DyadicFloat_kt2kd);
						Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num22);
					Llvm_lifetime_end_p0.Invoke(8L, &num21);
					Llvm_lifetime_end_p0.Invoke(8L, &num19);
					Llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num15);
				Llvm_lifetime_end_p0.Invoke(8L, &num14);
				Llvm_lifetime_end_p0.Invoke(8L, &num12);
				Llvm_lifetime_end_p0.Invoke(8L, &num11);
				Llvm_lifetime_end_p0.Invoke(8L, &num10);
				Llvm_lifetime_end_p0.Invoke(8L, &x);
				Llvm_lifetime_end_p0.Invoke(8L, &y);
				Llvm_lifetime_end_p0.Invoke(8L, &num9);
				Llvm_lifetime_end_p0.Invoke(8L, &z);
				Llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
				Llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
				Llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
				Llvm_lifetime_end_p0.Invoke(16L, &numberPair);
				Llvm_lifetime_end_p0.Invoke(4L, &num7);
				Llvm_lifetime_end_p0.Invoke(4L, &num6);
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
