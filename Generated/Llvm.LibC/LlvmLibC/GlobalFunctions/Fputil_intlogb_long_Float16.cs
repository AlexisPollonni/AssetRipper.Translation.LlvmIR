using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_intlogb_long_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7intlogbIlDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EET_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, long>::type __llvm_libc_20_1_2_::fputil::intlogb<long, _Float16>(_Float16)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, long>::type")]
	public unsafe static long Invoke([MangledName("x")][NativeType("_Float16")] Half X)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Fputil_DyadicFloat_jvghxm fputil_DyadicFloat_jvghxm = default(Fputil_DyadicFloat_jvghxm);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			long result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)) || FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)), Expected: false))
			{
				Fputil_set_errno_if_required.Invoke(33);
				Fputil_raise_except_if_required.Invoke(1);
				result = ((!FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva))) ? ((!FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva))) ? long.MaxValue : (-2147483648L)) : (-2147483648L));
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
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = DyadicFloat_16ul_get_unbiased_exponent.Invoke(&fputil_DyadicFloat_jvghxm);
				if (Details_expects_bool_condition_bool.Invoke(num > long.MaxValue || num < long.MinValue, Expected: false))
				{
					Fputil_set_errno_if_required.Invoke(34);
					Fputil_raise_except_if_required.Invoke(1);
					result = InstructionHelper.Select(num > 0, long.MaxValue, long.MinValue);
				}
				else
				{
					result = num;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
				Llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_jvghxm);
			}
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result;
		}
	}
}
