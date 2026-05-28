using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_frexp_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5frexpIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_Ri")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::frexp<_Float16, 0>(_Float16, int&)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X, [MangledName("exp")][NativeType("int&")] void* Exp)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Fputil_NormalFloat_epbrnk fputil_NormalFloat_epbrnk = default(Fputil_NormalFloat_epbrnk);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			Half result;
			if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)))
			{
				result = X;
			}
			else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
			{
				*(int*)Exp = 0;
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_NormalFloat_epbrnk);
				*(int*)(&fputil_NormalFloat_epbrnk) = -1431655766;
				((short*)(&fputil_NormalFloat_epbrnk))[2] = -21846;
				((sbyte*)(&fputil_NormalFloat_epbrnk))[6] = -86;
				((sbyte*)(&fputil_NormalFloat_epbrnk))[7] = -86;
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva2, &fputil_FPBits_2fahva, 2L, isVolatile: false);
				NormalFloat_Float16_Constructor.Invoke(&fputil_NormalFloat_epbrnk, fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0);
				*(int*)Exp = checked(fputil_NormalFloat_epbrnk.Exponent + 1);
				fputil_NormalFloat_epbrnk.Exponent = -1;
				result = NormalFloat_Float16_Float16.Invoke(&fputil_NormalFloat_epbrnk);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_NormalFloat_epbrnk);
			}
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result;
		}
	}
}
