using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_round_using_specific_rounding_mode_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil34round_using_specific_rounding_modeIdEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES4_E4typeES4_i")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, double>::type __llvm_libc_20_1_2_::fputil::round_using_specific_rounding_mode<double>(double, int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, double>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("rnd")][NativeType("int")] int Rnd)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		sbyte b = 0;
		int num = 0;
		int num2 = 0;
		long num3 = 0L;
		long num4 = 0L;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		double num5 = 0.0;
		long num6 = 0L;
		long num7 = 0L;
		long num8 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			double result;
			if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
			{
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) ? ((sbyte)1) : ((sbyte)0));
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
				if (num >= 52)
				{
					result = X;
				}
				else if (num <= -1)
				{
					result = Rnd switch
					{
						1 => InstructionHelper.Select((b & 1) == 1, -1.0, 0.0), 
						0 => InstructionHelper.Select((b & 1) == 1, -0.0, 1.0), 
						2 => InstructionHelper.Select((b & 1) == 1, -0.0, 0.0), 
						3 => (num >= -1) ? InstructionHelper.Select((b & 1) == 1, -1.0, 1.0) : InstructionHelper.Select((b & 1) == 1, -0.0, 0.0), 
						_ => (num > -2 && FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) != 0L) ? InstructionHelper.Select((b & 1) == 1, -1.0, 1.0) : InstructionHelper.Select((b & 1) == 1, -0.0, 0.0), 
					};
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(52 - num);
					Llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
					Llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = num3 >>> (int)(uint)num2 << (int)(uint)num2;
					if (num4 == num3)
					{
						result = X;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
						*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
						FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, num4);
						Llvm_lifetime_start_p0.Invoke(8L, &num5);
						num5 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
						Llvm_lifetime_start_p0.Invoke(8L, &num6);
						num6 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) & ((1L << (int)(uint)num2) - 1L);
						Llvm_lifetime_start_p0.Invoke(8L, &num7);
						num7 = 1L << (int)(uint)(num2 - 1);
						Llvm_lifetime_start_p0.Invoke(8L, &num8);
						num8 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) & (1L << (int)(uint)num2);
						result = Rnd switch
						{
							1 => ((b & 1) != 1) ? num5 : (num5 - 1.0), 
							0 => ((b & 1) != 1) ? (num5 + 1.0) : num5, 
							2 => num5, 
							3 => ((ulong)num6 < (ulong)num7) ? num5 : (((b & 1) != 1) ? (num5 + 1.0) : (num5 - 1.0)), 
							_ => ((ulong)num6 > (ulong)num7) ? (((b & 1) != 1) ? (num5 + 1.0) : (num5 - 1.0)) : ((num6 != num7) ? num5 : ((num == 0) ? InstructionHelper.Select((b & 1) == 1, -2.0, 2.0) : ((num8 == 0L) ? num5 : (((b & 1) != 1) ? (num5 + 1.0) : (num5 - 1.0))))), 
						};
						Llvm_lifetime_end_p0.Invoke(8L, &num8);
						Llvm_lifetime_end_p0.Invoke(8L, &num7);
						Llvm_lifetime_end_p0.Invoke(8L, &num6);
						Llvm_lifetime_end_p0.Invoke(8L, &num5);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num4);
					Llvm_lifetime_end_p0.Invoke(8L, &num3);
					Llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
				Llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
