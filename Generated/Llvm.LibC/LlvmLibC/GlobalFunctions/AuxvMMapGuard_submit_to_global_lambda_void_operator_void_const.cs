using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_13AuxvMMapGuard16submit_to_globalEvENKUlPvE_clES1_")]
[DemangledName("__llvm_libc_20_1_2_::AuxvMMapGuard::submit_to_global()::'lambda'(void*)::operator()(void*) const")]
internal static partial class AuxvMMapGuard_submit_to_global_lambda_void_operator_void_const
{
	public unsafe static void Invoke(void* @this, void* parameter_1)
	{
		unchecked((delegate*<void*, long, int>)munmap.__pointer)(auxv.Value, 1024L);
		auxv.Value = null;
	}
}
