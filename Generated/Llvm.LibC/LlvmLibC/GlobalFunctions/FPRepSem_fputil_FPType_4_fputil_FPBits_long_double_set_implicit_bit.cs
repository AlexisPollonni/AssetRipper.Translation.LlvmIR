using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_set_implicit_bit
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEE16set_implicit_bitEb")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::set_implicit_bit(bool)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("implicitVal")][NativeType("bool")] bool ImplicitVal)
	{
		sbyte b = (ImplicitVal ? ((sbyte)1) : ((sbyte)0));
		if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_implicit_bit.Invoke(This) != ((b & 1) == 1))
		{
			Int128* field_ = &unchecked((Fputil_internal_FPStorage_w3h7gw*)This)->field_0;
			*field_ = NumericHelper.BitwiseXor(*field_, long.MinValue);
		}
	}
}
