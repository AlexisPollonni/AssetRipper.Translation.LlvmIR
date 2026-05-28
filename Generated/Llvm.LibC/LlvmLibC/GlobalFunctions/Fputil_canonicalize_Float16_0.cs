using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_canonicalize_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12canonicalizeIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRS4_RKS4_")]
	[DemangledName("int __llvm_libc_20_1_2_::fputil::canonicalize<_Float16, 0>(_Float16&, _Float16 const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("cx")][NativeType("_Float16&")] void* Cx, [MangledName("x")][NativeType("_Float16 const&")] void* X)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, *(Half*)X);
			int result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)), Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				anon_izyfb.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
				short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)), Sign: anon_izyfb.Val);
				fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				*(Half*)Cx = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
				Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				Fputil_raise_except_if_required.Invoke(1);
				result = 1;
			}
			else
			{
				*(Half*)Cx = *(Half*)X;
				result = 0;
			}
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result;
		}
	}
}
