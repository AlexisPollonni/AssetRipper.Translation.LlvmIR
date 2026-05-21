using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvMMapGuard_Destructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13AuxvMMapGuardD2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvMMapGuard::~AuxvMMapGuard()")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((anon_5uk363*)@this)->field_0 != (void*)(-1L))
			{
				((delegate*<void*, long, int>)munmap.__pointer)(((anon_5uk363*)@this)->field_0, 1024L);
			}
		}
	}
}
