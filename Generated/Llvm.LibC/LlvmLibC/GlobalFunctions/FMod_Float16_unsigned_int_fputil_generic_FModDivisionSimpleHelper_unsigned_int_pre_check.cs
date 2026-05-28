using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FMod_Float16_unsigned_int_fputil_generic_FModDivisionSimpleHelper_unsigned_int_pre_check
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIDF16_jNS1_24FModDivisionSimpleHelperIjEEE9pre_checkEDF16_DF16_RDF16_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<_Float16, unsigned int, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned int>>::pre_check(_Float16, _Float16, _Float16&)")]
	public unsafe static bool Invoke([MangledName("x")][NativeType("_Float16")] Half X, [MangledName("y")][NativeType("_Float16")] Half Y, [MangledName("out")][NativeType("_Float16&")] void* Out)
	{
		Half half = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		Llvm_lifetime_start_p0.Invoke(2L, &half);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
		short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb.Val, 0);
		fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
		Half half2 = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva);
		Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
		half = half2;
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, X);
			Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			*(short*)(&fputil_FPBits_2fahva3) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva3, Y);
			bool result;
			if (Details_expects_bool_condition_bool.Invoke(!FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva3)) && !FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva3)) && InstructionHelper.BooleanXor(FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)), right: true), Expected: true))
			{
				result = false;
			}
			else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)) || FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva3)))
			{
				if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)) || FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva3)))
				{
					Fputil_raise_except_if_required.Invoke(1);
				}
				*(Half*)Out = default(Half);
				result = true;
			}
			else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)) || FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva3)))
			{
				Fputil_raise_except_if_required.Invoke(1);
				Fputil_set_errno_if_required.Invoke(33);
				*(Half*)Out = default(Half);
				result = true;
			}
			else
			{
				*(Half*)Out = X;
				result = true;
			}
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			Llvm_lifetime_end_p0.Invoke(2L, &half);
			return result;
		}
	}
}
