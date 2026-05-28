using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_long_double_get_val
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil6FPBitsIeE7get_valEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<long double>::get_val() const")]
	public unsafe static double Invoke([MangledName("this")] void* This)
	{
		return Cpp_bit_cast_long_double_unsigned_int128.Invoke(&unchecked((Fputil_internal_FPStorage_w3h7gw*)This)->field_0);
	}
}
