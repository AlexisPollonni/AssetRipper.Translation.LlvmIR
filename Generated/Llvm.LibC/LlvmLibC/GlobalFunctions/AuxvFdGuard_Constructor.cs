using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvFdGuard_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11AuxvFdGuardC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvFdGuard::AuxvFdGuard()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		unchecked
		{
			((Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 = ((delegate*<InlineArray16_SByte*, int, int>)Open.__pointer)(Str_103.Pointer, 524288);
		}
	}
}
