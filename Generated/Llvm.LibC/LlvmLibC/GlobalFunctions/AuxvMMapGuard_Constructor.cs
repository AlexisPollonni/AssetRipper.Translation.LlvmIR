using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvMMapGuard_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13AuxvMMapGuardC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvMMapGuard::AuxvMMapGuard()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		unchecked
		{
			((Anon_5uk363*)This)->field_0 = ((delegate*<void*, long, int, int, int, long, void*>)Mmap.__pointer)(null, 1024L, 3, 34, -1, 0L);
		}
	}
}
