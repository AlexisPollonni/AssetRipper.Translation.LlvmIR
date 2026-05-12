using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil34round_using_specific_rounding_modeIfEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES4_E4typeES4_i")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, float>::type __llvm_libc_20_1_2_::fputil::round_using_specific_rounding_mode<float>(float, int)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float_float_type_fputil_round_using_specific_rounding_mode_float_float_int
{
	public unsafe static float Invoke(float x, int rnd)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		sbyte b = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		float num5 = 0f;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			float result;
			if (fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) || fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs2))
			{
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_exponent_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
				if (num >= 23)
				{
					result = x;
				}
				else if (num <= -1)
				{
					result = rnd switch
					{
						1 => InstructionHelper.Select((b & 1) == 1, -1f, 0f), 
						0 => InstructionHelper.Select((b & 1) == 1, -0f, 1f), 
						2 => InstructionHelper.Select((b & 1) == 1, -0f, 0f), 
						3 => (num >= -1) ? InstructionHelper.Select((b & 1) == 1, -1f, 1f) : InstructionHelper.Select((b & 1) == 1, -0f, 0f), 
						_ => (num > -2 && fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) != 0) ? InstructionHelper.Select((b & 1) == 1, -1f, 1f) : InstructionHelper.Select((b & 1) == 1, -0f, 0f), 
					};
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(23 - num);
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = num3 >>> num2 << num2;
					if (num4 == num3)
					{
						result = x;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						*(int*)(&fputil_FPBits_5nkvcs3) = -1431655766;
						fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs3, num4);
						llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
						llvm_lifetime_start_p0.Invoke(4L, &num6);
						num6 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) & ((1 << num2) - 1);
						llvm_lifetime_start_p0.Invoke(4L, &num7);
						num7 = 1 << num2 - 1;
						llvm_lifetime_start_p0.Invoke(4L, &num8);
						num8 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3)) & (1 << num2);
						result = rnd switch
						{
							1 => ((b & 1) != 1) ? num5 : (num5 - 1f), 
							0 => ((b & 1) != 1) ? (num5 + 1f) : num5, 
							2 => num5, 
							3 => ((uint)num6 < (uint)num7) ? num5 : (((b & 1) != 1) ? (num5 + 1f) : (num5 - 1f)), 
							_ => ((uint)num6 > (uint)num7) ? (((b & 1) != 1) ? (num5 + 1f) : (num5 - 1f)) : ((num6 != num7) ? num5 : ((num == 0) ? InstructionHelper.Select((b & 1) == 1, -2f, 2f) : ((num8 == 0) ? num5 : (((b & 1) != 1) ? (num5 + 1f) : (num5 - 1f))))), 
						};
						llvm_lifetime_end_p0.Invoke(4L, &num8);
						llvm_lifetime_end_p0.Invoke(4L, &num7);
						llvm_lifetime_end_p0.Invoke(4L, &num6);
						llvm_lifetime_end_p0.Invoke(4L, &num5);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					}
					llvm_lifetime_end_p0.Invoke(4L, &num4);
					llvm_lifetime_end_p0.Invoke(4L, &num3);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
