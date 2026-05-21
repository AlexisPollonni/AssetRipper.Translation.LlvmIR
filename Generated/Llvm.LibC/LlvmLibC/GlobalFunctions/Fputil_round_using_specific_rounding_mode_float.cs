using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_round_using_specific_rounding_mode_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil34round_using_specific_rounding_modeIfEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES4_E4typeES4_i")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, float>::type __llvm_libc_20_1_2_::fputil::round_using_specific_rounding_mode<float>(float, int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, float>::type")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("rnd")][NativeType("int")] int Rnd)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		sbyte b = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		float num5 = 0f;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			float result;
			if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
			{
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) ? ((sbyte)1) : ((sbyte)0));
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
				if (num >= 23)
				{
					result = X;
				}
				else if (num <= -1)
				{
					result = Rnd switch
					{
						1 => InstructionHelper.Select((b & 1) == 1, -1f, 0f), 
						0 => InstructionHelper.Select((b & 1) == 1, -0f, 1f), 
						2 => InstructionHelper.Select((b & 1) == 1, -0f, 0f), 
						3 => (num >= -1) ? InstructionHelper.Select((b & 1) == 1, -1f, 1f) : InstructionHelper.Select((b & 1) == 1, -0f, 0f), 
						_ => (num > -2 && FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) != 0) ? InstructionHelper.Select((b & 1) == 1, -1f, 1f) : InstructionHelper.Select((b & 1) == 1, -0f, 0f), 
					};
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(23 - num);
					Llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = num3 >>> num2 << num2;
					if (num4 == num3)
					{
						result = X;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2) = -1431655766;
						FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, num4);
						Llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						Llvm_lifetime_start_p0.Invoke(4L, &num6);
						num6 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) & ((1 << num2) - 1);
						Llvm_lifetime_start_p0.Invoke(4L, &num7);
						num7 = 1 << num2 - 1;
						Llvm_lifetime_start_p0.Invoke(4L, &num8);
						num8 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2)) & (1 << num2);
						result = Rnd switch
						{
							1 => ((b & 1) != 1) ? num5 : (num5 - 1f), 
							0 => ((b & 1) != 1) ? (num5 + 1f) : num5, 
							2 => num5, 
							3 => ((uint)num6 < (uint)num7) ? num5 : (((b & 1) != 1) ? (num5 + 1f) : (num5 - 1f)), 
							_ => ((uint)num6 > (uint)num7) ? (((b & 1) != 1) ? (num5 + 1f) : (num5 - 1f)) : ((num6 != num7) ? num5 : ((num == 0) ? InstructionHelper.Select((b & 1) == 1, -2f, 2f) : ((num8 == 0) ? num5 : (((b & 1) != 1) ? (num5 + 1f) : (num5 - 1f))))), 
						};
						Llvm_lifetime_end_p0.Invoke(4L, &num8);
						Llvm_lifetime_end_p0.Invoke(4L, &num7);
						Llvm_lifetime_end_p0.Invoke(4L, &num6);
						Llvm_lifetime_end_p0.Invoke(4L, &num5);
						Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
					Llvm_lifetime_end_p0.Invoke(4L, &num3);
					Llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
				Llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
