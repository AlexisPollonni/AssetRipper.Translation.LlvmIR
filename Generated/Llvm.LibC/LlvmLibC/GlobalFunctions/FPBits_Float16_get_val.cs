using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_Float16_get_val
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil6FPBitsIDF16_E7get_valEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::get_val() const")]
	public unsafe static Half Invoke(fputil_FPBits_2fahva* @this)
	{
		return cpp_bit_cast_Float16_unsigned_short.Invoke(&unchecked((fputil_internal_FPStorage_za9n4f*)@this)->field_0);
	}
}
