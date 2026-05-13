using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_13AuxvMMapGuard16submit_to_globalEvENUlPvE_8__invokeES1_")]
[DemangledName("__llvm_libc_20_1_2_::AuxvMMapGuard::submit_to_global()::'lambda'(void*)::__invoke(void*)")]
internal static partial class AuxvMMapGuard_submit_to_global_lambda_void_invoke_void
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void>)(&Invoke));

	public unsafe static void Invoke(void* parameter_0)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		AuxvMMapGuard_submit_to_global_lambda_void_operator_void_const.Invoke(&anon_izyfb8, parameter_0);
	}
}
