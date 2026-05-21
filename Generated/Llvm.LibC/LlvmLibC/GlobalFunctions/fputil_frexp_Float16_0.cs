using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_frexp_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5frexpIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_Ri")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::frexp<_Float16, 0>(_Float16, int&)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([NativeType("_Float16")] Half x, [NativeType("int&")] void* exp)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_NormalFloat_epbrnk fputil_NormalFloat_epbrnk2 = default(fputil_NormalFloat_epbrnk);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, x);
			Half result;
			if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)))
			{
				result = x;
			}
			else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
			{
				*(int*)exp = 0;
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_NormalFloat_epbrnk2);
				*(int*)(&fputil_NormalFloat_epbrnk2) = -1431655766;
				((short*)(&fputil_NormalFloat_epbrnk2))[2] = -21846;
				((sbyte*)(&fputil_NormalFloat_epbrnk2))[6] = -86;
				((sbyte*)(&fputil_NormalFloat_epbrnk2))[7] = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva3, &fputil_FPBits_2fahva2, 2L, isVolatile: false);
				NormalFloat_Float16_Constructor.Invoke(&fputil_NormalFloat_epbrnk2, fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0);
				*(int*)exp = checked(fputil_NormalFloat_epbrnk2.exponent + 1);
				fputil_NormalFloat_epbrnk2.exponent = -1;
				result = NormalFloat_Float16_Float16.Invoke(&fputil_NormalFloat_epbrnk2);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_NormalFloat_epbrnk2);
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
