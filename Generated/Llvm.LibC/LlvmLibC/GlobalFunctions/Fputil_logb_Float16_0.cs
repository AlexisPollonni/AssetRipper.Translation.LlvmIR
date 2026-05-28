using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_logb_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4logbIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::logb<_Float16, 0>(_Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_DyadicFloat_jvghxm fputil_DyadicFloat_jvghxm = default(Fputil_DyadicFloat_jvghxm);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			Half result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)) || FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)), Expected: false))
			{
				if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
				{
					result = X;
				}
				else
				{
					Fputil_raise_except_if_required.Invoke(4);
					if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
					{
						Fputil_set_errno_if_required.Invoke(34);
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_NEG.Pointer, 1L, isVolatile: false);
						short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb.Val);
						fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb2.Val);
						fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					}
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_jvghxm);
				*(sbyte*)(&fputil_DyadicFloat_jvghxm) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_jvghxm) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_jvghxm))[1] = -1431655766;
				((short*)(&fputil_DyadicFloat_jvghxm))[4] = -21846;
				sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_jvghxm) + 10;
				*ptr2 = -86;
				ptr2[1] = -86;
				DyadicFloat_16ul_DyadicFloat_Float16_0.Invoke(&fputil_DyadicFloat_jvghxm, FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva));
				result = (Half)DyadicFloat_16ul_get_unbiased_exponent.Invoke(&fputil_DyadicFloat_jvghxm);
				Llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_jvghxm);
			}
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result;
		}
	}
}
