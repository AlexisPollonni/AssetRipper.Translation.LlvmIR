using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrictIntegralType_int_ToBoolean
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_18StrictIntegralTypeIiEcvbEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrictIntegralType<int>::operator bool() const")]
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 != 0;
	}
}
