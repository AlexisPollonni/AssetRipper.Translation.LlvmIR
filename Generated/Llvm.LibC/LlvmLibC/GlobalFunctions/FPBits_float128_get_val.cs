using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_float128_get_val
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil6FPBitsIgE7get_valEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<__float128>::get_val() const")]
	public unsafe static double Invoke([MangledName("this")] void* This)
	{
		return Cpp_bit_cast_float128_unsigned_int128.Invoke(&unchecked((Fputil_internal_FPStorage_w3h7gw*)This)->field_0);
	}
}
