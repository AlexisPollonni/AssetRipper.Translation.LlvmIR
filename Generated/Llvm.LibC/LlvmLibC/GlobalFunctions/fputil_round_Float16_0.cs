using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_round_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5roundIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::round<_Float16, 0>(_Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([NativeType("_Float16")] Half x)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		int num = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		int num2 = 0;
		sbyte b = 0;
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
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_exponent.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
				if (num >= 10)
				{
					result = x;
				}
				else if (num == -1)
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					anon_izyfb8.val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva2);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_one.Invoke(anon_izyfb8.val);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				}
				else if (num <= -2)
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					anon_izyfb9.val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva2);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb9.val);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(10 - num);
					llvm_lifetime_start_p0.Invoke(1L, &b);
					b = ((((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) & (1 << num2 - 1)) != 0) ? ((sbyte)1) : ((sbyte)0));
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
						result = (((b & 1) == 1) ? ((!FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2))) ? ((Half)((float)half + 1f)) : ((Half)((float)half - 1f))) : half);
						llvm_lifetime_end_p0.Invoke(2L, &half);
					}
					llvm_lifetime_end_p0.Invoke(2L, &num4);
					llvm_lifetime_end_p0.Invoke(2L, &num3);
					llvm_lifetime_end_p0.Invoke(1L, &b);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
