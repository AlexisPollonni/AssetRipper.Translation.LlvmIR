using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lambda_Invoke_t9vzrt
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_13AuxvMMapGuard16submit_to_globalEvENKUlPvE_clES1_")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvMMapGuard::submit_to_global()::'lambda'(void*)::operator()(void*) const")]
	[CleanName("Lambda_Invoke")]
	public unsafe static void Invoke([MangledName("this")] void* This, [NativeType("void*")] void* parameter_1)
	{
		unchecked((delegate*<void*, long, int>)Munmap.__pointer)(Llvm_libc_20_1_2_auxv.Value, 1024L);
		Llvm_libc_20_1_2_auxv.Value = null;
	}
}
