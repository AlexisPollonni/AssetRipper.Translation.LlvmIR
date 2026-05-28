using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_round_using_specific_rounding_mode_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil34round_using_specific_rounding_modeIDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES4_E4typeES4_i")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, _Float16>::type __llvm_libc_20_1_2_::fputil::round_using_specific_rounding_mode<_Float16>(_Float16, int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, _Float16>::type")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X, [MangledName("rnd")][NativeType("int")] int Rnd)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		sbyte b = 0;
		int num = 0;
		int num2 = 0;
		short num3 = 0;
		short num4 = 0;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Half half = default(Half);
		short num5 = 0;
		short num6 = 0;
		short num7 = 0;
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			Half result;
			if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)) || FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
			{
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)) ? ((sbyte)1) : ((sbyte)0));
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_exponent.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva));
				if (num >= 10)
				{
					result = X;
				}
				else if (num <= -1)
				{
					result = Rnd switch
					{
						1 => InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)), 
						0 => InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)), 
						2 => InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)), 
						3 => (num >= -1) ? InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)) : InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)), 
						_ => (num > -2 && (ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)) != 0) ? InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)) : InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)), 
					};
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(10 - num);
					Llvm_lifetime_start_p0.Invoke(2L, &num3);
					num3 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva));
					Llvm_lifetime_start_p0.Invoke(2L, &num4);
					num4 = (short)((ushort)num3 >> num2 << num2);
					if ((ushort)num4 == (ushort)num3)
					{
						result = X;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
						*(short*)(&fputil_FPBits_2fahva2) = -21846;
						FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva2, num4);
						Llvm_lifetime_start_p0.Invoke(2L, &half);
						half = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
						Llvm_lifetime_start_p0.Invoke(2L, &num5);
						num5 = (short)((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)) & (ushort)(short)checked((1 << num2) - 1));
						Llvm_lifetime_start_p0.Invoke(2L, &num6);
						num6 = (short)(1 << num2 - 1);
						Llvm_lifetime_start_p0.Invoke(2L, &num7);
						num7 = (short)((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) & (1 << num2));
						result = Rnd switch
						{
							1 => ((b & 1) != 1) ? half : ((Half)((float)half - 1f)), 
							0 => ((b & 1) != 1) ? ((Half)((float)half + 1f)) : half, 
							2 => half, 
							3 => ((ushort)num5 < (ushort)num6) ? half : (((b & 1) != 1) ? ((Half)((float)half + 1f)) : ((Half)((float)half - 1f))), 
							_ => ((ushort)num5 > (ushort)num6) ? (((b & 1) != 1) ? ((Half)((float)half + 1f)) : ((Half)((float)half - 1f))) : (((ushort)num5 != (ushort)num6) ? half : ((num == 0) ? InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)) : ((num7 == 0) ? half : (((b & 1) != 1) ? ((Half)((float)half + 1f)) : ((Half)((float)half - 1f)))))), 
						};
						Llvm_lifetime_end_p0.Invoke(2L, &num7);
						Llvm_lifetime_end_p0.Invoke(2L, &num6);
						Llvm_lifetime_end_p0.Invoke(2L, &num5);
						Llvm_lifetime_end_p0.Invoke(2L, &half);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					}
					Llvm_lifetime_end_p0.Invoke(2L, &num4);
					Llvm_lifetime_end_p0.Invoke(2L, &num3);
					Llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
				Llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result;
		}
	}
}
