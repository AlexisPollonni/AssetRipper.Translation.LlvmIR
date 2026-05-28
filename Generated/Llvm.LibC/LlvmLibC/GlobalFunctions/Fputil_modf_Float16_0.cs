using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_modf_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4modfIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_RS4_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::modf<_Float16, 0>(_Float16, _Float16&)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X, [MangledName("iptr")][NativeType("_Float16&")] void* Iptr)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			Half result;
			if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)) || FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
			{
				*(Half*)Iptr = X;
				result = X;
			}
			else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
			{
				*(Half*)Iptr = X;
				Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				anon_izyfb.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
				short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb.Val);
				fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
				Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			}
			else
			{
				*(Half*)Iptr = Fputil_trunc_Float16_0.Invoke(X);
				if (NumericHelper.FcmpOeq(X, *(Half*)Iptr))
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					anon_izyfb2.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb2.Val);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				}
				else
				{
					result = (Half)((float)X - (float)(*(Half*)Iptr));
				}
			}
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result;
		}
	}
}
