using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class unexpected_int_error
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp10unexpectedIiE5errorEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::unexpected<int>::error()")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0;
	}
}
