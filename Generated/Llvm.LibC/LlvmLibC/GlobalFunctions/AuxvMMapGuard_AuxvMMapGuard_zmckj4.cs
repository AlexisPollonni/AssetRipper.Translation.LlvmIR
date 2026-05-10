using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13AuxvMMapGuardD2Ev")]
[DemangledName("__llvm_libc_20_1_2_::AuxvMMapGuard::~AuxvMMapGuard()")]
[CleanName("AuxvMMapGuard_AuxvMMapGuard")]
internal static partial class AuxvMMapGuard_AuxvMMapGuard_zmckj4
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((anon_589mcc*)@this)->field_0 != (void*)(-1L))
			{
				((delegate*<void*, long, int>)munmap.__pointer)(((anon_589mcc*)@this)->field_0, 1024L);
			}
		}
	}
}
