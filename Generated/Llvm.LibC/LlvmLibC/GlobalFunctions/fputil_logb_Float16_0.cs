using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_logb_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4logbIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::logb<_Float16, 0>(_Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([NativeType("_Float16")] Half x)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_DyadicFloat_jvghxm fputil_DyadicFloat_jvghxm2 = default(fputil_DyadicFloat_jvghxm);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, x);
			Half result;
			if (details_expects_bool_condition_bool.Invoke((!FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2))) ? FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) : true, expected: false))
			{
				if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
				{
					result = x;
				}
				else
				{
					fputil_raise_except_if_required.Invoke(4);
					if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
					{
						fputil_set_errno_if_required.Invoke(34);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_NEG.Pointer, 1L, isVolatile: false);
						short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb8.val);
						fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb9.val);
						fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					}
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_jvghxm2);
				*(sbyte*)(&fputil_DyadicFloat_jvghxm2) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_jvghxm2) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_jvghxm2))[1] = -1431655766;
				((short*)(&fputil_DyadicFloat_jvghxm2))[4] = -21846;
				sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_jvghxm2) + 10;
				*ptr2 = -86;
				ptr2[1] = -86;
				DyadicFloat_16ul_DyadicFloat_Float16_0.Invoke(&fputil_DyadicFloat_jvghxm2, FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2));
				result = (Half)DyadicFloat_16ul_get_unbiased_exponent.Invoke(&fputil_DyadicFloat_jvghxm2);
				llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_jvghxm2);
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
