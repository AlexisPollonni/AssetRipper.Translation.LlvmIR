using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_setpayload_false_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10setpayloadILb0EDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEbE4typeERS4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, bool>::type __llvm_libc_20_1_2_::fputil::setpayload<false, _Float16>(_Float16&, _Float16)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, bool>::type")]
	public unsafe static bool Invoke([MangledName("res")][NativeType("_Float16&")] void* Res, [MangledName("pl")][NativeType("_Float16")] Half Pl)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		short num2 = 0;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, Pl);
			bool result;
			if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
			{
				Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
				short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb.Val, 0);
				fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				*(Half*)Res = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
				Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				result = false;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_exponent.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva));
				if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)) || num < 0 || num >= 9 || (((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)) << num) & 0x3FF) != 0)
				{
					*(Half*)Res = default(Half);
					result = true;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &num2);
					num2 = (short)((ushort)FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)) >> checked(10 - num));
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: num2, Sign: anon_izyfb2.Val);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					*(Half*)Res = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					result = false;
					Llvm_lifetime_end_p0.Invoke(2L, &num2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result;
		}
	}
}
