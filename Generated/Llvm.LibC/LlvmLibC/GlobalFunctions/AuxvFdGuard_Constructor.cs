using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvFdGuard_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11AuxvFdGuardC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvFdGuard::AuxvFdGuard()")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 = ((delegate*<InlineArray16_SByte*, int, int>)open.__pointer)(str_103.Pointer, 524288);
		}
	}
}
