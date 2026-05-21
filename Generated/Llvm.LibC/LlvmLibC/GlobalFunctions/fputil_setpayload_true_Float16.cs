using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_setpayload_true_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10setpayloadILb1EDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEbE4typeERS4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, bool>::type __llvm_libc_20_1_2_::fputil::setpayload<true, _Float16>(_Float16&, _Float16)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, bool>::type")]
	public unsafe static bool Invoke([NativeType("_Float16&")] void* res, [NativeType("_Float16")] Half pl)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		int num = 0;
		short num2 = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, pl);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_exponent.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
			bool result;
			if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) || num < 0 || num >= 9 || (((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) << num) & 0x3FF) != 0)
			{
				*(Half*)res = default(Half);
				result = true;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(2L, &num2);
				num2 = (short)((ushort)FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)) >> checked(10 - num));
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_signaling_nan.Invoke(v: num2, sign: anon_izyfb8.val);
				fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				*(Half*)res = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				result = false;
				llvm_lifetime_end_p0.Invoke(2L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
