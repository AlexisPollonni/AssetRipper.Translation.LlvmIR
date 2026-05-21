using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_double_get_val
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil6FPBitsIdE7get_valEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<double>::get_val() const")]
	public unsafe static double Invoke(void* @this)
	{
		return cpp_bit_cast_double_unsigned_long.Invoke(&unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val);
	}
}
