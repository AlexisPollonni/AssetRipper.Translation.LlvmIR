using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_totalorder_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10totalorderIDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEbE4typeES4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, bool>::type __llvm_libc_20_1_2_::fputil::totalorder<_Float16>(_Float16, _Float16)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, bool>::type")]
	public unsafe static bool Invoke([MangledName("x")][NativeType("_Float16")] Half X, [MangledName("y")][NativeType("_Float16")] Half Y)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		sbyte b = 0;
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, Y);
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva));
			Llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (((((ushort)num | (ushort)num2) & 0x8000) != 0) ? ((sbyte)1) : ((sbyte)0));
			bool result = (ushort)num == (ushort)num2 || (ushort)num < (ushort)num2 != ((b & 1) == 1);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(2L, &num2);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result;
		}
	}
}
