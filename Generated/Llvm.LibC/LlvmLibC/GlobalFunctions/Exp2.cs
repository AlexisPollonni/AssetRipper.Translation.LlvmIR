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
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		long num = 0L;
		int num2 = 0;
		double num3 = 0.0;
		double x = 0.0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double num7 = 0.0;
		double y = 0.0;
		double x2 = 0.0;
		double num8 = 0.0;
		double num9 = 0.0;
		double num10 = 0.0;
		long num11 = 0L;
		double num12 = 0.0;
		long num13 = 0L;
		NumberPair numberPair4 = default(NumberPair);
		double num14 = 0.0;
		double num15 = 0.0;
		long num16 = 0L;
		double num17 = 0.0;
		long num18 = 0L;
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
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
				Llvm_lifetime_start_p0.Invoke(16L, &numberPair);
				*(double*)(&numberPair) = double.NaN;
				((double*)(&numberPair))[1] = double.NaN;
				long num20 = (uint)num4;
				numberPair.Lo = ((Fputil_TripleDouble*)EXP2_MID1.Pointer)[num20].Mid;
				long num21 = (uint)num4;
				numberPair.Hi = ((Fputil_TripleDouble*)EXP2_MID1.Pointer)[num21].Hi;
				Llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
				*(double*)(&numberPair2) = double.NaN;
				((double*)(&numberPair2))[1] = double.NaN;
				long num22 = (uint)num5;
				numberPair2.Lo = ((Fputil_TripleDouble*)EXP2_MID2.Pointer)[num22].Mid;
				long num23 = (uint)num5;
				numberPair2.Hi = ((Fputil_TripleDouble*)EXP2_MID2.Pointer)[num23].Hi;
				Llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
				*(double*)(&numberPair3) = double.NaN;
				((double*)(&numberPair3))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja = Fputil_quick_mult_27ul.Invoke(&numberPair, &numberPair2);
				NumberPair* num24 = &numberPair3;
				Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
				*(double*)num24 = struct_4ydhja2.field_0;
				byte* num25 = (byte*)(&numberPair3) + 8u;
				Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
				*(double*)num25 = struct_4ydhja3.field_1;
				Llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = Fputil_multiply_add_double.Invoke(x, -0.000244140625, X);
				Llvm_lifetime_start_p0.Invoke(8L, &y);
				y = num7 * numberPair3.Hi;
				Llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = Anonymous_namespace_poly_approx_d_jq287d.Invoke(num7);
				Llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = Fputil_multiply_add_double.Invoke(x2, y, numberPair3.Lo);
				Llvm_lifetime_start_p0.Invoke(8L, &num9);
				num9 = numberPair3.Hi + (num8 + 1.6263032587282567E-19);
				Llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = numberPair3.Hi + (num8 - 1.6263032587282567E-19);
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
					Llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
					*(double*)(&numberPair4) = double.NaN;
					((double*)(&numberPair4))[1] = double.NaN;
					Struct_4ydhja struct_4ydhja4 = Anonymous_namespace_exp2_double_double.Invoke(num7, &numberPair3);
					NumberPair* num27 = &numberPair4;
					Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
					*(double*)num27 = struct_4ydhja5.field_0;
					byte* num28 = (byte*)(&numberPair4) + 8u;
					Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
					*(double*)num28 = struct_4ydhja6.field_1;
					Llvm_lifetime_start_p0.Invoke(8L, &num14);
					num14 = numberPair4.Hi + (numberPair4.Lo + 7.888609052210118E-31);
					Llvm_lifetime_start_p0.Invoke(8L, &num15);
					num15 = numberPair4.Hi + (numberPair4.Lo - 7.888609052210118E-31);
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
						Anonymous_namespace_exp2_f128.Invoke(&fputil_DyadicFloat_kt2kd, num7, num6, num4, num5);
						result = DyadicFloat_128ul_Double_double_void.Invoke(&fputil_DyadicFloat_kt2kd);
						Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num15);
					Llvm_lifetime_end_p0.Invoke(8L, &num14);
					Llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num10);
				Llvm_lifetime_end_p0.Invoke(8L, &num9);
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
				Llvm_lifetime_end_p0.Invoke(8L, &x2);
				Llvm_lifetime_end_p0.Invoke(8L, &y);
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
				Llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
				Llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
				Llvm_lifetime_end_p0.Invoke(16L, &numberPair);
				Llvm_lifetime_end_p0.Invoke(4L, &num6);
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				Llvm_lifetime_end_p0.Invoke(8L, &x);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
