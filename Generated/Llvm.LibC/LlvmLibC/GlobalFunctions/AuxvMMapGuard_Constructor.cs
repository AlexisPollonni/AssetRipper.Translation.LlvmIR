using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvMMapGuard_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13AuxvMMapGuardC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvMMapGuard::AuxvMMapGuard()")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((anon_5uk363*)@this)->field_0 = ((delegate*<void*, long, int, int, int, long, void*>)mmap.__pointer)(null, 1024L, 3, 34, -1, 0L);
		}
	}
}
