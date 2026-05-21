using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_ceil_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4ceilIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::ceil<_Float16, 0>(_Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([NativeType("_Float16")] Half x)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		sbyte b = 0;
		int num = 0;
		int num2 = 0;
		short num3 = 0;
		short num4 = 0;
		Half half = default(Half);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, x);
			Half result;
			if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) || FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
			{
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_exponent.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
				if (num >= 10)
				{
					result = x;
				}
				else if (num <= -1)
				{
					result = (((b & 1) != 1) ? default(Half) : default(Half));
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(10 - num);
					llvm_lifetime_start_p0.Invoke(2L, &num3);
					num3 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
					llvm_lifetime_start_p0.Invoke(2L, &num4);
					num4 = (short)((ushort)num3 >> num2 << num2);
					if ((ushort)num4 == (ushort)num3)
					{
						result = x;
					}
					else
					{
						FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_uintval.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2), num4);
						llvm_lifetime_start_p0.Invoke(2L, &half);
						half = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
						result = (((b & 1) != 1) ? ((Half)((float)half + 1f)) : half);
						llvm_lifetime_end_p0.Invoke(2L, &half);
					}
					llvm_lifetime_end_p0.Invoke(2L, &num4);
					llvm_lifetime_end_p0.Invoke(2L, &num3);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
