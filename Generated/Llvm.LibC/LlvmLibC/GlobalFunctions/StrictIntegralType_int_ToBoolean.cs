using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrictIntegralType_int_ToBoolean
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_18StrictIntegralTypeIiEcvbEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrictIntegralType<int>::operator bool() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return unchecked((Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 != 0;
	}
}
