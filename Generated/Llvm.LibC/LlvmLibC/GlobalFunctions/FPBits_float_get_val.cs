using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_float_get_val
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil6FPBitsIfE7get_valEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<float>::get_val() const")]
	public unsafe static float Invoke([MangledName("this")] Fputil_FPBits_5nkvcs* This)
	{
		return Cpp_bit_cast_float_unsigned_int.Invoke(&unchecked((Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0);
	}
}
