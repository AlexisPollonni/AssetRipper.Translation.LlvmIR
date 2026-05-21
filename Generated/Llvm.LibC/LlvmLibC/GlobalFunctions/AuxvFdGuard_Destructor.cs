using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvFdGuard_Destructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11AuxvFdGuardD2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvFdGuard::~AuxvFdGuard()")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 != -1)
			{
				((delegate*<int, int>)close.__pointer)(((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0);
			}
		}
	}
}
