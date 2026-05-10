using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11AuxvFdGuardD2Ev")]
[DemangledName("__llvm_libc_20_1_2_::AuxvFdGuard::~AuxvFdGuard()")]
[CleanName("AuxvFdGuard_AuxvFdGuard")]
internal static partial class AuxvFdGuard_AuxvFdGuard_jzbs6x
{
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
