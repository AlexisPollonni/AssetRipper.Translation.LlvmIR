using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lambda_invoke
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void>)(&Invoke));

	[MangledName("_ZZN19__llvm_libc_20_1_2_13AuxvMMapGuard16submit_to_globalEvENUlPvE_8__invokeES1_")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvMMapGuard::submit_to_global()::'lambda'(void*)::__invoke(void*)")]
	public unsafe static void Invoke([NativeType("void*")] void* parameter_0)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Lambda_Invoke_t9vzrt.Invoke(&anon_izyfb, parameter_0);
	}
}
