using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_canonicalize_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12canonicalizeIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRS4_RKS4_")]
	[DemangledName("int __llvm_libc_20_1_2_::fputil::canonicalize<_Float16, 0>(_Float16&, _Float16 const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("_Float16&")] void* cx, [NativeType("_Float16 const&")] void* x)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, *(Half*)x);
			int result;
			if (details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)), expected: false))
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				anon_izyfb8.val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva2);
				short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(v: FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)), sign: anon_izyfb8.val);
				fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				*(Half*)cx = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				fputil_raise_except_if_required.Invoke(1);
				result = 1;
			}
			else
			{
				*(Half*)cx = *(Half*)x;
				result = 0;
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
