using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_trunc_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5truncIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::trunc<_Float16, 0>(_Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		int num = 0;
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num2 = 0;
		short mantVal = 0;
		Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva, X);
			Half result;
			if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva)))
			{
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva));
				if (num >= 10)
				{
					result = X;
				}
				else if (num <= -1)
				{
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					anon_izyfb.Val = FPStorage_fputil_FPType_0_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(10 - num);
					Llvm_lifetime_start_p0.Invoke(2L, &mantVal);
					mantVal = (short)((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva)) >> num2 << num2);
					FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva), mantVal);
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva);
					Llvm_lifetime_end_p0.Invoke(2L, &mantVal);
					Llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
			return result;
		}
	}
}
