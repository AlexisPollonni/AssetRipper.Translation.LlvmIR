using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrictIntegralType_unsigned_int_ToInt32
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_18StrictIntegralTypeIjEcviEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrictIntegralType<unsigned int>::operator int() const")]
	public unsafe static int Invoke(void* @this)
	{
		return cpp_bit_cast_int_unsigned_int.Invoke(&unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0);
	}
}
